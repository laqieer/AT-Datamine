// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2AnimationPack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E52")]
  public class Adv2AnimationPack : ScriptableObject
  {
    [Token(Token = "0x40111A0")]
    [FieldOffset(Offset = "0x18")]
    public Adv2AnimationPack BasePack;
    [Token(Token = "0x40111A1")]
    [FieldOffset(Offset = "0x20")]
    public AvatarMask AvatarMask;
    [Token(Token = "0x40111A2")]
    [FieldOffset(Offset = "0x28")]
    public bool IsAddtive;
    [Token(Token = "0x40111A3")]
    [FieldOffset(Offset = "0x30")]
    public List<Adv2AnimationPack.LinkageTag> LinkTagList;
    [Token(Token = "0x40111A4")]
    [FieldOffset(Offset = "0x38")]
    public List<Adv2AnimationPack.LinkageParam> Animations;

    [Token(Token = "0x60191A2")]
    [Address(RVA = "0x2975D68", Offset = "0x2975D68", VA = "0x2975D68")]
    public void GetBaseAnimationTags(List<string> output)
    {
    }

    [Token(Token = "0x60191A3")]
    [Address(RVA = "0x2975FD0", Offset = "0x2975FD0", VA = "0x2975FD0")]
    public AnimationClip GetBaseAnimation(string tag) => (AnimationClip) null;

    [Token(Token = "0x60191A4")]
    [Address(RVA = "0x29761E8", Offset = "0x29761E8", VA = "0x29761E8")]
    public void GetLinkageAnimationTags(List<string> output)
    {
    }

    [Token(Token = "0x60191A5")]
    [Address(RVA = "0x2976450", Offset = "0x2976450", VA = "0x2976450")]
    public void GetLinkageAnimationClipTags(List<string> output, string linkageTag)
    {
    }

    [Token(Token = "0x60191A6")]
    [Address(RVA = "0x2976820", Offset = "0x2976820", VA = "0x2976820")]
    public AnimationClip GetLinkageAnimation(
      AnimationClip baseClip,
      string linkageTag,
      string animationTag)
    {
      return (AnimationClip) null;
    }

    [Token(Token = "0x60191A7")]
    [Address(RVA = "0x2976D20", Offset = "0x2976D20", VA = "0x2976D20")]
    public Adv2AnimationPack()
    {
    }

    [Token(Token = "0x2003E53")]
    [Serializable]
    public class LinkageTag
    {
      [Token(Token = "0x40111A5")]
      [FieldOffset(Offset = "0x10")]
      public string Tag;
      [Token(Token = "0x40111A6")]
      [FieldOffset(Offset = "0x18")]
      public List<string> ClipTags;

      [Token(Token = "0x60191A8")]
      [Address(RVA = "0x2CF0940", Offset = "0x2CF0940", VA = "0x2CF0940")]
      public LinkageTag()
      {
      }
    }

    [Token(Token = "0x2003E54")]
    [Serializable]
    public class Param
    {
      [Token(Token = "0x40111A7")]
      [FieldOffset(Offset = "0x10")]
      public string Tag;
      [Token(Token = "0x40111A8")]
      [FieldOffset(Offset = "0x18")]
      public AnimationClip Clip;

      [Token(Token = "0x60191A9")]
      [Address(RVA = "0x2CF09BC", Offset = "0x2CF09BC", VA = "0x2CF09BC")]
      public Param()
      {
      }
    }

    [Token(Token = "0x2003E55")]
    [Serializable]
    public class LinkageClipParam
    {
      [Token(Token = "0x40111A9")]
      [FieldOffset(Offset = "0x10")]
      public string Tag;
      [Token(Token = "0x40111AA")]
      [FieldOffset(Offset = "0x18")]
      public List<Adv2AnimationPack.Param> Clips;

      [Token(Token = "0x60191AA")]
      [Address(RVA = "0x2CF09C4", Offset = "0x2CF09C4", VA = "0x2CF09C4")]
      public LinkageClipParam()
      {
      }
    }

    [Token(Token = "0x2003E56")]
    [Serializable]
    public class LinkageParam : Adv2AnimationPack.Param
    {
      [Token(Token = "0x40111AB")]
      [FieldOffset(Offset = "0x20")]
      public List<Adv2AnimationPack.LinkageClipParam> Linkage;

      [Token(Token = "0x60191AB")]
      [Address(RVA = "0x2CF09CC", Offset = "0x2CF09CC", VA = "0x2CF09CC")]
      public LinkageParam()
      {
      }
    }
  }
}
