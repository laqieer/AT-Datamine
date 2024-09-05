// Decompiled with JetBrains decompiler
// Type: WindAnimation.WindAnimationController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace WindAnimation
{
  [Token(Token = "0x2003F11")]
  public class WindAnimationController : MonoBehaviour
  {
    [Token(Token = "0x4011468")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private WindManager windManager;
    [Token(Token = "0x4011469")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string windManagerTagName;
    [Token(Token = "0x401146A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private WindAnimationController.SettingType settingType;
    [Token(Token = "0x401146B")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private float offsetTime;
    [Token(Token = "0x401146C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private int interpolationFrame;
    [Token(Token = "0x401146D")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private int priority;
    [Token(Token = "0x401146E")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private bool animationLoop;
    [Token(Token = "0x401146F")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<string> targetModelNames;
    [Token(Token = "0x4011470")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private WindCommonParameter.WindMode mode;
    [Token(Token = "0x4011471")]
    [FieldOffset(Offset = "0x4C")]
    [Range(0.0f, 1f)]
    [SerializeField]
    private float directionCoefficient;
    [Token(Token = "0x4011472")]
    [FieldOffset(Offset = "0x50")]
    [HideInInspector]
    [SerializeField]
    private float normalizedTime;
    [Token(Token = "0x4011473")]
    [FieldOffset(Offset = "0x54")]
    [HideInInspector]
    [SerializeField]
    private float windPower;
    [Token(Token = "0x4011474")]
    [FieldOffset(Offset = "0x58")]
    private Vector3 gravity;
    [Token(Token = "0x4011475")]
    [FieldOffset(Offset = "0x64")]
    private Vector3 direction;
    [Token(Token = "0x4011476")]
    [FieldOffset(Offset = "0x70")]
    private bool isPlay;
    [Token(Token = "0x4011477")]
    [FieldOffset(Offset = "0x78")]
    private Animation animationComponent;
    [Token(Token = "0x4011478")]
    [FieldOffset(Offset = "0x80")]
    private bool isActiveAnimComponent;
    [Token(Token = "0x4011479")]
    [FieldOffset(Offset = "0x88")]
    private string animName;
    [Token(Token = "0x401147A")]
    [FieldOffset(Offset = "0x90")]
    private ParticleSystem particleComponent;
    [Token(Token = "0x401147B")]
    [FieldOffset(Offset = "0x98")]
    private int timeLineAnimCnt;
    [Token(Token = "0x401147C")]
    [FieldOffset(Offset = "0x9C")]
    private Quaternion prevRotation;
    [Token(Token = "0x401147D")]
    [FieldOffset(Offset = "0xAC")]
    private bool gravityOverWriteEnable;
    [Token(Token = "0x401147E")]
    [FieldOffset(Offset = "0xB0")]
    private float prevWindPower;
    [Token(Token = "0x401147F")]
    [FieldOffset(Offset = "0xB8")]
    private WindPowerParameterRange windPowerParamRange;
    [Token(Token = "0x4011480")]
    [FieldOffset(Offset = "0xC0")]
    private WindCommonParameter updateParameter;
    [Token(Token = "0x4011481")]
    [FieldOffset(Offset = "0xC8")]
    private UnityAction<List<string>, WindCommonParameter> registWindParameterEvent;

    [Token(Token = "0x60197AF")]
    [Address(RVA = "0x3742E50", Offset = "0x3742E50", VA = "0x3742E50")]
    public bool SetWindParameterEvent(
      UnityAction<List<string>, WindCommonParameter> windParameterEvent)
    {
      return new bool();
    }

    [Token(Token = "0x60197B0")]
    [Address(RVA = "0x3742E6C", Offset = "0x3742E6C", VA = "0x3742E6C")]
    public void PlayWindAnimation()
    {
    }

    [Token(Token = "0x60197B1")]
    [Address(RVA = "0x3742F48", Offset = "0x3742F48", VA = "0x3742F48")]
    public void StopWindAnimation()
    {
    }

    [Token(Token = "0x60197B2")]
    [Address(RVA = "0x3742FDC", Offset = "0x3742FDC", VA = "0x3742FDC")]
    private void Start()
    {
    }

    [Token(Token = "0x60197B3")]
    [Address(RVA = "0x3743704", Offset = "0x3743704", VA = "0x3743704")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x60197B4")]
    [Address(RVA = "0x3743794", Offset = "0x3743794", VA = "0x3743794")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60197B5")]
    [Address(RVA = "0x3743838", Offset = "0x3743838", VA = "0x3743838")]
    private void Update()
    {
    }

    [Token(Token = "0x60197B6")]
    [Address(RVA = "0x3743DB8", Offset = "0x3743DB8", VA = "0x3743DB8")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x60197B7")]
    [Address(RVA = "0x37433AC", Offset = "0x37433AC", VA = "0x37433AC")]
    private bool FindWindManager() => new bool();

    [Token(Token = "0x60197B8")]
    [Address(RVA = "0x37434C0", Offset = "0x37434C0", VA = "0x37434C0")]
    private void SetWindParameterEvent()
    {
    }

    [Token(Token = "0x60197B9")]
    [Address(RVA = "0x37435FC", Offset = "0x37435FC", VA = "0x37435FC")]
    private bool InitializeAnimationData() => new bool();

    [Token(Token = "0x60197BA")]
    [Address(RVA = "0x3743F44", Offset = "0x3743F44", VA = "0x3743F44")]
    private static IEnumerator Delay(float waitTime, Action callback) => (IEnumerator) null;

    [Token(Token = "0x60197BB")]
    [Address(RVA = "0x3742E90", Offset = "0x3742E90", VA = "0x3742E90")]
    private void StartAnimation()
    {
    }

    [Token(Token = "0x60197BC")]
    [Address(RVA = "0x3743D5C", Offset = "0x3743D5C", VA = "0x3743D5C")]
    private void SetAnimation()
    {
    }

    [Token(Token = "0x60197BD")]
    [Address(RVA = "0x3743FE4", Offset = "0x3743FE4", VA = "0x3743FE4")]
    public WindAnimationController()
    {
    }

    [Token(Token = "0x2003F12")]
    private enum SettingType
    {
      [Token(Token = "0x4011483")] Scene,
      [Token(Token = "0x4011484")] TimeLine,
      [Token(Token = "0x4011485")] Effect,
    }
  }
}
