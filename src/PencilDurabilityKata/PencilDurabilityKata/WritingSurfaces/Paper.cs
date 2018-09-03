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
    }
}
