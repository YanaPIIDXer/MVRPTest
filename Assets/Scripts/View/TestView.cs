using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using System;

namespace View
{
    /// <summary>
    /// Viewのインタフェース
    /// </summary>
    public interface ITestView
    {
        /// <summary>
        /// 値が送信された
        /// </summary>
        IObservable<float> OnValueSend { get; }

        /// <summary>
        /// Textの値を更新
        /// </summary>
        /// <param name="Value">値</param>
        void SetTextValue(float Value);
    }

    /// <summary>
    /// View
    /// </summary>
    public class TestView : MonoBehaviour, ITestView
    {
        /// <summary>
        /// スライダー
        /// </summary>
        [SerializeField]
        private Slider ValueSlider = null;

        /// <summary>
        /// 値を表示するテキスト
        /// </summary>
        [SerializeField]
        private Text ValueText = null;

        /// <summary>
        /// スライダーの値を外に放り投げるボタン
        /// </summary>
        [SerializeField]
        private Button SliderValueSendButton = null;

        /// <summary>
        /// 値が送信された
        /// </summary>
        public IObservable<float> OnValueSend => SliderValueSendButton.OnClickAsObservable()
                                                                .Select((_) => ValueSlider.value);

        /// <summary>
        /// Textの値を設定
        /// </summary>
        /// <param name="Value">値</param>
        public void SetTextValue(float Value)
        {
            ValueText.text = Value.ToString();
        }
    }
}
