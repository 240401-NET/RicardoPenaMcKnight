namespace chooseAdventure.Tests;
using ChooseAdventure;

public class UnitTest1
{

    // Create unit tests to make sure the regex is working in the password validation
    [Fact]
    public void Password_ValidatePassword_True()
    {
        // Arrange
        string testPassword = "Password123";
        bool expected = true;

        // Act
        bool actual = Password.ValidatePassword(testPassword);

        // Assert
        Assert.Equal(expected, actual);
    }

    // Create useful unit test for ChooseAdventure
    [Fact] 
    public void User_UserName_Default()
    {
        // Arrange
        User user = new User();
        string expected = "Default";

        // Act
        string actual = user.UserName;

        // Assert
        Assert.Equal(expected, actual);
    }

    // Create useful unit test for ChooseAdventure
    [Fact]
    public void Character_MaxHealth_100()
    {
        // Arrange
        Character character = new Character();
        int expected = 100;

        // Act
        int actual = character.MaxHealth;

        // Assert
        Assert.Equal(expected, actual);
    }
}