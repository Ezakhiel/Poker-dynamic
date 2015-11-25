using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Dynamic_Games.IncInformation.Player;
using Dynamic_Games.IncInformation.Cards;

namespace Dynamic_Games
{
    public partial class IncInformationForm : Form
    {
        Table table;
        public IncInformationForm()
        {
            InitializeComponent();
            PostInit();
            table = new Table(new Deck(), 2);
        }

        private void PostInit() 
        {
            List<int> players = new List<int> { 2, 3, 4, 5, 6, 7, 8 };
            ComboPlayerCount.DataSource = players;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    this.DialogResult = DialogResult.OK;
                    break;
            }
        }

        private void IncInformationForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            switch (ComboPlayerCount.SelectedIndex)
            {
                case 0:
                    table = new Table(new Deck(),2);
                    P1C1.Show();
                    P1C2.Show();
                    P2C1.Show();
                    P2C2.Show();
                    P3C1.Hide();
                    P3C2.Hide();
                    P4C1.Hide();
                    P4C2.Hide();
                    P5C1.Hide();
                    P5C2.Hide();
                    P6C1.Hide();
                    P6C2.Hide();
                    P7C1.Hide();
                    P7C2.Hide();
                    P8C1.Hide();
                    P8C2.Hide();
                    break;

                case 1:
                    table = new Table(new Deck(),3);
                    P1C1.Show();
                    P1C2.Show();
                    P2C1.Show();
                    P2C2.Show();
                    P3C1.Show();
                    P3C2.Show();
                    P4C1.Hide();
                    P4C2.Hide();
                    P5C1.Hide();
                    P5C2.Hide();
                    P6C1.Hide();
                    P6C2.Hide();
                    P7C1.Hide();
                    P7C2.Hide();
                    P8C1.Hide();
                    P8C2.Hide();
                    break;
                case 2:
                    table = new Table(new Deck(),4);
                    P1C1.Show();
                    P1C2.Show();
                    P2C1.Show();
                    P2C2.Show();
                    P3C1.Show();
                    P3C2.Show();
                    P4C1.Show();
                    P4C2.Show();
                    P5C1.Hide();
                    P5C2.Hide();
                    P6C1.Hide();
                    P6C2.Hide();
                    P7C1.Hide();
                    P7C2.Hide();
                    P8C1.Hide();
                    P8C2.Hide();
                    break;
                case 3:
                    table = new Table(new Deck(),5);
                    P1C1.Show();
                    P1C2.Show();
                    P2C1.Show();
                    P2C2.Show();
                    P3C1.Show();
                    P3C2.Show();
                    P4C1.Show();
                    P4C2.Show();
                    P5C1.Show();
                    P5C2.Show();
                    P6C1.Hide();
                    P6C2.Hide();
                    P7C1.Hide();
                    P7C2.Hide();
                    P8C1.Hide();
                    P8C2.Hide();
                    break;
                case 4:
                    table = new Table(new Deck(),6);
                    P1C1.Show();
                    P1C2.Show();
                    P2C1.Show();
                    P2C2.Show();
                    P3C1.Show();
                    P3C2.Show();
                    P4C1.Show();
                    P4C2.Show();
                    P5C1.Show();
                    P5C2.Show();
                    P6C1.Show();
                    P6C2.Show();
                    P7C1.Hide();
                    P7C2.Hide();
                    P8C1.Hide();
                    P8C2.Hide();
                    break;
                case 5:
                    table = new Table(new Deck(),7);
                    P1C1.Show();
                    P1C2.Show();
                    P2C1.Show();
                    P2C2.Show();
                    P3C1.Show();
                    P3C2.Show();
                    P4C1.Show();
                    P4C2.Show();
                    P5C1.Show();
                    P5C2.Show();
                    P6C1.Show();
                    P6C2.Show();
                    P7C1.Show();
                    P7C2.Show();
                    P8C1.Hide();
                    P8C2.Hide();
                    break;
                case 6:
                    table = new Table(new Deck(),8);
                    P1C1.Show();
                    P1C2.Show();
                    P2C1.Show();
                    P2C2.Show();
                    P3C1.Show();
                    P3C2.Show();
                    P4C1.Show();
                    P4C2.Show();
                    P5C1.Show();
                    P5C2.Show();
                    P6C1.Show();
                    P6C2.Show();
                    P7C1.Show();
                    P7C2.Show();
                    P8C1.Show();
                    P8C2.Show();
                    break;
            }
        }

        private void vizualize()
        {
            
        }
    }
}
