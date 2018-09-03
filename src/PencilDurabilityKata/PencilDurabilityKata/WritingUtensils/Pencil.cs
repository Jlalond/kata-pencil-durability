using System;
using System.Linq;

namespace PencilDurabilityKata.WritingUtensils
{
    public class Pencil
    {
        private int _durabilityRating;
        private const char WhiteSpace = ' ';
        private const int UpperCaseCost = 2;

        public Pencil(int durabilityRating)
        {
            _durabilityRating = durabilityRating;
        }

        public char WriteCharacterIfSharp(char characterToWrite)
        {
            if (IsWhiteSpaceOrNewLine(characterToWrite))
            {
                return characterToWrite;
            }

            if (IsUpperCase(characterToWrite) && _durabilityRating >= UpperCaseCost)
            {
                _durabilityRating -= UpperCaseCost;
                return characterToWrite;
            }

            if (_durabilityRating > 0)
            {
                _durabilityRating--;
                return characterToWrite;
            }

            return WhiteSpace;
        }

        private static bool IsWhiteSpaceOrNewLine(char character)
        {
            return character == ' ' || character == '\n';
        }

        private static bool IsUpperCase(char character)
        {
            return char.IsUpper(character);
        }
    }
}
