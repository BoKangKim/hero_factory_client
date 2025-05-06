using System.Collections;
using System.Collections.Generic;
using Game.Factory;
using Game.Manager;
using UnityEngine;

public enum UnitType
{
    Basic,
    Special
}

public class SpawnTestCode : MonoBehaviour
{
    private float delay = 1f;

    private float time = 0f;

    private void Update()
    {
        time += Time.deltaTime;

        if(time >= delay)
        {
            time = 0f;
            var factory = ManagerTable.FactoryContainer.RegisterOrGet<UnitFactory>();
            factory.Create(UnitType.Basic.ToString(), Vector3.zero, Quaternion.identity);
        }
    }
}
