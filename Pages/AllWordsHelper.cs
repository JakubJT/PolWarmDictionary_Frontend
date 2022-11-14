// using System.Net.Http;
// using PolWarmDictionary_Frontend.Models;
// using Microsoft.AspNetCore.Components;


// namespace PolWarmDictionary_Frontend.Pages;

// public class AllWordsHelper
// {
//     private readonly HttpClient _http;
//     private readonly IConfiguration _configuration;

//     public AllWordsHelper(HttpClient Http, IConfiguration Configuration)
//     {
//         _http = Http;
//         _configuration = Configuration;
//     }
//     public async Task<(int, Words[])> GetWords(string sortBy, bool ascendingOrder, RenderFragment? ErrorHandleMessage, int pageNumber = 1, int wordsPerPage = 10)
//     {
//         var response = await _http
//                         .GetAsync(_Endpoint.Url+ "/GetWords" + $"?sortBy={sortBy}" + $"&ascendingOrder={ascendingOrder}"
//                         + $"&pageNumber={pageNumber}" + $"&wordsPerPage={wordsPerPage}");
//         if (!response.IsSuccessStatusCode)
//         {
//             // ErrorHandleMessage = __builder =>
//             // {

//             //     < div class="alert alert-warning" role="alert">
//             //             Wyświetlenie słów się nie powiodło - <em>@response.StatusCode</em>
//             //         </div>
//             // };
//             return default;
//         }
//         var result = await response.Content.ReadFromJsonAsync<Words>();
//         numberOfPages = result.NumbeOfPages;
//         words = result.WordList.ToArray();
//         // Paginate();
//     }
// }