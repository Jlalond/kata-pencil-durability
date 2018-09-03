using PencilDurabilityKata.WritingUtensils.Interfaces;

namespace PencilDurabilityKata.WritingUtensils
{
    public class Eraser : IEraser
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
                return WhiteSpace;
            }

            return characterToErase;
        }
    }
}
