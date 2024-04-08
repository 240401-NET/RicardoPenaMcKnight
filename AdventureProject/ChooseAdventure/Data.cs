namespace ChooseAdventure;
using System.IO;
using System.Text.Json;

class Data
{
    public static void SaveUser(User user)
    {
        string json = JsonSerializer.Serialize(user);
        File.WriteAllText("user.json", json);
    }

    public static void SaveUsers(List<User> users)
    {
        string json = JsonSerializer.Serialize(users);
        File.WriteAllText("users.json", json);
    }
    public static void SaveCharacters(List<Character> characters)
    {
        string json = JsonSerializer.Serialize(characters);
        File.WriteAllText($"{Program.currentUser.UserName}characters.json", json);
    }

    public static User LoadUser()
    {
        string json = File.ReadAllText("user.json");
        return JsonSerializer.Deserialize<User>(json);
    }

    public static List<User> LoadUsers()
    {
        string json = File.ReadAllText("users.json");
        return JsonSerializer.Deserialize<List<User>>(json);
    }

    public static List<Character> LoadCharacters()
    {
        string json = File.ReadAllText($"{Program.currentUser.UserName}characters.json");
        return JsonSerializer.Deserialize<List<Character>>(json);
    }
}
