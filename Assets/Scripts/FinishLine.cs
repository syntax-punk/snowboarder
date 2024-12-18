using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField]
    private float RestartDelay = 1f;

    [SerializeField]
    private ParticleSystem FinishEffect;

    private void Awake()
    {
        if (FinishEffect == null)
        {
            FinishEffect = GetComponentInChildren<ParticleSystem>();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FinishEffect.Play();
            GetComponent<AudioSource>().Play();

            Invoke(nameof(RestartScene), RestartDelay);
        }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(0);
    }
}
