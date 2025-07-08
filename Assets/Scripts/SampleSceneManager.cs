using UnityEngine;

public class SampleSceneManager : MonoBehaviour
{
    public void ShowToast()
    {
        UnityToastManager.ShowToast("Hello from Unity!");
    }

    public void ShowAlertDialog()
    {
        UnityAlertDialogManager.ShowAlertDialog(
            "Alert Title",
            "This is an alert message.",
            false,
            "OK"
        );
    }
}
