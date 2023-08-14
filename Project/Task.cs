using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsCompleted { get; set; }
        public List<string> Comments { get; set; }


        public Task(int id, string title, string description, DateTime deadline, bool iscompleted, List<string> comments)
        {
            Id = id;
            Title = title;
            Description = description;
            Deadline = deadline;
            IsCompleted = iscompleted;
            Comments = comments;
        }



    }
}
