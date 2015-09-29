using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using log4net;
using log4net.Appender;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using Microsoft.TeamFoundation.VersionControl.Client;
using VersionOne.Integration.Tfs.Core.DataLayer;

namespace VersionOne.Integration.Tfs.Policy
{
    [Serializable]
    public class VersionOneTFSPolicy : PolicyBase, IV1ComponentContainerProvider
    {
        public const string VersionOneIdRegex = "[A-Z]{1,2}-[0-9]+";

        private static Lazy<V1ComponentContainer> container = new Lazy<V1ComponentContainer>(() => new V1ComponentContainer());
        private static Lazy<VersionOneQueryContainer> versionOneHelper = new Lazy<VersionOneQueryContainer>();

        public override string Description
        {
            get { return "Associate checkins with VersionOne work items"; }

        }

        // This is a string that is stored with the policy definition on the source
        // control server. If a user does not have the policy plug-in installed, this string
        // is displayed.  You can use this to explain to the user how they should 
        // install the policy plug-in.
        public override string InstallationInstructions
        {
            get { return string.Empty; }
        }
        // This string identifies the type of policy. It is displayed in the 
        // policy list when you add a new policy to a Team Project.
        public override string Type
        {
            get { return "VersionOne Policy for Visual Studio"; }
        }

        // This string is a description of the type of policy. It is displayed 
        // when you select the policy in the Add Check-in Policy dialog box.
        public override string TypeDescription
        {
            get { return "This policy will prompt the user to allow them to associate the checkin with one or more VersionOne work items"; }
        }

        // This method is called by the policy framework when you create 
        // a new check-in policy or edit an existing check-in policy.
        // You can use this to display a UI specific to this policy type 
        // allowing the user to change the parameters of the policy.
        public override bool Edit(IPolicyEditArgs args)
        {
            return true;
        }

        // This method performs the actual policy evaluation. 
        // It is called by the policy framework at various points in time
        // when policy should be evaluated. In this example, the method 
        // is invoked when various asyc events occur that may have 
        // invalidated the current list of failures.
        public override PolicyFailure[] Evaluate()
        {
            if (CountWorkitemsInComment(PendingCheckin.PendingChanges.Comment) <= 0)
            {
                PromptForWorkitem();
            }

            return CountWorkitemsInComment(PendingCheckin.PendingChanges.Comment) <= 0 ?
                new[] { new PolicyFailure("Please associate this checkin with one or more VersionOne work items", this) } :
                new PolicyFailure[0];
        }

        // This method is called if the user double-clicks on 
        // a policy failure in the UI. If so, display the V1 checkin dialog
        public override void Activate(PolicyFailure failure)
        {
            PromptForWorkitem();
        }

        private void PromptForWorkitem()
        {
            var form = new CheckInForm(this);
            form.SetComment(PendingCheckin.PendingChanges.Comment);

            if (form.ShowDialog() == DialogResult.OK)
            {
                PendingCheckin.PendingChanges.Comment = form.GetComment();
            }
        }

        // This method is called if the user presses F1 when a policy failure 
        // is active in the UI. 
        public override void DisplayHelp(PolicyFailure failure)
        {
            MessageBox.Show("This policy lets you associate your checkin with one or more VersionOne work items", "Prompt Policy Help");
        }

        private static void ConfigureLogger()
        {
            var appender = new RollingFileAppender
            {
                Layout = new PatternLayout("[%level] %date{dd-MM-yyyy HH:mm:ss} %message%n"),
                Name = "File",
                Threshold = Level.Debug,
                AppendToFile = true,
                File = "V1TFS.log",
                MaximumFileSize = "10M"
            };
            appender.ActivateOptions();

            var root = ((Hierarchy)LogManager.GetRepository()).Root;
            root.AddAppender(appender);
            root.Repository.Configured = true;
        }

        public int CountWorkitemsInComment(string comment)
        {
            var re = new Regex("[A-Z]{1,2}-[0-9]+");
            return re.Matches(comment).Count;
        }

        public V1ComponentContainer GetContainer()
        {
            return container.Value;
        }

        public VersionOneQueryContainer GetVersionOneHelper()
        {
            return versionOneHelper.Value;
        }
    }
}