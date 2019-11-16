using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using JsonPlaceholderApp.Models;
using Newtonsoft.Json;

namespace JsonPlaceholderApp.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        private static readonly HttpClient Client;
        private const string Url = "http://rallycoding.herokuapp.com/api/music_albums";

        static MockDataStore()
        {
            Client = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(10)
            };
        }

        //public async Task<bool> AddItemAsync(Item item)
        //{
        //    items.Add(item);

        //    return await Task.FromResult(true);
        //}

        //public async Task<bool> UpdateItemAsync(Item item)
        //{
        //    var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
        //    items.Remove(oldItem);
        //    items.Add(item);

        //    return await Task.FromResult(true);
        //}

        //public async Task<bool> DeleteItemAsync(Guid id)
        //{
        //    var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
        //    items.Remove(oldItem);

        //    return await Task.FromResult(true);
        //}

        //public async Task<Item> GetItemAsync(Guid id)
        //{
        //    return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        //}

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            var content = await Client.GetStringAsync(Url);
            return JsonConvert.DeserializeObject<List<Item>>(content);
        }
    }
}