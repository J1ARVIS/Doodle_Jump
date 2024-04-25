using Doodle.Utils;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Doodle.UI
{
    internal class AddButtonClickActions : Action
    {
        [SerializeField] private Button _button;
        [SerializeField] private List<Action> _executeOnButtonClick;

        public override void Execute()
        {
            foreach (var action in _executeOnButtonClick)
            {
                _button.onClick.AddListener(action.Execute);
            }
        }
    }
}
