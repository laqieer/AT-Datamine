// Decompiled with JetBrains decompiler
// Type: staq.Camera.GroundPosition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D7E")]
  public class GroundPosition : Vector3Base
  {
    [Token(Token = "0x4010E09")]
    [FieldOffset(Offset = "0x20")]
    private UnityEngine.Camera Camera;
    [Token(Token = "0x4010E0A")]
    [FieldOffset(Offset = "0x28")]
    private Quaternion LastCameraRotate;
    [Token(Token = "0x4010E0B")]
    [FieldOffset(Offset = "0x38")]
    private Vector3Base Position;

    [Token(Token = "0x6018BCD")]
    [Address(RVA = "0x264815C", Offset = "0x264815C", VA = "0x264815C")]
    public GroundPosition(UnityEngine.Camera camera, Vector3Base position)
    {
    }

    [Token(Token = "0x6018BCE")]
    [Address(RVA = "0x2648194", Offset = "0x2648194", VA = "0x2648194", Slot = "7")]
    public override void GetValue(out Vector3 outputValue)
    {
    }

    [Token(Token = "0x6018BCF")]
    [Address(RVA = "0x26482C8", Offset = "0x26482C8", VA = "0x26482C8", Slot = "8")]
    public override bool GetDirty() => new bool();

    [Token(Token = "0x6018BD0")]
    [Address(RVA = "0x2648360", Offset = "0x2648360", VA = "0x2648360", Slot = "5")]
    public override void SetDirty(bool dirty)
    {
    }

    [Token(Token = "0x6018BD1")]
    [Address(RVA = "0x26483E8", Offset = "0x26483E8", VA = "0x26483E8", Slot = "10")]
    public override bool CompareEqual(Vector3Base otherBase) => new bool();
  }
}
