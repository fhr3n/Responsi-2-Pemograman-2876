using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

                while (true)
                {
                    TampilMenu();

                    Console.Write("\nNomor Menu [1..5]: ");
                    int nomorMenu = Convert.ToInt32(Console.ReadLine());
                    switch (nomorMenu)

                    {
                        case 1:
                            TambahPenjualan();
                            break;

                        case 2:
                            HapusPenjualan();
                            break;

                        case 3:
                            TampilPenjualan();
                            break;

                        case 4: 
                            EditPenjualan();
                            break;

                        case 5:
                            return;

                        default:
                    
                            break;
                    }
                }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Hapus Penjualan");
            Console.WriteLine("3. Tampilkan Penjualan");
            Console.WriteLine("4. Edit Data Penjualan");
            Console.WriteLine("5. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();
            Console.WriteLine("Tambah Data Penjualan\n");
            Console.WriteLine("Nota: ");
            string nota = Console.ReadLine();
            Console.WriteLine("Tanggal: ");
            string tanggal = Console.ReadLine();
            Console.WriteLine("Customer: ");
            string nama = Console.ReadLine();
            Console.WriteLine("Jenis (T/K):");
            string jenis = Console.ReadLine();
            if (jenis == "t" || jenis == "T")
            {
                jenis = "Tunai";
            }
            else if (jenis == "K" || jenis == "k")
            {
                jenis = "Kredit";
            }
            Console.WriteLine("Total Nota: ");
            int totalNota = Convert.ToInt32(Console.ReadLine());
            daftarPenjualan.Add(new Penjualan(nota, tanggal, nama, jenis, totalNota));
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();

        }

        static void HapusPenjualan()
        {
            Console.Clear();
            Console.WriteLine("Hapus Data Penjualan\n");
            Console.WriteLine("Nota :");
            string nota = Console.ReadLine();
            for (int i = 0; i < daftarPenjualan.Count; i++)
            {
                Penjualan penjualan = daftarPenjualan[i];
                if (penjualan.nota == nota)
                {
                    daftarPenjualan.RemoveAt(i);
                    Console.WriteLine("Data penjualan berhasil di hapus\n");
                }
                else
                {
                    Console.WriteLine("Nota Tidak Ditemukan\n");
                }
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();
            int counter = 1;
            Console.WriteLine("Data Penjualan\n");
            foreach (Penjualan penjualan in daftarPenjualan)
            {

                Console.WriteLine(counter + ". " + penjualan.nota + ", " + penjualan.tanggal + ", " + penjualan.nama + ", " + penjualan.jenis + ", " + penjualan.totalNota);
                counter++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
        static void EditPenjualan()
        {
            Console.Clear();
            Console.WriteLine("Edit Data penjualan\n");
            Console.WriteLine("Masukkan Nota :");
            string nota = Console.ReadLine();
            for (int i = 0; i < daftarPenjualan.Count; i++)
            {
                Penjualan penjualan = daftarPenjualan[i];
                if (penjualan.nota == nota)
                {
                    Console.WriteLine("Nota: ");
                    string notas = Console.ReadLine();
                    Console.WriteLine("Tanggal: ");
                    string tanggal = Console.ReadLine();
                    Console.WriteLine("Customer: ");
                    string nama = Console.ReadLine();
                    Console.WriteLine("Jenis (T/K):");
                    string jenis = Console.ReadLine();
                    if (jenis == "t" || jenis == "T")
                    {
                        jenis = "Tunai";
                    }
                    else if (jenis == "K" || jenis == "k")
                    {
                        jenis = "Kredit";
                    }
                    Console.WriteLine("Total Nota: ");
                    int totalNota = Convert.ToInt32(Console.ReadLine());
                    daftarPenjualan[i].nota = notas;
                    daftarPenjualan[i].tanggal = tanggal;
                    daftarPenjualan[i].nama = nama;
                    daftarPenjualan[i].jenis = jenis;
                    daftarPenjualan[i].totalNota = totalNota;
                    Console.WriteLine("Data Berhasil Diubah!\n");
                }
                else
                {
                    Console.WriteLine("Data Tidak Ditemukan !\n");
                }
            }
        }
    }
}