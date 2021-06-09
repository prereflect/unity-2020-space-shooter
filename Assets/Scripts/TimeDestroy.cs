using UnityEngine;

public class TimeDestroy : MonoBehaviour
{
    public float DestroyTime = 2f;

    void Start ()
    {
        Destroy(gameObject, DestroyTime);
    }
}
