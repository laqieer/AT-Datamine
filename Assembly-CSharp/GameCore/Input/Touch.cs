// Decompiled with JetBrains decompiler
// Type: GameCore.Input.Touch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace GameCore.Input
{
  [Token(Token = "0x2001453")]
  internal class Touch
  {
    [Token(Token = "0x4005DB0")]
    [FieldOffset(Offset = "0x10")]
    private float tapTime;
    [Token(Token = "0x4005DB1")]
    [FieldOffset(Offset = "0x14")]
    private float flickTime;
    [Token(Token = "0x4005DB2")]
    [FieldOffset(Offset = "0x18")]
    private Vector2 startPos;
    [Token(Token = "0x4005DB3")]
    [FieldOffset(Offset = "0x20")]
    private Vector2 prevPos;

    [Token(Token = "0x17001194")]
    public float TapTime
    {
      [Token(Token = "0x600729B"), Address(RVA = "0x40511B0", Offset = "0x40511B0", VA = "0x40511B0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001195")]
    public float FlickTime
    {
      [Token(Token = "0x600729C"), Address(RVA = "0x40511B8", Offset = "0x40511B8", VA = "0x40511B8")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001196")]
    public Vector2 StartPos
    {
      [Token(Token = "0x600729D"), Address(RVA = "0x40511C0", Offset = "0x40511C0", VA = "0x40511C0")] get
      {
        return new Vector2();
      }
    }

    [Token(Token = "0x17001197")]
    public Vector2 PrevPos
    {
      [Token(Token = "0x600729E"), Address(RVA = "0x40511C8", Offset = "0x40511C8", VA = "0x40511C8")] set
      {
      }
      [Token(Token = "0x600729F"), Address(RVA = "0x40511D0", Offset = "0x40511D0", VA = "0x40511D0")] get
      {
        return new Vector2();
      }
    }

    [Token(Token = "0x60072A0")]
    [Address(RVA = "0x404EC00", Offset = "0x404EC00", VA = "0x404EC00")]
    public Touch()
    {
    }

    [Token(Token = "0x60072A1")]
    [Address(RVA = "0x40511D8", Offset = "0x40511D8", VA = "0x40511D8")]
    public void Clear()
    {
    }

    [Token(Token = "0x60072A2")]
    [Address(RVA = "0x4050718", Offset = "0x4050718", VA = "0x4050718")]
    public void Press(Vector2 pos)
    {
    }

    [Token(Token = "0x60072A3")]
    [Address(RVA = "0x4050740", Offset = "0x4050740", VA = "0x4050740")]
    public void Update(float deltatime)
    {
    }
  }
}
