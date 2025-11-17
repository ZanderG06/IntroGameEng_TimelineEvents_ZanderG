using UnityEngine;
using UnityEngine.Playables;

public class Trigger : MonoBehaviour
{
    public PlayableDirector timeLine;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trigger"))
        {
            timeLine.Play();
        }
    }
}
