// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.SceneParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C80")]
  public struct SceneParameter : IFlatbufferObject
  {
    [Token(Token = "0x4010BDF")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004E06")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017ED4"), Address(RVA = "0x37C1E08", Offset = "0x37C1E08", VA = "0x37C1E08", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017ED5")]
    [Address(RVA = "0x37C1E10", Offset = "0x37C1E10", VA = "0x37C1E10")]
    public static SceneParameter GetRootAsSceneParameter(ByteBuffer _bb) => new SceneParameter();

    [Token(Token = "0x6017ED6")]
    [Address(RVA = "0x37C1E1C", Offset = "0x37C1E1C", VA = "0x37C1E1C")]
    public static SceneParameter GetRootAsSceneParameter(ByteBuffer _bb, SceneParameter obj)
    {
      return new SceneParameter();
    }

    [Token(Token = "0x6017ED7")]
    [Address(RVA = "0x37C1E78", Offset = "0x37C1E78", VA = "0x37C1E78")]
    public static bool SceneParameterBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6017ED8")]
    [Address(RVA = "0x37C1EC4", Offset = "0x37C1EC4", VA = "0x37C1EC4", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017ED9")]
    [Address(RVA = "0x37C1E60", Offset = "0x37C1E60", VA = "0x37C1E60")]
    public SceneParameter __assign(int _i, ByteBuffer _bb) => new SceneParameter();

    [Token(Token = "0x17004E07")]
    public string AppVersion
    {
      [Token(Token = "0x6017EDA"), Address(RVA = "0x37C1ED0", Offset = "0x37C1ED0", VA = "0x37C1ED0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6017EDB")]
    [Address(RVA = "0x37C1F0C", Offset = "0x37C1F0C", VA = "0x37C1F0C")]
    public ArraySegment<byte>? GetAppVersionBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017EDC")]
    [Address(RVA = "0x37C1F44", Offset = "0x37C1F44", VA = "0x37C1F44")]
    public byte[] GetAppVersionArray() => (byte[]) null;

    [Token(Token = "0x17004E08")]
    public string DlcVersion
    {
      [Token(Token = "0x6017EDD"), Address(RVA = "0x37C1F90", Offset = "0x37C1F90", VA = "0x37C1F90")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6017EDE")]
    [Address(RVA = "0x37C1FCC", Offset = "0x37C1FCC", VA = "0x37C1FCC")]
    public ArraySegment<byte>? GetDlcVersionBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017EDF")]
    [Address(RVA = "0x37C2004", Offset = "0x37C2004", VA = "0x37C2004")]
    public byte[] GetDlcVersionArray() => (byte[]) null;

    [Token(Token = "0x17004E09")]
    public string BattleUuid
    {
      [Token(Token = "0x6017EE0"), Address(RVA = "0x37C2050", Offset = "0x37C2050", VA = "0x37C2050")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6017EE1")]
    [Address(RVA = "0x37C208C", Offset = "0x37C208C", VA = "0x37C208C")]
    public ArraySegment<byte>? GetBattleUuidBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017EE2")]
    [Address(RVA = "0x37C20C4", Offset = "0x37C20C4", VA = "0x37C20C4")]
    public byte[] GetBattleUuidArray() => (byte[]) null;

    [Token(Token = "0x17004E0A")]
    public int Seed
    {
      [Token(Token = "0x6017EE3"), Address(RVA = "0x37C2110", Offset = "0x37C2110", VA = "0x37C2110")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E0B")]
    public int QuestType
    {
      [Token(Token = "0x6017EE4"), Address(RVA = "0x37C2154", Offset = "0x37C2154", VA = "0x37C2154")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E0C")]
    public int QuestId
    {
      [Token(Token = "0x6017EE5"), Address(RVA = "0x37C2198", Offset = "0x37C2198", VA = "0x37C2198")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E0D")]
    public int LapCount
    {
      [Token(Token = "0x6017EE6"), Address(RVA = "0x37C21DC", Offset = "0x37C21DC", VA = "0x37C21DC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E0E")]
    public int InitDamage
    {
      [Token(Token = "0x6017EE7"), Address(RVA = "0x37C2220", Offset = "0x37C2220", VA = "0x37C2220")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E0F")]
    public int DeckIndex
    {
      [Token(Token = "0x6017EE8"), Address(RVA = "0x37C2264", Offset = "0x37C2264", VA = "0x37C2264")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017EE9")]
    [Address(RVA = "0x37C22A8", Offset = "0x37C22A8", VA = "0x37C22A8")]
    public int SortieDeckSlots(int j) => new int();

    [Token(Token = "0x17004E10")]
    public int SortieDeckSlotsLength
    {
      [Token(Token = "0x6017EEA"), Address(RVA = "0x37C2308", Offset = "0x37C2308", VA = "0x37C2308")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017EEB")]
    [Address(RVA = "0x37C233C", Offset = "0x37C233C", VA = "0x37C233C")]
    public ArraySegment<byte>? GetSortieDeckSlotsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017EEC")]
    [Address(RVA = "0x37C2374", Offset = "0x37C2374", VA = "0x37C2374")]
    public int[] GetSortieDeckSlotsArray() => (int[]) null;

    [Token(Token = "0x17004E11")]
    public int SubQuestTaskId
    {
      [Token(Token = "0x6017EED"), Address(RVA = "0x37C23C0", Offset = "0x37C23C0", VA = "0x37C23C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017EEE")]
    [Address(RVA = "0x37C2404", Offset = "0x37C2404", VA = "0x37C2404")]
    public ExpendableInfo? ExpendableInfos(int j) => new ExpendableInfo?();

    [Token(Token = "0x17004E12")]
    public int ExpendableInfosLength
    {
      [Token(Token = "0x6017EEF"), Address(RVA = "0x37C24B8", Offset = "0x37C24B8", VA = "0x37C24B8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017EF0")]
    [Address(RVA = "0x37C24EC", Offset = "0x37C24EC", VA = "0x37C24EC")]
    public ChestDropInfo? ChestDropInfos(int j) => new ChestDropInfo?();

    [Token(Token = "0x17004E13")]
    public int ChestDropInfosLength
    {
      [Token(Token = "0x6017EF1"), Address(RVA = "0x37C25A0", Offset = "0x37C25A0", VA = "0x37C25A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017EF2")]
    [Address(RVA = "0x37C25D4", Offset = "0x37C25D4", VA = "0x37C25D4")]
    public EnemyDropInfo? EnemyDropInfos(int j) => new EnemyDropInfo?();

    [Token(Token = "0x17004E14")]
    public int EnemyDropInfosLength
    {
      [Token(Token = "0x6017EF3"), Address(RVA = "0x37C2688", Offset = "0x37C2688", VA = "0x37C2688")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017EF4")]
    [Address(RVA = "0x37C26BC", Offset = "0x37C26BC", VA = "0x37C26BC")]
    public LvUpParamInfo? LvupParamInfos(int j) => new LvUpParamInfo?();

    [Token(Token = "0x17004E15")]
    public int LvupParamInfosLength
    {
      [Token(Token = "0x6017EF5"), Address(RVA = "0x37C2770", Offset = "0x37C2770", VA = "0x37C2770")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E16")]
    public int TimeSlot
    {
      [Token(Token = "0x6017EF6"), Address(RVA = "0x37C27A4", Offset = "0x37C27A4", VA = "0x37C27A4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E17")]
    public int Weather
    {
      [Token(Token = "0x6017EF7"), Address(RVA = "0x37C27E8", Offset = "0x37C27E8", VA = "0x37C27E8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017EF8")]
    [Address(RVA = "0x37C282C", Offset = "0x37C282C", VA = "0x37C282C")]
    public static Offset<SceneParameter> CreateSceneParameter(
      FlatBufferBuilder builder,
      StringOffset appVersionOffset = default (StringOffset),
      StringOffset dlcVersionOffset = default (StringOffset),
      StringOffset battleUuidOffset = default (StringOffset),
      int seed = 0,
      int questType = 0,
      int questId = 0,
      int lapCount = 0,
      int initDamage = 0,
      int deckIndex = 0,
      VectorOffset sortieDeckSlotsOffset = default (VectorOffset),
      int subQuestTaskId = 0,
      VectorOffset expendableInfosOffset = default (VectorOffset),
      VectorOffset chestDropInfosOffset = default (VectorOffset),
      VectorOffset enemyDropInfosOffset = default (VectorOffset),
      VectorOffset lvupParamInfosOffset = default (VectorOffset),
      int timeSlot = 0,
      int weather = 0)
    {
      return new Offset<SceneParameter>();
    }

    [Token(Token = "0x6017EF9")]
    [Address(RVA = "0x37C2C04", Offset = "0x37C2C04", VA = "0x37C2C04")]
    public static void StartSceneParameter(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017EFA")]
    [Address(RVA = "0x37C2B94", Offset = "0x37C2B94", VA = "0x37C2B94")]
    public static void AddAppVersion(FlatBufferBuilder builder, StringOffset appVersionOffset)
    {
    }

    [Token(Token = "0x6017EFB")]
    [Address(RVA = "0x37C2B74", Offset = "0x37C2B74", VA = "0x37C2B74")]
    public static void AddDlcVersion(FlatBufferBuilder builder, StringOffset dlcVersionOffset)
    {
    }

    [Token(Token = "0x6017EFC")]
    [Address(RVA = "0x37C2B54", Offset = "0x37C2B54", VA = "0x37C2B54")]
    public static void AddBattleUuid(FlatBufferBuilder builder, StringOffset battleUuidOffset)
    {
    }

    [Token(Token = "0x6017EFD")]
    [Address(RVA = "0x37C2B34", Offset = "0x37C2B34", VA = "0x37C2B34")]
    public static void AddSeed(FlatBufferBuilder builder, int seed)
    {
    }

    [Token(Token = "0x6017EFE")]
    [Address(RVA = "0x37C2B14", Offset = "0x37C2B14", VA = "0x37C2B14")]
    public static void AddQuestType(FlatBufferBuilder builder, int questType)
    {
    }

    [Token(Token = "0x6017EFF")]
    [Address(RVA = "0x37C2AF4", Offset = "0x37C2AF4", VA = "0x37C2AF4")]
    public static void AddQuestId(FlatBufferBuilder builder, int questId)
    {
    }

    [Token(Token = "0x6017F00")]
    [Address(RVA = "0x37C2AD4", Offset = "0x37C2AD4", VA = "0x37C2AD4")]
    public static void AddLapCount(FlatBufferBuilder builder, int lapCount)
    {
    }

    [Token(Token = "0x6017F01")]
    [Address(RVA = "0x37C2AB4", Offset = "0x37C2AB4", VA = "0x37C2AB4")]
    public static void AddInitDamage(FlatBufferBuilder builder, int initDamage)
    {
    }

    [Token(Token = "0x6017F02")]
    [Address(RVA = "0x37C2A94", Offset = "0x37C2A94", VA = "0x37C2A94")]
    public static void AddDeckIndex(FlatBufferBuilder builder, int deckIndex)
    {
    }

    [Token(Token = "0x6017F03")]
    [Address(RVA = "0x37C2A74", Offset = "0x37C2A74", VA = "0x37C2A74")]
    public static void AddSortieDeckSlots(
      FlatBufferBuilder builder,
      VectorOffset sortieDeckSlotsOffset)
    {
    }

    [Token(Token = "0x6017F04")]
    [Address(RVA = "0x37C2C1C", Offset = "0x37C2C1C", VA = "0x37C2C1C")]
    public static VectorOffset CreateSortieDeckSlotsVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017F05")]
    [Address(RVA = "0x37C2CC4", Offset = "0x37C2CC4", VA = "0x37C2CC4")]
    public static VectorOffset CreateSortieDeckSlotsVectorBlock(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017F06")]
    [Address(RVA = "0x37C2D4C", Offset = "0x37C2D4C", VA = "0x37C2D4C")]
    public static void StartSortieDeckSlotsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017F07")]
    [Address(RVA = "0x37C2A54", Offset = "0x37C2A54", VA = "0x37C2A54")]
    public static void AddSubQuestTaskId(FlatBufferBuilder builder, int subQuestTaskId)
    {
    }

    [Token(Token = "0x6017F08")]
    [Address(RVA = "0x37C2A34", Offset = "0x37C2A34", VA = "0x37C2A34")]
    public static void AddExpendableInfos(
      FlatBufferBuilder builder,
      VectorOffset expendableInfosOffset)
    {
    }

    [Token(Token = "0x6017F09")]
    [Address(RVA = "0x37C2D6C", Offset = "0x37C2D6C", VA = "0x37C2D6C")]
    public static VectorOffset CreateExpendableInfosVector(
      FlatBufferBuilder builder,
      Offset<ExpendableInfo>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017F0A")]
    [Address(RVA = "0x37C2E14", Offset = "0x37C2E14", VA = "0x37C2E14")]
    public static VectorOffset CreateExpendableInfosVectorBlock(
      FlatBufferBuilder builder,
      Offset<ExpendableInfo>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017F0B")]
    [Address(RVA = "0x37C2E9C", Offset = "0x37C2E9C", VA = "0x37C2E9C")]
    public static void StartExpendableInfosVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017F0C")]
    [Address(RVA = "0x37C2A14", Offset = "0x37C2A14", VA = "0x37C2A14")]
    public static void AddChestDropInfos(
      FlatBufferBuilder builder,
      VectorOffset chestDropInfosOffset)
    {
    }

    [Token(Token = "0x6017F0D")]
    [Address(RVA = "0x37C2EBC", Offset = "0x37C2EBC", VA = "0x37C2EBC")]
    public static VectorOffset CreateChestDropInfosVector(
      FlatBufferBuilder builder,
      Offset<ChestDropInfo>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017F0E")]
    [Address(RVA = "0x37C2F64", Offset = "0x37C2F64", VA = "0x37C2F64")]
    public static VectorOffset CreateChestDropInfosVectorBlock(
      FlatBufferBuilder builder,
      Offset<ChestDropInfo>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017F0F")]
    [Address(RVA = "0x37C2FEC", Offset = "0x37C2FEC", VA = "0x37C2FEC")]
    public static void StartChestDropInfosVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017F10")]
    [Address(RVA = "0x37C29F4", Offset = "0x37C29F4", VA = "0x37C29F4")]
    public static void AddEnemyDropInfos(
      FlatBufferBuilder builder,
      VectorOffset enemyDropInfosOffset)
    {
    }

    [Token(Token = "0x6017F11")]
    [Address(RVA = "0x37C300C", Offset = "0x37C300C", VA = "0x37C300C")]
    public static VectorOffset CreateEnemyDropInfosVector(
      FlatBufferBuilder builder,
      Offset<EnemyDropInfo>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017F12")]
    [Address(RVA = "0x37C30B4", Offset = "0x37C30B4", VA = "0x37C30B4")]
    public static VectorOffset CreateEnemyDropInfosVectorBlock(
      FlatBufferBuilder builder,
      Offset<EnemyDropInfo>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017F13")]
    [Address(RVA = "0x37C313C", Offset = "0x37C313C", VA = "0x37C313C")]
    public static void StartEnemyDropInfosVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017F14")]
    [Address(RVA = "0x37C29D4", Offset = "0x37C29D4", VA = "0x37C29D4")]
    public static void AddLvupParamInfos(
      FlatBufferBuilder builder,
      VectorOffset lvupParamInfosOffset)
    {
    }

    [Token(Token = "0x6017F15")]
    [Address(RVA = "0x37C315C", Offset = "0x37C315C", VA = "0x37C315C")]
    public static VectorOffset CreateLvupParamInfosVector(
      FlatBufferBuilder builder,
      Offset<LvUpParamInfo>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017F16")]
    [Address(RVA = "0x37C3204", Offset = "0x37C3204", VA = "0x37C3204")]
    public static VectorOffset CreateLvupParamInfosVectorBlock(
      FlatBufferBuilder builder,
      Offset<LvUpParamInfo>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017F17")]
    [Address(RVA = "0x37C328C", Offset = "0x37C328C", VA = "0x37C328C")]
    public static void StartLvupParamInfosVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017F18")]
    [Address(RVA = "0x37C29B4", Offset = "0x37C29B4", VA = "0x37C29B4")]
    public static void AddTimeSlot(FlatBufferBuilder builder, int timeSlot)
    {
    }

    [Token(Token = "0x6017F19")]
    [Address(RVA = "0x37C2994", Offset = "0x37C2994", VA = "0x37C2994")]
    public static void AddWeather(FlatBufferBuilder builder, int weather)
    {
    }

    [Token(Token = "0x6017F1A")]
    [Address(RVA = "0x37C2BB4", Offset = "0x37C2BB4", VA = "0x37C2BB4")]
    public static Offset<SceneParameter> EndSceneParameter(FlatBufferBuilder builder)
    {
      return new Offset<SceneParameter>();
    }

    [Token(Token = "0x6017F1B")]
    [Address(RVA = "0x37C32AC", Offset = "0x37C32AC", VA = "0x37C32AC")]
    public static void FinishSceneParameterBuffer(
      FlatBufferBuilder builder,
      Offset<SceneParameter> offset)
    {
    }

    [Token(Token = "0x6017F1C")]
    [Address(RVA = "0x37C3308", Offset = "0x37C3308", VA = "0x37C3308")]
    public static void FinishSizePrefixedSceneParameterBuffer(
      FlatBufferBuilder builder,
      Offset<SceneParameter> offset)
    {
    }
  }
}
