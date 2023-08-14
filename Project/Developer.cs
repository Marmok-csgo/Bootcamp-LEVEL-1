using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Developer
    {
        public Guid Id = new Guid();
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public List<Project> AssigmentProjects { get; set; }
        public List<string> Comments { get; set; }


        public Developer(string username, string password, string email)
        {
            UserName = username;
            Password = password;
            Email = email;
        }

        public void AddProject(Project project)
        {
            AssigmentProjects.Add(project);
        }
    }
}
