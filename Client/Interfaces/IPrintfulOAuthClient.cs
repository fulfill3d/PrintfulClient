using Client.Models.Response;

namespace Client.Interfaces
{
    public interface IPrintfulOAuthClient
    {
        Task<PrintfulResponse<OAuthScopeResponse>> GetOAuthScopes();
    }
}