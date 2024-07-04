using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class YouTube
    {

        private string Title;
        private int id;

        public YouTube()
        {
            this.Title = string.Empty;
            this.id = 0;
        }

        public YouTube(string title, int id)
        {
            Title = title;
            this.id = id;
        }

        public override string ToString()
        {
            return "\t\t\n ---Title: " + this.Title + "\n\t\t url: https://www.youtube.com/watch?v=: " + this.id + "\n";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is YouTube)) { 
            return false;
            }
            
            YouTube youTube= (YouTube)obj;

            return youTube.id == this.id &&
                   youTube.Title == this.Title;
        }

    }
}
