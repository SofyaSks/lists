using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace lists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListBox lb1 = new ListBox();
            //updateColor();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                if (!lb_1.Items.Contains(textBox1))
                {
                    lb_1.Items.Add(textBox1.Text);
                    textBox1.Clear();
                }
                else MessageBox.Show("String must be unique");
            }
        }

        private void button_copy_Click(object sender, EventArgs e)
        {
            lb_2.Items.Clear();
            if (lb_1.Items.Count != 0)
            {
                for (int i = 0; i < lb_1.Items.Count; i++)
                {
                    lb_2.Items.Add(lb_1.Items[i]);
                }
            }
            else MessageBox.Show("List_1 is Empty");
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (lb_1.Items.Count != 0)
            {
                if (lb_1.SelectedItem != null)
                {
                    while (lb_1.SelectedItems.Count > 0)
                    {
                        lb_1.Items.Remove(lb_1.SelectedItems[0]);
                    }
                }
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 50;
            for (int i = 0; i < progressBar1.Maximum; i++)
            {
                progressBar1.PerformStep();
                label1.Text = "Value = " + progressBar1.Value.ToString();
                Update();
                Thread.Sleep(1000);
            }           
        }

        private void updateColor()
        {
            Color color = Color.FromArgb(trackBar_red.Value, trackBar_green.Value, trackBar_blue.Value);
            BackColor = color;
        }

        private void trackBar_red_Scroll(object sender, EventArgs e)
        {
            updateColor();
        }

        private void trackBar_green_Scroll(object sender, EventArgs e)
        {
            updateColor();
        }

        private void trackBar_blue_Scroll(object sender, EventArgs e)
        {
            updateColor();
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files(*.*)|*.*| Text Files(*.txt)|*.txt||";
            open.FilterIndex = 1;
            if(open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(open.FileName);
                textBox2.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);
                writer.Write(textBox2.Text);
                writer.Close();
            }
        }
    }
}
