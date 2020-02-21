using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EncoLyze
{
    public partial class Form1 : Form
    {
        Controler control;
        string cstlblLength, cstlblNumberNum, cstlblLineNumber, cstlblWordNum;
        public Form1()
        {
            InitializeComponent();
            control = new Controler(this);
            cstlblLength = this.lblLength.Text;
            cstlblLineNumber = this.lblLineNumber.Text;
            cstlblNumberNum = this.lblnumberNum.Text;
            cstlblWordNum = this.lblWordNumber.Text;
            this.btnApply.Click += ApplyChange;

        }

        private void ApplyChange(object sender, EventArgs e)
        {
            if (this.lsbOptions.SelectedIndex == -1)
            {
                MessageBox.Show("Select options in list box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (this.lsbOptions.SelectedIndex)
            {
                case 0:
                    control.TextToBase64(this.rtbText.Text);
                    break;
                case 1:
                    control.ToHex(this.rtbText.Text);
                    break;
                case 2:
                    control.Base64ToText(this.rtbText.Text);
                    break;
                case 3:
                    control.FromHex(this.rtbText.Text);
                    break;
                default:
                    break;
            }
        }


        public void SetRtbText(string text)
        {
            this.rtbText.Text = text;
        }

        public void SetLength(long value)
        {
            this.lblLength.Text = $"{cstlblLength}{value}";
        }

        public void SetNumberNum(long value)
        {
            this.lblnumberNum.Text = $"{cstlblNumberNum}{value}";
        }

        public void SetLineNumber(long value)
        {
            this.lblLineNumber.Text = $"{cstlblLineNumber}{value}";
        }

        public void SetWordNumber(long value)
        {
            this.lblWordNumber.Text = $"{cstlblWordNum}{value}";
        }
    }
}
