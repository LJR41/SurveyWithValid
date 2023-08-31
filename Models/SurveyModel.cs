using System.ComponentModel.DataAnnotations;

namespace SurveyWithValid.Models;

public class Survey
{
    [Required]
    [MinLength(2,ErrorMessage = "Name must be at least 3 characters long")]
    public string Name { get; set; }
    [Required]
    public string Location { get; set; }
    [Required]
    public string Language { get; set; }
    [MinLength(20, ErrorMessage = "Comment must be at least 20 characters long")]
    public string? Comment { get; set; }
}