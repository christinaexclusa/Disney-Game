using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MenuExample
{
    //StoryBook will be where we house all of our disney characters
    //We will be able to search through all of our characters and pull specific characters to interact with
    public class StoryBook
    {
        private List<DisneyCharacter> characters = new List<DisneyCharacter>();

        public List<DisneyCharacter> Characters { get; private set; }
        public StoryBook()
        {
            Characters = new List<DisneyCharacter>();
        }

        public void AddCharacter(DisneyCharacter disneyCharacter) 
        {
            Characters.Add(disneyCharacter);
        }
        
        public  Villian RetrieveVillain(string name)
        {
            List<Villian> vList  = GetAllVillians();

            foreach(Villian v in vList)
            {
                if(v.Name.Equals(name , StringComparison.OrdinalIgnoreCase))
                {
                    return v;
                    
                }           
               
            }
            return null;
            
        }
        public Princess RetrievePrincess(string name)
        {
            List<Princess> pList = GetAllPrincesses();

            foreach (Princess p in pList)
            {
                if (p.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return p;

                }

            }
            return null;

        }
        public List<Princess> GetAllPrincesses()
        {
            List<Princess> princessList = new List<Princess>();
            foreach(DisneyCharacter character in  Characters)
            {
                if(character is Princess princess)
                {
                    princessList.Add(princess);
                }
            }
            return princessList;
        }
        public List<Villian> GetAllVillians()
        {
            List<Villian> villianList = new List<Villian>();
            foreach (DisneyCharacter character in Characters)
            {
                if (character is Villian villian)
                {
                    villianList.Add(villian);
                }
            }
            return villianList;
        }

        public void DisplayAllVillians(List<Villian> villianList)
        {
            foreach(Villian villain in villianList)
            {
                Console.WriteLine(villain.Name);
            }
        }
        public void DisplayAllPrincesses(List<Princess> princessList)
        {
            foreach(Princess princess in princessList)
            {
                Console.WriteLine(princess.Name);
            }
        }
       
    }
}
