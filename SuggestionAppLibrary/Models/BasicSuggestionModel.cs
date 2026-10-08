namespace SuggestionAppLibrary.Models;

public class BasicSuggestionModel
{
  [BsonRepresentation(BsonType.ObjectId)]
  public string Id { get; set; } = null!;
  public string Suggestion { get; set; } = string.Empty;

  public BasicSuggestionModel()
  {

  }

  public BasicSuggestionModel(SuggestionModel suggestion)
  {
    Id = suggestion.Id;
    Suggestion = suggestion.Suggestion;
  }
}
