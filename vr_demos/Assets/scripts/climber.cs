using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class climber : MonoBehaviour
{
    private CharacterController character;
    public static XRController climbingHand;
    private ContinuousMoveProviderBase continuousMoveProviderBase;

  void Start()
    {
        character = GetComponent<CharacterController>();
        continuousMoveProviderBase = GetComponent<ContinuousMoveProviderBase>();
    }
    void FixedUpdate()
    {
        if (climbingHand)
        {
            continuousMoveProviderBase.enabled = false;
            Climb();
        }
        else {
            continuousMoveProviderBase.enabled = true;
        }
    }
    void Climb() 
    {
        InputDevices.GetDeviceAtXRNode(climbingHand.controllerNode).TryGetFeatureValue(CommonUsages.deviceVelocity,out Vector3 velocity);
        character.Move(transform.rotation*-velocity * Time.fixedDeltaTime);
    }
}
