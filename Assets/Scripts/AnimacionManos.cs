using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class AnimacionManos : MonoBehaviour
{
    public InputActionProperty pincharAnimationAction;
    public InputActionProperty agarrarAnimationAction;
    public Animator handAnim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pincharAnimationAction.action.ReadValue<float>();
        handAnim.SetFloat("Trigger", triggerValue);

        float gripValue = agarrarAnimationAction.action.ReadValue<float>();
        handAnim.SetFloat("Grip", gripValue);

    }
}
