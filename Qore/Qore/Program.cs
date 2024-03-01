using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Qore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(checkBrackets("{()}"));
        }

        public static string checkBrackets(string str)
        {
            char[] chars = str.ToCharArray();
            var newStack = new Stack<char>();

            string valid = "valid";

            foreach (char chara in chars)
            {
                switch (chara)
                {
                    case '(':
                    case '{':
                    case '[':
                        newStack.Push(chara);
                        break;
                    case ')':
                    case '}':
                    case ']':

                        if (newStack.Count == 0)
                        {
                            valid = "invalid";
                        }
                       else
                        {
                            char open = newStack.Pop();
                            if ((chara == ')' && open != '(')
                                || (chara == ']' && open != '[')
                                || (chara == '}' && open != '{' )
                                )
                            {
                                valid = "invalid";
                            }
                        }
                        break;
                }
            }
            if (newStack.Count> 0)
            {
                valid = "invalid";
            }
            return valid;
        }

        // Question 2 pseudocode

        //function maxSubArraySum(nums)
        //if(length(nums) == 0)
        //    return 0

        //    maxEndingHere = NumberStyles[0]
        //    maxSoFar = NumberStyles[0]

        //    for i from 1 to length(nums) - 1;
        //    maxEndingHere = max(nums[i], maxEndingHere + nums[i])
        //maxSoFar = max(maxSoFar, maxEndingHere)
        //return maxSoFar


        // Question 3
        // Designing a high performance system

        //Pseudocode/ design

        //User logs in using the userId and password and he's authenticated using Jwt token. We should also include input validation to avoid
        //SQL injection and CSRF, thereby increasing security.

        //if user is not valid, bounce the user back, otherwise, log them in.

        //User can make transaction

        //check for available balance; if amount you want to transfer is < than the amount in the account, alert: Insufficient balance.
        //check for maximum transfer limit; daily transaction limit == 1,000,000
        //customer can go ahead to make transaction.
        //check for duplicate transaction; if transactionReference is the same transaction reference saved in the database, then it is duplicate, bounce it back.
        //users would have to wait for 30 secs before retrying transaction so as to avoid duplicate transaction.
        //Implement try/catch and log the caught exceptions using Logger.


        //Question 4

    
    }

  
}