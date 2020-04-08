using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveringSystem.Logics
{
    class Reservering
    {
        private int persAmount;
        private string telefoonNummer;
        private string name;
        private bool binnen;
        private int tafelNummer;

        public int PersAmount { get => persAmount; set => persAmount = value; }
        public string TelefoonNummer { get => telefoonNummer; set => telefoonNummer = value; }
        public string Name { get => name; set => name = value; }
        public int TafelNummer { get => tafelNummer; set => tafelNummer = value; }
        public bool Binnen { get => binnen; set => binnen = value; }

        public Reservering(String name, int amount, string telefoonNummer, int tafelNum, bool binnen)
        {
            Name = name;
            PersAmount = amount;
            Binnen = binnen;
            TelefoonNummer = telefoonNummer;
            TafelNummer = tafelNum;
        }


        

    }
}
