using Xunit;
using System.Collections.Generic;
using leetcode_codes;

namespace Leetcodes.Tests
{
    public class DuplicateFinder
    {
        [Fact]
        public void FindDuplicates_Returns_CharactersandCount()
        {
            var finder = new DuplicateFind();
            string input = "Vaaamsshi";
            Dictionary<char, int> result = finder.FindDuplicateCounts(input);
            Assert.Equal(3, result['a']);
            Assert.Equal(2, result['s']);


        }

        [Fact]

        public void FindDuplicates_Returns_EmptyCount()
        {
            var finder = new DuplicateFind();
            string input = "abc";
            Dictionary<char, int> result = finder.FindDuplicateCounts(input);

            Assert.Empty(result);
        }

        [Fact]
        public void IsValidInput_WithValidInput_ReturnsTrue()
        {           
            // Arrange
            var finder =new DuplicateFind();            
            // Act
            bool result =finder.IsValidInput("hello");            
            // Assert
            Assert.True(result);       
        }        
        [Fact]        
        public void IsValidInput_WithEmptyString_ReturnsFalse()        
        {            
            // Arrange
            var finder =new DuplicateFind();           
            // Act
            bool result =finder.IsValidInput("");            
            // Assert
            Assert.False(result);       
        }        
        [Fact]        
        public void IsValidInput_WithNull_ReturnsFalse()        
        {            
            // Arrange
            var finder =new DuplicateFind();            
            // Act
            bool result =finder.IsValidInput(null);      
            // Assert
            Assert.False(result);        
        }        
        [Fact]        
        public void IsValidInput_WithWhiteSpace_ReturnsFalse()        
        {            
            // Arrange
           var finder =new DuplicateFind();            
            // Act
            bool result = finder.IsValidInput("   ");            
                // Assert
           Assert.False(result);        
        }    
    }
}
