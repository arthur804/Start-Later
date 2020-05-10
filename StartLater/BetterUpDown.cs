using System.Windows.Forms;

namespace StartLater
{
    public class BetterUpDown : NumericUpDown
    {
        public new decimal Value { get { return base.Value; } set { base.Value = System.Math.Max(System.Math.Min(value, Maximum), Minimum); } }
        public new decimal Increment = 1;
        
        public BetterUpDown()
        {
            base.Increment = 0;
            this.MouseWheel += BetterUpDown_MouseWheel;
        }

        private void BetterUpDown_MouseWheel(object sender, MouseEventArgs e)
        {
            Value += e.Delta > 0 ? Increment : -Increment;
        }
    }
}
