using System.Runtime.InteropServices;

namespace FramePush.ReduceMotionPref
{
    public class ReduceMotion
    {
        #if UNITY_IOS
        [DllImport("__Internal")]
        private static extern bool FPRMP_ReduceMotion(); 
        #endif
        
        public static bool Reduce
        {
            get
            {
#if UNITY_EDITOR
                return false;
#elif UNITY_IOS
                return FPRMP_ReduceMotion();
#else
                return false;
#endif
            }
        }
    }
}