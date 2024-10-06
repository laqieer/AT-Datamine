// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.VectorSchemaExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CA9")]
  public static class VectorSchemaExtension
  {
    [Token(Token = "0x601831B")]
    [Address(RVA = "0x26D40CC", Offset = "0x26D40CC", VA = "0x26D40CC")]
    public static Vector2 ToVector2(this Vec2 self) => new Vector2();

    [Token(Token = "0x601831C")]
    [Address(RVA = "0x26D4110", Offset = "0x26D4110", VA = "0x26D4110")]
    public static Vector3 ToVector3(this Vec2 self) => new Vector3();

    [Token(Token = "0x601831D")]
    [Address(RVA = "0x26D4158", Offset = "0x26D4158", VA = "0x26D4158")]
    public static Vector4 ToVector4(this Vec2 self) => new Vector4();

    [Token(Token = "0x601831E")]
    [Address(RVA = "0x26D41A4", Offset = "0x26D41A4", VA = "0x26D41A4")]
    public static Vector3 ToVector3(this Vec3 self) => new Vector3();

    [Token(Token = "0x601831F")]
    [Address(RVA = "0x26D41FC", Offset = "0x26D41FC", VA = "0x26D41FC")]
    public static Vector4 ToVector4(this Vec3 self) => new Vector4();
  }
}
