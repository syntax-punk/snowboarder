using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField]
    public float MaxX = 65f;

    [SerializeField]
    public float Speed = 10f;

    [SerializeField]
    public float CurrentX = -3f;

    void FixedUpdate()
    {
        CurrentX += Speed * Time.deltaTime;
        transform.position = new Vector3(CurrentX, 0, 0);
    }
}
