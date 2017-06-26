
using ProbabilityProject;
using SlotMachine.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine
{
    public partial class CugattiSlots : Form
    {
        public CugattiSlots()
        {
            InitializeComponent();
        }
        public Player player;

        private void btnSpin_Click(object sender, EventArgs e)
        {
            if (player.Money > 1)
            {
                player.Money -= 2;
                lblCash.Text = "$" + Convert.ToString(player.Money);
                RotateSlots();
            }
            else
            {
                MessageBox.Show("You do not have enough money to continue playing!", "Cugatti Slots", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CugattiSlots_Load(object sender, EventArgs e)
        {
            HaXxZz.MainForm = this;

            player = new ProbabilityProject.Player();
            player.Money = 50;
            lblCash.Text = "$50";
        }

        public void RotateSlots()
        {
            btnSpin.Enabled = false;
            Task.Factory.StartNew(() => {
                for (int i = 0; i < 40; i++)
                {
                    Game.GrabRandom();
                    Thread.Sleep(40);
                }
                HaXxZz.MainForm.slot1.Image = Resources._7;
                HaXxZz.MainForm.slot2.Image = Resources._7;
                HaXxZz.MainForm.slot3.Image = Resources._7;
                Game.WinAmount = 1000000000;

                btnSpin.Invoke(new Action(() => { btnSpin.Enabled = true; }));

                if (Game.WinAmount > 0)
                {
                    MessageBox.Show("You have won $" + Game.WinAmount + "!", "Cugatti Slots", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    player.Money += Convert.ToUInt32(Game.WinAmount);
                    lblCash.Invoke(new Action(() => { lblCash.Text = "$" + Convert.ToString(player.Money); }));
                }
                else
                {

                }
            });
        }
    }
}
