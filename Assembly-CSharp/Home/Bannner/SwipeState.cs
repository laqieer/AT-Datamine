// Decompiled with JetBrains decompiler
// Type: Home.Bannner.SwipeState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Home.Bannner
{
  [Token(Token = "0x2000B8C")]
  internal class SwipeState
  {
    [Token(Token = "0x4003497")]
    [FieldOffset(Offset = "0x10")]
    private SwipeState.Axis axis;
    [Token(Token = "0x4003498")]
    [FieldOffset(Offset = "0x14")]
    private Vector2 dragBeginPos;
    [Token(Token = "0x4003499")]
    [FieldOffset(Offset = "0x1C")]
    private Vector2 dragEndPos;
    [Token(Token = "0x400349A")]
    [FieldOffset(Offset = "0x24")]
    private float thleshold;

    [Token(Token = "0x17000992")]
    private int AxisToIndex
    {
      [Token(Token = "0x60041D4"), Address(RVA = "0x2A32068", Offset = "0x2A32068", VA = "0x2A32068")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000993")]
    private float delta
    {
      [Token(Token = "0x60041D5"), Address(RVA = "0x2A32078", Offset = "0x2A32078", VA = "0x2A32078")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x60041D6")]
    [Address(RVA = "0x2A30BF4", Offset = "0x2A30BF4", VA = "0x2A30BF4")]
    public SwipeState(SwipeState.Axis axis)
    {
    }

    [Token(Token = "0x60041D7")]
    [Address(RVA = "0x2A320A8", Offset = "0x2A320A8", VA = "0x2A320A8")]
    public void SetThleshold(float thleshold)
    {
    }

    [Token(Token = "0x60041D8")]
    [Address(RVA = "0x2A320B0", Offset = "0x2A320B0", VA = "0x2A320B0")]
    public void SetAxis(SwipeState.Axis axis)
    {
    }

    [Token(Token = "0x60041D9")]
    [Address(RVA = "0x2A320B8", Offset = "0x2A320B8", VA = "0x2A320B8")]
    public void BeginDrag(Vector2 pos)
    {
    }

    [Token(Token = "0x60041DA")]
    [Address(RVA = "0x2A320C0", Offset = "0x2A320C0", VA = "0x2A320C0")]
    public void EndDrag(Vector2 pos)
    {
    }

    [Token(Token = "0x60041DB")]
    [Address(RVA = "0x2A31084", Offset = "0x2A31084", VA = "0x2A31084")]
    public void Clear()
    {
    }

    [Token(Token = "0x60041DC")]
    [Address(RVA = "0x2A31C0C", Offset = "0x2A31C0C", VA = "0x2A31C0C")]
    public SwipeState.SwipeStateType GetSwipeState() => new SwipeState.SwipeStateType();

    [Token(Token = "0x2000B8D")]
    public enum SwipeStateType
    {
      [Token(Token = "0x400349C")] None,
      [Token(Token = "0x400349D")] Right,
      [Token(Token = "0x400349E")] Left,
    }

    [Token(Token = "0x2000B8E")]
    public enum Axis
    {
      [Token(Token = "0x40034A0")] Horizontal,
      [Token(Token = "0x40034A1")] Vertical,
    }
  }
}
