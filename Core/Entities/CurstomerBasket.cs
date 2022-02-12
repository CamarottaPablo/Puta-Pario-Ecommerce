
using System.Collections.Generic;

namespace Core.Entities
{
    public class CurstomerBasket
    {
        public CurstomerBasket()
        {
        }

        public CurstomerBasket(string id)
        {
            Id = id;
        }

        public string Id { get; set; }
        public List<BasketItem> Items { get; set; } = new List<BasketItem>();
    }
}