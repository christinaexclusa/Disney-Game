using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExample
{
    public class SideKick: DisneyCharacter
    {
        private string companion;
        public string Companion { get; set; }
       
        public SideKick(string name, string species, string story, string enemy, string companion) : base(name, species, story, enemy)
        {

            Companion = companion;
        }

        public override void Greeting()
        {
            Console.WriteLine("Hi there! I'm " + Name +". Want to come on a fun adventure with " + Companion + " and I? It will be so fun!");
        }
    
    }
}
