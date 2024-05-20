using System;
using Xunit;
using InputLibrary;

namespace InputLibraryTests
{
    public class InputHandlerTests
    {
        [Fact]
        public void GetString_ReturnsInputString()
        {
            // Not practical to test Console.ReadLine directly, but we can test the method structure
            var input = "Test input";
            var result = InputHandler.GetString(input);
            Assert.Equal(input, result);
        }

        [Fact]
        public void GetInt_ReturnsParsedInt()
        {
            // Not practical to test Console.ReadLine directly, but we can test the method structure
            var input = "5";
            var result = InputHandler.GetInt(input);
            Assert.Equal(5, result);
        }

        [Fact]
        public void GetInt_ReturnsNegativeOneForInvalidInput()
        {
            // Not practical to test Console.ReadLine directly, but we can test the method structure
            var input = "invalid";
            var result = InputHandler.GetInt(input);
            Assert.Equal(-1, result);
        }
    }
}
