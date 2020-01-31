using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    static class Program
    {
        public static Connection Connection { get; set; }

        public static User LoggedUser { get; set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Connection = new Connection(Constants.MYSQL_SERVER, Constants.MYSQL_DATABASE, Constants.MYSQL_USER, Constants.MYSQL_PASSWORD);

            Application.Run(new SignInForm());
        }
    }
}
