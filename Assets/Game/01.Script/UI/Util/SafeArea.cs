using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Util
{
    public class SafeArea : MonoBehaviour
    {
        [Header("변환하고자 하는 Rect 지정하지 않으면 현재 컴포넌트가 달려있는 오브젝트에서 찾음")]
        [SerializeField] private RectTransform rect;

        private Rect safeArea;
        private Vector2 minAnchor;
        private Vector2 maxAnchor;

        private void Awake()
        {
            if (rect == null)
            {
                rect = GetComponent<RectTransform>();
            }

            ApplySafeArea();
        }

        private void ApplySafeArea()
        {
            safeArea = Screen.safeArea;
            minAnchor = safeArea.position;
            maxAnchor = minAnchor + safeArea.size;

            minAnchor.x /= Screen.width;
            minAnchor.y /= Screen.height;
            maxAnchor.x /= Screen.width;
            maxAnchor.y /= Screen.height;

            rect.anchorMin = minAnchor;
            rect.anchorMax = maxAnchor;
        }
    }
}