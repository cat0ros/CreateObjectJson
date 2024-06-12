using System;
using TMPro;
using UnityEngine;
using System.Linq;

public class HatDropdown : MonoBehaviour {
    [SerializeField]
    private TMP_Dropdown dropdown;

    [SerializeField]
    private HatVisualiser hatVisualiser;

    private void Awake() {
        if (hatVisualiser == null){
            throw new ArgumentNullException(nameof(hatVisualiser));
        }

        if (dropdown == null){
            throw new ArgumentNullException(nameof(dropdown));
        }

        var hatsNames = hatVisualiser.GetHats().Select(hat => hat.NameHat).ToList();

        dropdown.ClearOptions();
        dropdown.AddOptions(hatsNames);
    }
}