﻿using System;
using System.Text;

namespace MEncrypt_Commonly_implementation
{
    class Program
    {
        static void Main()
        {
            //to crack password we need 263130836933693530167218012160000000 possible state
            // you need 100 years  to crack password with  83438241036813016922633819 operation/second speed
            // if you are not genious :D

            var enc =
                new MEncrypter(
                //"21F8364BD9E801EB22889E259B1DF5C532157BF9185E974E5A740DB84168BB1AEFBA16AB276406E53093D3EA9684A8D033CB85DC0C8AADC362E9F267D749AAB9CA8037DF084DA1CD0F8FC97F82A6B1D2C63D816DDEDB0B600E5047396C9C10E2E41B231353C0C4E32CB0C875B42B40AF3B209599BC42E0F673CCD1AC026A5D6E7EF1986B879D7A0469A2482A118EA5ED198CFF51036629A43E31927CF717E1B7555BFACF79C72E8D91902F1CF4B3E6E726F09A615F12631EC1FD3F5809001F5CBF89D5A99FD8574A6570B56F440AB67D46B2560576724C43FBDD078BA0D486A378D64552EE353C4FA75914247728F3CE54C23483BE2DFE9471BDECDAFCAE3A38",
                    "Ifg2S9noAesiiJ4lmx31xTIVe/kYXpdOWnQNuEFouxrvuharJ2QG5TCT0+qWhKjQM8uF3AyKrcNi6fJn10mqucqAN98ITaHND4/Jf4KmsdLGPYFt3tsLYA5QRzlsnBDi5BsjE1PAxOMssMh1tCtArzsglZm8QuD2c8zRrAJqXW5+8Zhrh516BGmiSCoRjqXtGYz/UQNmKaQ+MZJ89xfht1Vb+s95xy6NkZAvHPSz5ucm8JphXxJjHsH9P1gJAB9cv4nVqZ/YV0plcLVvRAq2fUayVgV2ckxD+90Hi6DUhqN41kVS7jU8T6dZFCR3KPPOVMI0g74t/pRxveza/K46OA==",
                    MEncrypter.StringFormat.Base64);
            const string str = "Ramin";
            var encr = enc.Encrypt(Encoding.UTF8.GetBytes(str));
            Console.WriteLine(encr);
            Console.ReadKey();
        }
    }
}
