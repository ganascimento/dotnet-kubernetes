using SalesAd.Domain.Entities.Base;
using SalesAd.Domain.VO.Base;

namespace SalesAd.Domain.VO
{
    public class Address : BaseValueObject
    {
        public Address(string streetName, string zipCode, string neighborhood, string state, string country, int? number)
        {
            this.StreetName = streetName;
            this.ZipCode = zipCode;
            this.Neighborhood = neighborhood;
            this.State = state;
            this.Country = country;
            this.Number = number;
        }

        public string StreetName { get; private set; }
        public string ZipCode { get; private set; }
        public string Neighborhood { get; private set; }
        public int? Number { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }

        private void ValidateEntity()
        {
            AssertionConcern.AssertArgumentNotNull(StreetName, "StreetName is required!");
            AssertionConcern.AssertArgumentNotNull(ZipCode, "ZipCode is required!");
            AssertionConcern.AssertArgumentNotNull(Neighborhood, "Neighborhood is required!");
            AssertionConcern.AssertArgumentNotNull(State, "State is required!");
            AssertionConcern.AssertArgumentNotNull(Country, "Country is required!");
        }

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return StreetName;
            yield return ZipCode;
            yield return Neighborhood;
            yield return Number;
            yield return State;
            yield return Country;
        }
    }
}