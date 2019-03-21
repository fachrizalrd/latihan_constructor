using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //object mhs 1 
            Mahasiswa mhs1 = new Mahasiswa();
            CetakHasil(mhs1);

            Console.WriteLine();

            //object mhs 2
            Mahasiswa mhs2 = new Mahasiswa("2299","Topik");
            CetakHasil(mhs2);

            Console.ReadKey();
       }

        static void CetakHasil(Mahasiswa mhs)
        {
            Console.WriteLine("NIM : {0}", mhs.Nim);
            Console.WriteLine("Nama : {0}", mhs.Nama);
        }
    }
}
