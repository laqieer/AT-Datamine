// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.StoryGachaData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CE2")]
  public struct StoryGachaData : IFlatbufferObject
  {
    [Token(Token = "0x4010C43")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FE7")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018727"), Address(RVA = "0x26E38E0", Offset = "0x26E38E0", VA = "0x26E38E0", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018728")]
    [Address(RVA = "0x26E38E8", Offset = "0x26E38E8", VA = "0x26E38E8")]
    public static StoryGachaData GetRootAsStoryGachaData(ByteBuffer _bb) => new StoryGachaData();

    [Token(Token = "0x6018729")]
    [Address(RVA = "0x26E38F4", Offset = "0x26E38F4", VA = "0x26E38F4")]
    public static StoryGachaData GetRootAsStoryGachaData(ByteBuffer _bb, StoryGachaData obj)
    {
      return new StoryGachaData();
    }

    [Token(Token = "0x601872A")]
    [Address(RVA = "0x26E3950", Offset = "0x26E3950", VA = "0x26E3950")]
    public static bool StoryGachaDataBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x601872B")]
    [Address(RVA = "0x26E399C", Offset = "0x26E399C", VA = "0x26E399C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601872C")]
    [Address(RVA = "0x26E3938", Offset = "0x26E3938", VA = "0x26E3938")]
    public StoryGachaData __assign(int _i, ByteBuffer _bb) => new StoryGachaData();

    [Token(Token = "0x601872D")]
    [Address(RVA = "0x26E39A8", Offset = "0x26E39A8", VA = "0x26E39A8")]
    public StoryGachaReleaseNotificationIDData? ReleasedStoryGachaIds(int j)
    {
      return new StoryGachaReleaseNotificationIDData?();
    }

    [Token(Token = "0x17004FE8")]
    public int ReleasedStoryGachaIdsLength
    {
      [Token(Token = "0x601872E"), Address(RVA = "0x26E3A80", Offset = "0x26E3A80", VA = "0x26E3A80")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x601872F")]
    [Address(RVA = "0x26E3AB4", Offset = "0x26E3AB4", VA = "0x26E3AB4")]
    public StoryGachaReleaseNotificationTitleData? ReleasedStoryGachaTitles(int j)
    {
      return new StoryGachaReleaseNotificationTitleData?();
    }

    [Token(Token = "0x17004FE9")]
    public int ReleasedStoryGachaTitlesLength
    {
      [Token(Token = "0x6018730"), Address(RVA = "0x26E3B8C", Offset = "0x26E3B8C", VA = "0x26E3B8C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018731")]
    [Address(RVA = "0x26E3BC0", Offset = "0x26E3BC0", VA = "0x26E3BC0")]
    public static Offset<StoryGachaData> CreateStoryGachaData(
      FlatBufferBuilder builder,
      VectorOffset releasedStoryGachaIdsOffset = default (VectorOffset),
      VectorOffset releasedStoryGachaTitlesOffset = default (VectorOffset))
    {
      return new Offset<StoryGachaData>();
    }

    [Token(Token = "0x6018732")]
    [Address(RVA = "0x26E3CA8", Offset = "0x26E3CA8", VA = "0x26E3CA8")]
    public static void StartStoryGachaData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018733")]
    [Address(RVA = "0x26E3C38", Offset = "0x26E3C38", VA = "0x26E3C38")]
    public static void AddReleasedStoryGachaIds(
      FlatBufferBuilder builder,
      VectorOffset releasedStoryGachaIdsOffset)
    {
    }

    [Token(Token = "0x6018734")]
    [Address(RVA = "0x26E3CC0", Offset = "0x26E3CC0", VA = "0x26E3CC0")]
    public static VectorOffset CreateReleasedStoryGachaIdsVector(
      FlatBufferBuilder builder,
      Offset<StoryGachaReleaseNotificationIDData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018735")]
    [Address(RVA = "0x26E3D68", Offset = "0x26E3D68", VA = "0x26E3D68")]
    public static VectorOffset CreateReleasedStoryGachaIdsVectorBlock(
      FlatBufferBuilder builder,
      Offset<StoryGachaReleaseNotificationIDData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018736")]
    [Address(RVA = "0x26E3DF0", Offset = "0x26E3DF0", VA = "0x26E3DF0")]
    public static void StartReleasedStoryGachaIdsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018737")]
    [Address(RVA = "0x26E3C18", Offset = "0x26E3C18", VA = "0x26E3C18")]
    public static void AddReleasedStoryGachaTitles(
      FlatBufferBuilder builder,
      VectorOffset releasedStoryGachaTitlesOffset)
    {
    }

    [Token(Token = "0x6018738")]
    [Address(RVA = "0x26E3E10", Offset = "0x26E3E10", VA = "0x26E3E10")]
    public static VectorOffset CreateReleasedStoryGachaTitlesVector(
      FlatBufferBuilder builder,
      Offset<StoryGachaReleaseNotificationTitleData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018739")]
    [Address(RVA = "0x26E3EB8", Offset = "0x26E3EB8", VA = "0x26E3EB8")]
    public static VectorOffset CreateReleasedStoryGachaTitlesVectorBlock(
      FlatBufferBuilder builder,
      Offset<StoryGachaReleaseNotificationTitleData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601873A")]
    [Address(RVA = "0x26E3F40", Offset = "0x26E3F40", VA = "0x26E3F40")]
    public static void StartReleasedStoryGachaTitlesVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601873B")]
    [Address(RVA = "0x26E3C58", Offset = "0x26E3C58", VA = "0x26E3C58")]
    public static Offset<StoryGachaData> EndStoryGachaData(FlatBufferBuilder builder)
    {
      return new Offset<StoryGachaData>();
    }

    [Token(Token = "0x601873C")]
    [Address(RVA = "0x26E3F60", Offset = "0x26E3F60", VA = "0x26E3F60")]
    public static void FinishStoryGachaDataBuffer(
      FlatBufferBuilder builder,
      Offset<StoryGachaData> offset)
    {
    }

    [Token(Token = "0x601873D")]
    [Address(RVA = "0x26E3FBC", Offset = "0x26E3FBC", VA = "0x26E3FBC")]
    public static void FinishSizePrefixedStoryGachaDataBuffer(
      FlatBufferBuilder builder,
      Offset<StoryGachaData> offset)
    {
    }
  }
}
