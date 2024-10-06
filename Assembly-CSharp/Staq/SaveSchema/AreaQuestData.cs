// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.AreaQuestData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C64")]
  public struct AreaQuestData : IFlatbufferObject
  {
    [Token(Token = "0x4010BC3")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004D51")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017BE4"), Address(RVA = "0x37B5FE8", Offset = "0x37B5FE8", VA = "0x37B5FE8", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017BE5")]
    [Address(RVA = "0x37B5FF0", Offset = "0x37B5FF0", VA = "0x37B5FF0")]
    public static AreaQuestData GetRootAsAreaQuestData(ByteBuffer _bb) => new AreaQuestData();

    [Token(Token = "0x6017BE6")]
    [Address(RVA = "0x37B5FFC", Offset = "0x37B5FFC", VA = "0x37B5FFC")]
    public static AreaQuestData GetRootAsAreaQuestData(ByteBuffer _bb, AreaQuestData obj)
    {
      return new AreaQuestData();
    }

    [Token(Token = "0x6017BE7")]
    [Address(RVA = "0x37B6058", Offset = "0x37B6058", VA = "0x37B6058")]
    public static bool AreaQuestDataBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6017BE8")]
    [Address(RVA = "0x37B60A4", Offset = "0x37B60A4", VA = "0x37B60A4", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017BE9")]
    [Address(RVA = "0x37B6040", Offset = "0x37B6040", VA = "0x37B6040")]
    public AreaQuestData __assign(int _i, ByteBuffer _bb) => new AreaQuestData();

    [Token(Token = "0x17004D52")]
    public int AreaGroupId
    {
      [Token(Token = "0x6017BEA"), Address(RVA = "0x37B60B0", Offset = "0x37B60B0", VA = "0x37B60B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D53")]
    public int AreaId
    {
      [Token(Token = "0x6017BEB"), Address(RVA = "0x37B60F4", Offset = "0x37B60F4", VA = "0x37B60F4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D54")]
    public int AreaNodeId
    {
      [Token(Token = "0x6017BEC"), Address(RVA = "0x37B6138", Offset = "0x37B6138", VA = "0x37B6138")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D55")]
    public int AreaNodeDifficulty
    {
      [Token(Token = "0x6017BED"), Address(RVA = "0x37B617C", Offset = "0x37B617C", VA = "0x37B617C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D56")]
    public int DifficultySelectCache
    {
      [Token(Token = "0x6017BEE"), Address(RVA = "0x37B61C0", Offset = "0x37B61C0", VA = "0x37B61C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D57")]
    public bool AreaNodeScenarioSkipSetting
    {
      [Token(Token = "0x6017BEF"), Address(RVA = "0x37B6204", Offset = "0x37B6204", VA = "0x37B6204")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6017BF0")]
    [Address(RVA = "0x37B624C", Offset = "0x37B624C", VA = "0x37B624C")]
    public static Offset<AreaQuestData> CreateAreaQuestData(
      FlatBufferBuilder builder,
      int areaGroupId = 0,
      int areaId = 0,
      int areaNodeId = 0,
      int areaNodeDifficulty = 0,
      int difficultySelectCache = 0,
      bool areaNodeScenarioSkipSetting = false)
    {
      return new Offset<AreaQuestData>();
    }

    [Token(Token = "0x6017BF1")]
    [Address(RVA = "0x37B6404", Offset = "0x37B6404", VA = "0x37B6404")]
    public static void StartAreaQuestData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017BF2")]
    [Address(RVA = "0x37B6374", Offset = "0x37B6374", VA = "0x37B6374")]
    public static void AddAreaGroupId(FlatBufferBuilder builder, int areaGroupId)
    {
    }

    [Token(Token = "0x6017BF3")]
    [Address(RVA = "0x37B6354", Offset = "0x37B6354", VA = "0x37B6354")]
    public static void AddAreaId(FlatBufferBuilder builder, int areaId)
    {
    }

    [Token(Token = "0x6017BF4")]
    [Address(RVA = "0x37B6334", Offset = "0x37B6334", VA = "0x37B6334")]
    public static void AddAreaNodeId(FlatBufferBuilder builder, int areaNodeId)
    {
    }

    [Token(Token = "0x6017BF5")]
    [Address(RVA = "0x37B6314", Offset = "0x37B6314", VA = "0x37B6314")]
    public static void AddAreaNodeDifficulty(FlatBufferBuilder builder, int areaNodeDifficulty)
    {
    }

    [Token(Token = "0x6017BF6")]
    [Address(RVA = "0x37B62F4", Offset = "0x37B62F4", VA = "0x37B62F4")]
    public static void AddDifficultySelectCache(
      FlatBufferBuilder builder,
      int difficultySelectCache)
    {
    }

    [Token(Token = "0x6017BF7")]
    [Address(RVA = "0x37B6394", Offset = "0x37B6394", VA = "0x37B6394")]
    public static void AddAreaNodeScenarioSkipSetting(
      FlatBufferBuilder builder,
      bool areaNodeScenarioSkipSetting)
    {
    }

    [Token(Token = "0x6017BF8")]
    [Address(RVA = "0x37B63B4", Offset = "0x37B63B4", VA = "0x37B63B4")]
    public static Offset<AreaQuestData> EndAreaQuestData(FlatBufferBuilder builder)
    {
      return new Offset<AreaQuestData>();
    }

    [Token(Token = "0x6017BF9")]
    [Address(RVA = "0x37B641C", Offset = "0x37B641C", VA = "0x37B641C")]
    public static void FinishAreaQuestDataBuffer(
      FlatBufferBuilder builder,
      Offset<AreaQuestData> offset)
    {
    }

    [Token(Token = "0x6017BFA")]
    [Address(RVA = "0x37B6478", Offset = "0x37B6478", VA = "0x37B6478")]
    public static void FinishSizePrefixedAreaQuestDataBuffer(
      FlatBufferBuilder builder,
      Offset<AreaQuestData> offset)
    {
    }
  }
}
