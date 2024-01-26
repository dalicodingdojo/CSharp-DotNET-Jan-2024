#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models;

public class Song
{
    [Required(ErrorMessage = "Please enter a valid title.")]
    [MinLength(2)]
    [MaxLength(20)]
    public string Title { get; set; }
    [Required]
    [Range(1800, 2024)]
    [Display(Name = "Release Year")]
    public int ReleaseYear { get; set; }
    [Required(ErrorMessage = "Please enter a valid singer name 🧑🏼‍🎤👨🏼‍🎤👩🏼‍🎤.")]
    [MinLength(2)]
    public string Singer { get; set; }
    [Required]
    public bool IsExplicit { get; set; } = false;
}