using System;
namespace FinalProjectPemrograman.ProgramClass
{
    public class SotoBabat : Menu
    {
        public override string NamaMenu { get; set; }
        public override int Jumlah { get; set; }
        public override int Harga { get; set; }
        public override int TotalHarga() => this.Harga * this.Jumlah;
    }
}
