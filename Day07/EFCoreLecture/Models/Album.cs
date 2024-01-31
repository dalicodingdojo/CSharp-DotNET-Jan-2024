#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace EFCoreLecture.Models;

public class Album
{
    [Key]
    public int AlbumId { get; set; }
    //___________________________________
    [Required(ErrorMessage = "Please Provide Album Title.")]
    [MinLength(2, ErrorMessage = "Album title too short.")]
    public string Title { get; set; }
    //___________________________________
    [Required(ErrorMessage = "Please Provide Artist Name.")]
    [MinLength(2, ErrorMessage = "Artist Name too short.")]
    public string Artist { get; set; }
    //___________________________________
    [Required(ErrorMessage = "Please Provide Album Release Year.")]
    [Range(1800, 2024, ErrorMessage = "Please Provide a valid year (between 1800-2024)")]
    [Display(Name = "Year Of Release")]
    public int ReleaseYear { get; set; }
    //___________________________________
    [Required(ErrorMessage = "Please Provide Album Genre.")]
    [MinLength(2, ErrorMessage = "Album Genre too short.")]
    public string Genre { get; set; }
    //___________________________________
    [Required(ErrorMessage = "Please Provide Album Poster.")]
    [Display(Name = "Poster Image Url")]
    public string PosterUrl { get; set; }
    //___________________________________
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    //___________________________________
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}