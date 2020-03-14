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
        ただし、奇数の段とかけ算の結果が5で割り切れるものは出力しない
    </summary>
   */
    class Practice08 : Practice
    {

        public override void OutputImage()
        {
            StartImgae();
            Debug.WriteLine("2 4 6 8 12 14 16 18 ");
            Debug.WriteLine("4 8 12 16 24 28 32 36 ");
            Debug.WriteLine("6 12 18 24 36 42 48 54 ");
            Debug.WriteLine("8 16 24 32 48 56 64 72 ");
            EndImage();
        }

        public override void Solve()
        {
        }
    }
}
