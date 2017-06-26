using SlotMachine;
using SlotMachine.Properties;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ProbabilityProject
{
    public class Game
    {
        public Game()
        {
            
        }

        public static string[] Types = { "7", "Bell", "Cherry", "Clover", "Diamond", "Watermelon" };
        public static int WinAmount = 0;

        public static void GrabRandom()
        {
            
            int one = new Math().ReturnRandom(0, Types.Length);
            Thread.Sleep(17);
            int two = new Math().ReturnRandom(0, Types.Length);
            Thread.Sleep(17);
            int three = new Math().ReturnRandom(0, Types.Length);

            if (one == 0 && two == 0 && three == 0)
            {
                HaXxZz.MainForm.slot1.Image = Resources._7;
                HaXxZz.MainForm.slot2.Image = Resources._7;
                HaXxZz.MainForm.slot3.Image = Resources._7;
                WinAmount = 100000;
            }
            else if (one == 1 && two == 1 && three == 1)
            {
                HaXxZz.MainForm.slot1.Image = Resources.bell;
                HaXxZz.MainForm.slot2.Image = Resources.bell;
                HaXxZz.MainForm.slot3.Image = Resources.bell;
                WinAmount = 50000;
            }
            else if (one == 2 && two == 2 && three == 2)
            {
                HaXxZz.MainForm.slot1.Image = Resources.cherry;
                HaXxZz.MainForm.slot2.Image = Resources.cherry;
                HaXxZz.MainForm.slot3.Image = Resources.cherry;
                WinAmount = 25000;
            }
            else if (one == 3 && two == 3 && three == 3)
            {
                HaXxZz.MainForm.slot1.Image = Resources.clover;
                HaXxZz.MainForm.slot2.Image = Resources.clover;
                HaXxZz.MainForm.slot3.Image = Resources.clover;
                WinAmount = 10000;
            }
            else if (one == 4 && two == 4 && three == 4)
            {
                HaXxZz.MainForm.slot1.Image = Resources.diamond;
                HaXxZz.MainForm.slot2.Image = Resources.diamond;
                HaXxZz.MainForm.slot3.Image = Resources.diamond;
                WinAmount = 5000;
            }
            else if (one == 5 && two == 5 && three == 5)
            {
                HaXxZz.MainForm.slot1.Image = Resources.watermelon;
                HaXxZz.MainForm.slot2.Image = Resources.watermelon;
                HaXxZz.MainForm.slot3.Image = Resources.watermelon;
                WinAmount = 2500;
            }
            else
            {
                HaXxZz.MainForm.slot1.Image = GetType(one);
                HaXxZz.MainForm.slot2.Image = GetType(two);
                HaXxZz.MainForm.slot3.Image = GetType(three);
                WinAmount = 0;
            }
        }

        public static Image GetType(int type)
        {
            if (type == 0)
                return Resources._7;
            else if (type == 1)
                return Resources.bell;
            else if (type == 2)
                return Resources.cherry;
            else if (type == 3)
                return Resources.clover;
            else if (type == 4)
                return Resources.diamond;
            else if (type == 5)
                return Resources.watermelon;
            else return null;
        }
    }
}
