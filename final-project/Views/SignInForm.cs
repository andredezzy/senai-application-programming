using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace final_project
{
    public partial class SignInForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public SignInForm()
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            var email = textEmail.Text;
            var password = textPassword.Text;

            var passwordHash = Cryptography.EncryptSha256(password);

            Program.Connection.Connect();

            MySqlDataReader reader = Program.Connection.Execute("SELECT ",
                                                                    "user.id,",
                                                                    "user.nome,",
                                                                    "user.email,",
                                                                    "user.usuario,",
                                                                    "user.status,",
                                                                    "profile.nome AS perfil,",
                                                                    "profile.cad_usuario,",
                                                                    "profile.cad_perfil,",
                                                                    "profile.cad_setor,",
                                                                    "profile.cad_funcionario,",
                                                                    "profile.rel_setor,",
                                                                    "profile.rel_funcionario",
                                                                " FROM tb_usuario user",
                                                                " INNER JOIN tb_perfil profile ON user.id_perfil = profile.id",
                                                                $" WHERE email = '{email}' AND senha = '{passwordHash}'");

            while (reader.Read())
            {
                int id = Convert.ToInt16(reader["id"]);
                string name = Convert.ToString(reader["nome"]);
                email = Convert.ToString(reader["email"]);
                string username = Convert.ToString(reader["usuario"]);
                bool status = Convert.ToBoolean(reader["status"]);

                string profileName = reader.GetString(5);

                Access access = new Access(profileName);
                access.Accesses.Add("cad_usuario", Convert.ToBoolean(reader["cad_usuario"]));
                access.Accesses.Add("cad_perfil", Convert.ToBoolean(reader["cad_perfil"]));
                access.Accesses.Add("cad_setor", Convert.ToBoolean(reader["cad_setor"]));
                access.Accesses.Add("cad_funcionario", Convert.ToBoolean(reader["cad_funcionario"]));
                access.Accesses.Add("rel_setor", Convert.ToBoolean(reader["rel_setor"]));
                access.Accesses.Add("rel_funcionario", Convert.ToBoolean(reader["rel_funcionario"]));

                User user = new User(name, email, username, status);
                user.Id = id;
                user.Access = access;

                if (user.Status)
                {
                    Program.User = user;

                    MainForm mainForm = new MainForm();

                    mainForm.Show();

                    this.Hide();
                }

                Console.WriteLine(user.ToString());
            }

            Program.Connection.Disconnect();
        }
    }
}