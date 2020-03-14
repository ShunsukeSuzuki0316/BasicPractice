using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BasicPractice.practice
{
    /**  
    <summary>
    問題サンプル for文
         for文を使用してint配列arrayの中身をインデックスの順番通りに出力する

        Solveメソッドに解答となるプログラムを入力してください。
        OutputImageメソッドで解答のイメージが出力されます。
    </summary>
   */
    class PracticeSample : Practice
    {
        private int[] array = new int[] {1,2,3,4,5 };
        public override void OutputImage()
        {
            StartImgae();
            Debug.WriteLine(string.Join("", array));
            EndImage();
        }

        public override void Solve()
        {
            for(int i=0; i < array.Length; i++)
            {
                // 改行しないで出力する場合はWriteを使用する
                Write(array[i]);

                // 改行して出力する場合はWriteLineを使用する
                //WriteLine(array[i]);
            }
        }
    }
}
