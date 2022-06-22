using System;
using System.Linq;
using System.Text;
using DiamondKata.Helper;

namespace DiamondKata.Shapes
{
    public class Dimaond : BaseShapeBuilder
    {
        private const int FirstAlphabetASCII = (int)'A';
        public Dimaond(char endingCharacter) : base(endingCharacter)
        {
        }

        /*******************************
        Builds the full shape.

        Note:
            Top row = {begin Spacing}{alphabet}{end Spacing}
            All rows in Middle = {begin Spacing}{alphabet}{Middle Spacing}{alphabet}{end Spacing}
            Bottom row = {begin Spacing}{alphabet}{end Spacing}
        *******************************/
        public override string Build()
        {
            if (!StringHelper.IsAlphabet(this._endingCharacter))
            {
                return string.Empty;
            }

            int distinctAlphabetSeries = StringHelper.GetASCIIKey(this._endingCharacter) - FirstAlphabetASCII + 1;
            int shapeArraySize = (2 * distinctAlphabetSeries) - 1;
            var resultShapePattern = new string[shapeArraySize];
            int beginAndEndSpacing = distinctAlphabetSeries - 1;
            int endCharASCII = StringHelper.GetASCIIKey(this._endingCharacter);
            int runCount = 0;
            for (int currentCharASCII = FirstAlphabetASCII; currentCharASCII <= endCharASCII; currentCharASCII++)
            {
                runCount++;
                var s = new StringBuilder();
                this._AddBeginingSpace(s, beginAndEndSpacing);
                this._AddAlphabet(s, Convert.ToChar(currentCharASCII));
                if (runCount > 1)
                {
                    this._AddSpacesInMiddle(s, ((runCount - 1) * 2) - 1);
                    this._AddAlphabet(s, Convert.ToChar(currentCharASCII));
                }

                this._AddEndingSpace(s, beginAndEndSpacing);
                resultShapePattern[runCount - 1] = s.ToString();
                if (shapeArraySize - runCount > 0)
                {
                    resultShapePattern[shapeArraySize - runCount] = s.ToString();
                }

                beginAndEndSpacing--;
            }

            return string.Join( "\n\n", resultShapePattern);
        }

        private void _AddBeginingSpace(StringBuilder sb, int beginSpacing)
        {
            sb.Append(StringHelper.BuildStringOfSpaces(beginSpacing));
        }

        private void _AddEndingSpace(StringBuilder sb, int endSpacing)
        {
            sb.Append(StringHelper.BuildStringOfSpaces(endSpacing));
        }

        private void _AddAlphabet(StringBuilder sb, char alphabet)
        {
            sb.Append(alphabet);
        }

        private void _AddSpacesInMiddle(StringBuilder sb, int beginSpacing)
        {
            sb.Append(StringHelper.BuildStringOfSpaces(beginSpacing));
        }
    }
}