﻿namespace ChooseAdventure;

public class Program
{
    /*This program will need to start off with an introductory message which
    provides the user with options, then takes input from the user positively
    identifying the input as one of the options or rejecting the input
    if it is not a valid option and prompting them to pick a valid option.
    If the user selects a valid option then it should either advance them
    in the choose your own adventure narrative or should allow them to access
    certain menu options, such as the main menu or the inventory.
    
    I could do the options as a kind of interface maybe? IChoosable or
    something like that? Then I might be able to use it to fulfill the 
    dependency injection requirement. Would IChoosable make sense? What do
    I want the options to do exactly? Let's assume I use a switch case inside
    a while loop like in yesterday's demo. I would want each case to be an
    Option object essentially, one that calls a method that displays the next
    text and presents a new list of options. I'm going to have a lot of 
    different kinds of options with a lot of different text and sub options
    and I don't want to have to initialize a bunch of new option objects.
    
    This may require some more fleshing out on my part. Do I want the
    options as separate objects and if so would I have to instantiate them?
    I suppose unless they had static functions I probably would, though
    static functionality wouldn't be a bad way to go. It's not like there are
    really going to need to be a bunch of separate instances of an option 
    exactly. At least I don't think so. My dependency injection would be 
    calling a method with IChoosable as an argument. This method would be
    some sort of "MakeChoice" method. It'd be like... Readline converted to 
    an int or something potentially which is then taken as an argument for
    the make choice method. The make choice method would need some way of 
    having its choices swapped out every cycle.  */

    public static User? currentUser = new User();
    public static List<User> users = new List<User>();
    public static Character? currentCharacter;
    static void Main(string[] args)
    {
        // only load users if file exists
        if (File.Exists("users.json"))
        {
            users = Data.LoadUsers();
            Data.SaveUsers(users);
        }

        LoginMenu loginMenu = new("Welcome, please login or create a new user account.");
    }

    public static void UpdateUsers()
    {
        // Find the user in the list of users and update it
        int index = FindUserIndex(currentUser);
        if (index != -1)
        {
            users[index] = currentUser;
            Data.SaveUsers(users);
        }
    }

    public static User FindUser(string username)
    {
        foreach (User user in users)
        {
            if (user.UserName == username)
            {
                return user;
            }
        }
        Console.WriteLine("User not found.");
        return new User();
    }

    public static int FindUserIndex(User user)
    {
        for (int i = 0; i < users.Count; i++)
        {
            if (users[i].UserName == user.UserName)
            {
                return i;
            }
        }
        return -1;
    }

    public static void Exit()
    {
        Data.SaveCharacters(currentUser.Characters);
        UpdateUsers();
        Environment.Exit(0);
    }
}
