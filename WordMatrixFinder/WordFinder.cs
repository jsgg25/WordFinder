namespace WordMatrixFinder
{
    public class WordFinder
    {
        private readonly char[,] _matrix;
        private readonly int _rows;
        private readonly int _cols;

        public WordFinder(IEnumerable<string> matrix)
        {
            var matrixArray = matrix.ToArray();
            _rows = matrixArray.Length;
            _cols = matrixArray[0].Length;
            _matrix = new char[_rows, _cols];

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    _matrix[i, j] = matrixArray[i][j];
                }
            }
        }

        public IEnumerable<string> Find(IEnumerable<string> wordstream)
        {
            var wordCount = new Dictionary<string, int>();

            foreach (var word in wordstream)
            {
                CountOccurrences(word, wordCount);
            }

            return wordCount.OrderByDescending(kv => kv.Value).Take(10).Select(kv => kv.Key);
        }

        private void CountOccurrences(string word, Dictionary<string, int> wordCount)
        {
            // Check horizontally
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j <= _cols - word.Length; j++)
                {
                    if (IsMatch(word, i, j, 0, 1))
                    {
                        AddToCount(word, wordCount);
                    }
                }
            }

            // Check vertically
            for (int i = 0; i <= _rows - word.Length; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    if (IsMatch(word, i, j, 1, 0))
                    {
                        AddToCount(word, wordCount);
                    }
                }
            }
        }

        private void AddToCount(string word, Dictionary<string, int> wordCount)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            }
            else
            {
                wordCount[word] = 1;
            }
        }

        private bool IsMatch(string word, int startX, int startY, int stepX, int stepY)
        {
            for (int k = 0; k < word.Length; k++)
            {
                if (_matrix[startX + k * stepX, startY + k * stepY] != word[k])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
