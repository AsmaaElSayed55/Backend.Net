namespace Common
{
    internal struct Point
    {
        #region Attributes
        public int X;
        public int Y;
        #endregion

        #region Constructor Overloading
        public Point() // Compiler Make it By Default  .Net 7
        {
            X = default;
            Y = default;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Point(int number)
        {
            X = Y = number;
        }
        #endregion

        #region Methods 
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
        #endregion

    }
}
