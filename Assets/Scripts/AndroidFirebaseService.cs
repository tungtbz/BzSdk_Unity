using UnityEngine;

namespace DefaultNamespace
{
    public class AndroidFirebaseService : PersistentSingleton<AndroidFirebaseService>
    {
        public void LogEventOpenApp()
        {
            using AndroidJavaClass javaBridge = new AndroidJavaClass("com.bz.lib.AndroidBridge");
            javaBridge.CallStatic("LogEventOpenApp");
        }
    }
}