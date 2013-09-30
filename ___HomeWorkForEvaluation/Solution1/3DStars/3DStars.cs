using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBracketsBetter
{
    class CSharpBracketsBetter
    {

        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            string indentationString = Console.ReadLine();

            List<string> lines = new List<string>(linesCount);
            StringBuilder resultToClean = new StringBuilder();
            StringBuilder indentation = new StringBuilder("");

            //int indentationsCount = 0;

            for (int i = 0; i < linesCount; i++)
            {
                string currLine = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(currLine))
                {
                    currLine = currLine.Trim();

                    bool isTrimming = true;

                    StringBuilder currResultLine = new StringBuilder("");

                    for (int currCharInd = 0; currCharInd < currLine.Length; currCharInd++)
                    {
                        char currChar = currLine[currCharInd];

                        if (!char.IsWhiteSpace(currChar))
                        {
                            isTrimming = false;
                        }

                        if (currChar == '{')
                        {
                            isTrimming = true;
                            if (currCharInd != 0/* && currLine[currCharInd - 1] != '{' && currLine[currCharInd - 1] != '}'*/)
                            {
                                resultToClean.Append("\r\n");
                                currResultLine = new StringBuilder("");
                            }
                            resultToClean.Append(indentation);
                            indentation.Append(indentationString);
                        }
                        else if (currChar == '}')
                        {
                            isTrimming = true;
                            indentation.Remove(indentation.Length - indentationString.Length, indentationString.Length);
                            if (currCharInd != 0/* && currLine[currCharInd - 1] != '{' && currLine[currCharInd - 1] != '}'*/)
                            {
                                resultToClean.Append("\r\n");
                                currResultLine = new StringBuilder("");
                            }
                            resultToClean.Append(indentation);
                        }
                        else if (currCharInd == 0)
                        {
                            resultToClean.Append(indentation);
                        }

                        if (!char.IsWhiteSpace(currChar) || (!isTrimming && currChar != currLine[currCharInd + 1]))
                        {
                            resultToClean.Append(currChar);
                        }

                        if (currCharInd == currLine.Length - 1)
                        {
                            resultToClean.Append("\r\n");
                            //result.Append(indentation);
                        }

                        if (currChar == '{' && currCharInd != currLine.Length - 1)
                        {
                            resultToClean.Append("\r\n");
                            //if (currLine[currCharInd + 1] != '}')
                            //{
                            resultToClean.Append(indentation);
                            //}
                        }

                        if (currChar == '}' && currCharInd != currLine.Length - 1)
                        {
                            resultToClean.Append("\r\n");
                            resultToClean.Append(indentation);
                        }
                    }
                }
            }

            string[] separators = new string[] { "\r\n" };

            string[] splitResult = resultToClean.ToString().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder endResult = new StringBuilder(resultToClean.Length);
            int indentationsCount = 0;
            int cnt = 0;
            foreach (var line in splitResult)
            {
                if (line.Contains('{'))
                {
                    indentationsCount++;
                    endResult.AppendLine(line.Trim());
                }
                else if (line.Contains('}'))
                {
                    indentationsCount--;
                    endResult.AppendLine(line.Trim());
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(line.Substring(indentationsCount * indentationString.Length)))
                    {
                        endResult.AppendLine(line.Trim());
                    }
                }
                cnt++;
            }

            Console.Write(endResult.ToString());
        }
    }
}