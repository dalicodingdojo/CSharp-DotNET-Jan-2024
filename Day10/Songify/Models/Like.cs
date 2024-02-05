#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Songify.Models;

public class Like 
{
    [Key]
    public int LikeId { get; set; }
    //  Foreign Keys 
    public int UserId { get; set; }
    public int AlbumId { get; set; }

    // Navigation Properties
    public User? User { get; set; }
    public Album? Album { get; set; }
    public DateTime CreatedAt { get; set; }  = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}