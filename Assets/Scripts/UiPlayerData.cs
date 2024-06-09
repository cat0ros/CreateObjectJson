using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UiPlayerData : MonoBehaviour
{
    [SerializeField]
    private PlayerData playerData;

    [SerializeField]
    private TextMeshProUGUI statusMass;

    public void UpdateMassUi()
    {
        statusMass.text = playerData.MassPlayer.ToString();
    }
}
