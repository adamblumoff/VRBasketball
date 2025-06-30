using UnityEngine;

public class HandControllerVisualSwitcher : MonoBehaviour
{
    public GameObject handModel;
    public GameObject controllerModel;

    public void SetHandControllerVisuals(bool showHands)
    {
        if (handModel != null)
        {
            handModel.SetActive(showHands);
        }

        if (controllerModel != null)
        {
            controllerModel.SetActive(!showHands);
        }
    }
}
