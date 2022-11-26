namespace StringDivider
{
    public class DivideString
    {
        private string _dividedString;
        private List<string> _dividedStrings;

        private int _dividingIndex;
        private int _dividingElement;

        public DivideString()
        {
            _dividedStrings = new List<string>();
            _dividingIndex = 1;
            _dividingElement = 0;
            _dividedString = String.Empty;
        }


        private List<string> ParseDividedString(string value)
        {
            for (int i = 0; i < (value.Length - 1); i++)
            {
                for (int j = 0; j < (value.Length - _dividingIndex); j++)
                {
                    for (int k = 0; k < (_dividingIndex + 1); k++)
                    {
                        _dividedString += value[_dividingElement].ToString();
                        _dividingElement += 1;
                    }
                    _dividedStrings.Add(_dividedString);
                    _dividedString = String.Empty;
                    _dividingElement -= _dividingIndex;
                }
                _dividingElement = 0;
                _dividingIndex += 1;
            }
            return _dividedStrings;
        }

        public string Divide(string value)
        {
            string result = String.Empty;
            if (!String.IsNullOrEmpty(value))
            {
                var dividedStrings = ParseDividedString(value);
                foreach (var stringElement in dividedStrings)
                {
                    result += stringElement + '\n';
                }
            }
            return result;
        }
    }
}
