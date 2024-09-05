// Decompiled with JetBrains decompiler
// Type: staq.Camera.TransformPosition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D7D")]
  public class TransformPosition : Vector3Base
  {
    [Token(Token = "0x4010E08")]
    [FieldOffset(Offset = "0x20")]
    private Transform transform;

    [Token(Token = "0x6018BC8")]
    [Address(RVA = "0x2647F20", Offset = "0x2647F20", VA = "0x2647F20")]
    public TransformPosition(Transform inputTransform)
    {
    }

    [Token(Token = "0x6018BC9")]
    [Address(RVA = "0x2647F64", Offset = "0x2647F64", VA = "0x2647F64", Slot = "7")]
    public override void GetValue(out Vector3 outputValue)
    {
    }

    [Token(Token = "0x6018BCA")]
    [Address(RVA = "0x2647FD8", Offset = "0x2647FD8", VA = "0x2647FD8", Slot = "8")]
    public override bool GetDirty() => new bool();

    [Token(Token = "0x6018BCB")]
    [Address(RVA = "0x2648044", Offset = "0x2648044", VA = "0x2648044", Slot = "5")]
    public override void SetDirty(bool inputDirty)
    {
    }

    [Token(Token = "0x6018BCC")]
    [Address(RVA = "0x2648094", Offset = "0x2648094", VA = "0x2648094", Slot = "10")]
    public override bool CompareEqual(Vector3Base otherBase) => new bool();
  }
}
