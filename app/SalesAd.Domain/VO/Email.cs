using SalesAd.Domain.Entities.Base;

namespace SalesAd.Domain.VO
{
    public struct Email
    {
        private readonly string _value;

        private Email(string value)
        {
            AssertionConcern.AssertArgumentLength(value, 100, "Max char is 100!");
            AssertionConcern.AssertArgumentNotEmpty(value, "Email is required!");
            AssertionConcern.AssertArgumentMatches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", value, "Email is invalid!");

            _value = value;
        }

        public static Email Parse(string value)
        {
            if (TryParse(value, out var result))
            {
                return result;
            }
            throw new ArgumentException();
        }

        public static bool TryParse(string value, out Email email)
        {
            email = new Email(value);
            return true;
        }

        public override string ToString() => _value;

        public static implicit operator Email(string input) => Parse(input);
    }
}