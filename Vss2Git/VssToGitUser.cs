using System;

namespace Hpdi.Vss2Git
{
    public class VssToGitUser
    {
        public VssToGitUser()
        {

        }

        public VssToGitUser(string vssName, string name, string eMail)
        {
            VssName = vssName;
            GitName = name;
            GitEMail = eMail;
        }

        public VssToGitUser(string serializedstring)
        {
            var splitstring = serializedstring.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            if (splitstring.Length != 3)
                throw new Exception();

            VssName = splitstring[0];
            GitName = splitstring[1];
            GitEMail = splitstring[2];

            if (string.IsNullOrEmpty(VssName) || string.IsNullOrEmpty(GitName) || string.IsNullOrEmpty(GitEMail))
                throw new Exception();
        }

        public string VssName { get; set; }
        public string GitName { get; set; }
        public string GitEMail { get; set; }

        public override string ToString()
        {
            return $"{VssName}|{GitName}|{GitEMail}";
        }
    }
}
