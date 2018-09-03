using System;

namespace PencilDurabilityKata.WritingUtensils
{
    public class Pencil
    {
        private int _durabilityRating;
        private char _whiteSpace = ' ';

        public Pencil(int durabilityRating)
        {
            _durabilityRating = durabilityRating;
        }

        public char WriteCharacterIfSharp(char characterToWrite)
        {
            if (_durabilityRating > 0)
            {
                _durabilityRating--;
                return characterToWrite;
            }

            return _whiteSpace;
        }
    }
}
