using System;
using System.Text;
using PencilDurabilityKata.WritingUtensils;
using PencilDurabilityKata.WritingUtensils.Interfaces;

namespace PencilDurabilityKata.WritingSurfaces
{
    public class Paper
    {
        private readonly StringBuilder _characters;
        private int _lastErasedIndex;
        private const char CollisonCharacter = '@';
        private const char WhiteSpace = ' ';

        public Paper()
        {
            _characters = new StringBuilder();
            _lastErasedIndex = -1;
        }

        public void Write(IWritingUtensil pencil, string message)
        {
            var characters = message.ToCharArray();
            foreach (var character in characters)
            {
                _characters.Append(pencil.WriteCharacterIfCapable(character));
            }
        }

        public string ReadAll()
        {
            return _characters.ToString();
        }

        public void Erase(Eraser eraser, string phraseToBeErased)
        {
            var charactersToString = _characters.ToString();
            var indexOfPhrase = charactersToString.LastIndexOf(phraseToBeErased, StringComparison.CurrentCulture);
            if (indexOfPhrase == -1)
            {
                return;
            }
            var startIndex = indexOfPhrase + phraseToBeErased.Length - 1;
            for (var i = 0; i < phraseToBeErased.Length; i++)
            {
                _characters[startIndex - i] = eraser.Erase(_characters[startIndex - i]);
                if (_characters[startIndex - i] == WhiteSpace)
                {
                    _lastErasedIndex = startIndex - i;
                }
            }
        }

        public void Edit(string wordToWrite)
        {
            if (_lastErasedIndex == -1)
            {
                return;
            }

            for (var i = 0; i < wordToWrite.Length; i++)
            {
                HandleEditingCharacterIfNotWhiteSpace(i, wordToWrite[i]);
            }
        }

        private void HandleEditingCharacterIfNotWhiteSpace(int index, char characterToWrite)
        {
            if (_characters[_lastErasedIndex + index] != WhiteSpace)
            {
                _characters[_lastErasedIndex + index] = CollisonCharacter;
            }
            else
            {
                _characters[_lastErasedIndex + index] = characterToWrite;
            }
        }
    }
}
