namespace Cours.Models;

public class Article
{
    public int Id { get; set; }
    public string Libelle { get; set; }
    public float Prix { get; set; }
    public int Stock { get; set; }
    
    // Relation

    public virtual ICollection<ArticleDette>? ArticleDettes { get; set; }
}