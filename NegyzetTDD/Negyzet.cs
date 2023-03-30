namespace NegyzetTDD
{
    public class Negyzet
    {
        private int oldal;

        public Negyzet(int oldal)
        {
            this.oldal = oldal;
        }

        public int getKerulet()
        {
            return (int)Math.Pow(this.oldal, 2);
        }
    }
}