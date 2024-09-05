// Decompiled with JetBrains decompiler
// Type: GameCore.Input.DoubleTouch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace GameCore.Input
{
  [Token(Token = "0x200144D")]
  internal class DoubleTouch
  {
    [Token(Token = "0x17001180")]
    public bool IsPinchOut
    {
      [Token(Token = "0x600724B"), Address(RVA = "0x404E5A4", Offset = "0x404E5A4", VA = "0x404E5A4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600724C"), Address(RVA = "0x404E5AC", Offset = "0x404E5AC", VA = "0x404E5AC")] set
      {
      }
    }

    [Token(Token = "0x17001181")]
    public DoubleTouch.State Status
    {
      [Token(Token = "0x600724D"), Address(RVA = "0x404E5B8", Offset = "0x404E5B8", VA = "0x404E5B8")] get
      {
        return new DoubleTouch.State();
      }
      [Token(Token = "0x600724E"), Address(RVA = "0x404E5C0", Offset = "0x404E5C0", VA = "0x404E5C0")] set
      {
      }
    }

    [Token(Token = "0x17001182")]
    public Vector2 Distance
    {
      [Token(Token = "0x600724F"), Address(RVA = "0x404E5C8", Offset = "0x404E5C8", VA = "0x404E5C8")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6007250"), Address(RVA = "0x404E5D0", Offset = "0x404E5D0", VA = "0x404E5D0")] set
      {
      }
    }

    [Token(Token = "0x17001183")]
    public Vector2 Vector
    {
      [Token(Token = "0x6007251"), Address(RVA = "0x404E5D8", Offset = "0x404E5D8", VA = "0x404E5D8")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6007252"), Address(RVA = "0x404E5E0", Offset = "0x404E5E0", VA = "0x404E5E0")] set
      {
      }
    }

    [Token(Token = "0x17001184")]
    public Vector2 Center
    {
      [Token(Token = "0x6007253"), Address(RVA = "0x404E5E8", Offset = "0x404E5E8", VA = "0x404E5E8")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6007254"), Address(RVA = "0x404E5F0", Offset = "0x404E5F0", VA = "0x404E5F0")] set
      {
      }
    }

    [Token(Token = "0x17001185")]
    public Vector2 StartVector
    {
      [Token(Token = "0x6007255"), Address(RVA = "0x404E5F8", Offset = "0x404E5F8", VA = "0x404E5F8")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6007256"), Address(RVA = "0x404E600", Offset = "0x404E600", VA = "0x404E600")] private set
      {
      }
    }

    [Token(Token = "0x17001186")]
    public Vector2? StartPinchCenter
    {
      [Token(Token = "0x6007257"), Address(RVA = "0x404E608", Offset = "0x404E608", VA = "0x404E608")] get
      {
        return new Vector2?();
      }
      [Token(Token = "0x6007258"), Address(RVA = "0x404E618", Offset = "0x404E618", VA = "0x404E618")] set
      {
      }
    }

    [Token(Token = "0x6007259")]
    [Address(RVA = "0x404E624", Offset = "0x404E624", VA = "0x404E624")]
    public DoubleTouch()
    {
    }

    [Token(Token = "0x600725A")]
    [Address(RVA = "0x404E6A8", Offset = "0x404E6A8", VA = "0x404E6A8")]
    public void Clear()
    {
    }

    [Token(Token = "0x600725B")]
    [Address(RVA = "0x404E724", Offset = "0x404E724", VA = "0x404E724")]
    public void Press(Vector2 pos)
    {
    }

    [Token(Token = "0x200144E")]
    public enum State
    {
      [Token(Token = "0x4005D76")] None,
      [Token(Token = "0x4005D77")] Began,
      [Token(Token = "0x4005D78")] Moved,
      [Token(Token = "0x4005D79")] Pinchi,
      [Token(Token = "0x4005D7A")] Ended,
    }
  }
}
