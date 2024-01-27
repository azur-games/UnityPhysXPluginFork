using System.Runtime.InteropServices;
using System.Security;
using UnityEngine;
namespace NVIDIA.PhysX_Samples.API_Samples.Scripts
{
    public class Tester : MonoBehaviour
    {
        public void OnClick()
        {
            Debug.Log($"{NVIDIA.PhysX.Native.PX_PHYSICS_VERSION_MAJOR}");
        }
        
        [DllImport("NVIDIA.PhysX.Native", EntryPoint = "CSharp_NVIDIAfPhysX_PX_PHYSICS_VERSION_MAJOR_get___"), SuppressUnmanagedCodeSecurity]
        public static extern int PX_PHYSICS_VERSION_MAJOR_get();
    }
}
