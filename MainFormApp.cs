﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuggestNumbersApp
{
    public partial class MainFormApp : Form
    {
        public MainFormApp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.Visible = !checkBox1.Checked;

            RecalculateSuggestedType();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            RecalculateSuggestedType();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            RecalculateSuggestedType();
            ValidateMinAndMaxValue();
        }

        private void RecalculateSuggestedType()
        {

        }

        private void ValidateMinAndMaxValue()
        {

        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;
            if(!IsValidInput(e.KeyChar, textBox)) {
                e.Handled = true;
            }
        }

        private bool IsValidInput(char keyChar, TextBox textBox)
        {
            return char.IsControl(keyChar) || char.IsDigit(keyChar) ||
                (keyChar == '-' && textBox.SelectionStart == 0);
        }
    }
}
