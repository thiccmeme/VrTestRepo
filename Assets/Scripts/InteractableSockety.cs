using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InteractableSockety : MonoBehaviour
{

    public bool isLight = false;

    public FlashLight FlashLight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSocketActivated(SelectEnterEventArgs args)
    {
        FlashLight.ToggleLight();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Col");

        if (other.CompareTag("Light"))
        {
            isLight = true;
        }
    }
}
