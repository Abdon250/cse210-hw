
public class BreathingActivity : Activity
    {
        public BreathingActivity()
        {
            description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }

        public void PerformBreathingActivity()
        {
            base.PerformActivity();

            DateTime endTime = DateTime.Now.AddSeconds(duration);

            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Breathe in...");
                Pause(3000);
                Console.WriteLine("Breathe out...");
                Pause(3000);
                
            }

            Console.WriteLine("You have completed the Breathing Activity for {0} seconds.", duration);
            
            
        }
    }