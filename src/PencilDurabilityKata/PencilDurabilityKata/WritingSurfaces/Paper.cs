using System.Text;

namespace PencilDurabilityKata.WritingSurfaces
{
    public class Paper
    {
        private readonly StringBuilder _characters;

        public Paper()
        {
            _characters = new StringBuilder();
        }

        public void Write(string message)
        {
            _characters.Append(message);
        }

        public string ReadAll()
        {
            return _characters.ToString();
        }
    }
}
