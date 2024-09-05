// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.Vec2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CEB")]
  public struct Vec2 : IFlatbufferObject
  {
    [Token(Token = "0x4010C4B")]
    [FieldOffset(Offset = "0x0")]
    private Struct __p;

    [Token(Token = "0x17004FFC")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60187AD"), Address(RVA = "0x2937760", Offset = "0x2937760", VA = "0x2937760", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60187AE")]
    [Address(RVA = "0x2937768", Offset = "0x2937768", VA = "0x2937768", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60187AF")]
    [Address(RVA = "0x2937774", Offset = "0x2937774", VA = "0x2937774")]
    public Vec2 __assign(int _i, ByteBuffer _bb) => new Vec2();

    [Token(Token = "0x17004FFD")]
    public float X
    {
      [Token(Token = "0x60187B0"), Address(RVA = "0x293778C", Offset = "0x293778C", VA = "0x293778C")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17004FFE")]
    public float Y
    {
      [Token(Token = "0x60187B1"), Address(RVA = "0x29377B0", Offset = "0x29377B0", VA = "0x29377B0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x60187B2")]
    [Address(RVA = "0x29375F0", Offset = "0x29375F0", VA = "0x29375F0")]
    public static Offset<Vec2> CreateVec2(FlatBufferBuilder builder, float X, float Y)
    {
      return new Offset<Vec2>();
    }
  }
}
