using Doodle.Utils;
using TMPro;
using UnityEngine;

namespace Doodle.UI
{
    internal class CalcPlayScore : Action
    {
        [SerializeField] private TextMeshProUGUI _playScreenScoreCounter;
        [SerializeField] private TextMeshProUGUI _pauseScreenScoreCounter;
        [SerializeField] private TextMeshProUGUI _gameOverScreenScoreCounter;

        [SerializeField] private RectTransform _playScreen;
        [SerializeField] private RectTransform _gameOverScreen;

        [SerializeField] private Transform _player;

        [SerializeField] private int _lostGameOffset;

        private int _scoreCount;

        public override void Execute()
        {
            int currentPlayerPosition = (int)_player.position.y;

            if (_scoreCount - currentPlayerPosition >= _lostGameOffset)
            {
                _playScreen.gameObject.SetActive(false);
                _gameOverScreen.gameObject.SetActive(true);

                _player.gameObject.SetActive(false);

                _gameOverScreenScoreCounter.text = _scoreCount.ToString();
            }
            else if (currentPlayerPosition > _scoreCount) _scoreCount = currentPlayerPosition;

            _playScreenScoreCounter.text = _scoreCount.ToString();
            _pauseScreenScoreCounter.text = _scoreCount.ToString();
        }
    }
}
