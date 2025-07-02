using System.Collections;
using System.Collections.Generic;
using Game.Util;
using UnityEngine;

namespace Game.MVP
{
    public class PresenterContainer : MonoBehaviour
    {
        private Dictionary<string, IPresenter> presenterDict = new Dictionary<string, IPresenter>();

        private void Awake()
        {
            ClickPresenter clickPresenter = new ClickPresenter();
            clickPresenter.Generate(new ClickModel(), FindObjectOfType<ClickView>());

            MonsterPresenter monsterPresenter = new MonsterPresenter();
            monsterPresenter.Generate(new MonsterModel(), FindObjectOfType<MonsterView>());


            presenterDict.Add(nameof(ClickPresenter), clickPresenter);
            presenterDict.Add(nameof(MonsterPresenter), monsterPresenter);
        }

        public T GetPresenter<T>() where T : class, IPresenter
        {
            IPresenter presenter = null;

            if (presenterDict.TryGetValue(typeof(T).Name, out presenter))
            {
                return presenter as T;
            }
            else
            {
                return null;
            }
        }
    }
}