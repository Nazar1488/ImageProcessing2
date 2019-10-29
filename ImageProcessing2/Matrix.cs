namespace ImageProcessing2
{
    public static class Matrix
    {
        public static double[,] Prewitt3x3Horizontal
        {
            get
            {
                return new double[,]
                { { -1,  0,  1, },
                    { -1,  0,  1, },
                    { -1,  0,  1, }, };
            }
        }

        public static double[,] Prewitt3x3Vertical
        {
            get
            {
                return new double[,]
                { {  1,  1,  1, },
                    {  0,  0,  0, },
                    { -1, -1, -1, }, };
            }
        }

        public static double[,] Sobel3x3Horizontal
        {
            get
            {
                return new double[,]
                { { -1,  0,  1, },
                    { -2,  0,  2, },
                    { -1,  0,  1, }, };
            }
        }

        public static double[,] Sobel3x3Vertical
        {
            get
            {
                return new double[,]
                { {  1,  2,  1, },
                    {  0,  0,  0, },
                    { -1, -2, -1, }, };
            }
        }
    }
}
