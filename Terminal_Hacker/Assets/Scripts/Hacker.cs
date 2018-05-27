
using UnityEngine;

public class Hacker : MonoBehaviour
{

    // game config data
    string[] takeAwayPasswords = { "pizza", "burger", "chips", "kebab", "curry" };
    string[] hospitalPasswords = { "needle", "nurse", "death", "illness", "dirt" };
    string[] psnPasswords = { "server", "hacker", "sony", "playstation", "psp" };

    // game state
    int level;
    enum Screen { MainMenu, Password, Win };
    enum Password { TakeAway, Hospital, Psn };
    Screen currentScene;
    Password chosenPassword;
    string password;

    // Use this for initialization
    void Start()
    {
        MainMenu();
    }


    void OnUserInput(string input)
    {
        if (input.ToUpper() == "MENU") MainMenu();
        else if (currentScene == Screen.MainMenu) RunMainMenu(input);
        else if (currentScene == Screen.Password) CheckPassword(input);
    }

    void MainMenu()
    {
        currentScene = Screen.MainMenu;
        Terminal.ClearScreen();
        string greeting = "Hello Player";
        Terminal.WriteLine("");
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("");
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1 for local takeaway.");
        Terminal.WriteLine("Press 2 for local hospital.");
        Terminal.WriteLine("Press 3 for psn servers.");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter you selection.");
        Terminal.WriteLine("");
    }

    void RunMainMenu(string input)
    {
        if (input == "1") StartGame(input);
        else if (input == "2") StartGame(input);
        else if (input == "3") StartGame(input);
    }

    void StartGame(string input)
    {
        currentScene = Screen.Password;
        if (input == "1")
        {
            chosenPassword = Password.TakeAway;
            Terminal.WriteLine("You have chosen local takeaway");
            password = takeAwayPasswords[Random.Range(0, takeAwayPasswords.Length)];
        }
        else if (input == "2")
        {
            chosenPassword = Password.Hospital;
            Terminal.WriteLine("You have chosen local hospital");
            password = hospitalPasswords[Random.Range(0, hospitalPasswords.Length)];
        }
        else if (input == "3")
        {
            chosenPassword = Password.Psn;
            Terminal.WriteLine("You have chosen psn servers");
            password = psnPasswords[Random.Range(0, psnPasswords.Length)];
        }
        Terminal.WriteLine("");
        Terminal.WriteLine(string.Format("Please enter password. Hint: {0}", password.Anagram()));
    }

    void CheckPassword(string input)
    {
        Terminal.WriteLine("");
        if (input == password)
        {
            currentScene = Screen.Win;
            Terminal.WriteLine("");
        }
        else Terminal.WriteLine("Wrong password");

        if (currentScene == Screen.Win) Win();
    }

    void Win()
    {

        if (chosenPassword == Password.TakeAway)
        {
            Terminal.WriteLine(@" 
      /
   .-/-.
   |'-'|
   |   |
   |   |   .-""""-.
   \___/  /' .  '. \   \|/\//
         (`-..:...-')  |`""`|
          ;-......-;   |    |
           '------'    \____/
    ");

        }

        else if (chosenPassword == Password.Hospital)
        {
            Terminal.WriteLine(@" 
            Enjoy a nice rest.     
 
 |___|________|_
 |___|________|_|-----
 |   |        | 
      
");

        }

        else if (chosenPassword == Password.Psn)
        {
            Terminal.WriteLine(@" 
      _____
     |.---.|
     ||___||
     |+  .'|
     | _ _ |
     |_____/

                                ");

        }
        Terminal.WriteLine("Well done");
        Terminal.WriteLine("Type Menu to Play again.");
    }

}
