using BookingAppDio.Core.ModelsAggregate;

namespace BookingAppDio.Flight.Domain.Airports
{
    public class Airport : Aggregate<long>
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string Code { get; private set; }

        public static Airport Create(long id, string name, string address, string code)
        {
            var airport = new Airport
            {
                Id = id,
                Name = name,
                Address = address,
                Code = code
            };

            return airport;
        }
    }
}
