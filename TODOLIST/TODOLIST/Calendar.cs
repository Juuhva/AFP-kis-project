using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOLIST
{
     public class Calendar
    {
        StreamWriter sw = new StreamWriter("Naptar.txt");


        List<Task> tasks = new List<Task>();
        //public List<Task> Tasks;

        public Calendar()
        {
            List<Task> tasks;
        }


        public  void NewTask(Task task)
        {
            tasks.Add(task);
        }

        public void Delete(Task task)
        {
            tasks.Remove(task);
        }


        public void Edit(List<Task> tasks, Task task, string title, string description, DateTime date)
        {
            tasks[tasks.IndexOf(task)].Title = title;
            tasks[tasks.IndexOf(task)].Description = description;
            tasks[tasks.IndexOf(task)].Date = date;
        }

        public void Save()
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                sw.Write(tasks[i]);
            }

            sw.Close();
        }















        public int getLenght
        {
            get { return tasks.Count; }
        }
    }
}
