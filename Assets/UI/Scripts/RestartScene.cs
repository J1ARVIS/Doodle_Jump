using Doodle.Utils;
using UnityEngine.SceneManagement;

namespace Doodle.UI
{
    internal class RestartScene : Action
    {
        public override void Execute()
        {
            var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex);
        }
    }
}
