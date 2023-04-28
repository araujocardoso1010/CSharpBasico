namespace Pessoa
{
    public static class Extensions
    {
        public static bool HasOnlyDigits(this string str)
        {
            const string digits = "0123456789";
            foreach(char c in str){
                if (!digits.Contains(c)) return false;
            }
            return true;
        }
    }
}
