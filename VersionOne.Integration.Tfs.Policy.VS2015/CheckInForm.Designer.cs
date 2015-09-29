namespace VersionOne.Integration.Tfs.Policy {
    partial class CheckInForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MyWorkitemsTV = new System.Windows.Forms.TreeView();
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AllWorkitemsTV = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.OkB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserLabel = new System.Windows.Forms.Label();
            this.ChangeUser = new System.Windows.Forms.LinkLabel();
            this.LoadingPanel = new System.Windows.Forms.Panel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.LoadingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(551, 388);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MyWorkitemsTV);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(543, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "My Items";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MyWorkitemsTV
            // 
            this.MyWorkitemsTV.CheckBoxes = true;
            this.MyWorkitemsTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyWorkitemsTV.ImageIndex = 0;
            this.MyWorkitemsTV.ImageList = this.imageListIcons;
            this.MyWorkitemsTV.Location = new System.Drawing.Point(3, 3);
            this.MyWorkitemsTV.Name = "MyWorkitemsTV";
            this.MyWorkitemsTV.SelectedImageIndex = 0;
            this.MyWorkitemsTV.ShowNodeToolTips = true;
            this.MyWorkitemsTV.Size = new System.Drawing.Size(537, 356);
            this.MyWorkitemsTV.TabIndex = 0;
            this.MyWorkitemsTV.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.WorkitemsTV_AfterCheck);
            // 
            // imageListIcons
            // 
            this.imageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcons.ImageStream")));
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcons.Images.SetKeyName(0, "story-icon.gif");
            this.imageListIcons.Images.SetKeyName(1, "defect-icon.gif");
            this.imageListIcons.Images.SetKeyName(2, "task-icon.gif");
            this.imageListIcons.Images.SetKeyName(3, "Test-Icon.gif");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AllWorkitemsTV);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(543, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All Items";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AllWorkitemsTV
            // 
            this.AllWorkitemsTV.CheckBoxes = true;
            this.AllWorkitemsTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllWorkitemsTV.ImageIndex = 0;
            this.AllWorkitemsTV.ImageList = this.imageListIcons;
            this.AllWorkitemsTV.Location = new System.Drawing.Point(3, 3);
            this.AllWorkitemsTV.Name = "AllWorkitemsTV";
            this.AllWorkitemsTV.SelectedImageIndex = 0;
            this.AllWorkitemsTV.ShowNodeToolTips = true;
            this.AllWorkitemsTV.Size = new System.Drawing.Size(537, 356);
            this.AllWorkitemsTV.TabIndex = 1;
            this.AllWorkitemsTV.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.WorkitemsTV_AfterCheck);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.OkB);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 30);
            this.panel2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(86, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // OkB
            // 
            this.OkB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkB.Location = new System.Drawing.Point(5, 4);
            this.OkB.Name = "OkB";
            this.OkB.Size = new System.Drawing.Size(75, 23);
            this.OkB.TabIndex = 7;
            this.OkB.Text = "&Ok";
            this.OkB.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UserLabel);
            this.panel1.Controls.Add(this.ChangeUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(222, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 30);
            this.panel1.TabIndex = 6;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.UserLabel.Location = new System.Drawing.Point(263, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.UserLabel.Size = new System.Drawing.Size(0, 18);
            this.UserLabel.TabIndex = 7;
            // 
            // ChangeUser
            // 
            this.ChangeUser.AutoSize = true;
            this.ChangeUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.ChangeUser.Location = new System.Drawing.Point(263, 0);
            this.ChangeUser.Name = "ChangeUser";
            this.ChangeUser.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ChangeUser.Size = new System.Drawing.Size(66, 18);
            this.ChangeUser.TabIndex = 6;
            this.ChangeUser.TabStop = true;
            this.ChangeUser.Text = "change user";
            this.ChangeUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangeUser_LinkClicked);
            // 
            // LoadingPanel
            // 
            this.LoadingPanel.Controls.Add(this.StatusLabel);
            this.LoadingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadingPanel.Location = new System.Drawing.Point(0, 0);
            this.LoadingPanel.Name = "LoadingPanel";
            this.LoadingPanel.Size = new System.Drawing.Size(551, 388);
            this.LoadingPanel.TabIndex = 7;
            this.LoadingPanel.Visible = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusLabel.Location = new System.Drawing.Point(0, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(551, 388);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "Retrieving Workitems, Please Wait...";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 418);
            this.Controls.Add(this.LoadingPanel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Associate checkin with VersionOne work items";
            this.Shown += new System.EventHandler(this.CheckInForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.LoadingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView MyWorkitemsTV;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView AllWorkitemsTV;
        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button OkB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.LinkLabel ChangeUser;
        private System.Windows.Forms.Panel LoadingPanel;
        private System.Windows.Forms.Label StatusLabel;
    }
}