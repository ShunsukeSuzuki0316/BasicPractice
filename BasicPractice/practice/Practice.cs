using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BasicPractice.practice
{
    abstract class Practice : IPractice
    {
        public abstract void OutputImage();
        public abstract void Solve();

        /**  
         <summary>
         解答出力(改行なし)
         </summary>
        */
        public void Write(object content)
        {
            Debug.Write(content);
        }

        /**  
         <summary>
         解答出力(改行あり)
         </summary>
        */
        public void WriteLine(object content)
        {
            Debug.WriteLine(content);
        }

        /**  
         <summary>
         出力スタート
         </summary>
        */
        public void StartImgae() {
            Debug.WriteLine("");
            Debug.WriteLine("");
            Debug.WriteLine($"------------------------{this.GetType().Name}出力イメージ------------------------");
            Debug.WriteLine("");
        }

        /**  
        <summary>
        出力終了
        </summary>
       */
        public void EndImage()
        {
            Debug.WriteLine("");
            Debug.WriteLine($"--------------------------{this.GetType().Name}ここまで--------------------------");
            Debug.WriteLine("");
            Debug.WriteLine("");
        }
    }
}
