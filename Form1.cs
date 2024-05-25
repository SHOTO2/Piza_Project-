using System;
using System.Windows.Forms;

namespace PizaProject_Solve
{
    public partial class Form1 : Form
    {
        public void UpdateTotalPrice()
        {
            textPrice.Text = "$" + CalculateTotalPrice();
        }
        public float CalculateTotalPrice()
        {
            return GetSelectSizePrice() + GetToppingsSelectPrice() + GetCrustSelectSize();
        }
        public float GetSelectSizePrice()
        {
            if (rdSmall.Checked == true)
            {
                return Convert.ToSingle(rdSmall.Tag);
            }
            else if (rdMedium.Checked == true)
            {
                return Convert.ToSingle(rdMedium.Tag);
            }
            else 
            {
                return Convert.ToSingle(rdLarg.Tag);
            }
        }
        public float GetToppingsSelectPrice()
        {
            float ToppingPrice = 0;
            if (chkExtraChees.Checked == true)
            {
                ToppingPrice += Convert.ToSingle(chkExtraChees.Tag);
            }
            if (chkMushrooms.Checked == true)
            {
                ToppingPrice += Convert.ToSingle(chkMushrooms.Tag);
            }
            if (chkTomatoes.Checked == true)
            {
                ToppingPrice += Convert.ToSingle(chkTomatoes.Tag);
            }
            if (chkOnion.Checked == true)
            {
                ToppingPrice += Convert.ToSingle(chkOnion.Tag);
            }
            if (chkOlives.Checked == true)
            {
                ToppingPrice += Convert.ToSingle(chkOlives.Tag);
            }
            if (chkGreenPeppers.Checked == true)
            {
                ToppingPrice += Convert.ToSingle(chkGreenPeppers.Tag);
            }
            return ToppingPrice;
        }
        public float GetCrustSelectSize()
        {
            if (rdThin.Checked == true) 
            {
                return Convert.ToSingle(rdThin.Tag);
            }
            else
            {
                return Convert.ToSingle(rdThink.Tag);
            }
        }
        public void UpdateSize()
        {
            UpdateTotalPrice();
            if (rdSmall.Checked == true)
            {
                texSize.Text = "Small";
            }
            else if (rdMedium.Checked == true)
            {
                texSize.Text = "Medium";
            }
            else
            {
                texSize.Text = "Larg";
            }
        }
        public void UpdateToppings()
        {
            UpdateTotalPrice();
            string sToppings = "";
            if (chkExtraChees.Checked == true == true)
            {
                sToppings += "Extra Chees ,";
            }
            if (chkMushrooms.Checked == true == true)
            {
                sToppings += "Mushrooms ,";
            }
            if (chkTomatoes.Checked == true == true)
            {
                sToppings += "Tomatoes ,";
            }
            if (chkOnion.Checked == true == true)
            {
                sToppings += "Onion ,";
            }
            if (chkOlives.Checked == true == true)
            {
                sToppings += "Olives ,";
            }
            if (chkGreenPeppers.Checked == true == true)
            {
                sToppings += "Green Peppers ,";
            }
            if (sToppings == "")
            {
                sToppings = "No Toppings";
            }
            texToppings.Text= sToppings;
        }
        public void UpdateWhereEat()
        {
            if (rdEateIn.Checked == true)
            {
                texWhereToEat.Text = "Eate In";
            }
            if (rdTakeOut.Checked == true)
            {
                texWhereToEat.Text = "Take Out";
            }
        }
        public void UpdateCrustType()
        {
            UpdateTotalPrice();
            if (rdThin.Checked == true)
            {
                texCrustType.Text = "Thin Crust";
            }
            if (rdThink.Checked == true)
            {
                texCrustType.Text = "Think Crust";
            }
        }
        public void RestForm()
        {
            grpToppings.Enabled = true;
            grpSize.Enabled = true;
            grpCrustType.Enabled = true;
            grpWhereToEat.Enabled = true;

            rdMedium.Checked = true;
            rdThin.Checked = true;
            rdEateIn.Checked = true;

            chkExtraChees.Checked = false;
            chkGreenPeppers.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;
        }
        public void UpdateOrderSamary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrustType();
            UpdateWhereEat();
            UpdateTotalPrice();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdEateIn.Checked = true;
            rdThin.Checked = true;
            rdMedium.Checked = true;
            UpdateOrderSamary();
        }

        private void rdSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rdThink_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rdEateIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereEat();
        }

        private void rdTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereEat();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                grpSize.Enabled = false;
                grpCrustType.Enabled = false;
                grpToppings.Enabled = false;
                grpWhereToEat.Enabled = false;
            }
        }

        private void btRestForm_Click(object sender, EventArgs e)
        {
            RestForm();
        }
    }
}
