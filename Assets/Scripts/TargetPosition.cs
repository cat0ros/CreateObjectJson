using UnityEngine;

public class TargetPosition : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    void Update()
    {
        transform.position = target.position;
    }
}
