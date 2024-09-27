using System.Threading.Tasks;
using Caching_redis.Services;
using StackExchange.Redis;

namespace Caching_redis.Models {
    public class RedisCacheService : ICacheService {
        private readonly IConnectionMultiplexer multiplexer;
        public RedisCacheService (IConnectionMultiplexer multiplexer) {
            this.multiplexer = multiplexer;

        }
        public async Task<string> GetCacheValueAsync (string key) {
            var db = multiplexer.GetDatabase();
            return await db.StringGetAsync(key);
        }

        public async Task SetacheValueAsync (string key, string value) {
            var db = multiplexer.GetDatabase();
            await db.StringSetAsync(key, value);
        }
    }
}