// Decompiled with JetBrains decompiler
// Type: staq.Camera.MovePosition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D80")]
  public class MovePosition : Vector3Base
  {
    [Token(Token = "0x4010E19")]
    [FieldOffset(Offset = "0x20")]
    private Vector3 sourcePosition;
    [Token(Token = "0x4010E1A")]
    [FieldOffset(Offset = "0x30")]
    private Vector3Base destinationPosition;
    [Token(Token = "0x4010E1B")]
    [FieldOffset(Offset = "0x38")]
    private float moveTime;
    [Token(Token = "0x4010E1C")]
    [FieldOffset(Offset = "0x3C")]
    private float time;
    [Token(Token = "0x4010E1D")]
    [FieldOffset(Offset = "0x40")]
    private bool timeDirty;

    [Token(Token = "0x6018BDA")]
    [Address(RVA = "0x2647BBC", Offset = "0x2647BBC", VA = "0x2647BBC")]
    public MovePosition(
      Vector3Base inputSourcePosition,
      Vector3Base inputDestinationPosition,
      float inputMoveTime)
    {
    }

    [Token(Token = "0x6018BDB")]
    [Address(RVA = "0x2648B2C", Offset = "0x2648B2C", VA = "0x2648B2C", Slot = "7")]
    public override void GetValue(out Vector3 outputValue)
    {
    }

    [Token(Token = "0x6018BDC")]
    [Address(RVA = "0x2648C00", Offset = "0x2648C00", VA = "0x2648C00", Slot = "8")]
    public override bool GetDirty() => new bool();

    [Token(Token = "0x6018BDD")]
    [Address(RVA = "0x2648C48", Offset = "0x2648C48", VA = "0x2648C48", Slot = "5")]
    public override void SetDirty(bool value)
    {
    }

    [Token(Token = "0x6018BDE")]
    [Address(RVA = "0x2648C88", Offset = "0x2648C88", VA = "0x2648C88", Slot = "4")]
    public override void TimeUpdate(float deltaTime)
    {
    }

    [Token(Token = "0x6018BDF")]
    [Address(RVA = "0x2648CB0", Offset = "0x2648CB0", VA = "0x2648CB0", Slot = "9")]
    public override Vector3Base GetDestination() => (Vector3Base) null;

    [Token(Token = "0x6018BE0")]
    [Address(RVA = "0x2648CB8", Offset = "0x2648CB8", VA = "0x2648CB8", Slot = "11")]
    public override bool GetWaitIdle() => new bool();

    [Token(Token = "0x6018BE1")]
    [Address(RVA = "0x2648CC8", Offset = "0x2648CC8", VA = "0x2648CC8", Slot = "6")]
    public override void RegistContainer(GeometryContainer inputGeometryContainer)
    {
    }
  }
}
