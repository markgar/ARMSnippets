using System;
using System.Collections.Generic;

namespace ARMSnippets.models
{
    public class Snippet
    {
        public string prefix {get; set;}
        public List<string> body {get; set;}
        public string description {get; set;}

        public Snippet(string Filename)
        {
            string line;
            body = new List<string>();

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@".\templates\" + Filename);

            while ((line = file.ReadLine()) != null)
            {
                string lineTransformed = string.Empty;

                body.Add(line);
            }

            file.Close();

            prefix = "arm-" + Filename.Split('.')[0];
            description = Filename.Split('.')[0] + " ARM Template";
        }
    }
}