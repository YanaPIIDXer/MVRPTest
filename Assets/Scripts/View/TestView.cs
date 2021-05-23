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
        /// スライダーの値を外に放り投げるボタン
        /// </summary>
        [SerializeField]
        private Button SliderValueSendButton = null;

        /// <summary>
        /// 値が送信された
        /// </summary>
        public IObservable<float> OnValueSend => SliderValueSendButton.OnClickAsObservable()
                                                                .Select((_) => ValueSlider.value);
    }
}
