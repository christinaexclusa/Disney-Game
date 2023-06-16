// See https://aka.ms/new-console-template for more information
using MenuExample;




StoryBook storyBook = new StoryBook();


bool isRunning = true;
string princessOption = "";
while (isRunning)
{
    Console.Clear();
    Console.WriteLine("You have created " + DisneyCharacter.charactersCreated + " Disney Characters!");
    Console.WriteLine("Choose which character to create");
    Console.WriteLine("1. Princess and SideKick\n" +
                        "2. Villian\n"+
                        "3. Interact with Characters \n"+
                        "4. Exit");

    switch (Console.ReadLine())
    {
        
        case "1":
            Console.Clear();
            Princess princess = new Princess("","","","");
            princess.PrincessMenu();
            storyBook.AddCharacter(princess);
            Console.Clear();
            Console.WriteLine("You have chosen " + princess.Name + "! Here is some information about her: ");
            Console.WriteLine("-------------------------------------------------------------------------");
            princess.InitialDisplay();
            Console.ReadLine();
            break;
        case "2":
            Console.Clear();
            Villian villian = new Villian("", "", "", "");
            villian.DisneyVillansMenu();
            storyBook.AddCharacter(villian);
            Console.Clear();
            Console.WriteLine("You have chosen " + villian.Name + "! Here is some information about her: ");
            Console.WriteLine("-------------------------------------------------------------------------");
            villian.InitialDisplay();
            Console.ReadLine();
            break;
        case "3":
            Console.Clear();
            Console.WriteLine("Which Disney Villain would you like to interact with: ");
            Console.WriteLine("Type in their name.");
            foreach(Villian v in storyBook.GetAllVillians())
            {
                Console.WriteLine(v.Name);
            }
            string userInput = Console.ReadLine();
            Villian villianChoice = storyBook.RetrieveVillain(userInput);
            Console.Clear();
            Console.WriteLine("Which Disney Princess would you like to interact with: ");
            Console.WriteLine("Type in their name.");
            foreach(Princess p in storyBook.GetAllPrincesses())
            {
                Console.WriteLine(p.Name);
            }
           
            userInput = Console.ReadLine();
            Princess princessChoice = storyBook.RetrievePrincess(userInput);
            Console.Clear();
            //The Princess, the SideKick, and the Villian greet eachother, if the Villians enemy is the one
            //who is interacting, the Villians irritation level goes up 10
            princessChoice.Greeting();
            princessChoice.SideKick.Greeting();
            villianChoice.Greeting();
            if (villianChoice.Enemy.Equals(princessChoice.Name))
            {
                villianChoice.IrritationLevel += 10;
                Console.WriteLine("You have irritated me further!!! \n");
                villianChoice.DisplayIrritationLevel();
            }
            //At random, if the princess decides to sing it further irritates that Villian and they attack
            Random random = new Random();
            if(random.Next() % 2 == 0)
            {
                princessChoice.Sing();
                villianChoice.Attack();
            }
            Console.ReadLine();
            break;
       case "4":
            isRunning= false;
            break;
    }
}

