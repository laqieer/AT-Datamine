// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.Vec2Int
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CEC")]
  public struct Vec2Int : IFlatbufferObject
  {
    [Token(Token = "0x4010C4C")]
    [FieldOffset(Offset = "0x0")]
    private Struct __p;

    [Token(Token = "0x17004FFF")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60187B3"), Address(RVA = "0x29377D8", Offset = "0x29377D8", VA = "0x29377D8", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60187B4")]
    [Address(RVA = "0x29377E0", Offset = "0x29377E0", VA = "0x29377E0", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60187B5")]
    [Address(RVA = "0x29377EC", Offset = "0x29377EC", VA = "0x29377EC")]
    public Vec2Int __assign(int _i, ByteBuffer _bb) => new Vec2Int();

    [Token(Token = "0x17005000")]
    public int X
    {
      [Token(Token = "0x60187B6"), Address(RVA = "0x2937804", Offset = "0x2937804", VA = "0x2937804")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17005001")]
    public int Y
    {
      [Token(Token = "0x60187B7"), Address(RVA = "0x2937828", Offset = "0x2937828", VA = "0x2937828")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60187B8")]
    [Address(RVA = "0x2937850", Offset = "0x2937850", VA = "0x2937850")]
    public static Offset<Vec2Int> CreateVec2Int(FlatBufferBuilder builder, int X, int Y)
    {
      return new Offset<Vec2Int>();
    }
  }
}
