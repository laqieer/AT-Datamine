// Decompiled with JetBrains decompiler
// Type: GameCore.Animation.AnimationLayerControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

#nullable disable
namespace GameCore.Animation
{
  [Token(Token = "0x20014DC")]
  [Serializable]
  public class AnimationLayerControl : IChildPlayableAPI
  {
    [Token(Token = "0x4005FED")]
    [FieldOffset(Offset = "0x18")]
    protected AnimationMixerPlayable layerPlayable;
    [Token(Token = "0x4005FEE")]
    [FieldOffset(Offset = "0x28")]
    protected Dictionary<string, AnimationClipControl> clipInfo;

    [Token(Token = "0x17001222")]
    public int ConnectIndex
    {
      [Token(Token = "0x60075AF"), Address(RVA = "0x43F9E2C", Offset = "0x43F9E2C", VA = "0x43F9E2C")] protected set
      {
      }
      [Token(Token = "0x60075B0"), Address(RVA = "0x43F9E34", Offset = "0x43F9E34", VA = "0x43F9E34", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60075B1")]
    [Address(RVA = "0x43F9E3C", Offset = "0x43F9E3C", VA = "0x43F9E3C")]
    public AnimationLayerControl()
    {
    }

    [Token(Token = "0x60075B2")]
    [Address(RVA = "0x43F9EB8", Offset = "0x43F9EB8", VA = "0x43F9EB8")]
    public AnimationLayerControl(
      AnimationLayerMixerPlayable rootPlayable,
      AvatarMask avatarMask,
      float weight,
      bool isAdditive)
    {
    }

    [Token(Token = "0x60075B3")]
    [Address(RVA = "0x43F9F7C", Offset = "0x43F9F7C", VA = "0x43F9F7C")]
    public void Initialize(
      AnimationLayerMixerPlayable rootPlayable,
      AvatarMask avatarMask,
      float weight,
      bool isAdditive)
    {
    }

    [Token(Token = "0x60075B4")]
    [Address(RVA = "0x43FA278", Offset = "0x43FA278", VA = "0x43FA278")]
    public void Clear()
    {
    }

    [Token(Token = "0x60075B5")]
    [Address(RVA = "0x43FA4D0", Offset = "0x43FA4D0", VA = "0x43FA4D0", Slot = "5")]
    public bool IsValid() => new bool();

    [Token(Token = "0x60075B6")]
    [Address(RVA = "0x43FA558", Offset = "0x43FA558", VA = "0x43FA558")]
    public void AddClip(string clipName, AnimationClip clip, bool useIK)
    {
    }

    [Token(Token = "0x60075B7")]
    [Address(RVA = "0x43FA62C", Offset = "0x43FA62C", VA = "0x43FA62C")]
    public void RemoveClip(string clipName)
    {
    }

    [Token(Token = "0x60075B8")]
    [Address(RVA = "0x43FA6EC", Offset = "0x43FA6EC", VA = "0x43FA6EC")]
    public void DirectUpdate(string clipName, float time, float weight)
    {
    }

    [Token(Token = "0x60075B9")]
    [Address(RVA = "0x43FA1CC", Offset = "0x43FA1CC", VA = "0x43FA1CC")]
    private int FindConnectIndex(ref AnimationLayerMixerPlayable rootPlayable) => new int();
  }
}
