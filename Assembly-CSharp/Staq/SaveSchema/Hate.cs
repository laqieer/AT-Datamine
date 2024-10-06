// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.Hate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C8D")]
  public struct Hate : IFlatbufferObject
  {
    [Token(Token = "0x4010BEC")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004E79")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601807D"), Address(RVA = "0x3B1C638", Offset = "0x3B1C638", VA = "0x3B1C638", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601807E")]
    [Address(RVA = "0x3B1C640", Offset = "0x3B1C640", VA = "0x3B1C640")]
    public static Hate GetRootAsHate(ByteBuffer _bb) => new Hate();

    [Token(Token = "0x601807F")]
    [Address(RVA = "0x3B1C64C", Offset = "0x3B1C64C", VA = "0x3B1C64C")]
    public static Hate GetRootAsHate(ByteBuffer _bb, Hate obj) => new Hate();

    [Token(Token = "0x6018080")]
    [Address(RVA = "0x3B1C690", Offset = "0x3B1C690", VA = "0x3B1C690", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018081")]
    [Address(RVA = "0x3B1BE40", Offset = "0x3B1BE40", VA = "0x3B1BE40")]
    public Hate __assign(int _i, ByteBuffer _bb) => new Hate();

    [Token(Token = "0x17004E7A")]
    public int UnitId
    {
      [Token(Token = "0x6018082"), Address(RVA = "0x3B1C69C", Offset = "0x3B1C69C", VA = "0x3B1C69C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E7B")]
    public int Value
    {
      [Token(Token = "0x6018083"), Address(RVA = "0x3B1C6E0", Offset = "0x3B1C6E0", VA = "0x3B1C6E0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018084")]
    [Address(RVA = "0x3B1C724", Offset = "0x3B1C724", VA = "0x3B1C724")]
    public static Offset<Hate> CreateHate(FlatBufferBuilder builder, int unitId = 0, int value = 0)
    {
      return new Offset<Hate>();
    }

    [Token(Token = "0x6018085")]
    [Address(RVA = "0x3B1C80C", Offset = "0x3B1C80C", VA = "0x3B1C80C")]
    public static void StartHate(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018086")]
    [Address(RVA = "0x3B1C79C", Offset = "0x3B1C79C", VA = "0x3B1C79C")]
    public static void AddUnitId(FlatBufferBuilder builder, int unitId)
    {
    }

    [Token(Token = "0x6018087")]
    [Address(RVA = "0x3B1C77C", Offset = "0x3B1C77C", VA = "0x3B1C77C")]
    public static void AddValue(FlatBufferBuilder builder, int value)
    {
    }

    [Token(Token = "0x6018088")]
    [Address(RVA = "0x3B1C7BC", Offset = "0x3B1C7BC", VA = "0x3B1C7BC")]
    public static Offset<Hate> EndHate(FlatBufferBuilder builder) => new Offset<Hate>();
  }
}
