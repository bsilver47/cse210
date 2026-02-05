using System;

namespace ScriptureMemorizer
{
    class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(string book, int chapter, int beginVerse, int endVerse, string text)
        {
            _reference = new Reference(book, chapter, beginVerse, endVerse);
            _words = new List<Word>(text.Split(' ').Select(static word => new Word(word)));
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