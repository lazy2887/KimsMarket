using Game.Core.UI;
using Injection;

namespace Game.UI.Hud
{
    public sealed class LevelUpHudMediator : Mediator<LevelUpHudView>
    {
        private const int _reward = 500;

        [Inject] private GameManager _gameManager;

        protected override void Show()
        {
            _view.SetLvl(_gameManager.Model.LoadLvl());
            _view.SetReward(_reward);

            _view.CloseButton.onClick.AddListener(OnCloseButtoClick);
        }

        protected override void Hide()
        {
            _view.CloseButton.onClick.RemoveListener(OnCloseButtoClick);

        }

        private void OnCloseButtoClick()
        {
            _gameManager.Model.Cash += _reward;
            _gameManager.Model.Save();
            _gameManager.Model.SetChanged();

            InternalHide();
        }
    }
}


