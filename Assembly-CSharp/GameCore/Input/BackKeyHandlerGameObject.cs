// Decompiled with JetBrains decompiler
// Type: GameCore.Input.BackKeyHandlerGameObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.Input
{
  [Token(Token = "0x200144C")]
  public class BackKeyHandlerGameObject : BackKeyHandlerBase
  {
    [Token(Token = "0x4005D6D")]
    [FieldOffset(Offset = "0x20")]
    private readonly GameObject gameObject;

    [Token(Token = "0x1700117E")]
    public override bool IsActive
    {
      [Token(Token = "0x6007247"), Address(RVA = "0x404E4DC", Offset = "0x404E4DC", VA = "0x404E4DC", Slot = "10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700117F")]
    public override bool IsNull
    {
      [Token(Token = "0x6007248"), Address(RVA = "0x404E544", Offset = "0x404E544", VA = "0x404E544", Slot = "11")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007249")]
    [Address(RVA = "0x404E3A0", Offset = "0x404E3A0", VA = "0x404E3A0")]
    public BackKeyHandlerGameObject(GameObject gameObject, Action onBackKey, bool enabled)
    {
    }

    [Token(Token = "0x600724A")]
    [Address(RVA = "0x404E528", Offset = "0x404E528", VA = "0x404E528")]
    private bool IsVisible() => new bool();
  }
}
