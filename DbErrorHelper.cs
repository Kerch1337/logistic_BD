using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logistic_BD
{
    public static class DbErrorHelper
    {
        public static bool Execute(Action action)
        {
            try
            {
                action();
                return true;
            }
            catch (MySqlException ex)
            {
                ShowDbError(ex);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
        }


        private static void ShowDbError(MySqlException ex)
        {
            string message;

            switch (ex.Number)
            {
                case 1062:
                    message = "Такая запись уже существует.\nПроверьте уникальные поля.";
                    break;


                case 1451:
                    message = "Нельзя удалить запись.\nЕсть связанная(-ые) записи в других таблицах.";
                    break;


                case 1452:
                    message = "Нарушена связь между таблицами.";
                    break;


                default:
                    message = "Ошибка базы данных:\n" +
                        ex.Message;
                    break;
            }

            MessageBox.Show(
                message,
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }
    }
}