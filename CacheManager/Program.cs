//https://github.com/MichaCo/CacheManager
//Bom para usar com Redis
using CacheManager.Core;


var cache = CacheFactory.Build("getStartedCache", settings =>
{
    settings.WithSystemRuntimeCacheHandle("handleName");
});

cache.Add("keyA", "valueA");
Console.WriteLine("KeyA is " + cache.Get("keyA"));
cache.Update("keyA", v => 42);
Console.WriteLine("KeyA is " + cache.Get("keyA"));
Console.ReadKey();