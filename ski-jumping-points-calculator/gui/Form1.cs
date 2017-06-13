using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ski_jumping_points_calculator;
using System.Diagnostics;

namespace gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Hill> venues = new List<Hill> {new Hill("Lahti", "116", "1,8"), new Hill("Oberstdorf", "200", "1,2"), new Hill("Rovaniemi", "100", "2") };
            List<Jumper> jumpers = new List<Jumper> {new Jumper("Jumper A"), new Jumper("Jumper B"), new Jumper("Jumper C")};

            comboBox1.DataSource = null;
            comboBox1.Items.Clear();

            comboBox1.DataSource = new BindingSource(venues, null);
            comboBox1.DisplayMember = "Name";

            comboBox2.DataSource = new BindingSource(jumpers, null);
            comboBox2.DisplayMember = "JumperName";
            comboBox2.ValueMember = "JumperName";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hill selected = (Hill) comboBox1.SelectedItem;
            label1.Text = selected.KPoint;
            label2.Text = selected.Multiplier;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            panel1.Visible = true;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();

            Jumper jumper = (Jumper) comboBox2.SelectedItem;
            Hill hill = (Hill) comboBox1.SelectedItem;

            jumper.NewJump(Convert.ToString(length.Value), Convert.ToString(wind.Value), Convert.ToString(gate.Value), label1.Text, label2.Text);
            foreach (var item in jumper.ShowJumps())
            {
                richTextBox2.AppendText(item);
            }    
            hill.Addresult(jumper.Points, jumper.JumperName);
            richTextBox2.Refresh();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            Jumper selected = (Jumper)comboBox2.SelectedItem;
            foreach (var item in selected.ShowJumps())
            {
                richTextBox2.AppendText(item);
            }

            richTextBox2.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hill hill = (Hill)comboBox1.SelectedItem;
            richTextBox1.Text = $@"Results for { hill.Name }  {DateTime.Now:dd.MM.yyyy}" + System.Environment.NewLine + "Name:\t\t\tPoints:" + System.Environment.NewLine;
            
            foreach (var item in hill.GetResults())
            {
                richTextBox1.AppendText(item);
            }
        }
    }
}
