using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicPractice.practice
{
    /**  
   <summary>
   課題インターフェース
   </summary>
   */
    public interface IPractice
    {
        /**  
        <summary>
        解答イメージを出力
        </summary>
        */
        void OutputImage();
        
        /**  
        <summary>
         解答の処理を記述する
        </summary>
        */
        void Solve();
    }
}
