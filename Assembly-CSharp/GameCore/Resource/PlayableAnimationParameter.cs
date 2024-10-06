// Decompiled with JetBrains decompiler
// Type: GameCore.Resource.PlayableAnimationParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.Resource
{
  [Token(Token = "0x2000CAD")]
  [Serializable]
  public struct PlayableAnimationParameter : IEquatable<PlayableAnimationParameter>
  {
    [Token(Token = "0x4003913")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private string stateName;
    [Token(Token = "0x4003914")]
    [FieldOffset(Offset = "0x8")]
    [SerializeField]
    private AnimationClip animationClip;

    [Token(Token = "0x17000AB1")]
    public string StateName
    {
      [Token(Token = "0x6004920"), Address(RVA = "0x3135078", Offset = "0x3135078", VA = "0x3135078")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000AB2")]
    public AnimationClip AnimationClip
    {
      [Token(Token = "0x6004921"), Address(RVA = "0x3135080", Offset = "0x3135080", VA = "0x3135080")] get
      {
        return (AnimationClip) null;
      }
    }

    [Token(Token = "0x6004922")]
    [Address(RVA = "0x3135088", Offset = "0x3135088", VA = "0x3135088", Slot = "4")]
    private bool System\u002EIEquatable\u003CGameCore\u002EResource\u002EPlayableAnimationParameter\u003E\u002EEquals(
      PlayableAnimationParameter other)
    {
      return new bool();
    }
  }
}
