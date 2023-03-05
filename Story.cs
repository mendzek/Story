namespace Story
{
    public class Story
    {
        string Read_line_variable;
        string player_class;
        int location_ID = 0;

        public static void Main(string[] args)
        {
            Story story = new Story();
            story.Start();
            story.Enter_dangeon();
        }
        public void Start()
        {
            Console.WriteLine("\nchoose a class: \n1.Warior \n2.Wizzard \n3.Thief \n4.Nothing");
            Console.WriteLine("\nwrite number of class with \"_info\" if you want to know what that class can do. Like that \"1_info\".");
            Read_line_variable = Console.ReadLine();

            if (Read_line_variable == "1" || Read_line_variable == "2" || Read_line_variable == "3" || Read_line_variable == "4")
            {

                switch (Convert.ToInt32(Read_line_variable))
                {
                    case 1:
                        player_class = "Warior";
                        Console.WriteLine($"\nyour chose is {player_class}.");
                        break;
                    case 2:
                        player_class = "Wizzard";
                        Console.WriteLine($"\nyour chose is {player_class}.");
                        break;
                    case 3:
                        player_class = "Thief";
                        Console.WriteLine($"\nyour chose is {player_class}.");
                        break;
                    case 4:
                        player_class = "Nothing";
                        Console.WriteLine($"\nyour chose is {player_class}.");
                        break;
                }
            }
            else
            {
                switch (Read_line_variable)
                {
                    case "1_info":
                        Console.WriteLine("\nWarior is phisicly strong man with great sword and good metal armor.");
                        Start();
                        Read_line_variable = Console.ReadLine();
                        break;
                    case "2_info":
                        Console.WriteLine("\nWizzard know two-three spells, what means he can easely burn or freeze monsters with just his mind. With his intelligence he can learn more spells than others.");
                        Start();
                        break;
                    case "3_info":
                        Console.WriteLine("\nThief hiding in shadows and hit when enemes turn back. He is good archer, can easely hide from enemy's vision sight and hit doable painly. Weak when it comes to real battle.");
                        Start();
                        break;
                    case "4_info":
                        Console.WriteLine("\nYou are nothing. This is secret why and how you survived until this moment, but now you have no chance.");
                        Start();
                        break;
                    default: Console.WriteLine("Wrong input, try again."); Start(); break;
                }
            }




        }
        public void Enter_dangeon()
        {
            location_ID = 1;
            ED_1();
            ED_2();
            void ED_1()
            {
                Console.WriteLine("\nYou are one of Silver Guard and your job is protect the village. Residents said that close to village they saw ruins with ghosts. When you walk around you faund that ruins. You came closer. You see a big stone door. What you want to do? \n1.Try to open the door.\n2.Walk around.\nC.Camp");
            }
            void ED_2()
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("You close to door and push it. Nothing. It wont open. What you want to do?\n1.Check around if there is a button or lever.\n2.Back\nC.Camp");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine("You close to door and push it. Nothing. It wont open. What you want to do?\n1.Check around if there is a button or lever.\n2.Back\nC.Camp");
                                break;
                            case "2":
                                ED_1();
                                ED_2();
                                break;
                            case "C":
                                Camp();
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Walk around.");
                        break;
                    case "C":
                        Camp();
                        break;
                    default: Console.WriteLine("Wrong input, try again."); goto case "1";
                }
            }
        }
        void Camp()
        {
            Console.WriteLine("\nYou set up camp.");
            Console.WriteLine("After light up fire you sit close to it. What you want to do?\n1.Eat\n2.Start Thinking about the day\n3.Sleep\n4.Continue the advanture in night");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Eat."); // Eat
                    break;
                case "2":
                    Console.WriteLine("Think about."); // Think
                    break;
                case "3":
                    switch (location_ID)
                    {
                        case 1:
                            Console.WriteLine("Campfire burns all pain and tears you have to had in your journey. Your eyes slowly become heavy. Good night."); // Sleep
                            Thread.Sleep(6000);
                            Console.WriteLine("...");
                            Thread.Sleep(3000);
                            Console.WriteLine("...");
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                    }
                    break;
                case "4":
                    Console.WriteLine("Continue."); // Continue
                    break;
            }

        }
    }
}

