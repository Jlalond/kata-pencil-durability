using System;
using System.Text;
using PencilDurabilityKata.WritingUtensils;

namespace PencilDurabilityKata.WritingSurfaces
{
    public class Paper
    {
        private readonly StringBuilder _characters;

        public Paper()
        {
            _characters = new StringBuilder();
        }

        public void Write(Pencil pencil, string message)
        {
            var characters = message.ToCharArray();
            foreach (var character in characters)
            {
                _characters.Append(pencil.WriteCharacterIfSharp(character));
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
            if (indexOfPhrase != -1)
            {
                var startIndex = indexOfPhrase + phraseToBeErased.Length - 1;
                for (var i = 0; i < phraseToBeErased.Length; i++)
                {
                    _characters[startIndex - i] = eraser.Erase(_characters[startIndex - i]);
                }
            }
        }
    }
}
