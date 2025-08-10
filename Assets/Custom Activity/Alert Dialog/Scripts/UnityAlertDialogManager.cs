using UnityEngine;

public static class UnityAlertDialogManager
{
    public static void ShowAlertDialog(string title, string message, bool cancelable = true, string actionText = "Cancel")
    {
#if UNITY_ANDROID
        AndroidJavaClass unityPlayer = new("com.unity3d.player.UnityPlayer");
        AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");

        AndroidJavaObject toastClass = new("com.melonstudios.toastunity.ToastUnity");
        object[] args = new object[] { currentActivity, message, 0 };
        toastClass.Call("ShowToast", args);
        // AndroidJavaObject alertDialogClass = new("com.melonstudios.alertdialogunity.AlertDialogUnity");
        // object[] args = new object[] { currentActivity, title, message, cancelable, actionText };
        // alertDialogClass.Call("ShowAlertDialog", args);
#endif
    }
}
