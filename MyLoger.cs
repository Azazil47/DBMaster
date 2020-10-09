using System;
using System.IO;
using System.Windows.Forms;

namespace DBMaster
{
    static class MyLoger
    {

        public enum MyEnum
        {
            ERROR, INFO, WARNING
        }

        public static void write(String line)
        {

            try
            {
                DateTime date = DateTime.Now;
                StreamWriter writer = new StreamWriter($"Log\\{date.ToString("dd.MM.yyyy")}.log", true);
                writer.WriteLine($"{date.ToString("HH:mm:ss")}\t{line}");
                writer.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось записать файл log");
            }
        }
    }
}
