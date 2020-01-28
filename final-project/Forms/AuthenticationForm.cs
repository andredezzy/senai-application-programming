using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace final_project
{
    public partial class AuthenticationForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void panelTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {

        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            var email = textEmail.Text;
            var password = textPassword.Text;

            var passwordHash = Cryptography.EncryptSha256(password);

            Program.Connection.Connect();

            MySqlDataReader reader = Program.Connection.Execute($"SELECT * FROM tb_usuario WHERE email = '{email}' AND senha = '{passwordHash}'");

            while (reader.Read())
            {
                string name = reader.GetString(1);
                email = reader.GetString(2);
                string username = reader.GetString(4);
                int status = reader.GetInt16(5);
                // TODO

                User user = new User(name, email, username, status);

                Console.WriteLine(user);
            }

            Program.Connection.Disconnect();
        }
    }
}