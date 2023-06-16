using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExample
{
    public abstract class DisneyCharacter
    {
       
        public static int charactersCreated = 0;
        
        public string Name { get; protected set; }
        public string Species { get; protected set; } 
        public string Story { get; protected set; }
        public string Enemy { get; protected set; }


        public DisneyCharacter(string name, string species, string story, string enemy)
        {
            Name = name;
            Species = species;
            Story = story;
            Enemy = enemy;
            charactersCreated++;
        }
        public abstract void Sing();
        public abstract void Greeting();

    }
}
