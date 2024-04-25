using Doodle.Utils;
using UnityEngine;

namespace Doodle.UI
{
    public class IsScreenActiveCondition : Condition
    {
        [SerializeField] private RectTransform _UIScreen;

        public override bool Check()
        {
            return _UIScreen.gameObject.activeSelf;
        }
    }
}
