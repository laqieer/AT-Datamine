// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ChapterShopReleaseData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C9A")]
  public struct ChapterShopReleaseData : IFlatbufferObject
  {
    [Token(Token = "0x4010BF9")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004EE1")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60181F3"), Address(RVA = "0x3B2216C", Offset = "0x3B2216C", VA = "0x3B2216C", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60181F4")]
    [Address(RVA = "0x3B22174", Offset = "0x3B22174", VA = "0x3B22174")]
    public static ChapterShopReleaseData GetRootAsChapterShopReleaseData(ByteBuffer _bb)
    {
      return new ChapterShopReleaseData();
    }

    [Token(Token = "0x60181F5")]
    [Address(RVA = "0x3B22180", Offset = "0x3B22180", VA = "0x3B22180")]
    public static ChapterShopReleaseData GetRootAsChapterShopReleaseData(
      ByteBuffer _bb,
      ChapterShopReleaseData obj)
    {
      return new ChapterShopReleaseData();
    }

    [Token(Token = "0x60181F6")]
    [Address(RVA = "0x3B221DC", Offset = "0x3B221DC", VA = "0x3B221DC", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60181F7")]
    [Address(RVA = "0x3B221C4", Offset = "0x3B221C4", VA = "0x3B221C4")]
    public ChapterShopReleaseData __assign(int _i, ByteBuffer _bb) => new ChapterShopReleaseData();

    [Token(Token = "0x17004EE2")]
    public int ChapterShopType
    {
      [Token(Token = "0x60181F8"), Address(RVA = "0x3B221E8", Offset = "0x3B221E8", VA = "0x3B221E8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EE3")]
    public int ShopLevel
    {
      [Token(Token = "0x60181F9"), Address(RVA = "0x3B2222C", Offset = "0x3B2222C", VA = "0x3B2222C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60181FA")]
    [Address(RVA = "0x3B22270", Offset = "0x3B22270", VA = "0x3B22270")]
    public int ShopItemIdList(int j) => new int();

    [Token(Token = "0x17004EE4")]
    public int ShopItemIdListLength
    {
      [Token(Token = "0x60181FB"), Address(RVA = "0x3B222D0", Offset = "0x3B222D0", VA = "0x3B222D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60181FC")]
    [Address(RVA = "0x3B22304", Offset = "0x3B22304", VA = "0x3B22304")]
    public ArraySegment<byte>? GetShopItemIdListBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x60181FD")]
    [Address(RVA = "0x3B2233C", Offset = "0x3B2233C", VA = "0x3B2233C")]
    public int[] GetShopItemIdListArray() => (int[]) null;

    [Token(Token = "0x60181FE")]
    [Address(RVA = "0x3B22388", Offset = "0x3B22388", VA = "0x3B22388")]
    public int ReleaseStoryAbilityIds(int j) => new int();

    [Token(Token = "0x17004EE5")]
    public int ReleaseStoryAbilityIdsLength
    {
      [Token(Token = "0x60181FF"), Address(RVA = "0x3B223E8", Offset = "0x3B223E8", VA = "0x3B223E8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018200")]
    [Address(RVA = "0x3B2241C", Offset = "0x3B2241C", VA = "0x3B2241C")]
    public ArraySegment<byte>? GetReleaseStoryAbilityIdsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6018201")]
    [Address(RVA = "0x3B22454", Offset = "0x3B22454", VA = "0x3B22454")]
    public int[] GetReleaseStoryAbilityIdsArray() => (int[]) null;

    [Token(Token = "0x6018202")]
    [Address(RVA = "0x3B224A0", Offset = "0x3B224A0", VA = "0x3B224A0")]
    public static Offset<ChapterShopReleaseData> CreateChapterShopReleaseData(
      FlatBufferBuilder builder,
      int chapter_shop_type = 0,
      int shopLevel = 0,
      VectorOffset shopItemIdListOffset = default (VectorOffset),
      VectorOffset release_story_ability_idsOffset = default (VectorOffset))
    {
      return new Offset<ChapterShopReleaseData>();
    }

    [Token(Token = "0x6018203")]
    [Address(RVA = "0x3B225F0", Offset = "0x3B225F0", VA = "0x3B225F0")]
    public static void StartChapterShopReleaseData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018204")]
    [Address(RVA = "0x3B22580", Offset = "0x3B22580", VA = "0x3B22580")]
    public static void AddChapterShopType(FlatBufferBuilder builder, int chapterShopType)
    {
    }

    [Token(Token = "0x6018205")]
    [Address(RVA = "0x3B22560", Offset = "0x3B22560", VA = "0x3B22560")]
    public static void AddShopLevel(FlatBufferBuilder builder, int shopLevel)
    {
    }

    [Token(Token = "0x6018206")]
    [Address(RVA = "0x3B22540", Offset = "0x3B22540", VA = "0x3B22540")]
    public static void AddShopItemIdList(
      FlatBufferBuilder builder,
      VectorOffset shopItemIdListOffset)
    {
    }

    [Token(Token = "0x6018207")]
    [Address(RVA = "0x3B22608", Offset = "0x3B22608", VA = "0x3B22608")]
    public static VectorOffset CreateShopItemIdListVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018208")]
    [Address(RVA = "0x3B226B0", Offset = "0x3B226B0", VA = "0x3B226B0")]
    public static VectorOffset CreateShopItemIdListVectorBlock(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018209")]
    [Address(RVA = "0x3B22738", Offset = "0x3B22738", VA = "0x3B22738")]
    public static void StartShopItemIdListVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601820A")]
    [Address(RVA = "0x3B22520", Offset = "0x3B22520", VA = "0x3B22520")]
    public static void AddReleaseStoryAbilityIds(
      FlatBufferBuilder builder,
      VectorOffset releaseStoryAbilityIdsOffset)
    {
    }

    [Token(Token = "0x601820B")]
    [Address(RVA = "0x3B22758", Offset = "0x3B22758", VA = "0x3B22758")]
    public static VectorOffset CreateReleaseStoryAbilityIdsVector(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601820C")]
    [Address(RVA = "0x3B22800", Offset = "0x3B22800", VA = "0x3B22800")]
    public static VectorOffset CreateReleaseStoryAbilityIdsVectorBlock(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601820D")]
    [Address(RVA = "0x3B22888", Offset = "0x3B22888", VA = "0x3B22888")]
    public static void StartReleaseStoryAbilityIdsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601820E")]
    [Address(RVA = "0x3B225A0", Offset = "0x3B225A0", VA = "0x3B225A0")]
    public static Offset<ChapterShopReleaseData> EndChapterShopReleaseData(FlatBufferBuilder builder)
    {
      return new Offset<ChapterShopReleaseData>();
    }
  }
}
