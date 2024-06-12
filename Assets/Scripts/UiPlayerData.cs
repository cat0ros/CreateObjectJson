using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiPlayerData : MonoBehaviour
{
    [SerializeField]
    private PlayerData playerData;

    [SerializeField]
    private HatVisualiser hatVisualiser;

    [SerializeField]
    private TextMeshProUGUI statusMass;

    [SerializeField]
    private Slider heightSlider;

    [SerializeField]
    private Slider widthSlider;

    [SerializeField]
    private TMP_Dropdown hatDropdown;

    [SerializeField]
    private TMP_InputField inputField;

    public void UpdateMassUi()
    {
        statusMass.text = playerData.MassPlayer.ToString();
    }

    public void UpdateSize(){
        heightSlider.value = playerData.HeightPlayer;
        widthSlider.value = playerData.WidthPlayer;
    }

    public void UpdateDropdown(){
        hatDropdown.value = playerData.IndexHat;
        hatVisualiser.SelectHat(playerData.IndexHat);
    }

    public void UpdateNameField(){
        inputField.text = playerData.Name;
    }

    public void UpdateAllData(){
        UpdateMassUi();
        UpdateSize();
        UpdateDropdown();
        UpdateNameField();
    }
}
