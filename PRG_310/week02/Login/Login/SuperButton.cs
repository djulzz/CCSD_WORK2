using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Login
{
    public class SuperButton : System.Web.UI.WebControls.Button
    {
        public SuperButton( String login, String password, String email )
        {
            mLogin = login;
            mPwd = password;
            mEmail = email;
        }
        private String mLogin, mPwd, mEmail;
        public String Login
        {
            get { return mLogin; }
            set { mLogin = value; }
        }

        public String Pwd
        {
            get { return mPwd; }
            set { mPwd = value; }
        }

        public String Email
        {
            get { return mEmail;  }
            set { mEmail = value; }
        }
    }
}