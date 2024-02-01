using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CustomInteractable : XRGrabInteractable
{
    // Ajustez le point de saisie
    public Transform customAttachTransform;

    // Appelé lorsqu'un objet est saisi
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);

        // Ajustez la position et l'orientation lors du grab
        if (customAttachTransform != null)
        {
            attachTransform = customAttachTransform;
        }
    }
}
