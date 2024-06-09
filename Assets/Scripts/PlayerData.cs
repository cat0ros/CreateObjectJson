using UnityEngine;

public class PlayerData : MonoBehaviour
{
    private float massPlayer = 10f;
    private float heightPlayer = 1f;
    private float widthPlayer = 1f;
    
    private const float minMass = 10f;
    private const float maxMass = 60f;

    private const float heightMin = 1f;
    private const float heightMax = 3f;

    private const float widthMin = 1f;
    private const float widthMax = 3f;


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
