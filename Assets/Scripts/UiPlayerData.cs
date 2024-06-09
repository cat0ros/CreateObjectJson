using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiPlayerData : MonoBehaviour
{
    [SerializeField]
    private PlayerData playerData;

    [SerializeField]
    private TextMeshProUGUI statusMass;

    [SerializeField]
    private Slider heightSlider;

    [SerializeField]
    private Slider widthSlider;

    public void UpdateMassUi()
    {
        statusMass.text = playerData.MassPlayer.ToString();
    }

    public void UpdateSize(){
        heightSlider.value = playerData.HeightPlayer;
        widthSlider.value = playerData.WidthPlayer;
    }

    public void UpdateAllData(){
        UpdateMassUi();
        UpdateSize();
    }
}
