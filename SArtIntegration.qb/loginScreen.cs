using SArtIntegration.qb.Manager.Login;
using SArtIntegration.qb.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SArtIntegration.qb
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {

            var response = LoginManager.Login(txtBoxUserName.Text, txtBoxPassword.Text);

            if (!response.State)
            {
                MessageBox.Show(response.Messages.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            UserSharedInfo.UserInfo.UserName = txtBoxUserName.Text;
            UserSharedInfo.UserInfo.Password = txtBoxPassword.Text;
            UserSharedInfo.UserInfo.Token = response.Token;
        }
    }
}
