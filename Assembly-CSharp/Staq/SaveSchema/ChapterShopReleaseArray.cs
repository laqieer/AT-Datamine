// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ChapterShopReleaseArray
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C9B")]
  public struct ChapterShopReleaseArray : IFlatbufferObject
  {
    [Token(Token = "0x4010BFA")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004EE6")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601820F"), Address(RVA = "0x3B228A8", Offset = "0x3B228A8", VA = "0x3B228A8", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018210")]
    [Address(RVA = "0x3B228B0", Offset = "0x3B228B0", VA = "0x3B228B0")]
    public static ChapterShopReleaseArray GetRootAsChapterShopReleaseArray(ByteBuffer _bb)
    {
      return new ChapterShopReleaseArray();
    }

    [Token(Token = "0x6018211")]
    [Address(RVA = "0x3B228BC", Offset = "0x3B228BC", VA = "0x3B228BC")]
    public static ChapterShopReleaseArray GetRootAsChapterShopReleaseArray(
      ByteBuffer _bb,
      ChapterShopReleaseArray obj)
    {
      return new ChapterShopReleaseArray();
    }

    [Token(Token = "0x6018212")]
    [Address(RVA = "0x3B22918", Offset = "0x3B22918", VA = "0x3B22918")]
    public static bool ChapterShopReleaseArrayBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6018213")]
    [Address(RVA = "0x3B22964", Offset = "0x3B22964", VA = "0x3B22964", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018214")]
    [Address(RVA = "0x3B22900", Offset = "0x3B22900", VA = "0x3B22900")]
    public ChapterShopReleaseArray __assign(int _i, ByteBuffer _bb)
    {
      return new ChapterShopReleaseArray();
    }

    [Token(Token = "0x6018215")]
    [Address(RVA = "0x3B22970", Offset = "0x3B22970", VA = "0x3B22970")]
    public ChapterShopReleaseData? ReleaseDatas(int j) => new ChapterShopReleaseData?();

    [Token(Token = "0x17004EE7")]
    public int ReleaseDatasLength
    {
      [Token(Token = "0x6018216"), Address(RVA = "0x3B22A24", Offset = "0x3B22A24", VA = "0x3B22A24")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018217")]
    [Address(RVA = "0x3B22A58", Offset = "0x3B22A58", VA = "0x3B22A58")]
    public static Offset<ChapterShopReleaseArray> CreateChapterShopReleaseArray(
      FlatBufferBuilder builder,
      VectorOffset releaseDatasOffset = default (VectorOffset))
    {
      return new Offset<ChapterShopReleaseArray>();
    }

    [Token(Token = "0x6018218")]
    [Address(RVA = "0x3B22B10", Offset = "0x3B22B10", VA = "0x3B22B10")]
    public static void StartChapterShopReleaseArray(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018219")]
    [Address(RVA = "0x3B22AA0", Offset = "0x3B22AA0", VA = "0x3B22AA0")]
    public static void AddReleaseDatas(FlatBufferBuilder builder, VectorOffset releaseDatasOffset)
    {
    }

    [Token(Token = "0x601821A")]
    [Address(RVA = "0x3B22B28", Offset = "0x3B22B28", VA = "0x3B22B28")]
    public static VectorOffset CreateReleaseDatasVector(
      FlatBufferBuilder builder,
      Offset<ChapterShopReleaseData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601821B")]
    [Address(RVA = "0x3B22BD0", Offset = "0x3B22BD0", VA = "0x3B22BD0")]
    public static VectorOffset CreateReleaseDatasVectorBlock(
      FlatBufferBuilder builder,
      Offset<ChapterShopReleaseData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601821C")]
    [Address(RVA = "0x3B22C58", Offset = "0x3B22C58", VA = "0x3B22C58")]
    public static void StartReleaseDatasVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601821D")]
    [Address(RVA = "0x3B22AC0", Offset = "0x3B22AC0", VA = "0x3B22AC0")]
    public static Offset<ChapterShopReleaseArray> EndChapterShopReleaseArray(
      FlatBufferBuilder builder)
    {
      return new Offset<ChapterShopReleaseArray>();
    }

    [Token(Token = "0x601821E")]
    [Address(RVA = "0x3B22C78", Offset = "0x3B22C78", VA = "0x3B22C78")]
    public static void FinishChapterShopReleaseArrayBuffer(
      FlatBufferBuilder builder,
      Offset<ChapterShopReleaseArray> offset)
    {
    }

    [Token(Token = "0x601821F")]
    [Address(RVA = "0x3B22CD4", Offset = "0x3B22CD4", VA = "0x3B22CD4")]
    public static void FinishSizePrefixedChapterShopReleaseArrayBuffer(
      FlatBufferBuilder builder,
      Offset<ChapterShopReleaseArray> offset)
    {
    }
  }
}
