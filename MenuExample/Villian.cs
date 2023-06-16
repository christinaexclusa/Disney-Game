namespace MenuExample
{
    //Villian Class will represent all the villians in the game, irritation level will rise when bothered and rise high when bothered by enemy.
    //For now being bothered will be a Greeting.
    //Constructors are set up in a way that if wanted to change the game to user input we can do so.
    public class Villian : DisneyCharacter
    {
        private string motive;
        private int irritationLevel;
        private string attackMethod;
        public string Motive { get; set; }
        public int IrritationLevel { get; set; } = 25;
        public string AttackMethod { get; set; }


        public Villian(string name, string species, string story, string enemy) : base(name, species, story, enemy)
        {

        }
        public override void Sing()
        {
            Console.WriteLine("Ahhrrrrrrrrrrrr hahahahhaahahahhaha");
        }

        public override void Greeting()
        {
            Console.WriteLine("Leave me alone you idiot! " + Name + " doesn't have time for the likes of you!! \n");
            IrritationLevel++;
        }
        public void Attack()
        {
            
            Console.WriteLine(Name + " " + AttackMethod);
            IrritationLevel += 30;
            DisplayIrritationLevel();
        }


        public void DisneyVillansMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose which Villian to create:");
            Console.WriteLine("1. Maleficent \n" +
                "2. Jafar\n" +
                "3. The Evil Queen\n" +
                "4. Gaston\n" +
                "5. Ursula");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Name = "Maleficent";
                Story = "Sleeping Beauty";
                Enemy = "Aurora";
                Motive = "To seek revenge on Stefan, who stole her wings!";
                Species = "Fairy";
                AttackMethod = "raises her magical golden scepter and turns you into a bird!";


            }
            else if (input == "2")
            {
                Name = "Jafar";
                Story = "Aladdin";
                Enemy = "Aladdin";
                Motive = "To be the most powerful Sultan in the World!";
                Species = "Wizard";
                AttackMethod = "rasies his snake staff to your vision and puts you in a hypnosis";


            }
            else if (input == "3")
            {
                Name = "The Evil Queen";
                Story = "Snow White and the Seven Dwarves";
                Enemy = "Snow White";
                Motive = "To be the most beautiful woman in the Kingdom!";
                Species = "Witch";
                AttackMethod = "creates a magic potion that sends you into Sleeping Death!";



            }
            else if (input == "4")
            {
                Name = "Gaston";
                Story = "Beauty and the Beast";
                Enemy = "Beast";
                Motive = "To have the most beautiful girl in town as his bride";
                AttackMethod = "gathers the townspeople to torch your house!";

            }
            else if (input == "5")
            {
                Name = "Ursula";
                Story = "The Little Mermaid";
                Enemy = "Ariel";
                Motive = "Revenge and Power";
                Species = "Cecaelia";
                AttackMethod = "concocts a potion and steals your soul!";

            }
            else
            {
                Console.WriteLine("Enter a valid option");
            }
        }

        public void InitialDisplay()
        {
            Console.Clear();
            Console.WriteLine("You have chosen " + Name + "! Here is some information about them: ");
            Console.WriteLine("Cranky Cranky, Your Villian's irritation level is: " + IrritationLevel);
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Story: " + Story);
            Console.WriteLine("Enemy: " + Enemy);
            Console.WriteLine("Motive: " + Motive);
            Console.ReadLine();


        }
        public void DisplayIrritationLevel()
        {
            Console.WriteLine("Be Careful! " + Name + "'s irritation is rising!  Irritation Level has reached: " + IrritationLevel + "\n");
        }
    }
}
