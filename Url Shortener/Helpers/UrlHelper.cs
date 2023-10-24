namespace Url_Shortener.Helpers
{
    public class UrlHelper
    {
        public static List<string> min = new List<string>(){ "a", "b", "c", "d", "e", "f", "g", "h",
                                                             "i", "j", "k", "l", "m", "n", "o", "p",
                                                             "q", "r", "s", "t", "u", "v", "w", "x",
                                                             "y", "z" };

        public static List<string> may = new List<string>(){ "A", "B", "C", "D", "E", "F", "G", "H",
                                                             "I", "J", "K", "L", "M", "N", "O", "P",
                                                             "Q", "R", "S", "T", "U", "V", "W", "X",
                                                             "Y", "Z" };

        public static List<string> num = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public string GetShortURL()
        {
            Random Rselector = new Random();
            string shortUrl = "http://shortUrl.ly/";

            for (int i = 0; i <= 2; i++)
            {
                int index = Rselector.Next(min.Count);
                shortUrl += min[index];

                index = Rselector.Next(may.Count);
                shortUrl += may[index];

                index = Rselector.Next(num.Count);
                shortUrl += num[index];

            }
            return shortUrl;
        }
    }
}
