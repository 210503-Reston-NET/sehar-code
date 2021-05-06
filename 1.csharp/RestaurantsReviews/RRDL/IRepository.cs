using System;
using System.Collections.Generic;
using RRModel;
namespace RRDL
{
    public interface IRepository
    {
         List<Restaurants> GetAllRestaurants();
    }
}