using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODOLIST
{
    public static class Program
    {
        public static Calendar calendar = new Calendar();



       /* static void ClearFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
           
            }

            
        }*/


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

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

            //ClearFile("Naptar.txt");



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            
            


        }
        
        

        

       /*public static void AddNewTask(string title, string disc, DateTime DateTimePicker)
        {
            Task task = new Task(title, disc, DateTimePicker);
            //calendar.NewTask(task);
        }*/
    }
}
