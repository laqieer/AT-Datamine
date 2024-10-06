// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ReadInformationSave
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CD4")]
  public struct ReadInformationSave : IFlatbufferObject
  {
    [Token(Token = "0x4010C32")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FB3")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018629"), Address(RVA = "0x26DF9A4", Offset = "0x26DF9A4", VA = "0x26DF9A4", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601862A")]
    [Address(RVA = "0x26DF9AC", Offset = "0x26DF9AC", VA = "0x26DF9AC")]
    public static ReadInformationSave GetRootAsReadInformationSave(ByteBuffer _bb)
    {
      return new ReadInformationSave();
    }

    [Token(Token = "0x601862B")]
    [Address(RVA = "0x26DF9B8", Offset = "0x26DF9B8", VA = "0x26DF9B8")]
    public static ReadInformationSave GetRootAsReadInformationSave(
      ByteBuffer _bb,
      ReadInformationSave obj)
    {
      return new ReadInformationSave();
    }

    [Token(Token = "0x601862C")]
    [Address(RVA = "0x26DFA14", Offset = "0x26DFA14", VA = "0x26DFA14")]
    public static bool ReadInformationSaveBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x601862D")]
    [Address(RVA = "0x26DFA60", Offset = "0x26DFA60", VA = "0x26DFA60", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601862E")]
    [Address(RVA = "0x26DF9FC", Offset = "0x26DF9FC", VA = "0x26DF9FC")]
    public ReadInformationSave __assign(int _i, ByteBuffer _bb) => new ReadInformationSave();

    [Token(Token = "0x601862F")]
    [Address(RVA = "0x26DFA6C", Offset = "0x26DFA6C", VA = "0x26DFA6C")]
    public ReadInformation? ReadInformations(int j) => new ReadInformation?();

    [Token(Token = "0x17004FB4")]
    public int ReadInformationsLength
    {
      [Token(Token = "0x6018630"), Address(RVA = "0x26DFB20", Offset = "0x26DFB20", VA = "0x26DFB20")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018631")]
    [Address(RVA = "0x26DFB54", Offset = "0x26DFB54", VA = "0x26DFB54")]
    public static Offset<ReadInformationSave> CreateReadInformationSave(
      FlatBufferBuilder builder,
      VectorOffset ReadInformationsOffset = default (VectorOffset))
    {
      return new Offset<ReadInformationSave>();
    }

    [Token(Token = "0x6018632")]
    [Address(RVA = "0x26DFC0C", Offset = "0x26DFC0C", VA = "0x26DFC0C")]
    public static void StartReadInformationSave(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018633")]
    [Address(RVA = "0x26DFB9C", Offset = "0x26DFB9C", VA = "0x26DFB9C")]
    public static void AddReadInformations(
      FlatBufferBuilder builder,
      VectorOffset ReadInformationsOffset)
    {
    }

    [Token(Token = "0x6018634")]
    [Address(RVA = "0x26DFC24", Offset = "0x26DFC24", VA = "0x26DFC24")]
    public static VectorOffset CreateReadInformationsVector(
      FlatBufferBuilder builder,
      Offset<ReadInformation>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018635")]
    [Address(RVA = "0x26DFCCC", Offset = "0x26DFCCC", VA = "0x26DFCCC")]
    public static VectorOffset CreateReadInformationsVectorBlock(
      FlatBufferBuilder builder,
      Offset<ReadInformation>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018636")]
    [Address(RVA = "0x26DFD54", Offset = "0x26DFD54", VA = "0x26DFD54")]
    public static void StartReadInformationsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018637")]
    [Address(RVA = "0x26DFBBC", Offset = "0x26DFBBC", VA = "0x26DFBBC")]
    public static Offset<ReadInformationSave> EndReadInformationSave(FlatBufferBuilder builder)
    {
      return new Offset<ReadInformationSave>();
    }

    [Token(Token = "0x6018638")]
    [Address(RVA = "0x26DFD74", Offset = "0x26DFD74", VA = "0x26DFD74")]
    public static void FinishReadInformationSaveBuffer(
      FlatBufferBuilder builder,
      Offset<ReadInformationSave> offset)
    {
    }

    [Token(Token = "0x6018639")]
    [Address(RVA = "0x26DFDD0", Offset = "0x26DFDD0", VA = "0x26DFDD0")]
    public static void FinishSizePrefixedReadInformationSaveBuffer(
      FlatBufferBuilder builder,
      Offset<ReadInformationSave> offset)
    {
    }
  }
}
