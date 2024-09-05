// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.BannerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CD9")]
  public struct BannerData : IFlatbufferObject
  {
    [Token(Token = "0x4010C3A")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FBF")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601866B"), Address(RVA = "0x26E08A8", Offset = "0x26E08A8", VA = "0x26E08A8", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601866C")]
    [Address(RVA = "0x26E08B0", Offset = "0x26E08B0", VA = "0x26E08B0")]
    public static BannerData GetRootAsBannerData(ByteBuffer _bb) => new BannerData();

    [Token(Token = "0x601866D")]
    [Address(RVA = "0x26E08BC", Offset = "0x26E08BC", VA = "0x26E08BC")]
    public static BannerData GetRootAsBannerData(ByteBuffer _bb, BannerData obj)
    {
      return new BannerData();
    }

    [Token(Token = "0x601866E")]
    [Address(RVA = "0x26E0918", Offset = "0x26E0918", VA = "0x26E0918", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601866F")]
    [Address(RVA = "0x26E0900", Offset = "0x26E0900", VA = "0x26E0900")]
    public BannerData __assign(int _i, ByteBuffer _bb) => new BannerData();

    [Token(Token = "0x17004FC0")]
    public int ShopId
    {
      [Token(Token = "0x6018670"), Address(RVA = "0x26E0924", Offset = "0x26E0924", VA = "0x26E0924")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004FC1")]
    public long ShopEndAtTick
    {
      [Token(Token = "0x6018671"), Address(RVA = "0x26E0968", Offset = "0x26E0968", VA = "0x26E0968")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x6018672")]
    [Address(RVA = "0x26E09B0", Offset = "0x26E09B0", VA = "0x26E09B0")]
    public ArticleData? Articles(int j) => new ArticleData?();

    [Token(Token = "0x17004FC2")]
    public int ArticlesLength
    {
      [Token(Token = "0x6018673"), Address(RVA = "0x26E0A64", Offset = "0x26E0A64", VA = "0x26E0A64")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018674")]
    [Address(RVA = "0x26E0A98", Offset = "0x26E0A98", VA = "0x26E0A98")]
    public static Offset<BannerData> CreateBannerData(
      FlatBufferBuilder builder,
      int shop_id = 0,
      long shop_end_at_tick = 0,
      VectorOffset articlesOffset = default (VectorOffset))
    {
      return new Offset<BannerData>();
    }

    [Token(Token = "0x6018675")]
    [Address(RVA = "0x26E0BB8", Offset = "0x26E0BB8", VA = "0x26E0BB8")]
    public static void StartBannerData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018676")]
    [Address(RVA = "0x26E0B48", Offset = "0x26E0B48", VA = "0x26E0B48")]
    public static void AddShopId(FlatBufferBuilder builder, int shopId)
    {
    }

    [Token(Token = "0x6018677")]
    [Address(RVA = "0x26E0B08", Offset = "0x26E0B08", VA = "0x26E0B08")]
    public static void AddShopEndAtTick(FlatBufferBuilder builder, long shopEndAtTick)
    {
    }

    [Token(Token = "0x6018678")]
    [Address(RVA = "0x26E0B28", Offset = "0x26E0B28", VA = "0x26E0B28")]
    public static void AddArticles(FlatBufferBuilder builder, VectorOffset articlesOffset)
    {
    }

    [Token(Token = "0x6018679")]
    [Address(RVA = "0x26E0BD0", Offset = "0x26E0BD0", VA = "0x26E0BD0")]
    public static VectorOffset CreateArticlesVector(
      FlatBufferBuilder builder,
      Offset<ArticleData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601867A")]
    [Address(RVA = "0x26E0C78", Offset = "0x26E0C78", VA = "0x26E0C78")]
    public static VectorOffset CreateArticlesVectorBlock(
      FlatBufferBuilder builder,
      Offset<ArticleData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601867B")]
    [Address(RVA = "0x26E0D00", Offset = "0x26E0D00", VA = "0x26E0D00")]
    public static void StartArticlesVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601867C")]
    [Address(RVA = "0x26E0B68", Offset = "0x26E0B68", VA = "0x26E0B68")]
    public static Offset<BannerData> EndBannerData(FlatBufferBuilder builder)
    {
      return new Offset<BannerData>();
    }
  }
}
