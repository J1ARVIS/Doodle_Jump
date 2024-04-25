using Doodle.Utils;
using UnityEngine;

namespace Doodle.UI
{
    internal class StartPlay : Action
    {
        [SerializeField] private RectTransform _mainMenuScreen;
        [SerializeField] private RectTransform _gameOverScreen;
        [SerializeField] private RectTransform _playScreen;

        [SerializeField] private Transform _player;
        public override void Execute()
        {
            _mainMenuScreen.gameObject.SetActive(false);
            _gameOverScreen.gameObject.SetActive(false);
            _playScreen.gameObject.SetActive(true);

            _player.gameObject.SetActive(true);
        }
    }
}
