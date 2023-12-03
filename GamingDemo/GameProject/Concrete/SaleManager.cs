using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class SaleManager: ISaleService
    {
        public void Sale (Gamer gamer, Sale sale, Campaign campaign)
        {
            var newPrice = (sale.Price * campaign.DiscountRate);
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " adlı kullanıcının " + sale.Name + " adlı oyundan " + sale.Price + " TL ödeme siparişi vardır."
                + " Kampanya: " + campaign.Name + " Yeni fiyatı : " + newPrice);
        }
    }
}
