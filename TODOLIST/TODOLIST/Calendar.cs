using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace TODOLIST
{
     public class Calendar
    {
        

        List<Task> tasks = new List<Task>();
        //public List<Task> Tasks;

        public List<Task> GetTasks()
        {
            return tasks;
        }

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

        }

        public Task index(int i)
        {
            return tasks[i];
        }

        public string[] ToArray(int i)
        {
            string[] array = new string[3]; // Creates an array with 3 elements
            array[0] = tasks[i].Title;
            array[1] = tasks[i].Description;
            array[2] = Convert.ToString(tasks[i].Date);
            return array;
        } 

        public string IsEmpty()
        {
            if (tasks.Any())
            {
                return "nem öres;";
            }
            return "öres";
        }

        public string ToString(int i)
        {
            return "Feladat:"+tasks[i].Title + " Leírás:" + tasks[i].Description+" Időpont:" + tasks[i].Date;
        }










        public int getLenght
        {
            get { return tasks.Count; }
        }
    }
}
