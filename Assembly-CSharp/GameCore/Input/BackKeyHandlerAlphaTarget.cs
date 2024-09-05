// Decompiled with JetBrains decompiler
// Type: GameCore.Input.BackKeyHandlerAlphaTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.Input
{
  [Token(Token = "0x2001443")]
  public class BackKeyHandlerAlphaTarget : BackKeyHandlerBase
  {
    [Token(Token = "0x4005D5C")]
    [FieldOffset(Offset = "0x20")]
    private readonly GameObject gameObject;
    [Token(Token = "0x4005D5D")]
    [FieldOffset(Offset = "0x0")]
    private static readonly float ActiveAlphaThreshold;
    [Token(Token = "0x4005D5E")]
    [FieldOffset(Offset = "0x28")]
    private Func<float> AlphaGetter;

    [Token(Token = "0x17001174")]
    public override bool IsActive
    {
      [Token(Token = "0x600721F"), Address(RVA = "0x404D784", Offset = "0x404D784", VA = "0x404D784", Slot = "10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001175")]
    public override bool IsNull
    {
      [Token(Token = "0x6007220"), Address(RVA = "0x404D8CC", Offset = "0x404D8CC", VA = "0x404D8CC", Slot = "11")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007221")]
    [Address(RVA = "0x404D92C", Offset = "0x404D92C", VA = "0x404D92C")]
    public BackKeyHandlerAlphaTarget(GameObject gameObject, Action onBackKey, bool enabled)
    {
    }

    [Token(Token = "0x6007222")]
    [Address(RVA = "0x404D9B0", Offset = "0x404D9B0", VA = "0x404D9B0")]
    private void InitializeAlphaGetter()
    {
    }

    [Token(Token = "0x6007223")]
    [Address(RVA = "0x404D7C4", Offset = "0x404D7C4", VA = "0x404D7C4")]
    private bool IsVisible() => new bool();

    [Token(Token = "0x6007224")]
    [Address(RVA = "0x404DD04", Offset = "0x404DD04", VA = "0x404DD04")]
    static BackKeyHandlerAlphaTarget()
    {
    }
  }
}
