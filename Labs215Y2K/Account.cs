namespace Labs215Y2K
{
    internal class Account
    {
        private string v1;
        private int v2;

        public Account(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public int BalanceChangeEvent { get; internal set; }
    }
}