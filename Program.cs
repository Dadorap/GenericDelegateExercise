namespace GenericDelegate
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 2, 3, 4, 9, 9 };

            MatchDelegate<int> isEven = (x)=> x%2 == 0;

            var evenList = FindMatches(list, isEven);
        }
        public static List<T> FindMatches<T>(List<T> items, MatchDelegate<T> comparison)
        {
            List<T> result = new List<T>();
            foreach (T item in items)
            {
                if (comparison(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

    }
}
