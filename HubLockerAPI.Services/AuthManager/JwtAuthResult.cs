using System.Text.Json.Serialization;

namespace HubLockerAPI.Services.AuthManager
{
    public class JwtAuthResult
    {
        [JsonPropertyName("accessToken")]
        public string AccessToken { get; set; }
    }
}
