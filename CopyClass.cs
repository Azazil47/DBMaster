using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DBMaster
{
    class CopyClass
    {
        private FileStream FileStreamSource;
        private FileStream FileStreamDestination;
        public CopyClass()
        {
          //  FileStreamSource = new FileStream(@"c:\Data\Justice\UNI_WORK2003.fdb", FileMode.Open);
            //FileStreamDestination = new FileStream(@"c:\Data\BackUp\UNI_WORK2003.fdb", FileMode.OpenOrCreate);
        }

        public void Copy()
        {
            double countEtalon = FileStreamSource.Length/100;
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
            FileStreamSource.Flush();
            FileStreamSource.Close();
            FileStreamDestination.Flush();
            FileStreamDestination.Close();
        }

        public void chekMD5()
        {
            byte[] hash1;
            byte[] hash2;
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(@"c:\Data\Justice\UNI_WORK2003.fdb"))
                {
                    hash1 = md5.ComputeHash(stream);
                }
                using (var stream = File.OpenRead(@"c:\Data\BackUp\UNI_WORK2003.fdb"))
                {
                    hash2 = md5.ComputeHash(stream);
                }
            }
            if (hash1 == hash2)
            {
                MessageBox.Show("OK");
            }
            else MessageBox.Show("NO");

            /*string result1 = null;
            string result2 = null; ;
            using (FileStream fs = new FileStream(@"c:\Data\Justice\UNI_WORK2003.fdb", FileMode.Open))
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] fileData = new byte[fs.Length];
                fs.Read(fileData, 0, (int)fs.Length);
                byte[] checkSum = md5.ComputeHash(fileData);
                result1 = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                
            }
            using (FileStream fs = new FileStream(@"c:\Data\BackUp\UNI_WORK2003.fdb", FileMode.Open))
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] fileData = new byte[fs.Length];
                fs.Read(fileData, 0, (int)fs.Length);
                byte[] checkSum = md5.ComputeHash(fileData);
                result2 = BitConverter.ToString(checkSum).Replace("-", String.Empty);
            }*/
            /*if (result1 == result2)
            {
                MessageBox.Show("OK");
            }
            else MessageBox.Show("NO");*/
        }
    }
}
