using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOLIST
{
    class Task
    {

        string title;

        public string Title
        {
            get { return title; }
            set {
                if (value.Length>40)
                {
                    throw new Exception("A cím nem lehet hoszabb 40 karakternél.");
                }
                title = value; }
        }

        string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        DateTime date;

        public DateTime Date
        {
            get { return date; }
            set
            {
                if (date<DateTime.Now)
                {
                    throw new Exception("A megadott időpont nem lehet a multban");
                }
            }
        }

        public Task(string title, string description, DateTime date)
        {
            this.title = title;
            this.description = description;
            this.date = date;
        }






        


        


    }
}
