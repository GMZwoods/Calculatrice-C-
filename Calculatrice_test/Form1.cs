using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice_test
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// STRING ET NOMBRE COMME VARIABLES 
        /// </summary>
        /// 

        public Form1()
        {
            InitializeComponent();
        }
        double input1 = 0;
        double input2 = 0;
        string input3 = "";
        

        private void ButtonPress(object sender, EventArgs e)
        {
            Input_User.Text += ((Button)sender).Text;
        }



        private void BTN_Operateur(object sender, EventArgs e)
        {
            double input1 = double.Parse(Input_User.Text);
            Input_User.Text += ((Button)sender).Text;
            input3 = Input_User.Text;          
                        
        }

        private void BTN_Plus_Moins_Click(object sender, EventArgs e)
        {
            double input1 = double.Parse(Input_User.Text);
            Input_User.Clear();
            double inputNegation = input1 * -1;
            Input_User.Text = inputNegation.ToString();
        }

        private void BTN_Decimale_Click(object sender, EventArgs e)
        {
           
            this.Input_User.Text = "";
            input3 += ".";
            this.Input_User.Text += input3;

         /*   Input_User.Text += ((Button)sender).Text;
           if (Input_User.Text.Contains("."))
           {
                Input_User.Text = Input_User.Text.
           }
           else{}
         

            */
            
            
        }

        private void BTN_Égalité_Click(object sender, EventArgs e)
        {/*
           double input1 = double.Parse(Input_User.Text);
            if { BTN_Operateur  BTN_Multiplication}
        }*/
    }
}
