using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class PublicApiService : IPublicApiService
{
    private HttpClient _httpClient;
    public Task<IEnumerable<PublicApiEntry>> CatFactList { get; set; }

    public PublicApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<PublicApiEntry>> GetPublicApiEntries()
    {
        var publicApiEntryRoot =  await JsonSerializer.DeserializeAsync<PublicApiEntryRoot>
                (await _httpClient.GetStreamAsync($"entries"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        return publicApiEntryRoot.entries;
    }
}