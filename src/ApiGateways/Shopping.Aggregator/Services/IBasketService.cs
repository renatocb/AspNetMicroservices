using Shopping.Aggregator.Models;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace Shopping.Aggregator.Services
{
    public interface IBasketService
    {
        Task<BasketModel> GetBasket(string userName);
    }
}
