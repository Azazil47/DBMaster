using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DBMaster
{
    class CopyClass
    {
        private FileStream FileStreamSource;
        private FileStream FileStreamDestination;
        public CopyClass()
        {
            FileStreamSource = new FileStream(@"c:\Data\Justice\UNI_WORK2003.fdb", FileMode.Open); ;
            FileStreamDestination = new FileStream(@"c:\Data\BackUp\UNI_WORK2003.fdb", FileMode.OpenOrCreate); ;
        }

        public void Open()
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
        }
    }
}
