using Doodle.Utils;
using UnityEngine;

namespace Doodle.UI
{
    internal class PausePlay : Action
    {
        [SerializeField] private RectTransform _pauseScreen;
        [SerializeField] private RectTransform _playScreen;

        [SerializeField] private Transform _player;
        public override void Execute()
        {
            _playScreen.gameObject.SetActive(false);
            _pauseScreen.gameObject.SetActive(true);

            _player.gameObject.SetActive(false);
        }
    }
}
