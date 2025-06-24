using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.MVP
{
    public class PresenterContainer : MonoBehaviour
    {
        private ClickPresenter clickPresenter = null;

        private void Awake()
        {
            clickPresenter = new ClickPresenter();
            clickPresenter.Generate(new ClickModel(), FindObjectOfType<ClickView>());
        }
    }
}