using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace View
{
    /// <summary>
    /// View
    /// </summary>
    public class TestView : MonoBehaviour
    {
        /// <summary>
        /// スライダー
        /// </summary>
        [SerializeField]
        private Slider ValueSlider = null;

        /// <summary>
        /// スライダーの値
        /// </summary>
        [SerializeField]
        private Text SliderValueText = null;

        /// <summary>
        /// スライダーの値を外に放り投げるボタン
        /// </summary>
        [SerializeField]
        private Button SliderValueSendButton = null;
    }
}
