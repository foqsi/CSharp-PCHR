namespace Davis_FinalProject_Cs
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set the DataDirectory to the desired path before initializing the application
            //string dataDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            //AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectory);

            //ApplicationConfiguration.Initialize();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}