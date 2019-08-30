using Microsoft.AspNetCore.Blazor;
namespace PizzaSPA.Client

{
    public static class DebuggingExtensions
    {
        public static string ToJson(this object obj) => System.Text.Json.JsonSerializer.Serialize(obj);
    }
}