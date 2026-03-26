using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
    static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name and greeting them.
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
      
      // Present the first choice of the game: investigate the noise or not.
      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
      Console.WriteLine("Type YES or NO:");
      string noiseChoice = Console.ReadLine();
      
      // Convert the user's input to uppercase to avoid errors in case the user enters something that isn't exactly what was requested.
      string loadNoiseChoice = noiseChoice.ToUpper();
      Console.WriteLine(loadNoiseChoice);

      // Branch 1: Ends the game if the user chooses to stay in the room.
      if (loadNoiseChoice == "NO") {
        Console.WriteLine("Not much of an adventure if we don't leave our room! THE END.");
        Console.WriteLine();
        Console.WriteLine();
      }

      // Branch 2: Continues the story into the hallway.
      else if (loadNoiseChoice == "YES") {
        Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
      
        // Presents two options: knock on the door or open it.
        Console.WriteLine("Type OPEN or KNOCK:");
        string doorChoice = Console.ReadLine();
        string loadDoorChoice = doorChoice.ToUpper();

        // If the user types "KNOCK," they are presented with a kind of puzzle or challenge.
        if (loadDoorChoice == "KNOCK") {
          Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"");
          Console.WriteLine("\"Poor people have it. Rich people need it. If you eat it, you die. What is it?\"");
          string riddleAnswer = Console.ReadLine();
          string loadRiddleAnswer = riddleAnswer.ToUpper();

          // Check if the riddle answer is correct ("NOTHING").
          if (loadRiddleAnswer == "NOTHING") {
            Console.WriteLine("The door opens and NOTHING is there.");
            Console.WriteLine("You turn off the light and run back to your room and lock the door.");
            Console.WriteLine("THE END.");
          }
          // If the answer is wrong or doesn't match what was asked, the final answer is displayed, ending the story.
          else {
            Console.WriteLine("You answered incorrectly. The door doesn't open. THE END.");
          }
        }
        
        // If the user tries to open the door, prompt them to use a key.
        else if (loadDoorChoice == "OPEN") {
            Console.WriteLine("The door is locked! See if one of your three keys will open it.");
            Console.WriteLine("Enter a number (1-3):");
            string keyChoice = Console.ReadLine();

            // Evaluates the chosen key and defines the story's outcome.
            switch (keyChoice) {
              case "1":
                Console.WriteLine("You choose the first key. Lucky choice!");
                Console.WriteLine("The door opens and NOTHING is there. Strange...");
                Console.WriteLine("THE END.");
                break;
              case "2":
                Console.WriteLine("You choose the second key. The door doesn't open.");
                Console.WriteLine("THE END.");
                break;
              case "3":
                Console.WriteLine("You choose the third key. The door doesn't open.");
                Console.WriteLine("THE END.");
                break;
            }
        }
      } 
       
    }
  }
}