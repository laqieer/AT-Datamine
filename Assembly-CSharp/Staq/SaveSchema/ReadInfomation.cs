// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ReadInfomation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CD1")]
  public struct ReadInfomation : IFlatbufferObject
  {
    [Token(Token = "0x4010C2F")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FAB")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018600"), Address(RVA = "0x26DF10C", Offset = "0x26DF10C", VA = "0x26DF10C", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018601")]
    [Address(RVA = "0x26DF114", Offset = "0x26DF114", VA = "0x26DF114")]
    public static ReadInfomation GetRootAsReadInfomation(ByteBuffer _bb) => new ReadInfomation();

    [Token(Token = "0x6018602")]
    [Address(RVA = "0x26DF120", Offset = "0x26DF120", VA = "0x26DF120")]
    public static ReadInfomation GetRootAsReadInfomation(ByteBuffer _bb, ReadInfomation obj)
    {
      return new ReadInfomation();
    }

    [Token(Token = "0x6018603")]
    [Address(RVA = "0x26DF17C", Offset = "0x26DF17C", VA = "0x26DF17C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018604")]
    [Address(RVA = "0x26DF164", Offset = "0x26DF164", VA = "0x26DF164")]
    public ReadInfomation __assign(int _i, ByteBuffer _bb) => new ReadInfomation();

    [Token(Token = "0x17004FAC")]
    public int Id
    {
      [Token(Token = "0x6018605"), Address(RVA = "0x26DF188", Offset = "0x26DF188", VA = "0x26DF188")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004FAD")]
    public bool IsRead
    {
      [Token(Token = "0x6018606"), Address(RVA = "0x26DF1CC", Offset = "0x26DF1CC", VA = "0x26DF1CC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6018607")]
    [Address(RVA = "0x26DF214", Offset = "0x26DF214", VA = "0x26DF214")]
    public static Offset<ReadInfomation> CreateReadInfomation(
      FlatBufferBuilder builder,
      int id = 0,
      bool is_read = false)
    {
      return new Offset<ReadInfomation>();
    }

    [Token(Token = "0x6018608")]
    [Address(RVA = "0x26DF2FC", Offset = "0x26DF2FC", VA = "0x26DF2FC")]
    public static void StartReadInfomation(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018609")]
    [Address(RVA = "0x26DF26C", Offset = "0x26DF26C", VA = "0x26DF26C")]
    public static void AddId(FlatBufferBuilder builder, int id)
    {
    }

    [Token(Token = "0x601860A")]
    [Address(RVA = "0x26DF28C", Offset = "0x26DF28C", VA = "0x26DF28C")]
    public static void AddIsRead(FlatBufferBuilder builder, bool isRead)
    {
    }

    [Token(Token = "0x601860B")]
    [Address(RVA = "0x26DF2AC", Offset = "0x26DF2AC", VA = "0x26DF2AC")]
    public static Offset<ReadInfomation> EndReadInfomation(FlatBufferBuilder builder)
    {
      return new Offset<ReadInfomation>();
    }
  }
}
