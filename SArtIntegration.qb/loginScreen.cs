using SArtIntegration.qb.Manager.Login;
using SArtIntegration.qb.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

            var response = await LoginManager.LoginAsync("operasyon@arpaciogluavr.com", "Oa1234");

            if (!response.State)
            {
                MessageBox.Show(response.Messages.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            UserSharedInfo.UserInfo.UserName = txtBoxUserName.Text;
            UserSharedInfo.UserInfo.Password = txtBoxPassword.Text;
            UserSharedInfo.UserInfo.Token = response.Token;

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
