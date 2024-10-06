// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ArticleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CD8")]
  public struct ArticleData : IFlatbufferObject
  {
    [Token(Token = "0x4010C39")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FBC")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601865B"), Address(RVA = "0x26E04B0", Offset = "0x26E04B0", VA = "0x26E04B0", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601865C")]
    [Address(RVA = "0x26E04B8", Offset = "0x26E04B8", VA = "0x26E04B8")]
    public static ArticleData GetRootAsArticleData(ByteBuffer _bb) => new ArticleData();

    [Token(Token = "0x601865D")]
    [Address(RVA = "0x26E04C4", Offset = "0x26E04C4", VA = "0x26E04C4")]
    public static ArticleData GetRootAsArticleData(ByteBuffer _bb, ArticleData obj)
    {
      return new ArticleData();
    }

    [Token(Token = "0x601865E")]
    [Address(RVA = "0x26E0520", Offset = "0x26E0520", VA = "0x26E0520", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601865F")]
    [Address(RVA = "0x26E0508", Offset = "0x26E0508", VA = "0x26E0508")]
    public ArticleData __assign(int _i, ByteBuffer _bb) => new ArticleData();

    [Token(Token = "0x17004FBD")]
    public int ArticleId
    {
      [Token(Token = "0x6018660"), Address(RVA = "0x26E052C", Offset = "0x26E052C", VA = "0x26E052C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018661")]
    [Address(RVA = "0x26E0570", Offset = "0x26E0570", VA = "0x26E0570")]
    public ContentData? Contents(int j) => new ContentData?();

    [Token(Token = "0x17004FBE")]
    public int ContentsLength
    {
      [Token(Token = "0x6018662"), Address(RVA = "0x26E0624", Offset = "0x26E0624", VA = "0x26E0624")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018663")]
    [Address(RVA = "0x26E0658", Offset = "0x26E0658", VA = "0x26E0658")]
    public static Offset<ArticleData> CreateArticleData(
      FlatBufferBuilder builder,
      int article_id = 0,
      VectorOffset contentsOffset = default (VectorOffset))
    {
      return new Offset<ArticleData>();
    }

    [Token(Token = "0x6018664")]
    [Address(RVA = "0x26E0740", Offset = "0x26E0740", VA = "0x26E0740")]
    public static void StartArticleData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018665")]
    [Address(RVA = "0x26E06D0", Offset = "0x26E06D0", VA = "0x26E06D0")]
    public static void AddArticleId(FlatBufferBuilder builder, int articleId)
    {
    }

    [Token(Token = "0x6018666")]
    [Address(RVA = "0x26E06B0", Offset = "0x26E06B0", VA = "0x26E06B0")]
    public static void AddContents(FlatBufferBuilder builder, VectorOffset contentsOffset)
    {
    }

    [Token(Token = "0x6018667")]
    [Address(RVA = "0x26E0758", Offset = "0x26E0758", VA = "0x26E0758")]
    public static VectorOffset CreateContentsVector(
      FlatBufferBuilder builder,
      Offset<ContentData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018668")]
    [Address(RVA = "0x26E0800", Offset = "0x26E0800", VA = "0x26E0800")]
    public static VectorOffset CreateContentsVectorBlock(
      FlatBufferBuilder builder,
      Offset<ContentData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018669")]
    [Address(RVA = "0x26E0888", Offset = "0x26E0888", VA = "0x26E0888")]
    public static void StartContentsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601866A")]
    [Address(RVA = "0x26E06F0", Offset = "0x26E06F0", VA = "0x26E06F0")]
    public static Offset<ArticleData> EndArticleData(FlatBufferBuilder builder)
    {
      return new Offset<ArticleData>();
    }
  }
}
