using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BasicPractice.practice
{
    /**  
    <summary>
    問題 for文/配列
        for文を使用してint配列arrayの中身をインデックスの逆順に出力する
    </summary>
   */
    class Practice02 : Practice
    {
        int[] array = new int[] { 9, 2, 6, 1, 3, 8, 4, 5, 7 };

        public override void OutputImage()
        {
            StartImgae();
            Debug.WriteLine(string.Join("", array.Reverse()));
            EndImage();
        }

        public override void Solve()
        {
        }
    }
}
