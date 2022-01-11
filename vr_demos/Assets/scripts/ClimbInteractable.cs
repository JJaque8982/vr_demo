using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ClimbInteractable : XRBaseInteractable
{
    [System.Obsolete]
    protected override void OnSelectEntering(XRBaseInteractor interactor)
    {
        base.OnSelectEntering(interactor);
      
         if (interactor is XRDirectInteractor)
      climber.climbingHand = interactor.GetComponent<XRController>();
    }

    [System.Obsolete]
    protected override void OnSelectExited(XRBaseInteractor interactor)
    {
        base.OnSelectExited(interactor);
 

 if (interactor is XRDirectInteractor)
               if (climber.climbingHand && climber.climbingHand.name == interactor.name) 
               {
                   climber.climbingHand = null;
               }
    }
}
