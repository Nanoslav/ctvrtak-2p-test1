using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int suma = 0;
            foreach(Control c in groupBoxCars.Controls)
            {
                if(c is RadioButton)
                {
                    if(((RadioButton)c).Checked == true)
                    {
                        suma += int.Parse(c.Tag.ToString());
                    }
                }
            }

            foreach (Control c in groupBoxPackets.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        suma += int.Parse(c.Tag.ToString());
                    }
                }
            }
            labelSuma.Text = "Celkem: " + suma;
        }

        private void checkBoxPacket1_CheckedChanged(object sender, EventArgs e)
        {
            labelSuma.Text = "Celkem: ";
            if (checkBoxPacket1.Checked)
            {
                labelPaket1.Visible = true;
            }
            else
            {
                labelPaket1.Visible = false;
            }
        }

        private void checkBoxPacket2_CheckedChanged(object sender, EventArgs e)
        {
            labelSuma.Text = "Celkem: ";
            if (checkBoxPacket2.Checked)
            {
                labelPaket1.Visible = true;
                labelPaket2.Visible = true;
                checkBoxPacket1.Checked = true;
                checkBoxPacket1.Enabled = false;
            }
            else
            {
                labelPaket1.Visible = true;
                labelPaket2.Visible = false;
                checkBoxPacket1.Enabled = true;
                checkBoxPacket1.Checked = true;
            }
        }

        private void checkBoxPacket3_CheckedChanged(object sender, EventArgs e)
        {
            labelSuma.Text = "Celkem: ";
            if (checkBoxPacket3.Checked)
            {
                labelPaket1.Visible = true;
                labelPaket2.Visible = true;
                labelPaket3.Visible = true;

                checkBoxPacket1.Checked = true;
                checkBoxPacket2.Checked = true;

                checkBoxPacket1.Enabled = false;
                checkBoxPacket2.Enabled = false;
            }
            else
            {
                labelPaket1.Visible = true;
                labelPaket2.Visible = true;
                labelPaket3.Visible = false;

                checkBoxPacket1.Checked = true;
                checkBoxPacket2.Checked = true;

                checkBoxPacket1.Enabled = false;
                checkBoxPacket2.Enabled = true;
            }
        }

        private void radioButtonCar1_CheckedChanged(object sender, EventArgs e)
        {
            labelSuma.Text = "Celkem: ";
        }

        private void radioButtonCar2_CheckedChanged(object sender, EventArgs e)
        {
            labelSuma.Text = "Celkem: ";
        }

        private void radioButtonCar3_CheckedChanged(object sender, EventArgs e)
        {
            labelSuma.Text = "Celkem: ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
