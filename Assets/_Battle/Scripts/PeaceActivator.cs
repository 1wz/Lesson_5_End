using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BattleScripts
{
    class PeaceActivator: IEnemy
    {
        Button _passPeacefullyButton;
        const int maxPeaceRate = 2;
        public PeaceActivator(Button passPeacefullyButton)
        {
            _passPeacefullyButton = passPeacefullyButton;
        }

        public void Update(PlayerData playerData)
        {
            switch (playerData.DataType)
            {
                case DataType.CrimeRate:
                    ChangeCrimeRate(playerData.Value);
                    break;

            }

        }

        private void ChangeCrimeRate(int crimeRateValue)
        {
            if (crimeRateValue > maxPeaceRate) _passPeacefullyButton.gameObject.SetActive(false);
            else _passPeacefullyButton.gameObject.SetActive(true);
        }
    }
    
}
