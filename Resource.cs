using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Benchmark_ConstVSEmbedded
{
    public static class Resource
    {
        public static string GetScript(string fileName)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var resourceName = assembly.GetManifestResourceNames().Single(str => str.EndsWith($"{fileName}.sql"));

            using var stream = assembly.GetManifestResourceStream(resourceName);

            if (stream == null)
            {
                throw new ArgumentException($"Script not found: {resourceName}");
            }

            using var reader = new StreamReader(stream, leaveOpen: true);

            return reader.ReadToEnd();
        }
    }
}
