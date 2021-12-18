namespace ConsoleApp.WorkWithObjectc
{
    public static class PersonExtensions
    {
        public static void AddAgeFromExtension(this Person person, int numberOfMonths)
        {
            person.BirthDay = person.BirthDay.AddMonths(numberOfMonths);
        }

        public static bool IsNullOrEmpty(this string inputString)
        {
            return string.IsNullOrEmpty(inputString);
        }
    }
}