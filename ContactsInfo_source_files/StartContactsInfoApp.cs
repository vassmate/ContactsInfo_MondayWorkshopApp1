using System;
using System.Windows.Forms;

namespace ContactsInfoApp
{
    static class StartContactsInfoApp
    {
        //Start program
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Contacts());
        }
    }
}
