public class ListingActivity : Activity
    {
        private string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity()
        {
            description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }

        public void PerformListingActivity()
        {
            base.PerformActivity();

            DateTime endTime = DateTime.Now.AddSeconds(duration);

            Random random = new Random();
            int promptIndex = random.Next(prompts.Length);

            Console.WriteLine(prompts[promptIndex]);
            Pause(3000);

            int itemCount = 0;

            while (DateTime.Now < endTime)
            {
                Console.Write("Enter an item: ");
                string item = Console.ReadLine();
                itemCount++;
                Console.WriteLine("Item #{0} entered.", itemCount);
            }

            Console.WriteLine("You have completed the Listing Activity for {0} seconds.", duration);
            Console.WriteLine("Total items entered: {0}", itemCount);
            
        
        }
    }