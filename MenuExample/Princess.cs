namespace MenuExample
{
    //Princess class will represent the princesses in the game
    //When a princess is created a sidekick will automatically be created as well
    public class Princess : DisneyCharacter
    {
       
        public string LoveInterest { get; private set; }
        public SideKick SideKick { get; private set; }

        public Princess(string name, string story, string enemy, string loveInterest) : base(name, "Human", story, enemy)
        {
            LoveInterest = loveInterest;
        }


        public override void Sing()
        {
            Console.WriteLine("La La La La");
        }

        public override void Greeting()
        {
            Console.WriteLine("Hello! So charmed to meet you!, my name is " + Name +". \n");
        }

        public void PrincessMenu()
        {

            Console.Clear();
            Console.WriteLine("Choose which princess to create:");
            Console.WriteLine("1. Cinderella\n" +
                "2. Snow White\n" +
                "3. Aurora\n" +
                "4. Jasmine\n" +
                "5. Belle");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Name = "Cinderella";
                Story = "Happily Ever After";
                Enemy = "The Wicked StepMother and StepSisters";
                LoveInterest = "Prince Charming";
                //SideKick = new SideKick("Jaq", "mouse", Story, Enemy, Name);
                SideKick = new SideKick("Gus", "mouse", Story, Enemy, Name);
            }
            else if (input == "2")
            {
                Name = "Snow White";
                Story = "Snow White and the Seven Dwarves";
                Enemy = "The Evil Queen";
                LoveInterest = "Prince Florian";
                SideKick = new SideKick("Doc", "Dwarf", Story, Enemy, Name);
                //SideKick = new SideKick("Sleepy", "Dwarf", Story, Enemy, Name);
                //SideKick = new SideKick("Dopey", "Dwarf", Story, Enemy, Name);
                //SideKick = new SideKick("Grumpy", "Dwarf", Story, Enemy, Name);
                //SideKick = new SideKick("Happy", "Dwarf", Story, Enemy, Name);
                //SideKick = new SideKick("Bashful", "Dwarf", Story, Enemy, Name);
                //SideKick = new SideKick("Sneezy", "Dwarf", Story, Enemy, Name);

            }
            else if (input == "3")
            {
                Name = "Aurora";
                Story = "Sleeping Beauty";
                Enemy = "Maleficent";
                LoveInterest = "Prince Phillip";
                SideKick = new SideKick("Flora", "Fairy", Story, Enemy, Name);
                //SideKick = new SideKick("Fauna", "Fairy", Story, Enemy, Name);
                //SideKick = new SideKick("Merryweather", "Fairy", Story, Enemy, Name);
            }
            else if (input == "4")
            {
                Name = "Jasmine";
                Story = "Aladdin";
                Enemy = "Jafar";
                LoveInterest = "Aladdin";
                SideKick = new SideKick("Rajah", "Tiger", Story, Enemy, Name);
            }
            else if (input == "5")
            {
                Name = "Belle";
                Story = "Beauty and the Beast";
                Enemy = "Gaston";
                LoveInterest = "The Beast";
                SideKick = new SideKick("Lumiere", "CandleStick", Story, Enemy, Name);
            }
            else
            {
                Console.WriteLine("Enter a valid option");
            }

        }
        public void InitialDisplay()
        {
            Console.Clear();
            Console.WriteLine("You have chosen " + Name + "! Here is some information about her: ");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Story: " + Story);
            Console.WriteLine("Enemy: " + Enemy);
            Console.WriteLine("Love Interest: " + LoveInterest);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("A Princess needs her sidekick!");
            Console.WriteLine(Name + "'s companion through thick and thin is " + SideKick.Name + " the " + SideKick.Species);

        }
        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Story: " + Story);
            Console.WriteLine("Enemy: " + Enemy);
            Console.WriteLine("Love Interest: " + LoveInterest);
        }
       
    }
}
