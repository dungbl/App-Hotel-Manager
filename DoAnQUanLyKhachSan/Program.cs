using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace DoAnQUanLyKhachSan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // kiem tra file config co ton tai hay khong
            if (File.Exists("Config.txt") == false)
            {
                Application.Run(new checkDB());
            }
            else
            Application.Run(new Login());
        }
    }
}
