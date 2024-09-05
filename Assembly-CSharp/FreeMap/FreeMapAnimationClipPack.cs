// Decompiled with JetBrains decompiler
// Type: FreeMap.FreeMapAnimationClipPack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace FreeMap
{
  [Token(Token = "0x20015EF")]
  public class FreeMapAnimationClipPack : ScriptableObject
  {
    [Token(Token = "0x4006415")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public FreeMapAnimationClipPack BasePack;
    [Token(Token = "0x4006416")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public FreeMapAnimationClipPack.Param[] Animations;

    [Token(Token = "0x6007C2C")]
    [Address(RVA = "0x219F3D0", Offset = "0x219F3D0", VA = "0x219F3D0")]
    public bool TryGetAnimationClip(string tag, out AnimationClip clip, bool ignoreCase = true)
    {
      return new bool();
    }

    [Token(Token = "0x6007C2D")]
    [Address(RVA = "0x219F548", Offset = "0x219F548", VA = "0x219F548")]
    public FreeMapAnimationClipPack()
    {
    }

    [Token(Token = "0x20015F0")]
    [Serializable]
    public class Param
    {
      [Token(Token = "0x4006417")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      public string Tag;
      [Token(Token = "0x4006418")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      public AnimationClip Clip;

      [Token(Token = "0x6007C2E")]
      [Address(RVA = "0x219F550", Offset = "0x219F550", VA = "0x219F550")]
      public Param()
      {
      }
    }
  }
}
