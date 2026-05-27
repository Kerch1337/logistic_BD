using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;

namespace logistic_BD
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Licenser.LicenseKey = "WDN52-ARNFA-844M5-S4FA";

            // ошибки потока интерфейса
            Application.ThreadException +=
                (sender, e) =>
            {
                MessageBox.Show(
                    e.Exception.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            };

            // ошибки остальных потоков
            AppDomain.CurrentDomain.UnhandledException +=
                (sender, e) =>
            {
                Exception ex = (Exception)e.ExceptionObject;

                MessageBox.Show(
                    ex.Message,
                    "Критическая ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            };


            LoginForm login =
                new LoginForm();

            login.ShowDialog();

            if (login.IsLoggedIn)
            {
                Application.Run(
                    new MainForm()
                );
            }
        }
    }
}
