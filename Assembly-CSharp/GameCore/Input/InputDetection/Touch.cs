// Decompiled with JetBrains decompiler
// Type: GameCore.Input.InputDetection.Touch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace GameCore.Input.InputDetection
{
  [Token(Token = "0x2001458")]
  internal class Touch
  {
    [Token(Token = "0x4005DCD")]
    [FieldOffset(Offset = "0x10")]
    private float tapTime;
    [Token(Token = "0x4005DCE")]
    [FieldOffset(Offset = "0x14")]
    private float flickTime;
    [Token(Token = "0x4005DCF")]
    [FieldOffset(Offset = "0x18")]
    private Vector2 startPos;
    [Token(Token = "0x4005DD0")]
    [FieldOffset(Offset = "0x20")]
    private Vector2 prevPos;

    [Token(Token = "0x1700119A")]
    public float TapTime
    {
      [Token(Token = "0x60072B9"), Address(RVA = "0x4051B80", Offset = "0x4051B80", VA = "0x4051B80")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700119B")]
    public float FlickTime
    {
      [Token(Token = "0x60072BA"), Address(RVA = "0x4051B88", Offset = "0x4051B88", VA = "0x4051B88")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700119C")]
    public Vector2 StartPos
    {
      [Token(Token = "0x60072BB"), Address(RVA = "0x4051B90", Offset = "0x4051B90", VA = "0x4051B90")] get
      {
        return new Vector2();
      }
    }

    [Token(Token = "0x1700119D")]
    public Vector2 PrevPos
    {
      [Token(Token = "0x60072BC"), Address(RVA = "0x4051B98", Offset = "0x4051B98", VA = "0x4051B98")] set
      {
      }
      [Token(Token = "0x60072BD"), Address(RVA = "0x4051BA0", Offset = "0x4051BA0", VA = "0x4051BA0")] get
      {
        return new Vector2();
      }
    }

    [Token(Token = "0x60072BE")]
    [Address(RVA = "0x405155C", Offset = "0x405155C", VA = "0x405155C")]
    public Touch()
    {
    }

    [Token(Token = "0x60072BF")]
    [Address(RVA = "0x4051BA8", Offset = "0x4051BA8", VA = "0x4051BA8")]
    public void Clear()
    {
    }

    [Token(Token = "0x60072C0")]
    [Address(RVA = "0x4051BFC", Offset = "0x4051BFC", VA = "0x4051BFC")]
    public void Press(Vector2 pos)
    {
    }

    [Token(Token = "0x60072C1")]
    [Address(RVA = "0x4051C24", Offset = "0x4051C24", VA = "0x4051C24")]
    public void Update(float deltatime)
    {
    }
  }
}
