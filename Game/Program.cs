using Tools;

namespace Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Utils.Add(3, 5);
            Utils.Reverse("Dani");
            Utils.Max(10, 4);
            Utils.IsEven(2);
            Utils.IsValidGrade(2);
            Utils.IsValidGrade(-1);
            Utils.CountVowels("The lord of the rings");
        }
    }
}
