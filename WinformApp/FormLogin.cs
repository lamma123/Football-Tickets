using WinformApp.DataAccess;


namespace WinformApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        Prn211ProjectContext projectContext = new Prn211ProjectContext();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            string username = textBoxusename.Text;
            string password = textBoxPassword.Text;
            Account account = projectContext.Accounts.SingleOrDefault(x => x.Username == username);
            if (account == null || !account.Password.Equals(password))
            {
                MessageBox.Show("sai mk or username");
            }
            else
            {

                this.Hide();
                if (account.Role == 1)
                {
                    FormUser formUser = new FormUser
                    {
                        acc = account,
                    };
                    formUser.Show();

                }
                else
                {
                    FormMain formMain = new FormMain();
                    formMain.Show();
                }
            }

        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}