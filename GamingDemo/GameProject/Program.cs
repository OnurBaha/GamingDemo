using GameProject.Concrete;
using GameProject.Entities;

Gamer gamer1 = new Gamer()
{
    Id = 1,
    FirstName = "Onur Baha",
    LastName = "Koç",
    DateOfBirth = new DateTime(2001,07,21),
    Identity="123",
};

GamerManager gamerManager = new GamerManager(new GamerCheckManager());
gamerManager.Create(gamer1);

Sale sale1 = new Sale()
{
    Id = 1,
    Name = "CS-GO",
    Price = 150,
};

Campaign campaign1 = new Campaign()
{
    Id = 1,
    Name = "BlackFriday %50",
    DiscountRate = 0.5,
};

SaleManager saleManager = new SaleManager();
saleManager.Sale(gamer1, sale1, campaign1);
