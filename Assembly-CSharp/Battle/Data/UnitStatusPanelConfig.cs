// Decompiled with JetBrains decompiler
// Type: Battle.Data.UnitStatusPanelConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x20026EE")]
  [Serializable]
  public class UnitStatusPanelConfig
  {
    [Token(Token = "0x400A67F")]
    [FieldOffset(Offset = "0x10")]
    [Tooltip("ルートオブジェクトのオフセット")]
    [SerializeField]
    private TransformConfig rootOffset;
    [Token(Token = "0x400A680")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Tooltip("HPゲージUIオブジェクトのオフセット")]
    private TransformConfig hpGaugeOffset;
    [Token(Token = "0x400A681")]
    [FieldOffset(Offset = "0x20")]
    [Tooltip("ターゲットアイコンUIオブジェクトのオフセット")]
    [SerializeField]
    private TransformConfig targetIconOffset;
    [Token(Token = "0x400A682")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Tooltip("猛撃UIオブジェクトのオフセット")]
    private TransformConfig fierceCountOffset;

    [Token(Token = "0x170032DD")]
    public TransformConfig RootOffset
    {
      [Token(Token = "0x600F0D6"), Address(RVA = "0x41ABBD4", Offset = "0x41ABBD4", VA = "0x41ABBD4")] get
      {
        return (TransformConfig) null;
      }
    }

    [Token(Token = "0x170032DE")]
    public TransformConfig HpGaugeOffset
    {
      [Token(Token = "0x600F0D7"), Address(RVA = "0x41ABBDC", Offset = "0x41ABBDC", VA = "0x41ABBDC")] get
      {
        return (TransformConfig) null;
      }
    }

    [Token(Token = "0x170032DF")]
    public TransformConfig TargetIconOffset
    {
      [Token(Token = "0x600F0D8"), Address(RVA = "0x41ABBE4", Offset = "0x41ABBE4", VA = "0x41ABBE4")] get
      {
        return (TransformConfig) null;
      }
    }

    [Token(Token = "0x170032E0")]
    public TransformConfig FierceCountOffset
    {
      [Token(Token = "0x600F0D9"), Address(RVA = "0x41ABBEC", Offset = "0x41ABBEC", VA = "0x41ABBEC")] get
      {
        return (TransformConfig) null;
      }
    }

    [Token(Token = "0x600F0DA")]
    [Address(RVA = "0x41ABBF4", Offset = "0x41ABBF4", VA = "0x41ABBF4")]
    public UnitStatusPanelConfig()
    {
    }
  }
}
