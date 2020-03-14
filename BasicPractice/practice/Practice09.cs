using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BasicPractice.practice
{
    /**  
    <summary>
    問題 for文(ネスト)/if文
        for文を使用して九九の計算結果を出力する。
        (数字と数字に間にはスペースを入れる)
        ただし、1の段は計算結果を1つまで、2の段は2つまで...と九九の段の対象の数だけ九九の結果を出力する
    </summary>
   */
    class Practice09 : Practice
    {

        public override void OutputImage()
        {
            StartImgae();
            Debug.WriteLine("1 ");
            Debug.WriteLine("2 4 ");
            Debug.WriteLine("3 6 9 ");
            Debug.WriteLine("4 8 12 16 ");
            Debug.WriteLine("5 10 15 20 25 ");
            Debug.WriteLine("6 12 18 24 30 36 ");
            Debug.WriteLine("7 14 21 28 35 42 49 ");
            Debug.WriteLine("8 16 24 32 40 48 56 64 ");
            Debug.WriteLine("9 18 27 36 45 54 63 72 81 ");
            EndImage();
        }

        public override void Solve()
        {
        }
    }
}
