using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.ServiceProcess;
using System.Windows.Forms;

namespace DBMaster
{
    static class MyLoger
    {
        private static Dictionary<int, Enum> lvl = new Dictionary<int, Enum>();
        
        static MyLoger() 
            {
            lvl.Add(-1, MyEnum.ERROR);
            lvl.Add(0, MyEnum.INFO);
            lvl.Add(1, MyEnum.WARNING);
        }
        public static Enum getlvl(int i)
        {
            return lvl[i];
        }

        public enum MyEnum
        {
            ERROR = -1, INFO = 0, WARNING =1
        }


        public static void writeFile(int level, String line, String name, ServiceControllerStatus stat) //ЗАПИСЬ В ФАЙЛ
        {
            try
            {
                DateTime date = DateTime.Now;
                StreamWriter writer = new StreamWriter($"Log\\{date.ToString("dd.MM.yyyy")}.log", true);
                writer.WriteLine($"{date.ToString("HH:mm:ss") } - {getlvl(level)} Служба \"{name}\" - {stat}");
                writer.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось записать файл log");
            }
        }

        public static void writeFile(int level, String line, String name, String stat) //ЗАПИСЬ В ФАЙЛ ДЛЯ НЕКОРРЕКТНОЙ СЛУЖБЫ
        {
            try
            {
                DateTime date = DateTime.Now;
                StreamWriter writer = new StreamWriter($"Log\\{date.ToString("dd.MM.yyyy")}.log", true);
                writer.WriteLine($"{date.ToString("HH:mm:ss") } - {getlvl(level)} Служба \"{name}\" - {stat}");
                writer.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось записать файл log");
            }
        }

        public static void writeTextBox(int level, String line, String name, String stat) //ЗАПИСЬ В TEXTBOX
        {
            try
            {
                DateTime date = DateTime.Now;
                Program.myForm.textBoxLog.Text += $"{date.ToString("HH:mm:ss")} - {getlvl(level)} Служба \"{name}\" - {stat} \r\n";
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось отобразить лог");
            }
        }

        public static void writeTextBox(int level, String line, String name, ServiceControllerStatus stat) //ЗАПИСЬ В TEXTBOX ДЛЯ НЕКОРРЕКТНОЙ СЛУЖБЫ
        {
            try
            {
                DateTime date = DateTime.Now;
                Program.myForm.textBoxLog.Text += $"{date.ToString("HH:mm:ss")} - {getlvl(level)} Служба \"{name}\" - {stat} \r\n";
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось отобразить лог");
            }
        }
    }
}
