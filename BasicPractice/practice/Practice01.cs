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
        for文を使用してint配列arrayの中身をインデックスの順番通りに出力する
    </summary>
   */
    class Practice01 : Practice
    {
        int[] array = new int[] { 9,2,6,1,3,8,4,5,7 };

        public override void OutputImage()
        {
            StartImgae();
            Debug.WriteLine(string.Join("",array));
            EndImage();
        }

        public override void Solve()
        {
        }
    }
}
