namespace SuggestionAppLibrary.Models;
public class SuggestionModel
{
  [BsonId]
  [BsonRepresentation(BsonType.ObjectId)]
  public string Id { get; set; } = null!;
  public string Suggestion { get; set; } = string.Empty;
  public string Description { get; set; } = string.Empty;
  public DateTime DateCreated { get; set; } = DateTime.UtcNow;
  public CategoryModel Category { get; set; } = null!;
  public BasicUserModel Author { get; set; } = null!;
  public HashSet<string> UserVotes { get; set; } = new();
  public StatusModel? SuggestionStatus { get; set; }
  public string OwnerNotes { get; set; } = string.Empty;
  public bool ApprovedForRelease { get; set; } = false;
  public bool Archived { get; set; } = false;
  public bool Rejected { get; set; } = false;
}
