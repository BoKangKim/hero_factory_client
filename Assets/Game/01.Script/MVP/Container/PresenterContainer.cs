using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.MVP
{
    // TODO : 다양한 Presenter를 받을 수 있도록 수정해야 됨
    public class PresenterContainer : MonoBehaviour
    {
        private ClickPresenter clickPresenter = null;

        private void Awake()
        {
            clickPresenter = new ClickPresenter();
            clickPresenter.Generate(new ClickModel(), FindObjectOfType<ClickView>());
        }

        public ClickPresenter GetClickPresenter()
        {
            return clickPresenter;
        }
    }
}