using BepInEx;
using System;
using UnityEngine;
namespace FarClipPlane
{
    [BepInPlugin("com.brokenstone.gorillatag.farclipplane", "FarClipPlane", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        void FixedUpdate()
        {
            Camera.main.farClipPlane = 25000;
        }
    }
}
