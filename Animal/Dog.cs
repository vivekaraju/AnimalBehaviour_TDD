namespace Animal
{
    public class Dog
    {
        public string SpeakBasedOnName(string dogName)
        {
            if (dogName == "Rex")
                return "Woof!";
            else
                return "Roof?";
        }
    }
}