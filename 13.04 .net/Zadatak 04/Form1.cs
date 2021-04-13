using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WriteEvent("btnZeleni_Click");
        }
      
        private void btnRed_Click(object sender, EventArgs e)
        {
            WriteEvent("btnRed_Click");
        }

        private void txtEvent_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            WriteEvent("btnBlue_Click");
        }

        private void btnRed_MouseClick(object sender, MouseEventArgs e)
        {
            WriteEvent("btnRed_MouseClick");
        }

        private void btnGreen_MouseClick(object sender, MouseEventArgs e)
        {
            WriteEvent("btnGreen_MouseClick");
        }

        private void btnBlue_MouseClick(object sender, MouseEventArgs e)
        {
            WriteEvent("btnBlue_MouseClick");
        }

        private void btnRed_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(sender,e);
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            string control;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    control = "Lijeva";
                    break;
                case MouseButtons.Right:
                    control = "Desna";
                    break;
                case MouseButtons.Middle:
                    control = "Srednja";
                    break;
                default:
                    control = "N/A";
                    break;
            }

            string Message = $"Na gumbu {button.Text} stisnuta je {control} tipka";
            WriteEvent(Message);
        }

        private void btnGreen_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(sender, e);
        }

        private void btnBlue_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(sender, e);
        }
        private void WriteEvent(string Event)
        {
            txtEvent.AppendText(Event);
            txtEvent.AppendText(Environment.NewLine);

        }
    }
}
