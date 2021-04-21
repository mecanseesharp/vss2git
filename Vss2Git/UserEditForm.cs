using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Hpdi.Vss2Git
{
    public partial class UserEditForm : Form
    {
        private VssToGitUser user;

        private List<VssToGitUser> existingVssUsers;

        private bool editUser = false;

        public UserEditForm(VssToGitUser user, List<VssToGitUser> existingVssUsers) : this(existingVssUsers)
        {
            this.user = user;

            vssNameTextbox.Text = user.VssName;
            gitNameTextbox.Text = user.GitName;
            gitEMailTextbox.Text = user.GitEMail;

            this.Text = "Edit VSS / Git User";
            editUser = true;
        }

        public UserEditForm(List<VssToGitUser> existingVssUsers)
        {
            InitializeComponent();

            this.existingVssUsers = existingVssUsers;
            this.user = new VssToGitUser();

            this.Text = "New VSS / Git User";
        }

        public VssToGitUser User => user;

        private bool validate()
        {
            bool result = true;

            if (string.IsNullOrEmpty(vssNameTextbox.Text.Trim()))
            {
                result = false;
                errorProvider.SetError(vssNameTextbox, "Set a Username");
            }
            else if(existingVssUsers.Any(x => String.Equals(x.VssName, vssNameTextbox.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                if (!editUser || !string.Equals(User.VssName, vssNameTextbox.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    result = false;
                    errorProvider.SetError(vssNameTextbox, "User already exists");
                }
            }
            else
                errorProvider.SetError(vssNameTextbox, null);

            if (string.IsNullOrEmpty(gitNameTextbox.Text.Trim()))
            {
                result = false;
                errorProvider.SetError(gitNameTextbox, "Set a Name");
            }
            else
                errorProvider.SetError(gitNameTextbox, null);

            if (string.IsNullOrEmpty(gitEMailTextbox.Text.Trim()))
            {
                result = false;
                errorProvider.SetError(gitEMailTextbox, "Set a Mailaddress");
            }
            else
            {
                try
                {
                    _ = new System.Net.Mail.MailAddress(gitEMailTextbox.Text.Trim());
                    errorProvider.SetError(gitEMailTextbox, null);
                }
                catch (Exception)
                {
                    errorProvider.SetError(gitEMailTextbox, "Set a valid Mailaddress");
                    result = false;
                }
            }

            return result;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            validateAndClose();
        }

        private void validateAndClose()
        {
            if (validate())
            {
                this.DialogResult = DialogResult.OK;
                this.user.VssName = vssNameTextbox.Text.Trim();
                this.user.GitName = gitNameTextbox.Text.Trim();
                this.user.GitEMail = gitEMailTextbox.Text.Trim();

                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void UserEditForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                validateAndClose();
                e.Handled = true;
            }
        }
    }
}
