using System.Windows.Forms;

namespace StartLater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hoursInput.Value = System.DateTime.Now.Hour;
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            SetUpTimer(System.TimeSpan.FromHours((double)hoursInput.Value) + System.TimeSpan.FromMinutes((double)minutesInput.Value), urlBox.Text);
            //close form + dispose of form
            this.Close();
        }

        private static void Launch(string text)
        {
            if(text.EndsWith(".exe") || text.StartsWith("http"))
                System.Diagnostics.Process.Start(text);
            else
                System.Diagnostics.Process.Start(text + ".exe");
        }

        private void SetUpTimer(System.TimeSpan alertTime, string text)
        {
            System.DateTime current = System.DateTime.Now;
            System.TimeSpan timeToGo = alertTime - current.TimeOfDay;
            if(timeToGo < System.TimeSpan.Zero)
            {
                timeToGo = alertTime + System.TimeSpan.FromDays(1) - current.TimeOfDay;
            }
            Program.Timer = new ArthurTimerData(Launch, text, (int)timeToGo.TotalMilliseconds);
        }

        private void HoursInput_ValueChanged(object sender, System.EventArgs e)
        {
            var s = (BetterUpDown)sender;
            if(s.Value == s.Minimum)
                s.Value = s.Maximum - 1;
            else if(s.Value == s.Maximum)
                s.Value = s.Minimum + 1;
        }

        private void MinutesInput_ValueChanged(object sender, System.EventArgs e)
        {
            var s = (BetterUpDown)sender;
            if(s.Value == s.Minimum)
            {
                s.Value = s.Maximum - 1;
                hoursInput.Value += 1;
            }
            else if(s.Value == s.Maximum)
            {
                s.Value = s.Minimum + 1;
                hoursInput.Value -= 1;
            }
        }
    }
}
