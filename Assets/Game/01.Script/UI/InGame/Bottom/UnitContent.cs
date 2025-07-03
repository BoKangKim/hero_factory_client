using System.Collections;
using System.Collections.Generic;
using Game.Const;
using Game.Factory;
using Game.Manager;
using Game.MVP;
using Game.Util;
using UnityEngine;
using UnityEngine.UI;

namespace Game.UI
{
    public class UnitContent : Content
    {
        [SerializeField] private Button summonTestButton;

        public override void Init()
        {
            summonTestButton.onClick.RemoveAllListeners();
            summonTestButton.onClick.AddListener(() =>
            {
                UnitFactory factory = ManagerTable.FactoryContainer.RegisterOrGet<UnitFactory>();
                factory.Create(UnitType.Standard.ToString(), Vector3.zero, Quaternion.identity);
            });

            summonTestButton.interactable = false;

            ClickPresenter clickPresenter = ManagerTable.PresenterContainer.GetPresenter<ClickPresenter>();
            clickPresenter.onChangeData += OnChangeClick;
        }

        public void OnChangeClick(IModelData data)
        {
            if ((data as ClickModelData).ClickCount < 5)
            {
                summonTestButton.interactable = false;
            }
            else
            {
                summonTestButton.interactable = true;
            }
        }
    }
}