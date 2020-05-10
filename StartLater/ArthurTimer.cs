namespace StartLater
{
    public class ArthurTimerData
    {
        public readonly System.Action<string> Action;
        public readonly string text;
        public readonly int Millseconds;
        public ArthurTimerData(System.Action<string> action, string text, int millseconds)
        {
            this.Action = action;
            this.text = text;
            this.Millseconds = millseconds;
        }
    }
}
