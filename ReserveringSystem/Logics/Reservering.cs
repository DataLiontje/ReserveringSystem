using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveringSystem.Logics
{
    class Reservering
    {
        private int PersAmount { get; set; }
        private string TelefoonNummer { get; set; }
        private string Name { get; set; }
        private bool Binnen { get; set; }
        private int TafelNummer { get; set; }



        public Reservering(String name, int amount, string telefoonNummer, int tafelNum, bool binnen)
        {
            Name = name;
            PersAmount = amount;
            Binnen = binnen;
            TelefoonNummer = telefoonNummer;
            TafelNummer = tafelNum;
        }


        public string GetTelNum()
        {
            return TelefoonNummer;
        }


        public int GetPersonAmount()
        {
            return PersAmount;
        }


        public int GetTafelNum()
        {
            return TafelNummer;
        }

        public string GetName()
        {
            return Name;
        }


        public bool IsBinnen()
        {
            return Binnen;
        }
        

    }
}
