using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BasicPractice.practice
{
    /**  
    <summary>
    課題 for文(ネスト)
        for文を使用して九九の計算結果を出力する。
        (数字と数字に間にはスペースを入れる)
    </summary>
   */
    class Practice07 : Practice
    {

        public override void OutputImage()
        {
            StartImgae();
            Debug.WriteLine("1 2 3 4 5 6 7 8 9 ");
            Debug.WriteLine("2 4 6 8 10 12 14 16 18 ");
            Debug.WriteLine("3 6 9 12 15 18 21 24 27 ");
            Debug.WriteLine("4 8 12 16 20 24 28 32 36 ");
            Debug.WriteLine("5 10 15 20 25 30 35 40 45 ");
            Debug.WriteLine("6 12 18 24 30 36 42 48 54 ");
            Debug.WriteLine("7 14 21 28 35 42 49 56 63 ");
            Debug.WriteLine("8 16 24 32 40 48 56 64 72 ");
            Debug.WriteLine("9 18 27 36 45 54 63 72 81 ");
            EndImage();
        }

        public override void Solve()
        {
        }
    }
}
