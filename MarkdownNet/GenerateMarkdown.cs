using Markdig;
using MarkdownNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MarkdownNet
{
    public class GenerateMarkdown
    {
        public static string CreateMarkdown(ArticleModel artilce)
        {
            var result = Markdown.ToHtml(ConvertCsvToHtmlTable(artilce.Content));
            Console.WriteLine(result);   // prints: <p>This is a text with some <em>emphasis</em></p>

            return result;
        }

        private static string ConvertCsvToHtmlTable(string csvText)
        {
            //split the CSV, assume no commas or line breaks in text
            List<List<string>> splitString = new List<List<string>>();
            List<string> lineSplit = csvText.Split('\n').ToList();
            foreach (string line in lineSplit)
            {
                splitString.Add(line.Split(',').ToList());
            }

            //encode text safely, and create table
            string tableResult = "<table>";
            foreach (List<string> splitLine in splitString)
            {
                tableResult += "<tr>";
                foreach (string splitText in splitLine)
                {
                    tableResult += "<td>" + WebUtility.HtmlEncode(splitText) + "</td>";
                }
                tableResult += "</tr>";
            }
            tableResult += "</table>";
            return tableResult;
        }
    }
}
