using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace AppEcommerce.Extensions
{
    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T Carrinho)
        {
            session.SetString(key, JsonSerializer.Serialize(Carrinho));
        }

        public static T Get<T>(this ISession session, string key)
        {
            var Carrinho = session.GetString(key);
            return Carrinho == null ? default : JsonSerializer.Deserialize<T>(Carrinho);
        }
    }
}