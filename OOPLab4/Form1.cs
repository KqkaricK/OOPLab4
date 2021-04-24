using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label1.Text = "Введите длину квадрата: ";
                CheckRadioButton(sender);
            }
        }
        void CheckRadioButton(object sender)
        {
            RadioButton checkBox = (RadioButton)sender;
            if (checkBox.Checked == true)
            {
                label1.Visible = true;
                button1.Visible = true;
                textBox1.Visible = true;
            }
            else
            {
                label1.Visible = false;
                button1.Visible = false;
                textBox1.Visible = false;
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label1.Text = "Введите радиус круга: ";
                CheckRadioButton(sender);
            }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                label1.Text = "Введите длину прав. треугольника: ";
                CheckRadioButton(sender);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            if (radioButton1.Checked == true)
            {
                Square A = new Square(Convert.ToDouble(textBox1.Text));
                label2.Text = "Имя объекта: " + A.Name;
                label3.Text = "Кол. вершин: " + A.Kol_Ver();
                label4.Text = "Периметр: " + A.Perimetr();
                label5.Text = "Площадь: " + A.Area();
                A.Paint(panel1);
            }
            else if (radioButton2.Checked == true)
            {
                Krug A = new Krug(Convert.ToDouble(textBox1.Text));
                label2.Text = "Имя объекта: " + A.Name;
                label3.Text = "Кол. вершин: " + A.Kol_Ver();
                label4.Text = "Периметр: " + A.Perimetr();
                label5.Text = "Площадь: " + A.Area();
                A.Paint(panel1);
            }
            else if (radioButton3.Checked == true)
            {
                Traingle A = new Traingle(Convert.ToDouble(textBox1.Text));
                label2.Text = "Имя объекта: " + A.Name;
                label3.Text = "Кол. вершин: " + A.Kol_Ver();
                label4.Text = "Периметр: " + A.Perimetr();
                label5.Text = "Площадь: " + A.Area();
                A.Paint(panel1);
            }
        }
    }
}
