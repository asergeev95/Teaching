namespace ConsoleApp
{
    public static class StringExtensions
    {
        public static string ConcatString(this string targetString, string additionalString)
        {
            return $"{targetString} {additionalString}";
        }
    }
}