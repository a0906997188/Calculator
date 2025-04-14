using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    /// <summary>
    /// 這是一個列舉，用於定義運算符號
    /// </summary>
    enum Operator
    {
        Add,
        Sub,
        Mul,
        Div
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtNumber.Text = "0";
        }

        private void btnOne_Click(object sender, EventArgs e)=>NumberbtnAdd(sender);
        

        private void btnTwo_Click(object sender, EventArgs e)=>NumberbtnAdd(sender);
        

        private void btnThree_Click(object sender, EventArgs e)=>NumberbtnAdd(sender);
        

        private void btnSix_Click(object sender, EventArgs e)=>NumberbtnAdd(sender);
        

        private void btnFive_Click(object sender, EventArgs e)=>NumberbtnAdd(sender);
        

        private void btnFour_Click(object sender, EventArgs e)=>NumberbtnAdd(sender);
        

        private void btnSeven_Click(object sender, EventArgs e)=>NumberbtnAdd(sender);
        

        private void btnEight_Click(object sender, EventArgs e)=>NumberbtnAdd(sender);
        

        private void btnNine_Click(object sender, EventArgs e)=>NumberbtnAdd(sender);
        

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }
            NumberbtnAdd(sender);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "0";
        }

        #region 這是一個製作數字添加到txtNumber的函數
        public void NumberbtnAdd(object sender)
        {
            Button b = sender as Button;
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }
            txtNumber.Text += b.Text;
        }
        #endregion

        float num1, num2 = 0;
        Operator op;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtNumber.Text);
            txtNumber.Text = "";
            op = Operator.Add;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtNumber.Text);
            txtNumber.Text = "";
            op = Operator.Sub;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtNumber.Text);
            txtNumber.Text = "";
            op = Operator.Mul;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtNumber.Text);
            txtNumber.Text = "";
            op = Operator.Div;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtNumber.Text.Contains("."))
            {
                txtNumber.Text += ".";
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtNumber.Text, out float number))
            {
                txtNumber.Text = (number / 100).ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length > 0)
            {
                txtNumber.Text = txtNumber.Text.Remove(txtNumber.Text.Length - 1);
                if (txtNumber.Text.Length == 0)
                {
                    txtNumber.Text = "0";
                }
            }
        }


        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                float num2 = float.Parse(txtNumber.Text);
                float result = 0;
                switch (op)
                {
                    case Operator.Add:
                        result = num1 + num2;
                        break;
                    case Operator.Sub:
                        result = num1 - num2;
                        break;
                    case Operator.Mul:
                        result = num1 * num2;
                        break;
                    case Operator.Div:
                        if (num2 == 0)
                        {
                            MessageBox.Show("除數不能為零", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNumber.Text = "0";
                            return;
                        }
                        result = num1 / num2;
                        break;
                }
                txtNumber.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber.Text = "0";
            }
        }
    }
}
