using Cours.Data;
using Cours.Models;

namespace Cours.Fixtures;

public class ClientFixtures
{
    private readonly ApplicationDbContext _context;

    public ClientFixtures(ApplicationDbContext context)
    {
        this._context = context;
    }

    public void Load()
    {
        if (!_context.Articles.Any())
        {
            _context.Articles.AddRange(
                new Article
                {
                    Libelle = "Article 1",
                    Prix = 1000,
                    Stock = 500
                },
                  new Article
                  {
                      Libelle = "Lait",
                      Prix = 600,
                      Stock = 40
                  },
                  new Article
                  {
                      Libelle = "Sucre",
                      Prix = 650,
                      Stock = 100
                  },
                  new Article
                  {
                      Libelle = "Riz",
                      Prix = 400,
                      Stock = 150
                  }

            );

            _context.SaveChanges();
        }

        /* 


         */


        if (!_context.Clients.Any())
        {
            _context.Clients.AddRange(
                new Client
                {
                    Surnom = "John Doe",
                    Telephone = "771234567",
                    Adresse = "123 Rue des Bleus",
                    Dettes = [
                    new Dette { Montant = 1000, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-3)), ArticleDettes = [

                    ]},
                    new Dette { Montant = 2000, Date =  DateOnly.FromDateTime(DateTime.Now.AddDays(-8)), MontantVerser = 1500 , Paiements = [
                        new Paiement { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-2)), Montant = 500 },
                        new Paiement { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-5)), Montant = 1000 }
                    ]},
                    //  Des ArticleDette
                    new Dette { Montant = 3000, Date =  DateOnly.FromDateTime(DateTime.Now.AddDays(-1)) ,  Paiements = [
                        new Paiement { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-2)), Montant = 500 },
                        new Paiement { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-5)), Montant = 1000 },
                        new Paiement { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-7)), Montant = 1500 }
                    ]},
                    new Dette { Montant = 3000, Date =  DateOnly.FromDateTime(DateTime.Now.AddDays(-1)), MontantVerser = 3000 },
                ]
                },
                new Client
                {
                    Surnom = "Jane Smith",
                    Telephone = "789654321",
                    Adresse = "456 Rue des Verts",
                    Dettes = [
                    new Dette { Montant = 8000, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-10))},
                    new Dette { Montant = 6000, Date =  DateOnly.FromDateTime(DateTime.Now.AddDays(-8)), MontantVerser = 4500,  Paiements = [
                        new Paiement { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-2)), Montant = 500 },
                        new Paiement { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-5)), Montant = 1000 },
                        new Paiement { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-7)), Montant = 1500 },
                        new Paiement { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-10)), Montant = 500 }
                    ] },
                    new Dette { Montant = 1000, Date =  DateOnly.FromDateTime(DateTime.Now.AddDays(-1)) },
                    new Dette { Montant = 5000, Date =  DateOnly.FromDateTime(DateTime.Now.AddDays(-1)),MontantVerser = 5000 },
                ]
                },
                new Client
                {
                    Surnom = "Alice Johnson",
                    Telephone = "761472583",
                    Adresse = "789 Rue des Gris",
                    Dettes = [
                    new Dette { Montant = 1000, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-3))},
                    new Dette { Montant = 2000, Date =  DateOnly.FromDateTime(DateTime.Now.AddDays(-8)), MontantVerser = 2000 },
                    new Dette { Montant = 3000, Date =  DateOnly.FromDateTime(DateTime.Now.AddDays(-1)) },
                    new Dette { Montant = 3000, Date =  DateOnly.FromDateTime(DateTime.Now.AddDays(-1)), MontantVerser = 500,   Paiements = [
                        new Paiement { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-2)), Montant = 500 },
                    ] },
                ]
                }
            );

            // _context.SaveChanges();
        }

        if (!_context.ArticleDettes.Any())
        {
            _context.ArticleDettes.AddRange(
                new ArticleDette { Article = _context.Articles.Find(1)!, Dette = _context.Dettes.Find(1)!, Quantite = 15, PrixUnitaire = 680 },
                new ArticleDette { Article = _context.Articles.Find(2)!, Dette = _context.Dettes.Find(1)!, Quantite = 20, PrixUnitaire = 700 },
                new ArticleDette { Article = _context.Articles.Find(3)!, Dette = _context.Dettes.Find(1)!, Quantite = 45, PrixUnitaire = 500 },
                new ArticleDette { Article = _context.Articles.Find(4)!, Dette = _context.Dettes.Find(2)!, Quantite = 15, PrixUnitaire = 876 }
            );
        }
        _context.SaveChanges();

    }
}
