// Decompiled with JetBrains decompiler
// Type: Story.Prop.PropClipElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Animation;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Story.Prop
{
  [Token(Token = "0x2000664")]
  [Serializable]
  public class PropClipElement
  {
    [Token(Token = "0x4001EFF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private AnimationClip clip;
    [Token(Token = "0x4001F00")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private AnimationClipParam clipParam;
    [Token(Token = "0x4001F01")]
    [FieldOffset(Offset = "0x20")]
    [Range(0.0f, 1f)]
    [SerializeField]
    private float weight;

    [Token(Token = "0x1700054E")]
    public AnimationClip Clip
    {
      [Token(Token = "0x60024B0"), Address(RVA = "0x2F33A24", Offset = "0x2F33A24", VA = "0x2F33A24")] get
      {
        return (AnimationClip) null;
      }
      [Token(Token = "0x60024B1"), Address(RVA = "0x2F33A2C", Offset = "0x2F33A2C", VA = "0x2F33A2C")] set
      {
      }
    }

    [Token(Token = "0x1700054F")]
    public AnimationClipParam ClipParam
    {
      [Token(Token = "0x60024B2"), Address(RVA = "0x2F33A34", Offset = "0x2F33A34", VA = "0x2F33A34")] get
      {
        return (AnimationClipParam) null;
      }
      [Token(Token = "0x60024B3"), Address(RVA = "0x2F33A3C", Offset = "0x2F33A3C", VA = "0x2F33A3C")] set
      {
      }
    }

    [Token(Token = "0x17000550")]
    public float Weight
    {
      [Token(Token = "0x60024B4"), Address(RVA = "0x2F33A44", Offset = "0x2F33A44", VA = "0x2F33A44")] get
      {
        return new float();
      }
      [Token(Token = "0x60024B5"), Address(RVA = "0x2F33A4C", Offset = "0x2F33A4C", VA = "0x2F33A4C")] set
      {
      }
    }

    [Token(Token = "0x60024B6")]
    [Address(RVA = "0x2F33A68", Offset = "0x2F33A68", VA = "0x2F33A68")]
    public PropClipElement()
    {
    }
  }
}
