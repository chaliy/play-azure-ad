using System;
using Newtonsoft.Json;

static class ObjectExtensions
{
    public static void Dump(this Object obj, string description = "")
    {
        Console.WriteLine(description, JsonConvert.ToString(obj));
    }
}