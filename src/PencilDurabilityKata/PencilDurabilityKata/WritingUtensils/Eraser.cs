﻿namespace PencilDurabilityKata.WritingUtensils
{
    public class Eraser
    {
        private int _durabilityRating;
        private const char WhiteSpace = ' ';

        public Eraser(int durabilityRating)
        {
            _durabilityRating = durabilityRating;
        }

        public char Erase(char characterToErase)
        {
            if (characterToErase == ' ')
            {
                return characterToErase;
            }

            if (_durabilityRating > 0)
            {
                _durabilityRating--;
                return characterToErase;
            }

            return WhiteSpace;
        }
    }
}