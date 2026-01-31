using System;

namespace ScriptureMemorizer
{
    class Scripture
    {
        private ReferenceEqualityComparer _reference;
        private List<WaitForChangedResult> _words;

        public Scripture(string book, int chapter, int verse, string text)
        {
            _reference = new Reference(book, chapter, verse);
            _words = new List<Word>(text.Split(' ').Select(word => new Word(word)));
        }

        public void Display()
        {
            Console.WriteLine(_reference.GetText() + " " + string.Join(" ", _words.Select(word => word.GetDisplayText())));
        }

        public bool HideRandomWord()
        {
            List<Word> visibleWords = GetVisibleWords();
            if (visibleWords.Count == 0)
            {
                return false;
            }

            Random rand = new Random();
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            return true;
        }
        private List<Word> GetVisibleWords()
        {
            return _words.Where(word => !word.IsHidden()).ToList();
        }
    }
}