using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

namespace Model
{
    /// <summary>
    /// Modelのインタフェース
    /// </summary>
    public interface ITestModel
    {
        /// <summary>
        /// 値をセット
        /// </summary>
        /// <param name="NewValue">新しい値</param>
        void SetValue(float NewValue);
    }

    /// <summary>
    /// Model
    /// </summary>
    public class TestModel : MonoBehaviour, ITestModel
    {
        /// <summary>
        /// 値のReactiveProperty
        /// </summary>
        private ReactiveProperty<float> ValueProperty = new ReactiveProperty<float>(0.0f);

        /// <summary>
        /// 値
        /// </summary>
        public IReadOnlyReactiveProperty<float> Value => ValueProperty;

        /// <summary>
        /// 値をセット
        /// </summary>
        /// <param name="NewValue">新しい値</param>
        public void SetValue(float NewValue)
        {
            ValueProperty.Value = NewValue;
        }

        void Awake()
        {
            Value.Subscribe((v) => Debug.Log(v))
                .AddTo(gameObject);
        }
    }
}
