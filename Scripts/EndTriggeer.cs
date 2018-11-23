
using UnityEngine;

public class EndTriggeer : MonoBehaviour {

    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }

}
