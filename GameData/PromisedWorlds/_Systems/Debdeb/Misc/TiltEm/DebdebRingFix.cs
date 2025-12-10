using System.IO;
using UnityEngine;

namespace PromisedWorldsDebdebRingTilt
{
    [KSPAddon(KSPAddon.Startup.Instantly, false)]
    public class PromisedWorldsDebdebRingTilt : MonoBehaviour
    {
        public void Start()
        {
            if (Directory.Exists(Path.Combine(KSPUtil.ApplicationRootPath,"GameData/TiltEm")))
            {
                File.WriteAllText(Path.Combine(KSPUtil.ApplicationRootPath, "GameData/PromisedWorlds/_Systems/Debdeb/ScaledDecorator/DebDebDisk.cfg"), "ScaledDecoratorObject\r\n{\r\n    assetBundle = PromisedWorlds/_Systems/Debdeb/ScaledDecorator/DebbyDisk.unity3d\r\n    prefab = DebbyDisk3\r\n    parent = Debdeb\r\n    rotatesWithParent = false\r\n    rotation = 25,0,0\r\n    rotationSpeed = 0,0,0\r\n    localPosition = 0,0,0\r\n    scale = 380000, 380000, 380000\r\n}");
            }
        }
    }
}
