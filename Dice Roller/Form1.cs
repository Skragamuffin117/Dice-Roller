using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Roller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Roll_Click(object sender, EventArgs e)
        {
            Result.Clear();
            KeyValuePair<string, int> die = (KeyValuePair<string, int>)DieType.SelectedItem;
            int value = die.Value;
            if (value < 1)
            {
                MessageBox.Show("Please Select A Die Type From The Dropdown.");
            }
            else
            {
                int roll = DieRoll(value);
                string result = roll.ToString();
                Result.Items.Add(result);
                PassFail(roll);
            }
            
        }

        private int DieRoll(int value)
        {
            int result;
            DiceLogic roller = new DiceLogic();
            result = roller.Roll(value);
            return result;
        }

        private void PassFail(int roll)
        {
            int difficulty;
            string entry = DifficultyRating.Text;
            if (int.TryParse(entry, out difficulty))
            {
                if (difficulty < roll)
                {
                    string result = "Pass";
                    Result.Items.Add(result);
                }
                else
                {
                    string result = "Fail";
                    Result.Items.Add(result);
                }
            }
            else
            {
                Result.Items.Add("Invalid Difficulty");
            }
        }

        private void DieType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DifficultyRating_TextChanged(object sender, EventArgs e)
        {

        }

        private void Result_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DieType.Items.Add(new KeyValuePair<string, int>("Select Die Type", 0));
            DieType.Items.Add(new KeyValuePair<string, int>("D4", 4));
            DieType.Items.Add(new KeyValuePair<string, int>("D6", 7));
            DieType.Items.Add(new KeyValuePair<string, int>("D8", 9));
            DieType.Items.Add(new KeyValuePair<string, int>("D10", 11));
            DieType.Items.Add(new KeyValuePair<string, int>("D12", 13));
            DieType.Items.Add(new KeyValuePair<string, int>("D20", 21));
            DieType.Items.Add(new KeyValuePair<string, int>("D100", 101));

            DieType.DisplayMember = "Key";
            DieType.ValueMember = "Value";
            DieType.SelectedIndex = 0;
            
        }
    }
}
