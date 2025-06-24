using Game.Util;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Game.MVP
{
    public partial class ClickView : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        private ClickPresenter presenter = null;

        public void OnPointerDown(PointerEventData eventData)
        {
            presenter.OnEvent(null);
        }

        public void OnPointerUp(PointerEventData eventData)
        {
        }

        public void Init(ClickPresenter presenter)
        {
            this.presenter = presenter;
        }
    }
}