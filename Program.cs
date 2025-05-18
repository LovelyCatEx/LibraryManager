using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    /**
     * A 的代码
     */

    /**
     * B 的代码
     */
    public class User
    {
        public string username;
        public string password;

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public void sayHello()
        {
            Console.WriteLine(username + " says: hello world!");
        }
    }
}
