using System.ComponentModel.DataAnnotations;

namespace SuggestionAppUI.Models;

public class CreateSuggestionModel
{
	[Required]
	[MaxLength(75)]
	public string Suggestion { get; set; } = string.Empty;

	[Required]
	[MinLength(1)]
	[Display(Name = "Category")]
	public string CategoryId { get; set; } = string.Empty;

	[MaxLength(500)]
	public string Description { get; set; } = string.Empty;
}
