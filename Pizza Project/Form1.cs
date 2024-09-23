using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        int Money = 0;
        string Current_Size = "";
        string Current_Toppings = "";
        string Current_CrustType = "";
        string Current_WhereToEat = "";
        public Form1()
        {
            InitializeComponent();

            UpdateLabel();
        }
        float GetSelectedSizedPrice()
        {
            if (btnSmall.Checked)
                return Convert.ToSingle(btnSmall.Tag);
            else if (btnMeduim.Checked)
                return Convert.ToSingle(btnMeduim.Tag);
            else
                return Convert.ToSingle(btnLarge.Tag);

        }

        float CalculateToppingsPrice()
        {
            float ToppingTotalPrice = 0;
            return
        }
        float CalculateTotalPrice()
        {
            return GetSelectedSizedPrice() + CalculateToppingsPrice(); //GetSelected;
        }
        void UpdateTotalPrice()
        {
            labelTotalPrice.Text = "$ " + CalculateTotalPrice().ToString();
        }
        void UpdatePrice()
        {
            UpdateTotalPrice();
            if(btnSmall.Checked)
            {
                label8.Text = "Small";
                return;
            }
            if (btnMeduim.Checked)
            {
                label8.Text = "Medium";
                return;
            }
            if (btnLarge.Checked)
            {
                label8.Text = "Large";
                return;
            }
        }
        private void UpdateLabel()
        {
            labelTotalPrice.Text = "$ " + Money.ToString();
        }
        private void UpdateSize()
        {
            label8.Text = Current_Size;
        }
        private void UpdateCrustType()
        {
            label11.Text = Current_CrustType;
        }
        private void UpdateWhereToEat()
        {
            label12.Text = Current_WhereToEat;
        }
        private void UpdateToppings()
        {
            label9.Text = Current_Toppings;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show("Confirm Order ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                groupBox1.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                groupBox5.Enabled = false;
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            groupBox5.Enabled = true;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (btnSmall.Checked)
            {
                Money += 10;
                Current_Size = "Small";
            } else
            {
                Money -= 10;
            }
            UpdateLabel();
            UpdateSize();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (btnMeduim.Checked)
            {
                Money += 20;
                Current_Size = "Medium";
            }
            else
            {
                Money -= 20;
            }
            UpdateLabel();
            UpdateSize();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (btnLarge.Checked)
            {
                Money += 30;
                Current_Size = "Large";
            }
            else
            {
                Money -= 30;
            }
            UpdateLabel();
            UpdateSize();
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                Money += 30;
                Current_CrustType = "Thick Crust";
            }
            else
            {
                Money -= 30;
            }
            UpdateLabel();
            UpdateCrustType();
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                Money += 15;
                Current_CrustType = "Thin Crust";
            }
            else
            {
                Money -= 15;
            }
            UpdateLabel();
            UpdateCrustType();
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if ( radioButton7.Checked)
            {
                Current_WhereToEat = "Eat In";
            }
            UpdateWhereToEat();
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                Current_WhereToEat = "Take Away";
            }
            UpdateWhereToEat();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Money += 5;
                Current_Toppings = checkBox1.Text + " ";
            }
            else
            {
                Money -= 5;
            }
            UpdateLabel();
            UpdateToppingsList();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Money += 5;
                Current_Toppings = checkBox2.Text + " ";
            }
            else
            {
                Money -= 5;
            }
            UpdateLabel();
            UpdateToppingsList();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                Money += 5;
            }
            else
            {
                Money -= 5;
            }
            UpdateLabel();
            UpdateToppingsList();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                Money += 5;
            }
            else
            {
                Money -= 5;
            }
            UpdateLabel();
            UpdateToppingsList();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                Money += 5;
            }
            else
            {
                Money -= 5;
            }
            UpdateLabel();
            UpdateToppingsList();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                Money += 5;
            }
            else
            {
                Money -= 5;
            }
            UpdateLabel();
            UpdateToppingsList();
        }


        private void UpdateToppingsList()
        {
            Current_Toppings = "";
            byte counter = 0;

            if (checkBox1.Checked)
            {
                counter++;
                Current_Toppings += checkBox1.Text + " , ";
            }

            if (checkBox2.Checked)
            {
                counter++;
                Current_Toppings += checkBox2.Text + " , ";
            }

            if (checkBox3.Checked)
            {
                counter++;
                Current_Toppings += checkBox3.Text + " , ";
            }

            if (checkBox4.Checked)
            {
                counter++;
                Current_Toppings += checkBox4.Text + " ,  ";
            }

            if (checkBox5.Checked)
            {
                counter++;
                Current_Toppings += checkBox5.Text + " ,  ";
            }

            if (checkBox6.Checked)
            {
                counter++;
                Current_Toppings += checkBox6.Text + " , ";
            }


            label9.Text = Current_Toppings;
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
    }
}
