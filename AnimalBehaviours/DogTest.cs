using System;
using Xunit;

namespace AnimalBehaviours
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
