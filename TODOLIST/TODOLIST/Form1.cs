using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TODOLIST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e) //new task btn
        {
            Task tempTask = new Task(Cim_textBox.Text, Leiras_textBox.Text, dateTimePicker.Value);
            Program.calendar.NewTask(tempTask);
            Cim_textBox.Clear();
            Leiras_textBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e) //Edit
        {
            Task tempTask = new Task(Cim_textBox.Text, Leiras_textBox.Text, dateTimePicker.Value);
            Program.calendar.NewTask(tempTask);

        }

        private void button3_Click(object sender, EventArgs e) //delete
        {
            Task tempTask = new Task(Cim_textBox.Text, Leiras_textBox.Text, dateTimePicker.Value);
            Program.calendar.Delete(tempTask);
            Cim_textBox.Clear();
            Leiras_textBox.Clear();

        }

        private void button4_Click(object sender, EventArgs e) //save
        {

            Program.calendar.Save();
        }



        

    }
}
