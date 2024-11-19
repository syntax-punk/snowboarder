using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField]
    float RestartDelay = 1f;

    [SerializeField]
    ParticleSystem CrashEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            CrashEffect.Play();
            Invoke(nameof(RestartScene), RestartDelay);
        }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(0);
    }
}
