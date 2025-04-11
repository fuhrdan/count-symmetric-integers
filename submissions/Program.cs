//*****************************************************************************
//** 2843. Count Symmetric Integers                                 leetcode **
//*****************************************************************************

int countSymmetricIntegers(int low, int high) {
    int retval = 0;

    for (int x = low; x <= high; x++)
    {
        int temp = x;
        int digits = 0;

        int t = temp;
        while (t > 0)
        {
            digits++;
            t /= 10;
        }

        if (digits % 2 != 0)
        {
            continue;
        }

        int half = digits / 2;
        int div = 1;
        for (int i = 0; i < half; i++)
        {
            div *= 10;
        }

        int left = temp / div;
        int right = temp % div;
        int sumLeft = 0, sumRight = 0;

        for (int i = 0; i < half; i++)
        {
            sumLeft += left % 10;
            left /= 10;

            sumRight += right % 10;
            right /= 10;
        }

        if (sumLeft == sumRight)
        {
            retval++;
        }
    }

    return retval;
}