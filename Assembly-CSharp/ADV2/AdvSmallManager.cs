// Decompiled with JetBrains decompiler
// Type: ADV2.AdvSmallManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.Effect;
using GameCore;
using Il2CppDummyDll;
using staq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E02")]
  public class AdvSmallManager : Adv2Object
  {
    [Token(Token = "0x4010FDD")]
    [FieldOffset(Offset = "0xA0")]
    private Dictionary<Adv2Object, Adv2Camera> exclusiveCameraDictionary;
    [Token(Token = "0x4010FDE")]
    [FieldOffset(Offset = "0xA8")]
    private List<Adv2Camera> randomCameraList;
    [Token(Token = "0x4010FDF")]
    [FieldOffset(Offset = "0xB0")]
    private IEnumerator changeRandomCameraCoroutine;
    [Token(Token = "0x4010FE0")]
    [FieldOffset(Offset = "0xB8")]
    private float changeCameraWait;
    [Token(Token = "0x4010FE1")]
    [FieldOffset(Offset = "0xBC")]
    private float changeCameraTime;
    [Token(Token = "0x4010FE2")]
    [FieldOffset(Offset = "0xC0")]
    private int lastRandomCamera;
    [Token(Token = "0x4010FE3")]
    [FieldOffset(Offset = "0xC8")]
    private Adv2Object lastUpCamera;
    [Token(Token = "0x4010FE4")]
    [FieldOffset(Offset = "0xD0")]
    private bool initialFlag;
    [Token(Token = "0x4010FE5")]
    [FieldOffset(Offset = "0xD8")]
    private PostProcessBehaviour depthOfFieldPostProcessBehaviour;
    [Token(Token = "0x4010FE6")]
    [FieldOffset(Offset = "0xE0")]
    private Volume depthOfFieldVolume;
    [Token(Token = "0x4010FE7")]
    [FieldOffset(Offset = "0xE8")]
    private bool dontChangeCameraFlag;
    [Token(Token = "0x4010FE8")]
    private const string depthOfFieldVolumeTypeFullName = "UnityEngine.Rendering.Universal.DepthOfField";
    [Token(Token = "0x4010FE9")]
    private const float defaultDOFGaussianStart = 1f;
    [Token(Token = "0x4010FEA")]
    private const float defaultDOFGaussianEnd = 4f;
    [Token(Token = "0x4010FEB")]
    [FieldOffset(Offset = "0xF0")]
    private AppQualitySettings qualitySettings;
    [Token(Token = "0x4010FEC")]
    [FieldOffset(Offset = "0xF8")]
    private SaveDataManager saveDataManager;

    [Token(Token = "0x6018F26")]
    [Address(RVA = "0x2CB23B0", Offset = "0x2CB23B0", VA = "0x2CB23B0")]
    public static AdvSmallManager Create(string objectName, Transform parent)
    {
      return (AdvSmallManager) null;
    }

    [Token(Token = "0x6018F27")]
    [Address(RVA = "0x2CB2410", Offset = "0x2CB2410", VA = "0x2CB2410")]
    private void Start()
    {
    }

    [Token(Token = "0x6018F28")]
    [Address(RVA = "0x2CB253C", Offset = "0x2CB253C", VA = "0x2CB253C")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6018F29")]
    [Address(RVA = "0x2CB2620", Offset = "0x2CB2620", VA = "0x2CB2620")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6018F2A")]
    [Address(RVA = "0x2CB2638", Offset = "0x2CB2638", VA = "0x2CB2638")]
    private void InitializeDepthOfField()
    {
    }

    [Token(Token = "0x6018F2B")]
    [Address(RVA = "0x2CB28E0", Offset = "0x2CB28E0", VA = "0x2CB28E0")]
    public VolumeProfile GetDepthOfFieldProfile() => (VolumeProfile) null;

    [Token(Token = "0x6018F2C")]
    [Address(RVA = "0x2CB2720", Offset = "0x2CB2720", VA = "0x2CB2720")]
    public void SetFocalLength(float focalLength)
    {
    }

    [Token(Token = "0x6018F2D")]
    [Address(RVA = "0x2CB27D4", Offset = "0x2CB27D4", VA = "0x2CB27D4")]
    public void SetDofActive(bool active)
    {
    }

    [Token(Token = "0x6018F2E")]
    [Address(RVA = "0x2CB2994", Offset = "0x2CB2994", VA = "0x2CB2994")]
    public void InitializePhysicalPropertie()
    {
    }

    [Token(Token = "0x6018F2F")]
    [Address(RVA = "0x2CB2A3C", Offset = "0x2CB2A3C", VA = "0x2CB2A3C")]
    public void RegisterExclusiveCamera(Adv2Camera camera, Adv2Object actor)
    {
    }

    [Token(Token = "0x6018F30")]
    [Address(RVA = "0x2CB2B08", Offset = "0x2CB2B08", VA = "0x2CB2B08")]
    public void ResetExclusiveCamera()
    {
    }

    [Token(Token = "0x6018F31")]
    [Address(RVA = "0x2CB2E10", Offset = "0x2CB2E10", VA = "0x2CB2E10")]
    public void RegisterRandomCamera(Adv2Camera camera)
    {
    }

    [Token(Token = "0x6018F32")]
    [Address(RVA = "0x2CB2EB8", Offset = "0x2CB2EB8", VA = "0x2CB2EB8")]
    public void ResetRandomCamera()
    {
    }

    [Token(Token = "0x6018F33")]
    [Address(RVA = "0x2CB31C8", Offset = "0x2CB31C8", VA = "0x2CB31C8")]
    public void CloseupUpExclusiveCamera(Adv2Object actor)
    {
    }

    [Token(Token = "0x6018F34")]
    [Address(RVA = "0x2CB3544", Offset = "0x2CB3544", VA = "0x2CB3544")]
    private IEnumerator ChangeRandomCameraCoroutine() => (IEnumerator) null;

    [Token(Token = "0x6018F35")]
    [Address(RVA = "0x2CB35D4", Offset = "0x2CB35D4", VA = "0x2CB35D4")]
    private void OffLastUpCamera()
    {
    }

    [Token(Token = "0x6018F36")]
    [Address(RVA = "0x2CB365C", Offset = "0x2CB365C", VA = "0x2CB365C")]
    private void SetChangeCameraTime()
    {
    }

    [Token(Token = "0x6018F37")]
    [Address(RVA = "0x2CB3680", Offset = "0x2CB3680", VA = "0x2CB3680")]
    private void ChangeRandomCamera()
    {
    }

    [Token(Token = "0x6018F38")]
    [Address(RVA = "0x2CB34E8", Offset = "0x2CB34E8", VA = "0x2CB34E8")]
    private void StartChangeRandomCameraCoroutine()
    {
    }

    [Token(Token = "0x6018F39")]
    [Address(RVA = "0x2CB3824", Offset = "0x2CB3824", VA = "0x2CB3824")]
    private void StopChangeRandomCameraCoroutine()
    {
    }

    [Token(Token = "0x6018F3A")]
    [Address(RVA = "0x2CB305C", Offset = "0x2CB305C", VA = "0x2CB305C")]
    private void OffRandomCamera()
    {
    }

    [Token(Token = "0x6018F3B")]
    [Address(RVA = "0x2CB3848", Offset = "0x2CB3848", VA = "0x2CB3848")]
    public void DontCameraOffset(Adv2Object actor)
    {
    }

    [Token(Token = "0x6018F3C")]
    [Address(RVA = "0x2CB3924", Offset = "0x2CB3924", VA = "0x2CB3924")]
    public void DontChangeCamera(bool flag)
    {
    }

    [Token(Token = "0x6018F3D")]
    [Address(RVA = "0x2CB3964", Offset = "0x2CB3964", VA = "0x2CB3964")]
    public void RestartRandomCamera()
    {
    }

    [Token(Token = "0x6018F3E")]
    [Address(RVA = "0x2CB3970", Offset = "0x2CB3970", VA = "0x2CB3970")]
    public bool IsRndCameraActive() => new bool();

    [Token(Token = "0x6018F3F")]
    [Address(RVA = "0x2CB3978", Offset = "0x2CB3978", VA = "0x2CB3978")]
    public Adv2Camera GetCameraByName(string cameraName) => (Adv2Camera) null;

    [Token(Token = "0x6018F40")]
    [Address(RVA = "0x2CB3C8C", Offset = "0x2CB3C8C", VA = "0x2CB3C8C")]
    public AdvSmallManager()
    {
    }
  }
}
