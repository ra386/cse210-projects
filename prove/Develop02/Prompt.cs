using System;
using System.Collections.Generic;
namespace Develop02
{
    public class PromptGenerator
    {
       
        
             public List<string> prompt = new List<string>
            {
                 "Who was the most interesting person I interacted with today?",
                 "What was the best part of my day?",
                 "How did I see the hand of the Lord in my life today?",
                 "What was the strongest emotion I felt today?",
                 "If I had one thing I could do over today, what would it be?",
                 "Did my actions today reflect my beliefs",
                 "What was the funniest moment of your day"
            };
            public Random rand = new Random();

            public string GetRandomPrompt()
            {
                
                int randomTxt = rand.Next(prompt.Count);
                return prompt[randomTxt];
                
            }

            
            
    }
}