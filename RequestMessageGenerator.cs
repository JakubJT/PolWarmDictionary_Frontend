using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace PolWarmDictionary_Frontend;

public class RequestMessageGenerator
{
    private readonly IAccessTokenProvider _tokenProvider;
    public RequestMessageGenerator(IAccessTokenProvider TokenProvider)
    {
        _tokenProvider = TokenProvider;
    }

    public async Task<HttpRequestMessage> GetHttpRequestMessage(HttpMethod httpMethod, string requestUri)
    {
        var requestMessage = new HttpRequestMessage(httpMethod, requestUri);
        System.Net.Http.Headers.AuthenticationHeaderValue? authorization = new("Bearer", await GetToken());
        requestMessage.Headers.Authorization = authorization;
        return requestMessage;
    }

    private async Task<string> GetToken()
    {
        AccessToken accessToken;
        var token = await _tokenProvider.RequestAccessToken();
        token.TryGetToken(out accessToken);
        return accessToken.Value;
    }
}