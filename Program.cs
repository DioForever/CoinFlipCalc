using System;
using System.Collections.Generic;
using System.Linq;

class CoinFlip
{
    static void Main()
    {
        int triesSize = 100000;
        int sampleSize = 100;
        int repReachedCounter = 0;
        int repDesired = 7;


        for (int t = 0; t < triesSize; t++)
        {
            int repetition = 0;
            bool coinTypeRep = flipCoin();


            for (int s = 0; s < sampleSize - 1; s++)
            {
                bool coinType = flipCoin();
                if (coinTypeRep == coinType) repetition++;
                else { repetition = 0; coinTypeRep = coinType; }
                if (repetition == repDesired) repReachedCounter++;
            }
        }
        System.Console.WriteLine($"{repReachedCounter}/{triesSize} => {(double)(repReachedCounter) / (double)(triesSize) * 100}%");


    }

    static bool flipCoin()
    {
        Random r = new Random();
        int rand = r.Next(0, 2);
        if (rand == 1) return true;
        return false;
    }
}
