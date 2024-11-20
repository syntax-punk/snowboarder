using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField]
    float RestartDelay = 1f;

    [SerializeField]
    ParticleSystem CrashEffect;

    private void Start()
    {
        if (CrashEffect == null)
        {
            Debug.LogWarning("CrashEffect is not assigned. Trying to find it in children.");
            CrashEffect = GetComponentInChildren<ParticleSystem>();

            if (CrashEffect == null)
            {
                Debug.LogError("CrashEffect is not assigned and not found in children.");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
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
