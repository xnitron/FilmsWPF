namespace FilmsWPF.Utils
{
    public class StringUtils
    {
       public static string TrimString(string str, int length = 100)
        {
            if (str.Length > length)
            {
                return str.Substring(0, length) + " ...";
            }
            return str;
        }
    }
}
