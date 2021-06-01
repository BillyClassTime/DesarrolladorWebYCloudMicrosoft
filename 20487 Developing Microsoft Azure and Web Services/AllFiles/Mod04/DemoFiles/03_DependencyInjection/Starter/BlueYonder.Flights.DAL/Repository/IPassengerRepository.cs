using System.Threading.Tasks;
using System.Collections.Generic;
using BlueYonder.Flights.DAL.Models;

namespace BlueYonder.Flights.DAL.Repository
{
    public interface IPassengerRepository
    {
        Task<IEnumerable<Passenger>> GetAllPassengers();
        Task<Passenger> GetPassenger(int passengerId);
        Task<Passenger> Add(Passenger newPassenger);
        Task<Passenger> Update(Passenger passengerToUpdate);
        void Delete(int passengerId);
    }
}