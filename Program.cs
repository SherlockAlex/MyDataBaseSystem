using MySql.Data.MySqlClient;

namespace MyDataBaseSystem
{
    internal static class Program
    {

        static Form currentForm=null;

        public static void SetCurrentForm(Form form)
        {
            currentForm= form;
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            LoginForm loginForm = new LoginForm();
            SetCurrentForm(loginForm);
            Application.Run(currentForm);//³ÌÐòÖ´ÐÐµÇÂ¼Ò³Ãæ
        }
    }
}