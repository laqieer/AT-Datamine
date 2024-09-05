// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.Vec3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CED")]
  public struct Vec3 : IFlatbufferObject
  {
    [Token(Token = "0x4010C4D")]
    [FieldOffset(Offset = "0x0")]
    private Struct __p;

    [Token(Token = "0x17005002")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60187B9"), Address(RVA = "0x29378E4", Offset = "0x29378E4", VA = "0x29378E4", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60187BA")]
    [Address(RVA = "0x29378EC", Offset = "0x29378EC", VA = "0x29378EC", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60187BB")]
    [Address(RVA = "0x29378F8", Offset = "0x29378F8", VA = "0x29378F8")]
    public Vec3 __assign(int _i, ByteBuffer _bb) => new Vec3();

    [Token(Token = "0x17005003")]
    public float X
    {
      [Token(Token = "0x60187BC"), Address(RVA = "0x2937910", Offset = "0x2937910", VA = "0x2937910")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17005004")]
    public float Y
    {
      [Token(Token = "0x60187BD"), Address(RVA = "0x2937934", Offset = "0x2937934", VA = "0x2937934")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17005005")]
    public float Z
    {
      [Token(Token = "0x60187BE"), Address(RVA = "0x293795C", Offset = "0x293795C", VA = "0x293795C")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x60187BF")]
    [Address(RVA = "0x293769C", Offset = "0x293769C", VA = "0x293769C")]
    public static Offset<Vec3> CreateVec3(FlatBufferBuilder builder, float X, float Y, float Z)
    {
      return new Offset<Vec3>();
    }
  }
}
