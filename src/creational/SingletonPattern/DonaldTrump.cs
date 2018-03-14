using System;
using System.Collections.Generic;

namespace SingletonPattern
{
    public class DonaldTrump
    {
        private static DonaldTrump instance;
        private List<string> trumpQuotes;

        private DonaldTrump()
        {
            trumpQuotes = new List<string>
            {
                "Let's make america great again.",
                "I will build a great wall – and nobody builds walls better than me, believe me..."
            };
        }

        public static DonaldTrump GetInstance()
        {
            if (instance == null)
                instance = new DonaldTrump();

            return instance;
        }

        public void Speak()
        {
            trumpQuotes.ForEach(Console.WriteLine);
        }
    }
}
