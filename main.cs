using System;
using static System.Console;

public class MainClass
{
  public static void Main(string[] args)
  {
    int EX_1 = 1;
    int EX_2 = 2;
    int EX_3 = 3;
    int EX_4 = 4;
    int QUIT = 5;
    int choice = 0;

    while (choice != QUIT)
    {
      choice = getMenu();
      if(choice == EX_1)
      {
      Menu.userName();
      }
      if (choice == EX_2)
      {
      Menu.rectangleArea();
      }
      if (choice == EX_3)
      {
      Menu.carMPG();
      }
      if (choice == EX_4)
      {
      Menu.aliceWorld();
      }
      if (choice == QUIT)
      {
      WriteLine("You have quitted. See you soon!");
      }

    }   

  }
  public static int getMenu()
  {
    int EX_1 = 1;
    int EX_2 = 2;
    int EX_3 = 3;
    int EX_4 = 4;
    int QUIT = 5;
    WriteLine("Welcome to the exercise program!\nChoose from this list which exercise you would like to do!");
    WriteLine("1. Get the user name\n2. The Area of a rectangle\n3. The MPG of a car\n4. Alice's World\n5. To quit");
    int choice;
    Write("Enter the exercise number: ");
    choice = Convert.ToInt32(ReadLine());
    while (choice < EX_1 || choice > QUIT)
    {
    choice = 0;
    Write("Enter a valid exercise number: ");
    choice = Convert.ToInt32(ReadLine());
    }
    return choice;
  }
}

public class Menu
{
  public static void userName()
  {
    //Ex1
    string name;
    Write("Enter your name: ");
    name = ReadLine();
    WriteLine("Hello, " + name+"!");
  }
  public static void rectangleArea()
  {
    //Ex2
    int height;
    int width;
    int area;
    Write("Enter the height: ");
    height = Convert.ToInt32(ReadLine());
    Write("Enter the width: ");
    width = Convert.ToInt32(ReadLine());
    area = height * width;
    WriteLine("The area is: " + area);
  }
  public static void carMPG()
  {
    //Ex3
    int miles;
    int gallons;
    int MPG;
    Write("Enter the miles: ");
    miles = Convert.ToInt32(ReadLine());
    Write("Enter the gallons: ");
    gallons = Convert.ToInt32(ReadLine());
    MPG = miles / gallons;
    WriteLine("The MPG is: " + MPG);
  }
  public static void aliceWorld()
  {
    //Ex4
    string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
    string word;
    Write("Enter the word: ");
    word = ReadLine();
    if (sentence.ToLower().Contains(word.ToLower()))
    {
    WriteLine("True");
    }
    else
    {
    WriteLine("False");
    }
  }

} 






