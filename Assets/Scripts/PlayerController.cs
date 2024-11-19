using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    public float TorqueAmount = 1f;

    [SerializeField]
    public float BaseSpeed = 15f;

    [SerializeField]
    public float BoostSpeed = 30f;

    private Rigidbody2D _rb;
    private SurfaceEffector2D _surfaceEffector2D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _surfaceEffector2D = FindAnyObjectByType<SurfaceEffector2D>();
    }

    void Update()
    {
        RotatePlayer();
        BoostPlayer();
    }

    private void RotatePlayer()
    {
        var torqueValue = TorqueAmount;

        if (Input.GetKey(KeyCode.A))
        {
            _rb.AddTorque(torqueValue);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _rb.AddTorque(-torqueValue);
        }
    }

    private void BoostPlayer()
    {
        var currentSpeed = _surfaceEffector2D.speed;

        if (Input.GetKey(KeyCode.W) && currentSpeed < BoostSpeed)
        {
            _surfaceEffector2D.speed = BoostSpeed;
            return;
        }

        if (currentSpeed > BaseSpeed)
        {
            _surfaceEffector2D.speed = BaseSpeed;
        }
    }
}
