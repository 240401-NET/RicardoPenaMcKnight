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
}