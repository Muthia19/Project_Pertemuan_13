using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Pertemuan_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pendaftaran anggota perpus
            Console.Write("NPM : "); string _npm = Console.ReadLine();
            Console.Write("NAMA : "); string _nama = Console.ReadLine();
            Console.Write("ALAMAT : "); string _alamat = Console.ReadLine();
            Console.Write("URL FOTO : "); string _urlfoto = Console.ReadLine();
            Console.Write("KODE : "); string _kode = Console.ReadLine();

            //Buat anggota perpus
            AnggotaPerpus anggota1 = new AnggotaPerpus(_npm, _nama, _alamat, _urlfoto, _kode);

            //TAMPILAN INFORMASI
            anggota1.TampilkanDataAnggota();

            //anggota perpus melakukan login
            Console.Write("MASUKKAN KODE : ") string _KodeMasukkan = Console.ReadLine();

            //pengecekan login
            bool hasillogin = anggota1.Login(_KodeMasukkan);

            if(hasillogin == true)
            {
                Console.WriteLine("SELAMAT DATANG");
            }
            else
            {
                Console.WriteLine("KODE SALAH");
            }

            #region Peminjaman Buku
            //masukkan judul buku yang dipinjam
            Console.Write("MASUKKAN KODE ANDA : ") string _kodeuntukpinjam = Console.ReadLine();

            //akses fungsi peminjaman
            if(anggota1.PinjamBuku(_kodeuntukpinjam) == true)
            {
                //input judul buku
                Console.Write("Masukkan Judul Buku yang Dipinjam : "); string _judul = Console.ReadLine();

            }
            else
            {
                //gagal pinjam
                Console.WriteLine("KODE ANDA SALAH, ANDA TIDAK DAPAT MAMINJAM BUKU!!!!");

            }
	        #endregion

            //Tampilkan data buku pinjaman
            anggota1.TampilkanDataAnggota();

            Console.ReadKey();
        }
    }
}
