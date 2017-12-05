namespace Day4
{
    using System.Linq;

    public class PassPhrase
    {
        private string _value;

        private PassPhrase() { }
        private PassPhrase(string passPhrase) => _value = passPhrase;

        public static bool TryParse(string value, out PassPhrase passPhrase)
        {
            if (Validate(value))
            {
                passPhrase = new PassPhrase(value);
                return true;
            }

            passPhrase = null;
            return false;
        }

        private static bool Validate(string value)
        {
            var splitValue = value
                .Split(' ')
                .Select(s => new string(s.ToCharArray().OrderBy(c => c).ToArray()))
                .ToArray();

            var splitValueRemoveDuplicates = splitValue.Distinct().ToArray();
            return splitValue.Length == splitValueRemoveDuplicates.Length;
        }

        //ToDo Override Equals / GetHashCode then Ihave a nice little value object
    }
}
