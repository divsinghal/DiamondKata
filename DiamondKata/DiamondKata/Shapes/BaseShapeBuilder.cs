using System.Text.RegularExpressions;

namespace DiamondKata.Shapes
{
    public abstract class BaseShapeBuilder
    {
        protected readonly char _endingCharacter;

        public BaseShapeBuilder(char input)
        {
            this._endingCharacter = char.ToUpperInvariant(input);
        }

        public abstract string Build();

        protected virtual bool IsvalidCharacter(char input)
        {
            return Regex.IsMatch(input.ToString(), "[a-z]", RegexOptions.IgnoreCase);
        }
    }
}