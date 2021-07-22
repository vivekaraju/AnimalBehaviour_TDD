using System;
using Xunit;
using Animal;

namespace AnimalTest
{
    public class DogTest
    {
        [Fact]
        public void DogSpeaksBasedOnGivenName()
        {
            string dogGivenName = "Rex";
            string dogWrongName = "Rocky";
            Dog dog = new Dog();
            string expectedSound = "Woof!";
            string expectedWrongSound = "Roof?";
            Assert.Equal(expectedSound, dog.SpeakBasedOnName(dogGivenName));
            Assert.Equal(expectedWrongSound, dog.SpeakBasedOnName(dogWrongName));
        }
    }
}
