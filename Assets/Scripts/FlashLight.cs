using UnityEngine;

public class FlashLight : MonoBehaviour
{

    private bool isOn = false;

    [SerializeField] private MeshRenderer bulb;

    [SerializeField] private GameObject spotLight;

    [SerializeField] private Material lightOn;

    [SerializeField] private Material lightOff;

    public void ToggleLight()
    {
        isOn = !isOn;
        
        spotLight.SetActive(isOn);

        bulb.material = isOn ? lightOn : lightOff;
    }
}
