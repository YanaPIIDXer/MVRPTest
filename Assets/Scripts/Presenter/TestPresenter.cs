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
        private TestView View = null;

        /// <summary>
        /// Model
        /// </summary>
        [Inject]
        private ITestModel Model = null;

        void Awake()
        {
            View = GetComponent<TestView>();
            View.OnValueSend
                .Subscribe(Model.SetValue)
                .AddTo(gameObject);
        }
    }
}
