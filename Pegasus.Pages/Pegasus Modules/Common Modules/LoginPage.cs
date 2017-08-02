using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PegasusAutomationFramework.CommonRepository;

namespace Pegasus.Pages.Pegasus_Modules.Common_Modules
{
   public class LoginPage : BasePage
    {
       //Enter the Username 
        public void EnterTheUsername()
        {
            base.InsertTextByID(LoginPageResource.peg_login_username_locator_id, LoginPageResource.peg_login_username);
        }

        //Enter the Passoword 
        public void EnterThePassword()
        {
            base.InsertTextByID(LoginPageResource.peg_login_password_locator_id, LoginPageResource.peg_login_password);
        }
        //Click on the Sign In Button
       public void ClickOnSignInButton()
        {
            base.ClickOnLinkbyCSS(LoginPageResource.peg_login_signIn_locator_class);
        }
    }
}
