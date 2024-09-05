// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.BattleMissionProgress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C78")]
  public struct BattleMissionProgress : IFlatbufferObject
  {
    [Token(Token = "0x4010BD7")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004DE9")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017E50"), Address(RVA = "0x37C0210", Offset = "0x37C0210", VA = "0x37C0210", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017E51")]
    [Address(RVA = "0x37C0218", Offset = "0x37C0218", VA = "0x37C0218")]
    public static BattleMissionProgress GetRootAsBattleMissionProgress(ByteBuffer _bb)
    {
      return new BattleMissionProgress();
    }

    [Token(Token = "0x6017E52")]
    [Address(RVA = "0x37C0224", Offset = "0x37C0224", VA = "0x37C0224")]
    public static BattleMissionProgress GetRootAsBattleMissionProgress(
      ByteBuffer _bb,
      BattleMissionProgress obj)
    {
      return new BattleMissionProgress();
    }

    [Token(Token = "0x6017E53")]
    [Address(RVA = "0x37C0280", Offset = "0x37C0280", VA = "0x37C0280", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017E54")]
    [Address(RVA = "0x37C0268", Offset = "0x37C0268", VA = "0x37C0268")]
    public BattleMissionProgress __assign(int _i, ByteBuffer _bb) => new BattleMissionProgress();

    [Token(Token = "0x17004DEA")]
    public int QuestType
    {
      [Token(Token = "0x6017E55"), Address(RVA = "0x37C028C", Offset = "0x37C028C", VA = "0x37C028C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DEB")]
    public int MissionSetId
    {
      [Token(Token = "0x6017E56"), Address(RVA = "0x37C02D0", Offset = "0x37C02D0", VA = "0x37C02D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017E57")]
    [Address(RVA = "0x37C0314", Offset = "0x37C0314", VA = "0x37C0314")]
    public MatchCountData? MissionMatchCountDic(int j) => new MatchCountData?();

    [Token(Token = "0x17004DEC")]
    public int MissionMatchCountDicLength
    {
      [Token(Token = "0x6017E58"), Address(RVA = "0x37C03C8", Offset = "0x37C03C8", VA = "0x37C03C8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017E59")]
    [Address(RVA = "0x37C03FC", Offset = "0x37C03FC", VA = "0x37C03FC")]
    public static Offset<BattleMissionProgress> CreateBattleMissionProgress(
      FlatBufferBuilder builder,
      int questType = 0,
      int missionSetId = 0,
      VectorOffset missionMatchCountDicOffset = default (VectorOffset))
    {
      return new Offset<BattleMissionProgress>();
    }

    [Token(Token = "0x6017E5A")]
    [Address(RVA = "0x37C051C", Offset = "0x37C051C", VA = "0x37C051C")]
    public static void StartBattleMissionProgress(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017E5B")]
    [Address(RVA = "0x37C04AC", Offset = "0x37C04AC", VA = "0x37C04AC")]
    public static void AddQuestType(FlatBufferBuilder builder, int questType)
    {
    }

    [Token(Token = "0x6017E5C")]
    [Address(RVA = "0x37C048C", Offset = "0x37C048C", VA = "0x37C048C")]
    public static void AddMissionSetId(FlatBufferBuilder builder, int missionSetId)
    {
    }

    [Token(Token = "0x6017E5D")]
    [Address(RVA = "0x37C046C", Offset = "0x37C046C", VA = "0x37C046C")]
    public static void AddMissionMatchCountDic(
      FlatBufferBuilder builder,
      VectorOffset missionMatchCountDicOffset)
    {
    }

    [Token(Token = "0x6017E5E")]
    [Address(RVA = "0x37C0534", Offset = "0x37C0534", VA = "0x37C0534")]
    public static VectorOffset CreateMissionMatchCountDicVector(
      FlatBufferBuilder builder,
      Offset<MatchCountData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017E5F")]
    [Address(RVA = "0x37C05DC", Offset = "0x37C05DC", VA = "0x37C05DC")]
    public static VectorOffset CreateMissionMatchCountDicVectorBlock(
      FlatBufferBuilder builder,
      Offset<MatchCountData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017E60")]
    [Address(RVA = "0x37C0664", Offset = "0x37C0664", VA = "0x37C0664")]
    public static void StartMissionMatchCountDicVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017E61")]
    [Address(RVA = "0x37C04CC", Offset = "0x37C04CC", VA = "0x37C04CC")]
    public static Offset<BattleMissionProgress> EndBattleMissionProgress(FlatBufferBuilder builder)
    {
      return new Offset<BattleMissionProgress>();
    }
  }
}
