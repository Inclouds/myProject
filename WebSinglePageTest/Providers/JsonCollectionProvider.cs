using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using WebSinglePageTest.Repositories;

namespace WebSinglePageTest.Providers
{
    public class JsonCollectionProvider<Tsource>
    {
        private readonly IRepository<Tsource> repository;

        public JsonCollectionProvider(IRepository<Tsource> repository)
        {
            this.repository = repository;
        }

        public string GetSerialized()
        {
            return JsonConvert.SerializeObject(repository.Get());
        }
    }
}