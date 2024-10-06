// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.LvUpParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C6B")]
  public struct LvUpParam : IFlatbufferObject
  {
    [Token(Token = "0x4010BCA")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004D7B")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017C97"), Address(RVA = "0x37B8F7C", Offset = "0x37B8F7C", VA = "0x37B8F7C", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017C98")]
    [Address(RVA = "0x37B8F84", Offset = "0x37B8F84", VA = "0x37B8F84")]
    public static LvUpParam GetRootAsLvUpParam(ByteBuffer _bb) => new LvUpParam();

    [Token(Token = "0x6017C99")]
    [Address(RVA = "0x37B8F90", Offset = "0x37B8F90", VA = "0x37B8F90")]
    public static LvUpParam GetRootAsLvUpParam(ByteBuffer _bb, LvUpParam obj) => new LvUpParam();

    [Token(Token = "0x6017C9A")]
    [Address(RVA = "0x37B8FEC", Offset = "0x37B8FEC", VA = "0x37B8FEC", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017C9B")]
    [Address(RVA = "0x37B8FD4", Offset = "0x37B8FD4", VA = "0x37B8FD4")]
    public LvUpParam __assign(int _i, ByteBuffer _bb) => new LvUpParam();

    [Token(Token = "0x17004D7C")]
    public int Level
    {
      [Token(Token = "0x6017C9C"), Address(RVA = "0x37B8FF8", Offset = "0x37B8FF8", VA = "0x37B8FF8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D7D")]
    public BasicParameter? Params
    {
      [Token(Token = "0x6017C9D"), Address(RVA = "0x37B903C", Offset = "0x37B903C", VA = "0x37B903C")] get
      {
        return new BasicParameter?();
      }
    }

    [Token(Token = "0x6017C9E")]
    [Address(RVA = "0x37B90EC", Offset = "0x37B90EC", VA = "0x37B90EC")]
    public static Offset<LvUpParam> CreateLvUpParam(
      FlatBufferBuilder builder,
      int level = 0,
      Offset<BasicParameter> paramsOffset = default (Offset<BasicParameter>))
    {
      return new Offset<LvUpParam>();
    }

    [Token(Token = "0x6017C9F")]
    [Address(RVA = "0x37B91D4", Offset = "0x37B91D4", VA = "0x37B91D4")]
    public static void StartLvUpParam(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017CA0")]
    [Address(RVA = "0x37B9164", Offset = "0x37B9164", VA = "0x37B9164")]
    public static void AddLevel(FlatBufferBuilder builder, int level)
    {
    }

    [Token(Token = "0x6017CA1")]
    [Address(RVA = "0x37B9144", Offset = "0x37B9144", VA = "0x37B9144")]
    public static void AddParams(FlatBufferBuilder builder, Offset<BasicParameter> paramsOffset)
    {
    }

    [Token(Token = "0x6017CA2")]
    [Address(RVA = "0x37B9184", Offset = "0x37B9184", VA = "0x37B9184")]
    public static Offset<LvUpParam> EndLvUpParam(FlatBufferBuilder builder)
    {
      return new Offset<LvUpParam>();
    }
  }
}
