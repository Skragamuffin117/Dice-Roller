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
            int parse;
            KeyValuePair<string, string> die = (KeyValuePair<string, string>)DieType.SelectedItem;
            string value = die.Value.ToString();
            parse = int.Parse(value);
            if (parse < 1)
            {
                MessageBox.Show("Please Select A Die Type From The Dropdown.");
            }
            else
            {
                int roll = DieRoll(parse);
                string result = roll.ToString();
                Result.Items.Add(result);
            }
            
        }

        private int DieRoll(int parse)
        {
            int result;
            DiceLogic roller = new DiceLogic();
            if (parse == 1)
            {
                result = roller.D4();
                return result;
            }
            else return 0;
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
            DieType.Items.Add(new KeyValuePair<string, string>("Select Die Type", "0"));
            DieType.Items.Add(new KeyValuePair<string, string>("D4", "1"));
            DieType.Items.Add(new KeyValuePair<string, string>("D6", "2"));
            DieType.Items.Add(new KeyValuePair<string, string>("D8", "3"));
            DieType.Items.Add(new KeyValuePair<string, string>("D10", "4"));
            DieType.Items.Add(new KeyValuePair<string, string>("D12", "5"));
            DieType.Items.Add(new KeyValuePair<string, string>("D20", "6"));
            DieType.Items.Add(new KeyValuePair<string, string>("D100", "7"));

            DieType.DisplayMember = "Key";
            DieType.ValueMember = "Value";
            DieType.SelectedIndex = 0;
            
        }
    }
}
