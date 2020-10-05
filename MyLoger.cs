using System;
using System.IO;
using System.Windows.Forms;

namespace DBMaster
{
   static class MyLoger
    {
        enum level {
            spring,
            summer,
            autumn,
            winter
        }
        
      
        public static void write(String line)
        {
            try
            {
                 DateTime date =  DateTime.Now;
                 StreamWriter writer = new StreamWriter($"{date.ToString("dd.MM.yyyy")}.log", true);
        writer.WriteLine($"{date.ToString("hh:mm:ss")} {line} ");  
                writer.Flush();
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось записать файл log");
            }
        }
    }
}
