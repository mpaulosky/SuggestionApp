namespace SuggestionAppLibrary.Models;

public class CategoryModel
{
  [BsonId]
  [BsonRepresentation(BsonType.ObjectId)]
  public string Id { get; set; } = null!;
  public string CategoryName { get; set; } = string.Empty;
  public string CategoryDescription { get; set; } = string.Empty;
}
