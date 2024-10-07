using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODOLIST
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
        
        public static Calendar calendar = new Calendar();

        

       /*public static void AddNewTask(string title, string disc, DateTime DateTimePicker)
        {
            Task task = new Task(title, disc, DateTimePicker);
            //calendar.NewTask(task);
        }*/
    }
}
