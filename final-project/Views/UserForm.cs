using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace final_project
{
    public partial class UserForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public UserForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine(Program.LoggedUser.ToString());

            if (Program.LoggedUser.Access.Has("cad_usuario"))
                buttonUsers.Click -= buttonUsers_Click;

            labelLoggedUserName.Text = Program.LoggedUser.Name;
            labelLoggedUserProfileName.Text = Program.LoggedUser.Access.Name;
        }

        private void panelTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();

            signInForm.Show();

            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {

        }
    }
}