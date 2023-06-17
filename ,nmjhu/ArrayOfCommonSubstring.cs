using System.ComponentModel.Design;
using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;
using System.Security;

class LongestCommonSubsequence
{


    /*abvba*/

    static void Main()
    {
        
        string input = Console.ReadLine();
         List<string> result=LCS(input);
        Console.WriteLine(string.Join(' ', result));
    }
    static List<string> LCS(string input)
    {

        int length = input.Length;
        int currentLength = 0;
        int bestLength = 0;                                                          //aaaaababvbabaaa
        string message = string.Empty;
        List<string> longestCom = new List <string>();
        string bestSeq = string.Empty;
        bool isLCS = false;
        if (input.Length == 1)
        {
            isLCS = true;
            longestCom.Add(input);
            bestSeq = input;
            currentLength=input.Length;
            return longestCom;
        }
        else if (input.Length == 2)
        {
            if (input[0] == input[1])
                isLCS = true;
            longestCom.Add(input);
            bestSeq = input;
            currentLength =input.Length;
        return longestCom;
        }
        else if (input.Length == 3)
        {
            if (input[0] == input[2])

                isLCS = true;
            longestCom.Add(input);
            bestSeq = input;
            currentLength =input.Length;
        return longestCom;
        }
        else
        {
            for (int i = length - 1; i >= 0; i--)
            {
                currentLength = 0;

                for (int j = i; j <= length - 1; j++)
                {
                    if (i == j)
                    {
                        message = input[i].ToString();
                        currentLength++;
                        //longestCom.Add(message);
                    }
                    else if (input[i] == input[j] && Math.Abs(j - i) == 1)
                    {
                        currentLength++;
                        int test = Math.Abs(j - i);
                        message += input[i].ToString();
                    }
                    else if (input[i] == input[j])/*&& Math.Abs(i-j)>1)*/
                    {
                        message += input[j];
                        currentLength++;
                    }
                        else
                            break;
                }
                if (currentLength > bestLength)
                {
                    bestLength = currentLength;
                    //   string secondHalf = message.Reverse().ToString();
                    longestCom.Add(message);
                    bestSeq = input;
                }

            }
        }
        return longestCom;
    }
}