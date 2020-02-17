namespace Task2
{
    class Block
    {
        int a, b, c, d;

        public Block(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Block block = (Block)obj;
            return (a == block.a) && (b == block.b) && (c == block.c) && (d == block.d);
        }

        public override int GetHashCode()
        {
            return a ^ b ^ c ^ d;
        }
    }
}
