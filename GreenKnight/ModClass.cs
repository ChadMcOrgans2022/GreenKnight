using System;
using System.Collections;
using System.Collections.Generic;
using Modding;
using UnityEngine;
using UObject = UnityEngine.Object;

namespace GreenKnight
{
    public class GreenKnight : Mod
    {
        internal static GreenKnight Instance;

        public override string GetVersion() => "1.0.255.0";

        public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects)
        {
            Log("Initializing");

            Instance = this;

            Log("Initialized");

            ModHooks.HeroUpdateHook += () =>
            {
                HeroController.instance.GetComponent<tk2dSprite>().color = Color.green;
            };
        }
    }
}