using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BasicPractice.practice
{
    /**  
    <summary>
    課題 for文/if文 
        for文を使用してint配列arrayの中身をインデックスの順番通りに出力する
        ただし、対象インデックスの値が3だった場合出力しない(for文は中断しない)
    </summary>
   */
    class Practice06 : Practice
    {
        int[] array = new int[] { 9, 2, 6, 1, 3, 8, 4, 5, 7 };

        public override void OutputImage()
        {
            StartImgae();
            Debug.WriteLine("92618457");
            EndImage();
        }

        public override void Solve()
        {
        }
    }
}
