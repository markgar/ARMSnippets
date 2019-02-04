using System;
using System.Collections.Generic;

namespace ARMSnippets.models
{
    public class Snippet
    {
        public string prefix {get; set;}
        public List<string> body {get; set;}
        public string description {get; set;}

        public Snippet(string FilenameAndPath)
        {
            string line;
            body = new List<string>();

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(FilenameAndPath);

            while ((line = file.ReadLine()) != null)
            {
                string lineTransformed = string.Empty;

                body.Add(line);
            }

            file.Close();

            prefix = "arm-" + FilenameAndPath.Split('\\')[1].Split('.')[0];
            description = FilenameAndPath.Split('\\')[1].Split('.')[0] + " ARM Template";
        }
    }
}