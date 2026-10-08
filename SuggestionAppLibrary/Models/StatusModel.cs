namespace SuggestionAppLibrary.Models;

public class StatusModel
{
  [BsonId]
  [BsonRepresentation(BsonType.ObjectId)]
  public string Id { get; set; } = null!;
  public string StatusName { get; set; } = string.Empty;
  public string StatusDescription { get; set; } = string.Empty;


}
