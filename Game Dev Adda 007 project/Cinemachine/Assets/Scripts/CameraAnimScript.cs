using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimScript : MonoBehaviour
{
    bool onChicken;
    public Animator cameraAnimation;
    // Start is called before the first frame update
    void Start()
    {
        onChicken = false;
        cameraAnimation = gameObject.GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if (!onChicken && Input.GetKeyDown(KeyCode.F))
        {
            camNPCtoChicken();
            onChicken = true;
        }
        else if (onChicken && Input.GetKeyDown(KeyCode.F))
        {
            camChickenToNPC();
            Invoke("camTopToNPC", 3);
        }

    }

    public void camTopToNPC()
    {
        Debug.Log("top to chicken");
        cameraAnimation.Play("cameraTop");
    }

    public void camNPCtoChicken()
    {
        Debug.Log("npc to chicken");
        cameraAnimation.Play("cameraChicken");
    }

    public void camChickenToNPC()
    {
        Debug.Log("chicken to npc");
        cameraAnimation.Play("cameraNPC");
    }
}
