using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    public float torqueAmount = 1f;

    private Rigidbody2D _rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var torqueValue = torqueAmount * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
        {
            _rb.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _rb.AddTorque(-torqueAmount);
        }
    }
}
