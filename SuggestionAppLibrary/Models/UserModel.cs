namespace SuggestionAppLibrary.Models;

public class UserModel
{
  [BsonId]
  [BsonRepresentation(BsonType.ObjectId)]
  public string Id { get; set; } = null!;
  public string ObjectIdentifier { get; set; } = string.Empty;
  public string FirstName { get; set; } = string.Empty;
  public string LastName { get; set; } = string.Empty;
  public string DisplayName { get; set; } = string.Empty;
  public string EmailAddress { get; set; } = string.Empty;
  public List<BasicSuggestionModel> AuthoredSuggestions { get; set; } = new();
  public List<BasicSuggestionModel> VotedOnSuggestions { get; set; } = new();
}
