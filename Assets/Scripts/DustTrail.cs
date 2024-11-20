using Unity.VisualScripting;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField]
    ParticleSystem DustPraticles;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Ground"))
        {
            DustPraticles.Play();
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.CompareTag("Ground"))
        {
            DustPraticles.Stop();
        }
    }
}
