using System;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Reflection;
using System.ComponentModel;
using DevExpress.XtraEditors;
using Software_Testing_LastProject.Views;
using Software_Testing_LastProject.Views.Rooms;
using Software_Testing_LastProject.Views.Users;

namespace Software_Testing_LastProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Assembly asm = typeof(DevExpress.UserSkins.OfficeSkins).Assembly;
            DevExpress.Skins.SkinManager.Default.RegisterAssembly(asm);

            SkinManager.EnableFormSkins();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

       
    }
}
