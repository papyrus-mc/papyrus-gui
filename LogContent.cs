using System.Collections.Generic;

namespace papyrus_gui
{
    public struct LogContent
    {
        public string[] Lines
        {
            get
            {
                return _content.ToArray();
            }
        }
        private List<string> _content;
        private uint _linesToKeep;

        public LogContent(uint linesToKeep)
        {
            _linesToKeep = linesToKeep;
            _content = new List<string>();
        }

        public void Append(string text)
        {
            if (_content.Count == _linesToKeep)
            {
                _content.RemoveAt(0);
            }

            _content.Add(text);
        }
    }
}
