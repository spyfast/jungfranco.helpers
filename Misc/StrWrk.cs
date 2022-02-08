namespace JungFranco.Helpers.Misc
{
    internal static class StrWrk
    {
        public static string QSubstr(string str, string substr, bool before = false)
        {
            if (before)
                return str.Substring(0, str.IndexOf(substr));
            return str.Substring(str.IndexOf(substr) + substr.Length);
        }

        public static string GetBetween(string str, string left, string right)
        {
            return QSubstr(QSubstr(str, left), right, true);
        }

        public static int IsInteger(string value)
        {
            var result = 0;
            return int.TryParse(value, out result) ? result > 0 ? result : 0 : 0;
        }
    }
}
