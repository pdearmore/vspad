using System;
using Newtonsoft.Json;

namespace VsPad
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// This is a simple (and lazy, read: effective) solution. Simply send your
        /// object to Newtonsoft serialize method, with the indented formatting, and
        /// you have your own Dump() extension method.
        /// </summary>
        /// <typeparam name="T">The object Type</typeparam>
        /// <param name="anObject">The object to dump</param>
        /// <param name="aTitle">Optional, will print this before the dump.</param>
        /// <returns>The object as you passed it</returns>
        public static T Dump<T>(this T anObject, string aTitle = "")
        {
            var pretty_json = JsonConvert.SerializeObject(anObject, Formatting.Indented);
            if (aTitle != "")
                Console.Out.WriteLine(aTitle + ": ");

            Console.Out.WriteLine(pretty_json);
            return anObject;
        }
    }
}