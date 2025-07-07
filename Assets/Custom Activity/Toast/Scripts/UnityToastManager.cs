using UnityEngine;

public static class UnityToastManager
{
    public static void ShowToast(string message, int duration = 1)
    {
#if UNITY_ANDROID
        AndroidJavaClass unityPlayer = new("com.unity3d.player.UnityPlayer");
        AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");

        AndroidJavaClass toastClass = new("com.melonstudios.toastunity.ToastUnity");
        object[] args = new object[] { currentActivity, message, duration };
        toastClass.Call("ShowToast", args);
#endif
    }
}
