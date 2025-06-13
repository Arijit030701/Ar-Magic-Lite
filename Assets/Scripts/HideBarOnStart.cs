using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Canvas ARMagicBar;
    // Start is called before the first frame update
    void Start()
    {
        UIButtonHandler.OnUIStartButtonClicked 
            += 
              OnStartButtonClicked;
        UIButtonHandler.OnUIResetButtonClicked 
            += 
               OnResetButtonClicked;
    }

    private void OnStartButtonClicked()
    {
        ARMagicBar.enabled = false;
    }

    private void OnResetButtonClicked()
    {
        ARMagicBar.enabled = true;
    }
   
}
