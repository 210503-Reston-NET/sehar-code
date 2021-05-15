using System.Collections.Generic;
using Models;
using SDL;
namespace SBL
{
    public class LocationBL : ILocationBL
    {
        private IRepository _repo;
        public LocationBL(IRepository repository){
            _repo = repository;
        }
        public List<MLocation> GetAllLocation()
        {
            return _repo.GetAllLocation();
        }
    }
}