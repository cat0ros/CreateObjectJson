using System;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    private string namePlayer;

    private float massPlayer = 10f;
    private float heightPlayer = 1f;
    private float widthPlayer = 1f;
    
    private const float minMass = 10f;
    private const float maxMass = 60f;

    private const float heightMin = 1f;
    private const float heightMax = 3f;

    private const float widthMin = 1f;
    private const float widthMax = 3f;

    private int indexHat;

    public float MassPlayer
    {
        get => massPlayer;
        set => massPlayer = Mathf.Clamp(value, minMass, maxMass);
    }

    public float HeightPlayer {
        get => heightPlayer;
        set {
            heightPlayer = Mathf.Clamp(value, heightMin, heightMax);
        }
    }

    public float WidthPlayer {
        get => widthPlayer;
        set {
            widthPlayer = Mathf.Clamp(value, widthMin, widthMax);
        }
    }

    public int IndexHat {
        get => indexHat;
        set {
            if (value < 0){
                throw new ArgumentOutOfRangeException(nameof(value));
            }

            indexHat = value;
        }
    }
    
    public string Name {
        get => new string(namePlayer);
        set {
            if (string.IsNullOrEmpty(value)) {
                throw new ArgumentNullException(nameof(value));
            }

            namePlayer = value;
        }
    }

    public void AddMass(float massStep)
    {
        MassPlayer += massStep;
    }

    public void MinusMass(float massStep)
    {
        MassPlayer -= massStep;
    }

    public void AddHeight(float heightCoff){
        HeightPlayer = heightCoff;
    }

    public void AddWidth(float widthCoff){
        WidthPlayer = widthCoff;
    }
}
