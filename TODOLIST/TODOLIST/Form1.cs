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
using System.Globalization;

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
            Task tempTask = new Task(Cim_textBox.Text, Leiras_textBox.Text, dateTimePicker.Value);
            calendar.NewTask(tempTask);
<<<<<<< Updated upstream
            if (tempTask.Title != "")
            {
                checkedListBox.Items.Add(tempTask.Title); // A címet illeszti be a listába
            }
=======
            checkedListBox.Items.Add(tempTask.Title); // A címet illeszti be a listába, Misi: az miért jó?
>>>>>>> Stashed changes
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
            int count = checkedListBox.Items.Count;
            for (int i = count; i > 0; i--)
            {
                if (checkedListBox.CheckedItems.Contains(checkedListBox.Items[i-1]))
                {
                    checkedListBox.Items.RemoveAt(i - 1); // teendő eltávolítása, Misi:Listából is el kell tavolitani
                }
            }
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
