namespace FormEOS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form1 = new Form1();
            form1.FormBorderStyle = FormBorderStyle.None;
            form1.WindowState = FormWindowState.Maximized; // Hiển thị form toàn màn hình

            Application.Run(new Login());
        }

    }
}