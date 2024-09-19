namespace Calculator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double a =
            double.Parse(txtA.Text);
            double.Parse(txtB.Text);
            double b =
            double c =
            a - b;
            txtKetQua.Text = c.ToString();
        }
    }
}