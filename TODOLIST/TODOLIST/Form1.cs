﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace TODOLIST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OpenNaptar();

        
        }



        #region

        static void ClearFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {

            }
        }

        Calendar calendar = new Calendar();

        private void OpenNaptar()
        {
            Calendar calendar = new Calendar();

            StreamReader sr = new StreamReader("Naptar.txt");
            Task readTask;

            while (!sr.EndOfStream)
            {
                String[] line = new string[3];
                line = sr.ReadLine().Split(',');
                readTask = new Task(line[0], line[1], DateTime.Parse(line[2]));
                calendar.NewTask(readTask);
            }
            sr.Close();
            ClearFile("Naptar.txt");
        }

        #endregion

        StreamWriter sw = new StreamWriter("Naptar.txt");


        private void button1_Click(object sender, EventArgs e) //new task btn
        {
            Task tempTask = new Task(Cim_textBox.Text, Leiras_textBox.Text, dateTimePicker.Value);
            calendar.NewTask(tempTask);
            Cim_textBox.Clear();
            Leiras_textBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e) //Edit
        {
            Task tempTask = new Task(Cim_textBox.Text, Leiras_textBox.Text, dateTimePicker.Value);
            calendar.NewTask(tempTask);

        }

        private void button3_Click(object sender, EventArgs e) //delete
        {
            Task tempTask = new Task(Cim_textBox.Text, Leiras_textBox.Text, dateTimePicker.Value);
            calendar.Delete(tempTask);
            Cim_textBox.Clear();
            Leiras_textBox.Clear();

        }


        private void button4_Click(object sender, EventArgs e) //save
        {

            calendar.Save();
        }



        

    }
}
