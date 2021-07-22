using System;
using Xunit;
using Animal;

namespace AnimalTest
{
    public class DogTest
    {
        [Fact]
        public void DogSpeaksBasedOnGivenNameBeingRex()
        {
            string dogName = "Rex";
            Dog dog = new Dog();
            Assert.Equal("Woof!", dog.SpeakBasedOnName(dogName));
        }
    }
}
