using System;
namespace FinalProjectPemrograman.ProgramClass
{
    public abstract class Menu
    {
        public abstract string NamaMenu { get; set; }
        public abstract int Harga { get; set; }
        public abstract int Jumlah { get; set; }
        public abstract int TotalHarga();
    }
}
