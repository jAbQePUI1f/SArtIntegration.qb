using SArtIntegration.qb.Manager.Connect;
using SArtIntegration.qb.Manager.Helper;
using SArtIntegration.qb.Manager.Login;
using SArtIntegration.qb.Models;

namespace SArtIntegration.qb
{
    public partial class loginScreen : Form
    {
        public loginScreen()
        {
            InitializeComponent();
        }

        private async void bttnLogin_Click(object sender, EventArgs e)
        {
            #region --Auth Code
            //var authenticationHelper = new AuthenticationHelper();

            //var jwtToken = await authenticationHelper.GetJwtTokenAsync("operasyon@arpaciogluavr.com", "Oa1234", "MANAGEMENT");

            //if (!string.IsNullOrEmpty(jwtToken))
            //{
            //    Console.WriteLine($"Successfully logged in. JWT Token: {jwtToken}");
            //}
            //else
            //{
            //    Console.WriteLine("Login failed.");
            //}
            #endregion
            var response = await LoginManager.LoginAsync("operasyon@arpaciogluavr.com", "Oa1234");//"operasyon@arpaciogluavr.com", "Oa1234"


            var connectInfoQB = ConnectManager.ConnectToQB();

            if (string.IsNullOrEmpty(connectInfoQB.Ticket))
            {
                MessageBox.Show("Your Quickbooks ERP application is not open. Please try again after opening your application.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!response.State)
            {
                MessageBox.Show(response.Messages.GetMessages(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            UserSharedInfo.UserInfo.UserName = txtUserName.Text;
            UserSharedInfo.UserInfo.Password = txtPassword.Text;
            UserSharedInfo.UserInfo.Token = response.Token;
            UserSharedInfo.UserInfo.QbConnectInfo = connectInfoQB;

            new mainScreen().Show();
            this.Hide();
        }
        private void lblLoginPage_Click(object sender, EventArgs e)
        {
            mainScreen mS = new mainScreen();
            mS.Show();
            this.Hide();
        }
    }
}
