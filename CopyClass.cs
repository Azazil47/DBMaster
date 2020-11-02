using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DBMaster
{
    class CopyClass
    {
        private FileStream FileStreamSource;
        private FileStream FileStreamDestination;
        public CopyClass()
        {
            
        }

        public void Copy(string fileSource, string fileDestination) //Метод копирования БД
        {
            if(ServiceClass.ChekServices(Program.controllers))
            {
                MessageBox.Show("Не все службы остановлены");
            }
            else
            {
                FileStreamSource = new FileStream(fileSource, FileMode.Open);
                FileStreamDestination = new FileStream(fileDestination, FileMode.OpenOrCreate);
                double countEtalon = FileStreamSource.Length / 100;
                double persent = 1;
                double count = 0;
                while (FileStreamSource.Position < FileStreamSource.Length)
                {
                    byte[] buffer = new byte[1000000];
                    int i = FileStreamSource.Read(buffer, 0, buffer.Length);
                    FileStreamDestination.Write(buffer, 0, i);
                    while (persent < 100)
                    {
                        count += countEtalon;
                        persent = count * 100 / FileStreamSource.Length;
                        Program.myForm.updProgressBar(persent);
                    }
                }
                FileStreamSource.Close();
                FileStreamDestination.Flush();
                FileStreamDestination.Close();
                chekMD5(fileSource, fileDestination);
            }
        }
        
        public void chekMD5(string fileSource, string fileDestination)
        {
            byte[] hash1;
            byte[] hash2;
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(fileSource))
                {
                    hash1 = md5.ComputeHash(stream);
                }
                using (var stream = File.OpenRead(fileDestination))
                {
                    hash2 = md5.ComputeHash(stream);
                }
            }
            if (Enumerable.SequenceEqual(hash1, hash2))
            {
                MessageBox.Show("База данных успешно скопирована");
            }
            else MessageBox.Show("Ошибка контрольной суммы базы данных");
        }
    }
}
