namespace AssemblyModules_Bukov
{
    public class StringUtilities
    {
        public string ToUpperCase(string input)
        {
            return input.ToUpper();
        }

        public int GetLength(string input)
        {
            return input.Length;
        }

        public string Concatenate(string a, string b)
        {
            return a + b;
        }
    }
}