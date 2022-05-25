using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodOnOff : MonoBehaviour
{
    [SerializeField] GameObject BloodOff;
    
    void Start()
    {
        StartCoroutine(SwitchOff());
    }

    void Update()
    {
        StartCoroutine(SwitchOff());
    }

    IEnumerator SwitchOff()
    {
        yield return new WaitForSeconds(0.2f);
        BloodOff.gameObject.SetActive(false);
    }
}
