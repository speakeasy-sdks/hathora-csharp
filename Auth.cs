///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace hathora.Auth;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using hathora.Models.Shared;
using hathora.Models.Auth;
using hathora.Utils;

public interface IAuthSDK
{
    Task<LoginAnonymousResponse> LoginAnonymousAsync(LoginAnonymousRequest request);
    Task<LoginGoogleResponse> LoginGoogleAsync(LoginGoogleRequest request);
    Task<LoginNicknameResponse> LoginNicknameAsync(LoginNicknameRequest request);
}

public class AuthSDK: IAuthSDK
{

    private const string language = "csharp";
    private const string sdkVersion = "0.0.1";
    private const string sdkGenVersion = "internal";
    public Uri ServerUrl { get { return _defaultClient.BaseAddress; } }
    private HttpClient _defaultClient;
    private HttpClient _securityClient;

    public AuthSDK(HttpClient defaultClient, HttpClient securityClient)
    {
        _defaultClient = defaultClient;
        _securityClient = securityClient;
    }

    
    public async Task<LoginAnonymousResponse> LoginAnonymousAsync(LoginAnonymousRequest request)
    {
        string baseUrl = "";
        var message = LoginAnonymousRequest.BuildHttpRequestMessage("LoginAnonymous", request);
        var httpResponseMessage = await _defaultClient.SendAsync(message);
        var response = new LoginAnonymousResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.LoginAnonymous200ApplicationJSONObject = JsonConvert.DeserializeObject<LoginAnonymous200ApplicationJSON>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                // application/json
                throw new NotImplementedException();
            }
            return response;
        }
        return response;
    }

    
    public async Task<LoginGoogleResponse> LoginGoogleAsync(LoginGoogleRequest request)
    {
        string baseUrl = "";
        var message = LoginGoogleRequest.BuildHttpRequestMessage("LoginGoogle", request);
        var httpResponseMessage = await _defaultClient.SendAsync(message);
        var response = new LoginGoogleResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.LoginGoogle200ApplicationJSONObject = JsonConvert.DeserializeObject<LoginGoogle200ApplicationJSON>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        if((response.StatusCode == 401))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                // application/json
                throw new NotImplementedException();
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                // application/json
                throw new NotImplementedException();
            }
            return response;
        }
        return response;
    }

    
    public async Task<LoginNicknameResponse> LoginNicknameAsync(LoginNicknameRequest request)
    {
        string baseUrl = "";
        var message = LoginNicknameRequest.BuildHttpRequestMessage("LoginNickname", request);
        var httpResponseMessage = await _defaultClient.SendAsync(message);
        var response = new LoginNicknameResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.LoginNickname200ApplicationJSONObject = JsonConvert.DeserializeObject<LoginNickname200ApplicationJSON>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                // application/json
                throw new NotImplementedException();
            }
            return response;
        }
        return response;
    }

    
}