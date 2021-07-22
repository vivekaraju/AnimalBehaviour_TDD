namespace Animal
{
    public class Dog
    {
        public string SpeakBasedOnName(string dogName)
        {
            if (dogName == "Rex")
            {
                return "Woof!";
            }
            
            return "Roof?";
        }
        public bool ActBasedOnCommand(string dogGivenName, string dogCommand)
        {
            return true;
        }
    }
}