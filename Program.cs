namespace BankaOtomasyonu
{
    internal static class Program
    { 
        
        public static int AktifMusteriID;
        public static string AktifHesapID;// char / varchar

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Giris());
        }
    }
}