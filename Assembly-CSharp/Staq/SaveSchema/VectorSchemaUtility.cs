// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.VectorSchemaUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CEA")]
  public static class VectorSchemaUtility
  {
    [Token(Token = "0x60187AA")]
    [Address(RVA = "0x29375DC", Offset = "0x29375DC", VA = "0x29375DC")]
    public static Offset<Vec2> CreateVec2(FlatBufferBuilder builder, Vector2 value)
    {
      return new Offset<Vec2>();
    }

    [Token(Token = "0x60187AB")]
    [Address(RVA = "0x2937684", Offset = "0x2937684", VA = "0x2937684")]
    public static Offset<Vec3> CreateVec3(FlatBufferBuilder builder, Vector2 value)
    {
      return new Offset<Vec3>();
    }

    [Token(Token = "0x60187AC")]
    [Address(RVA = "0x293774C", Offset = "0x293774C", VA = "0x293774C")]
    public static Offset<Vec3> CreateVec3(FlatBufferBuilder builder, Vector3 value)
    {
      return new Offset<Vec3>();
    }
  }
}
