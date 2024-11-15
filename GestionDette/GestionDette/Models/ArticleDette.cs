namespace Cours.Models;

public class ArticleDette
{
    public int Id { get; set; }
    public int Quantite { get; set; }
    public int PrixUnitaire { get; set; }
    
    // Relation
    public Article Article { get; set; }
    public int ArticleId { get; set; }
    public Dette Dette { get; set; }
    public int DetteId { get; set; }
}