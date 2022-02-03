
namespace SuggestionAppLibrary.DataAccess;

public interface ISuggestionData
{
	Task CreateSuggestion(SuggestionModel suggestion);
	Task<List<SuggestionModel>> GetAllSuggestions();
	Task<List<SuggestionModel>> GetAllSuggestionsWaitingForApproval();
	Task<SuggestionModel> GetSuggestion(string id);
	Task<List<SuggestionModel>> GetSuggestionModels();
	Task UpdateSuggestion(SuggestionModel suggestion);
	Task UpVoteSuggestion(string suggestionId, string userId);
	Task<List<SuggestionModel>> GetAllApprovedSuggestions();
	Task<List<SuggestionModel>> GetUsersSuggestions(string userId);
}