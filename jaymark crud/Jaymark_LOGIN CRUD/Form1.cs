using MySql.Data.MySqlClient;
namespace Jaymark_LOGIN_CRUD
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=arboledadb;username=root;password=;");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
           else

            {
                txtPassword.UseSystemPasswordChar = false;
            }
            

            }
    }
}
