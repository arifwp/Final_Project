using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using FinalProjectPemrograman.ProgramClass;

namespace FinalProjectPemrograman
{
    class Program
    {
        static Pesan DataPesanan = new Pesan();

        static void Main(string[] args)
        {
            
            Console.Title = "Soto Holywood Mikom";
            awal:
            Menu();
            string opsi = MenuProgram();

            switch (opsi)
            {
                case "1":
                    BuatPesanan();
                    break;
                case "2":
                    Console.WriteLine("Terimakasih Telah menggunakan program kami");
                    break;
                case "3":
                    PrintStruk();
                    break;

                default:
                    goto awal;
                    break;
            }

        }

        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu Warung Soto Holywood Mikom:");
            Console.WriteLine("1. Soto Babat       : Rp. 13.000.00,-");
            Console.WriteLine("2. Soto Sapi        : Rp. 12.000.00,-");
            Console.WriteLine("3. Soto Ayam        : Rp. 10.000.00,-");
            Console.WriteLine("4. Soto Campur      : Rp. 12.000.00,-");
        }
        
        private static string MenuProgram()
        {
            Console.WriteLine("\nAksi program: ");
            Console.WriteLine("1. Buat pesanan");
            Console.WriteLine("2. Keluar");
            Console.WriteLine("3. Print Struk");

            Console.Write("Masukkan Pilihan: ");
            return Console.ReadLine();
        }

        private static void BuatPesanan()
        {
            Menu();


            Console.WriteLine();

            Console.Write("Nama Pembeli: ");
            DataPesanan.Pembeli = Console.ReadLine();

            UpOrder:
            Console.Write("Masukkan Makanan/Minuman Yang akan dipesan: ");
            string menuPilihan = Console.ReadLine();


            switch(menuPilihan)
            {
                case "1":
                    SotoBabat sotoBabat = new SotoBabat();

                    sotoBabat.NamaMenu = "Soto Babat";
                    sotoBabat.Harga = 13000;

                    Console.WriteLine("Pesanan \t\t: {0}", sotoBabat.NamaMenu);
                    Console.WriteLine("Harga\t\t\t: {0}", sotoBabat.Harga);
                    Console.Write("Masukkan Jumlah Pesanan\t: ");
                    sotoBabat.Jumlah = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Total\t\t\t: {0}", sotoBabat.TotalHarga());

                    DataPesanan.Pesanan.Add(sotoBabat);

                    goto ReOrder;
                    break;
                case "2":
                    SotoSapi sotoSapi = new SotoSapi();

                    sotoSapi.NamaMenu = "Soto Sapi";
                    sotoSapi.Harga = 12000;

                    Console.WriteLine("Pesanan \t\t: {0}", sotoSapi.NamaMenu);
                    Console.WriteLine("Harga\t\t\t: {0}", sotoSapi.Harga);
                    Console.Write("Masukkan Jumlah Pesanan\t: ");
                    sotoSapi.Jumlah = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Total\t\t\t: {0}", sotoSapi.TotalHarga());

                    DataPesanan.Pesanan.Add(sotoSapi);

                    goto ReOrder;
                    break;

                case "3":
                    SotoAyam sotoAyam = new SotoAyam();

                    sotoAyam.NamaMenu = "Soto Ayam";
                    sotoAyam.Harga = 10000;

                    Console.WriteLine("Pesanan \t\t: {0}", sotoAyam.NamaMenu);
                    Console.WriteLine("Harga\t\t\t: {0}", sotoAyam.Harga);
                    Console.Write("Masukkan Jumlah Pesanan\t: ");
                    sotoAyam.Jumlah = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Total\t\t\t: {0}", sotoAyam.TotalHarga());

                    DataPesanan.Pesanan.Add(sotoAyam);

                    goto ReOrder;
                    break;

                case "4":
                    SotoCampur sotoCampur = new SotoCampur();

                    sotoCampur.NamaMenu = "Soto Campur";
                    sotoCampur.Harga = 120000;

                    Console.WriteLine("Pesanan \t\t: {0}", sotoCampur.NamaMenu);
                    Console.WriteLine("Harga\t\t\t: {0}", sotoCampur.Harga);
                    Console.Write("Masukkan Jumlah Pesanan\t: ");
                    sotoCampur.Jumlah = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Total\t\t\t: {0}", sotoCampur.TotalHarga());

                    DataPesanan.Pesanan.Add(sotoCampur);


                    goto ReOrder;
                    break;

                default:
                    Console.Write("Inputan salah, silahkan masukkan lagi: ");
                    goto UpOrder;
                    break;
            }


        ReOrder:
            Console.WriteLine("Apakah ingin menambah Pesanan? (y/n): ");
            string opt = Console.ReadLine();

            switch(opt)
            {
                case "Y":
                    goto UpOrder;
                    break;
                case "y":
                    goto UpOrder;
                    break;
                default:
                    PrintStruk();
                    break;
            }
        }

        private static void PrintStruk()
        {
            Console.Clear();
            Console.Title = "Soto Holywood Mikom";
            Console.WriteLine("Pembeli          : {0}", DataPesanan.Pembeli);
            Console.WriteLine("Daftar Pesanan   : ");

            int totalBayar = 0, i = 1;

            foreach(Menu menu in DataPesanan.Pesanan)
            {
                Console.WriteLine("{0}. {1} \t {2} x {3} \t = {4}", i, menu.NamaMenu, menu.Harga, menu.Jumlah, menu.TotalHarga());
                totalBayar += menu.TotalHarga();
                i++;
            }

            Console.WriteLine("Total Pembayaran : {0}", totalBayar);
            Console.WriteLine();
            Console.WriteLine("Apakah ingin kembali ke menu awal? (y/n): ");
            string awal = Console.ReadLine();

            if (awal=="Y" || awal=="y")
            {
                awal2:
                Menu();
                string opsi = MenuProgram();

                switch (opsi)
                {
                    case "1":
                        BuatPesanan();
                        break;
                    case "2":
                        Console.WriteLine("Terimakasih Telah menggunakan program kami");
                        break;
                    case "3":
                        PrintStruk();
                        break;
                    default:
                        goto awal2;
                        break;
                }
            } 
            else
            {
                Console.WriteLine("Terimakasih Telah menggunakan program kami");
            }
        }
    }
}
