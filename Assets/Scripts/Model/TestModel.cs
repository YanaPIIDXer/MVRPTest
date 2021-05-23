using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    /// <summary>
    /// Model
    /// </summary>
    public class TestModel : MonoBehaviour
    {
        /// <summary>
        /// 値をログ表示
        /// </summary>
        /// <param name="Value">ログ表示する値</param>
        private void ShowValue(float Value)
        {
            Debug.Log(string.Format("Value:{0}", Value));
        }
    }
}
