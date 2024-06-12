using System;
using UnityEngine;

public class Hat : MonoBehaviour, IReadonlyHat {
    [SerializeField]
    private GameObject model;

    [SerializeField]
    private string nameHat;

    public string NameHat {
        get => nameHat.ToLower().Trim();
        set {
            if (string.IsNullOrEmpty(value)) {
                throw new ArgumentNullException(nameof(value));
            }

            nameHat = value.Trim().ToLower();
        }
    }
}