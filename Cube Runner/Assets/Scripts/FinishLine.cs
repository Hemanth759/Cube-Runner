using UnityEngine;

public class FinishLine : MonoBehaviour
{


    private void OnTriggerEnter()
    {
        FindObjectOfType<GameManagerScript>().GameComplete();
    }
}
