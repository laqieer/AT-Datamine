// Decompiled with JetBrains decompiler
// Type: FacialAnimationSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000226")]
[CreateAssetMenu(menuName = "FacialAnimation/Facial Animation Settings Asset")]
public class FacialAnimationSet : ScriptableObject
{
  [Token(Token = "0x4000CDA")]
  [FieldOffset(Offset = "0x18")]
  public List<FacialAnimationSet.AnimationSet> sets;

  [Token(Token = "0x6000DB4")]
  [Address(RVA = "0x1C87A18", Offset = "0x1C87A18", VA = "0x1C87A18")]
  public FacialAnimationSet()
  {
  }

  [Token(Token = "0x2000227")]
  [Serializable]
  public class BlinkAnimationSet
  {
    [Token(Token = "0x4000CDB")]
    [FieldOffset(Offset = "0x10")]
    public AnimationClip Open;
    [Token(Token = "0x4000CDC")]
    [FieldOffset(Offset = "0x18")]
    public AnimationClip Close;
    [Token(Token = "0x4000CDD")]
    [FieldOffset(Offset = "0x20")]
    public AnimationClip Wink;
    [Token(Token = "0x4000CDE")]
    [FieldOffset(Offset = "0x28")]
    public AnimationClip Normal;

    [Token(Token = "0x6000DB5")]
    [Address(RVA = "0x1C87A94", Offset = "0x1C87A94", VA = "0x1C87A94")]
    public BlinkAnimationSet()
    {
    }
  }

  [Token(Token = "0x2000228")]
  [Serializable]
  public class LipAnimationSet
  {
    [Token(Token = "0x4000CDF")]
    [FieldOffset(Offset = "0x10")]
    public AnimationClip Close1;
    [Token(Token = "0x4000CE0")]
    [FieldOffset(Offset = "0x18")]
    public AnimationClip Close2;
    [Token(Token = "0x4000CE1")]
    [FieldOffset(Offset = "0x20")]
    public AnimationClip Open1;
    [Token(Token = "0x4000CE2")]
    [FieldOffset(Offset = "0x28")]
    public AnimationClip Open2;

    [Token(Token = "0x6000DB6")]
    [Address(RVA = "0x1C87A9C", Offset = "0x1C87A9C", VA = "0x1C87A9C")]
    public LipAnimationSet()
    {
    }
  }

  [Token(Token = "0x2000229")]
  [Serializable]
  public class AnimationSet
  {
    [Token(Token = "0x4000CE3")]
    [FieldOffset(Offset = "0x10")]
    public string Tag;
    [Token(Token = "0x4000CE4")]
    [FieldOffset(Offset = "0x18")]
    public AnimationClip FaceAnimation;
    [Token(Token = "0x4000CE5")]
    [FieldOffset(Offset = "0x20")]
    public FacialAnimationSet.BlinkAnimationSet BlinkAnimationSet;
    [Token(Token = "0x4000CE6")]
    [FieldOffset(Offset = "0x28")]
    public FacialAnimationSet.LipAnimationSet LipAnimationSet;

    [Token(Token = "0x6000DB7")]
    [Address(RVA = "0x1C87AA4", Offset = "0x1C87AA4", VA = "0x1C87AA4")]
    public AnimationSet()
    {
    }
  }
}
