using WordMatrixFinder;

namespace WordFinderTests
{
    public class UnitTest
    {
        [Fact]
        public void WordFinder_WhenWordIsNotInMatrix_ReturnsWord()
        {
            var matrix = new List<string>
        {
            "chill",
            "hello",
            "igloo",
            "llama",
            "lions"
        };

            var wordStream = new List<string> { "house", "monkey" };

            var wordFinder = new WordFinder(matrix);
            var result = wordFinder.Find(wordStream);

            Assert.DoesNotContain("house", result);
            Assert.DoesNotContain("monkey", result);
        }

        [Fact]
        public void WordFinder_WhenWordIsHorizontally_ReturnsWord()
        {
            var matrix = new List<string>
{
    "hellowoeld",
    "soabcdlmno",
    "plxyzefghs",
    "sworldjklp",
    "sworldjklp",
    "sworldjklp",
    "sstuvwxysa"
};

            var wordStream = new List<string> { "hello", "world" };

            var wordFinder = new WordFinder(matrix);
            var result = wordFinder.Find(wordStream);

            Assert.Contains("hello", result);
            Assert.Contains("world", result);
        }


        [Fact]
        public void WordFinder_WhenWordIsVertically_ReturnsWord()
        {
            var matrix = new List<string>
{
    "csafowoeld",
    "sohbcolmno",
    "pleyzrfghs",
    "swldlljklp",
    "ssluvdxysa",
    "ssouvdxysa"
};

            var wordStream = new List<string> { "hello", "world" };

            var wordFinder = new WordFinder(matrix);
            var result = wordFinder.Find(wordStream);

            Assert.Contains("hello", result);
            Assert.Contains("world", result);
        }


        [Fact]
        public void WordFinder_WhenMultipleMatches_ReturnsTop10()
        {

            var matrix = new List<string>
            {
                "helloabef",
                "worldabfe",
                "helloghgh",
                "worldijij",
                "klklklhhh",
                "mnmnklkls",
                "qrqrstyys",
                "opopopops",
            };


            var wordStream = new List<string> { "hello", "world", "ab", "ef", "gh", "ij", "kl", "mn", "op", "qr", "st" };

            var wordFinder = new WordFinder(matrix);
            var result = wordFinder.Find(wordStream);

            //There are 11 items found, but only the 10 most repeated are returned
            Assert.Equal(10, result.Count());
            Assert.Contains("hello", result); //2 time
            Assert.Contains("world", result); //3 time
            Assert.Contains("ab", result); // 2 time
            Assert.Contains("ef", result); // 2 time
            Assert.Contains("gh", result); // 2 time
            Assert.Contains("ij", result);  // 2 times
            Assert.Contains("kl", result); // 4 time
            Assert.Contains("mn", result);  // 2 time
            Assert.Contains("op", result); // 2 time 
            Assert.Contains("qr", result); // 2 time
            Assert.DoesNotContain("st", result); // 1 time




        }


        [Fact]
        public void WordFinder_LargeMatrix_Test()
        {
            var matrix = new List<string>
            {
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxyabcdefghijklmn",
            };


            var wordStream = new List<string> { "hello", "world", "lmnopqrstuvwxyab" };

            var wordFinder = new WordFinder(matrix);
            var result = wordFinder.Find(wordStream);

            Assert.DoesNotContain("hello", result);
            Assert.DoesNotContain("world", result);
            Assert.Contains("lmnopqrstuvwxyab", result);


        }




    }
}