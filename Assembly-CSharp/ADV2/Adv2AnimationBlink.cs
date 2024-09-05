// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2AnimationBlink
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E04")]
  [RequireComponent(typeof (Adv2LinkageAnimation))]
  [ExecuteAlways]
  public class Adv2AnimationBlink : MonoBehaviour
  {
    [Token(Token = "0x4010FF0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected Adv2LinkageAnimation targetComponent;
    [Token(Token = "0x4010FF1")]
    [FieldOffset(Offset = "0x20")]
    public Action RequestAction;
    [Token(Token = "0x4010FF2")]
    [FieldOffset(Offset = "0x28")]
    public Action RequestActionCloseEye;
    [Token(Token = "0x4010FF3")]
    [FieldOffset(Offset = "0x30")]
    public Action RequestActionOpenEye;
    [Token(Token = "0x4010FF4")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    protected string linkTag;
    [Token(Token = "0x4010FF5")]
    [FieldOffset(Offset = "0x40")]
    private Adv2AnimationBlink.ForceMode forcePlayMode;
    [Token(Token = "0x4010FF6")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    protected int countMin;
    [Token(Token = "0x4010FF7")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    protected int countMax;
    [Token(Token = "0x4010FF8")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    protected int ContinuousBlink;
    [Token(Token = "0x4010FF9")]
    [FieldOffset(Offset = "0x50")]
    protected bool ContinuousBlinkFlag;
    [Token(Token = "0x4010FFA")]
    [FieldOffset(Offset = "0x54")]
    protected float interval;
    [Token(Token = "0x4010FFB")]
    [FieldOffset(Offset = "0x58")]
    protected float intervalMin;
    [Token(Token = "0x4010FFC")]
    [FieldOffset(Offset = "0x5C")]
    protected float intervalMax;
    [Token(Token = "0x4010FFD")]
    [FieldOffset(Offset = "0x60")]
    protected string playingTag;

    [Token(Token = "0x6018F47")]
    [Address(RVA = "0x2CB3E38", Offset = "0x2CB3E38", VA = "0x2CB3E38")]
    public static Adv2AnimationBlink AddComponent(Adv2LinkageAnimation target)
    {
      return (Adv2AnimationBlink) null;
    }

    [Token(Token = "0x6018F48")]
    [Address(RVA = "0x2CB3F08", Offset = "0x2CB3F08", VA = "0x2CB3F08")]
    public void ForceEyeSync(string syncTag)
    {
    }

    [Token(Token = "0x6018F49")]
    [Address(RVA = "0x2CB4208", Offset = "0x2CB4208", VA = "0x2CB4208")]
    public void ResetForcePlayMode()
    {
    }

    [Token(Token = "0x6018F4A")]
    [Address(RVA = "0x2CB4214", Offset = "0x2CB4214", VA = "0x2CB4214")]
    protected void SetInterval()
    {
    }

    [Token(Token = "0x6018F4B")]
    [Address(RVA = "0x2CB4288", Offset = "0x2CB4288", VA = "0x2CB4288")]
    public void SetInterval(string tag, int minValue, int maxValue)
    {
    }

    [Token(Token = "0x6018F4C")]
    [Address(RVA = "0x2CB4348", Offset = "0x2CB4348", VA = "0x2CB4348")]
    private void Awake()
    {
    }

    [Token(Token = "0x6018F4D")]
    [Address(RVA = "0x2CB434C", Offset = "0x2CB434C", VA = "0x2CB434C")]
    private void Update()
    {
    }

    [Token(Token = "0x6018F4E")]
    [Address(RVA = "0x2CB42C4", Offset = "0x2CB42C4", VA = "0x2CB42C4")]
    private void CheckCountValue()
    {
    }

    [Token(Token = "0x6018F4F")]
    [Address(RVA = "0x2CB3FF0", Offset = "0x2CB3FF0", VA = "0x2CB3FF0")]
    private void Blink()
    {
    }

    [Token(Token = "0x6018F50")]
    [Address(RVA = "0x2CB40B0", Offset = "0x2CB40B0", VA = "0x2CB40B0")]
    private void CloseEye()
    {
    }

    [Token(Token = "0x6018F51")]
    [Address(RVA = "0x2CB415C", Offset = "0x2CB415C", VA = "0x2CB415C")]
    private void OpenEye()
    {
    }

    [Token(Token = "0x6018F52")]
    [Address(RVA = "0x2CB4924", Offset = "0x2CB4924", VA = "0x2CB4924")]
    public Adv2AnimationBlink()
    {
    }

    [Token(Token = "0x2003E05")]
    private enum ForceMode
    {
      [Token(Token = "0x4010FFF")] Close,
      [Token(Token = "0x4011000")] Open,
      [Token(Token = "0x4011001")] Auto,
    }
  }
}
