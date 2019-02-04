using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using ARMSnippets.models;
using Newtonsoft.Json;

namespace ARMSnippets
{
    class Program
    {
        static void Main(string[] args)
        {

            Hashtable snippets = new Hashtable();

            foreach (string file in Directory.GetFiles("templates-base"))
            {
                string fileName = file.Split("\\")[1];
                string fileNameWithoutExtension = fileName.Split(".")[0];
                Snippet snippet = new Snippet(file);
                snippet.prefix = "arm!-" + fileNameWithoutExtension;
                snippets.Add(fileNameWithoutExtension, snippet);

            }

            foreach (string file in Directory.GetFiles("templates-resources"))
            {
                string fileName = file.Split("\\")[1];
                string fileNameWithoutExtension = fileName.Split(".")[0];
                snippets.Add(fileNameWithoutExtension, new Snippet(file));
            }

            string json = JsonConvert.SerializeObject(snippets);
            System.Console.WriteLine(json);

            File.WriteAllText("snippets.json", json);
        }
    }
}
