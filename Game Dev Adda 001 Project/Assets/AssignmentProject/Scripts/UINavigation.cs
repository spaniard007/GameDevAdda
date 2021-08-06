using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UINavigation : MonoBehaviour
{
    private ShuffleManager shuffleManager;

    void Start()
    {
        shuffleManager = GetComponent<ShuffleManager>();
    }

    public void ShuffleButtonPress()
    {
        shuffleManager.ShuffleTopic();
        shuffleManager.ShufflePerson();
    }
}
