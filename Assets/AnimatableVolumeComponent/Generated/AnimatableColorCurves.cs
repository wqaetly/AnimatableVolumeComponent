// <auto-generated />

using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace TsukimiNeko.AnimatableVolumeComponent
{
    [AnimatableOf(typeof(UnityEngine.Rendering.Universal.ColorCurves))]
    [DisallowMultipleComponent]
    public class AnimatableColorCurves : AnimatableVolumeComponentBase
    {
        public override Type TargetType { get; } = typeof(UnityEngine.Rendering.Universal.ColorCurves);

        public bool override_master;
        public bool override_red;
        public bool override_green;
        public bool override_blue;
        public bool override_hueVsHue;
        public bool override_hueVsSat;
        public bool override_satVsSat;
        public bool override_lumVsSat;


        private void WriteToVolumeComponent(UnityEngine.Rendering.Universal.ColorCurves volumeComponent)
        {
            if (!volumeComponent) return;

            volumeComponent.active = active;
            volumeComponent.master.overrideState = override_master;
            volumeComponent.red.overrideState = override_red;
            volumeComponent.green.overrideState = override_green;
            volumeComponent.blue.overrideState = override_blue;
            volumeComponent.hueVsHue.overrideState = override_hueVsHue;
            volumeComponent.hueVsSat.overrideState = override_hueVsSat;
            volumeComponent.satVsSat.overrideState = override_satVsSat;
            volumeComponent.lumVsSat.overrideState = override_lumVsSat;

        }

        private void ReadFromVolumeComponent(UnityEngine.Rendering.Universal.ColorCurves volumeComponent)
        {
            if (!volumeComponent) return;

            active = volumeComponent.active;
            override_master = volumeComponent.master.overrideState;
            override_red = volumeComponent.red.overrideState;
            override_green = volumeComponent.green.overrideState;
            override_blue = volumeComponent.blue.overrideState;
            override_hueVsHue = volumeComponent.hueVsHue.overrideState;
            override_hueVsSat = volumeComponent.hueVsSat.overrideState;
            override_satVsSat = volumeComponent.satVsSat.overrideState;
            override_lumVsSat = volumeComponent.lumVsSat.overrideState;

        }

        private void Reset()
        {
            var volume = GetComponent<Volume>();
            if (!volume || !volume.sharedProfile || !volume.sharedProfile.TryGet<UnityEngine.Rendering.Universal.ColorCurves>(out var volumeComponent)) return;

            ReadFromVolumeComponent(volumeComponent);
        }

        public override void WriteToVolumeComponentAndRead()
        {
            if (!volumeHelper.TryGet<UnityEngine.Rendering.Universal.ColorCurves>(out var volumeComponent)) return;

            WriteToVolumeComponent(volumeComponent);
            ReadFromVolumeComponent(volumeComponent);
        }

        public override void ReadFromVolumeComponent()
        {
            if (!volumeHelper.TryGet<UnityEngine.Rendering.Universal.ColorCurves>(out var volumeComponent)) return;

            ReadFromVolumeComponent(volumeComponent);
        }
    }
}
