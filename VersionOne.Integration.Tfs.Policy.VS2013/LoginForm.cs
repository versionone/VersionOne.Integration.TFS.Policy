using System;
using System.Windows.Forms;

namespace VersionOne.Integration.Tfs.Policy.VS2013
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            chkUseProxy.CheckedChanged += chkUseProxy_CheckedChanged;
        }

        public string Username
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        public string V1Url
        {
            get { return cbUrl.Text; }
            set { cbUrl.Text = value; }
        }

        public bool IntegratedAuthentication
        {
            get { return chkWindowsAuth.Checked; }
            set { chkWindowsAuth.Checked = value; }
        }

        public bool CacheCredentials
        {
            get { return chkCacheCredentials.Checked; }
            set { chkCacheCredentials.Checked = value; }
        }

        public bool UseProxy
        {
            get { return chkUseProxy.Checked; }
            set { chkUseProxy.Checked = value; }
        }

        public string ProxyUrl
        {
            get { return txtProxyUrl.Text.Trim(); }
            set { txtProxyUrl.Text = value; }
        }

        public string ProxyUsername
        {
            get { return txtProxyUsername.Text.Trim(); }
            set { txtProxyUsername.Text = value; }
        }

        public string ProxyPassword
        {
            get { return txtProxyPassword.Text.Trim(); }
            set { txtProxyPassword.Text = value; }
        }

        public string ProxyDomain
        {
            get { return txtProxyDomain.Text.Trim(); }
            set { txtProxyDomain.Text = value; }
        }

        private void UpdateOkButton()
        {
            if (cbUrl.Text.Length > 0)
            {
                if (chkWindowsAuth.Checked)
                {
                    btnOk.Enabled = true;
                }
                else if (txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0)
                {
                    btnOk.Enabled = true;
                }
                else
                    btnOk.Enabled = false;
            }
            else
                btnOk.Enabled = false;
        }

        private void WindowsAuthCB_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWindowsAuth.Checked)
            {
                txtUsername.Enabled = false;
                lblUsername.Enabled = false;
                txtPassword.Enabled = false;
                lblPassword.Enabled = false;
            }
            else
            {
                txtUsername.Enabled = true;
                lblUsername.Enabled = true;
                txtPassword.Enabled = true;
                lblPassword.Enabled = true;
            }
            UpdateOkButton();
        }

        private void UsernameTB_TextChanged(object sender, EventArgs e)
        {
            UpdateOkButton();
        }

        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {
            UpdateOkButton();
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            UpdateOkButton();
            SetProxyRelatedFieldsEnabled(chkUseProxy.Checked);
        }

        private void URLCB_TextChanged(object sender, EventArgs e)
        {
            UpdateOkButton();
        }

        private void chkUseProxy_CheckedChanged(object sender, EventArgs e)
        {
            SetProxyRelatedFieldsEnabled(chkUseProxy.Checked);
        }

        private void SetProxyRelatedFieldsEnabled(bool enabled)
        {
            txtProxyUrl.Enabled = txtProxyUsername.Enabled = txtProxyPassword.Enabled = txtProxyDomain.Enabled = enabled;
        }
    }
}