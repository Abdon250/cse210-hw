public class ReflectionActivity : Activity
    {
        private string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public ReflectionActivity()
        {
            description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        }

        public void PerformReflectionActivity()
        {
            base.PerformActivity();

            DateTime endTime = DateTime.Now.AddSeconds(duration);

            Random random = new Random();
            int promptIndex = random.Next(prompts.Length);

            Console.WriteLine(prompts[promptIndex]);
            Pause(3000);

            while (DateTime.Now < endTime)
            {
                int questionIndex = random.Next(questions.Length);
                Console.WriteLine(questions[questionIndex]);
                Pause(3000);
            }

            Console.WriteLine("You have completed the Reflection Activity for {0} seconds.", duration);
            
        
        }
    }