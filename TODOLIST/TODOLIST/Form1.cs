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
using System.Reflection;

namespace TODOLIST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OpenNaptar();
            FillCheckedListBox();

        }


        PopUpForm popup = new PopUpForm();

        #region
        Calendar calendar = new Calendar();

        private void ClearFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {

            }
        }


        private void OpenNaptar()
        {
            
            StreamReader sr = new StreamReader("Naptar.txt");
            Task readTask;
            while (!sr.EndOfStream)
            {
                String[] line = new string[3];
                line = sr.ReadLine().Split('Ł');
                readTask = new Task(line[0], line[1], DateTime.Parse(line[2]));
                calendar.NewTask(readTask);
            }
            sr.Close();
        }


        private void FillCheckedListBox()
        {
            List<Task> tasks = new List<Task>();
            tasks=calendar.GetTasks();
            for (int i = 0; i < calendar.getLenght; i++)
            {
                checkedListBox.Items.Add(calendar.ToString(i));
            }
        }

                


        #endregion


        private void WriteNaptar()
        {
            StreamWriter sw = new StreamWriter("Naptar.txt", true);
            string[] line = new string[3];
            for (int i = 0; i < calendar.getLenght; i++)
            {
                line = calendar.ToArray(i);
                sw.WriteLine(line[0] + "Ł" + line[1] + "Ł" + line[2]);
            }

            sw.Close();
        }

        private void button1_Click(object sender, EventArgs e) //new task btn
        {
            DateTime date = dateTimePicker.Value.Date;
            Task tempTask = new Task(Cim_textBox.Text, Leiras_textBox.Text, dateTimePicker.Value.Date);
            if (tempTask.Title=="")
            {
                popup.SetLabel("A cím mező nem lehet üres!");
                popup.ShowDialog();

            }
            else if (tempTask.Title.Length>40)
            {
                popup.SetLabel("A cím mező nem lehet hoszabb 40 karakternél");
                popup.ShowDialog();

            }
            else if (tempTask.Date.Date < DateTime.Now.AddDays(-1))
            {
                popup.SetLabel("A megadott dátum nem lehet a multban");
                popup.ShowDialog();

            }
            else
            {
                checkedListBox.Items.Add(tempTask.ToString());
                calendar.NewTask(tempTask);
                Cim_textBox.Clear();
                Leiras_textBox.Clear();

            }
        }

        private void button2_Click(object sender, EventArgs e) //Edit
        {

            
            if (checkedListBox.CheckedItems.Count > 1)
            {

                popup.SetLabel("Egyszerre nem szerkeszthető két teendő!");
                popup.ShowDialog();   
            }
            else if (Cim_textBox.Text == "")
            {
                popup.SetLabel("A cím mező nem lehet üres!");
                popup.ShowDialog();
            }
            else if (Cim_textBox.Text.Length>40)
            {
                popup.SetLabel("A cím mező nem lehet hoszabb mint 40 karakter!");
                popup.ShowDialog();

            }
            else
            {


            Task tempTask = new Task(Cim_textBox.Text, Leiras_textBox.Text, dateTimePicker.Value);

            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (checkedListBox.GetItemChecked(i))
                {
                    checkedListBox.Items[i] = tempTask.ToString();
                    calendar.RemoveAt(i);
                    calendar.NewTask(tempTask);
                    Cim_textBox.Clear();
                    Leiras_textBox.Clear();
                }
            }

            }


        }

        private void button3_Click(object sender, EventArgs e) //delete
        {
            int index=0;
            while (index != calendar.getLenght)
            {
                if (checkedListBox.GetItemChecked(index))
                {
                    calendar.RemoveAt(index);
                    checkedListBox.Items.RemoveAt(index); // teendő eltávolítása, Misi:Listából is el kell tavolitani

                    index = 0;
                }

                if (checkedListBox.Items.Count > index && !checkedListBox.GetItemChecked(index))
                    index++;
                
            }
            /*for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
            }*/

            /*for (int i = checkedListBox.Items.Count; i > 0; i--)
            {
                if (checkedListBox.CheckedItems.Contains(checkedListBox.Items[i-1]))
                {
                    checkedListBox.Items.RemoveAt(i - 1); // teendő eltávolítása, Misi:Listából is el kell tavolitani
                }
            }*/


            Cim_textBox.Clear();
            Leiras_textBox.Clear();

        }


        private void button4_Click(object sender, EventArgs e) //save
        {

            ClearFile("Naptar.txt");
            WriteNaptar();
            this.Close();
        }



        

    }
}
