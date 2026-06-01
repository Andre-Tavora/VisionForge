using UnityEngine;

public class AreaTutorial : MonoBehaviour
{
    public AudioSource audioSource;

    private bool jaExecutou = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !jaExecutou)
        {
            jaExecutou = true;

            audioSource.Play();
        }
    }
}