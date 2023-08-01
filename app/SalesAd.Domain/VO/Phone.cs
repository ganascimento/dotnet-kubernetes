using System.Text.RegularExpressions;
using SalesAd.Domain.Entities.Base;

namespace SalesAd.Domain.VO
{
    public struct Phone
    {
        private readonly string _value;

        private Phone(string value)
        {
            AssertionConcern.AssertArgumentNotEmpty(value, "Phone is required!");
            value = Regex.Replace(value, "[^0-9]+", "");
            AssertionConcern.AssertArgumentLength(value, 10, 11, "Phone is invalid");

            _value = value;
        }

        public static Phone Parse(string value)
        {
            if (TryParse(value, out var result))
            {
                return result;
            }
            throw new ArgumentException();
        }

        public static bool TryParse(string value, out Phone phone)
        {
            phone = new Phone(value);
            return true;
        }

        public override string ToString() => _value;

        public static implicit operator Phone(string input) => Parse(input);
    }
}