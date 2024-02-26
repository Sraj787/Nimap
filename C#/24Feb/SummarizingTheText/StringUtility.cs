using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarizingTheText
{
    public class StringUtility
    {
        public static string SummerizeText(string sentance, int maxlength = 20)
        {

            if (sentance.Length < maxlength)
                return sentance;


            var words = sentance.Split(' ');
            var totalCharacters = 0;
            var summarywords = new List<string>();

            foreach (var word in words)
            {
                summarywords.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxlength)
                    break;
            }

            return String.Join(" ", summarywords) + ".....";
        }

        }
    }
