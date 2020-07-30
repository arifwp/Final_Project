using System;
using System.Collections.Generic;

namespace FinalProjectPemrograman.ProgramClass
{
    public class Pesan
    {
        public string Pembeli { get; set; }
        public List<Menu> Pesanan = new List<Menu>();
        public int TotalHarga { get; set; }
    }
}
