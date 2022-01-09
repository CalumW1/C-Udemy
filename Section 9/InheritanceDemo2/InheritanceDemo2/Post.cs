using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    class Post
    {
        private static int CurrentPostID;

        // properties
        protected int ID { get; set; }
        protected string Title { get; set; }

        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        //defualt constructor
        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Calum";
        }

        // 
        public Post(String title, bool isPublic, string sendbyUsername)
        {
            this.ID = 0;
            this.Title = title;
            this.SendByUsername = sendbyUsername;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++CurrentPostID;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}
