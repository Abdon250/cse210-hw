public class Activity
    {
        protected string description;
        protected int duration;

        
        public void PerformActivity()
        {
            Console.WriteLine("=== {0} ===", GetType().Name);
            Console.WriteLine(description);
            duration = GetDuration();
            
            DateTime endTime = DateTime.Now.AddSeconds(duration);
            TimeSpan remainingTime;

            if ((remainingTime = endTime - DateTime.Now) > TimeSpan.Zero)
            {
                Console.WriteLine("ready!");

                List<string> animationStrings = new List<string>();
                animationStrings.Add("/");
                animationStrings.Add("\\");
                animationStrings.Add("|");
                animationStrings.Add("_");
                animationStrings.Add("!");

                foreach (string s in animationStrings)
                {
            
                    Console.Write(s);
                    Thread.Sleep(500);
                    Console.Write("\b \b");
                }

                Console.WriteLine();
                Thread.Sleep(500);
            }
        }

        protected int GetDuration()
        {
        
            Console.Write("Enter the duration in seconds: ");
            int duration;
            while (!int.TryParse(Console.ReadLine(), out duration))
            {
                Console.WriteLine("Invalid duration. Please enter a valid number.");
                Console.Write("Enter the duration in seconds: ");
            }
            return duration;
        }

        protected void Pause(int milliseconds)
        {
            int remainingSeconds = milliseconds / 1000;

            
            {
                Console.WriteLine("ready!");

                List<string> animationStrings = new List<string>();
                animationStrings.Add("/");
                animationStrings.Add("\\");
                animationStrings.Add("|");
                animationStrings.Add("_");
                animationStrings.Add("!");


                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(remainingSeconds);

                int i = 0;

                while (DateTime.Now < endTime)
                {
                    string s = animationStrings[i];
                    Console.Write(s);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                } 

            Console.WriteLine();
        }


    }
    }
