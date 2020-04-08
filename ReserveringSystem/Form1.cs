using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReserveringSystem.Logics;

namespace ReserveringSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BinnenTafelsNum.Text = Restaurant.GetRestaurantByName("moenen").CalculateInside().ToString();
            BuitenTafelsNum.Text = Restaurant.GetRestaurantByName("moenen").CalculateOutside().ToString();
        }
        private void SubmitReserveringButton_Click(object sender, EventArgs e)
        {
            string naamRes = NaamInput.Text;
            string telNum = TelNumInput.Text;
            int aantal = (int) AantalPersInput.Value;
            bool binnen = IsBinnenCheck.Checked;
            int neededTables = (int)Math.Ceiling((Double)aantal / 4);


 




            if(aantal < 1 || naamRes.Length < 3 || telNum.Length < 5)
            {
                MessageBox.Show("Invalid Name, Tel Num or Amount input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            NaamInput.Text = "";
            AantalPersInput.Value = 1;
            TelNumInput.Text = "";
            Restaurant restaurant = Restaurant.GetRestaurantByName("moenen");

            if(restaurant.GetReserveringByName(naamRes) != null)
            {
                MessageBox.Show("Er staat al een reservering op deze naam!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!restaurant.CanGetGetTables(binnen, neededTables)){
                MessageBox.Show("Niet genoeg beschikbare Tafels", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Reservering reservering = new Reservering(naamRes, aantal, telNum, restaurant.GetNextAvailableTableNum(), binnen);
            restaurant.reserveringen.Add(reservering);
            Button reserveringItem = new Button();
            reserveringItem.TextAlign = ContentAlignment.MiddleCenter;
            reserveringItem.Text = naamRes;
            reserveringItem.Click += new EventHandler(ReserveringButton);
            Reserveringen.Controls.Add(reserveringItem);
            BinnenTafelsNum.Text = Restaurant.GetRestaurantByName("moenen").CalculateInside().ToString();
            BuitenTafelsNum.Text = Restaurant.GetRestaurantByName("moenen").CalculateOutside().ToString();
        }
        private void ReserveringButton(object sender, EventArgs e)
        {
            Restaurant restaurant = Restaurant.GetRestaurantByName("moenen");
            Button btn = (Button)sender;
            String reserveerder = btn.Text;
            Reservering resv = restaurant.GetReserveringByName(reserveerder);
            MessageBox.Show("Reserveernaam: "+resv.GetName()+"\nAantal Personen: "+resv.GetPersonAmount()+"\nTelefoon Nummer: "+resv.GetTelNum()+"\nLocatie: "+(resv.IsBinnen() ? "Binnen" : "Buiten"), "Reservering tafel "+resv.GetTafelNum());
        }
    }
}
