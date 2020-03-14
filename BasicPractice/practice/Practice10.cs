using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BasicPractice.practice
{
    /**  
    <summary>
    問題 for文(ネスト)/多次元配列
        for文を使用してint配列arrayの中身をインデックスの順番通りに出力する
    </summary>
   */
    class Practice10 : Practice
    {
        int[,] array = new int[,] {{ 1,2,3 },{ 4,5, 6 } ,{ 7,8,9}};

        public override void OutputImage()
        {
            StartImgae();
            Debug.WriteLine("123456789");
            EndImage();
        }

        public override void Solve()
        {
           
        }
    }
}
