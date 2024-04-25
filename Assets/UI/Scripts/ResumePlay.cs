using Doodle.Utils;
using UnityEngine;

namespace Doodle.UI
{
    internal class ResumePlay : Action
    {
        [SerializeField] private RectTransform _pauseScreen;
        [SerializeField] private RectTransform _playScreen;

        [SerializeField] private Transform _player;
        public override void Execute()
        {
            _pauseScreen.gameObject.SetActive(false);
            _playScreen.gameObject.SetActive(true);

            _player.gameObject.SetActive(true);
        }
    }
}
