using Doodle.Utils;
using UnityEngine;

namespace Doodle.UI
{
    internal class ExitGame : Action
    {
        public override void Execute()
        {
            Application.Quit();
        }
    }
}
