namespace AveryGameOfferCreator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static INIFile ini = new("settings.ini", true);
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            if (string.IsNullOrWhiteSpace(ini.GetValue("backend", "url")))
            {
                ini.SetValue("backend", "url", "http://127.0.0.1:8000/");
            }

            Helper.SetBaseURL(ini.GetValue("backend", "url"));
             
            Application.Run(new Form1());
        }
    }
}