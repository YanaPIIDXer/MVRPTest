using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using View;
using Model;
using Zenject;
using UniRx;
using System;

namespace Presenter
{
    /// <summary>
    /// Presenter
    /// </summary>
    public class TestPresenter : MonoBehaviour
    {
        /// <summary>
        /// View
        /// </summary>
        [Inject]
        private ITestView View = null;

        /// <summary>
        /// Model
        /// </summary>
        [Inject]
        private ITestModel Model = null;

        void Awake()
        {
            View.OnValueSend
                .Select((Value) => Value * 100)
                .Subscribe(Model.SetValue)
                .AddTo(gameObject);

            Model.Value
                .Subscribe(View.SetTextValue)
                .AddTo(gameObject);
        }
    }
}
