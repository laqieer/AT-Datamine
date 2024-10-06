// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ReadInfomationSave
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CD2")]
  public struct ReadInfomationSave : IFlatbufferObject
  {
    [Token(Token = "0x4010C30")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FAE")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601860C"), Address(RVA = "0x26DF314", Offset = "0x26DF314", VA = "0x26DF314", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601860D")]
    [Address(RVA = "0x26DF31C", Offset = "0x26DF31C", VA = "0x26DF31C")]
    public static ReadInfomationSave GetRootAsReadInfomationSave(ByteBuffer _bb)
    {
      return new ReadInfomationSave();
    }

    [Token(Token = "0x601860E")]
    [Address(RVA = "0x26DF328", Offset = "0x26DF328", VA = "0x26DF328")]
    public static ReadInfomationSave GetRootAsReadInfomationSave(
      ByteBuffer _bb,
      ReadInfomationSave obj)
    {
      return new ReadInfomationSave();
    }

    [Token(Token = "0x601860F")]
    [Address(RVA = "0x26DF384", Offset = "0x26DF384", VA = "0x26DF384")]
    public static bool ReadInfomationSaveBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6018610")]
    [Address(RVA = "0x26DF3D0", Offset = "0x26DF3D0", VA = "0x26DF3D0", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018611")]
    [Address(RVA = "0x26DF36C", Offset = "0x26DF36C", VA = "0x26DF36C")]
    public ReadInfomationSave __assign(int _i, ByteBuffer _bb) => new ReadInfomationSave();

    [Token(Token = "0x6018612")]
    [Address(RVA = "0x26DF3DC", Offset = "0x26DF3DC", VA = "0x26DF3DC")]
    public ReadInfomation? ReadInfomations(int j) => new ReadInfomation?();

    [Token(Token = "0x17004FAF")]
    public int ReadInfomationsLength
    {
      [Token(Token = "0x6018613"), Address(RVA = "0x26DF490", Offset = "0x26DF490", VA = "0x26DF490")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018614")]
    [Address(RVA = "0x26DF4C4", Offset = "0x26DF4C4", VA = "0x26DF4C4")]
    public static Offset<ReadInfomationSave> CreateReadInfomationSave(
      FlatBufferBuilder builder,
      VectorOffset ReadInfomationsOffset = default (VectorOffset))
    {
      return new Offset<ReadInfomationSave>();
    }

    [Token(Token = "0x6018615")]
    [Address(RVA = "0x26DF57C", Offset = "0x26DF57C", VA = "0x26DF57C")]
    public static void StartReadInfomationSave(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018616")]
    [Address(RVA = "0x26DF50C", Offset = "0x26DF50C", VA = "0x26DF50C")]
    public static void AddReadInfomations(
      FlatBufferBuilder builder,
      VectorOffset ReadInfomationsOffset)
    {
    }

    [Token(Token = "0x6018617")]
    [Address(RVA = "0x26DF594", Offset = "0x26DF594", VA = "0x26DF594")]
    public static VectorOffset CreateReadInfomationsVector(
      FlatBufferBuilder builder,
      Offset<ReadInfomation>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018618")]
    [Address(RVA = "0x26DF63C", Offset = "0x26DF63C", VA = "0x26DF63C")]
    public static VectorOffset CreateReadInfomationsVectorBlock(
      FlatBufferBuilder builder,
      Offset<ReadInfomation>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018619")]
    [Address(RVA = "0x26DF6C4", Offset = "0x26DF6C4", VA = "0x26DF6C4")]
    public static void StartReadInfomationsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601861A")]
    [Address(RVA = "0x26DF52C", Offset = "0x26DF52C", VA = "0x26DF52C")]
    public static Offset<ReadInfomationSave> EndReadInfomationSave(FlatBufferBuilder builder)
    {
      return new Offset<ReadInfomationSave>();
    }

    [Token(Token = "0x601861B")]
    [Address(RVA = "0x26DF6E4", Offset = "0x26DF6E4", VA = "0x26DF6E4")]
    public static void FinishReadInfomationSaveBuffer(
      FlatBufferBuilder builder,
      Offset<ReadInfomationSave> offset)
    {
    }

    [Token(Token = "0x601861C")]
    [Address(RVA = "0x26DF740", Offset = "0x26DF740", VA = "0x26DF740")]
    public static void FinishSizePrefixedReadInfomationSaveBuffer(
      FlatBufferBuilder builder,
      Offset<ReadInfomationSave> offset)
    {
    }
  }
}
