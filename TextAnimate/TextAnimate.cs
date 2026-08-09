namespace TextAnimate
{

    public static class Anim
    {
        public static void Type(string text, int DelayMs = 0)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
            if (DelayMs > 0)
            {
                Thread.Sleep(DelayMs);
            }
        }
    
        public static void Delay(string text, int DelayMs)
        {
            Console.WriteLine(text);
            Thread.Sleep(DelayMs);
        }
    }
}