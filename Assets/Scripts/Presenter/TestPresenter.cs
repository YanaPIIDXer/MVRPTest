using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using View;

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

        void Awake()
        {
            View = GetComponent<TestView>();
        }
    }
}
