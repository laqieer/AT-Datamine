// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.BattleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C68")]
  public struct BattleData : IFlatbufferObject
  {
    [Token(Token = "0x4010BC7")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004D67")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017C38"), Address(RVA = "0x37B7304", Offset = "0x37B7304", VA = "0x37B7304", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017C39")]
    [Address(RVA = "0x37B730C", Offset = "0x37B730C", VA = "0x37B730C")]
    public static BattleData GetRootAsBattleData(ByteBuffer _bb) => new BattleData();

    [Token(Token = "0x6017C3A")]
    [Address(RVA = "0x37B7318", Offset = "0x37B7318", VA = "0x37B7318")]
    public static BattleData GetRootAsBattleData(ByteBuffer _bb, BattleData obj)
    {
      return new BattleData();
    }

    [Token(Token = "0x6017C3B")]
    [Address(RVA = "0x37B7374", Offset = "0x37B7374", VA = "0x37B7374")]
    public static bool BattleDataBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6017C3C")]
    [Address(RVA = "0x37B73C0", Offset = "0x37B73C0", VA = "0x37B73C0", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017C3D")]
    [Address(RVA = "0x37B735C", Offset = "0x37B735C", VA = "0x37B735C")]
    public BattleData __assign(int _i, ByteBuffer _bb) => new BattleData();

    [Token(Token = "0x17004D68")]
    public int QuestType
    {
      [Token(Token = "0x6017C3E"), Address(RVA = "0x37B73CC", Offset = "0x37B73CC", VA = "0x37B73CC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D69")]
    public int MasterId
    {
      [Token(Token = "0x6017C3F"), Address(RVA = "0x37B7410", Offset = "0x37B7410", VA = "0x37B7410")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017C40")]
    [Address(RVA = "0x37B7454", Offset = "0x37B7454", VA = "0x37B7454")]
    public int PlayerTurnOrder(int j) => new int();

    [Token(Token = "0x17004D6A")]
    public int PlayerTurnOrderLength
    {
      [Token(Token = "0x6017C41"), Address(RVA = "0x37B74B4", Offset = "0x37B74B4", VA = "0x37B74B4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017C42")]
    [Address(RVA = "0x37B74E8", Offset = "0x37B74E8", VA = "0x37B74E8")]
    public ArraySegment<byte>? GetPlayerTurnOrderBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017C43")]
    [Address(RVA = "0x37B7520", Offset = "0x37B7520", VA = "0x37B7520")]
    public int[] GetPlayerTurnOrderArray() => (int[]) null;

    [Token(Token = "0x17004D6B")]
    public int Time
    {
      [Token(Token = "0x6017C44"), Address(RVA = "0x37B756C", Offset = "0x37B756C", VA = "0x37B756C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D6C")]
    public int Weather
    {
      [Token(Token = "0x6017C45"), Address(RVA = "0x37B75B0", Offset = "0x37B75B0", VA = "0x37B75B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017C46")]
    [Address(RVA = "0x37B75F4", Offset = "0x37B75F4", VA = "0x37B75F4")]
    public EffectData? Effects(int j) => new EffectData?();

    [Token(Token = "0x17004D6D")]
    public int EffectsLength
    {
      [Token(Token = "0x6017C47"), Address(RVA = "0x37B76C0", Offset = "0x37B76C0", VA = "0x37B76C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017C48")]
    [Address(RVA = "0x37B76F4", Offset = "0x37B76F4", VA = "0x37B76F4")]
    public SkillData? Skills(int j) => new SkillData?();

    [Token(Token = "0x17004D6E")]
    public int SkillsLength
    {
      [Token(Token = "0x6017C49"), Address(RVA = "0x37B77C0", Offset = "0x37B77C0", VA = "0x37B77C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017C4A")]
    [Address(RVA = "0x37B77F4", Offset = "0x37B77F4", VA = "0x37B77F4")]
    public UnitData? Units(int j) => new UnitData?();

    [Token(Token = "0x17004D6F")]
    public int UnitsLength
    {
      [Token(Token = "0x6017C4B"), Address(RVA = "0x37B78C0", Offset = "0x37B78C0", VA = "0x37B78C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017C4C")]
    [Address(RVA = "0x37B78F4", Offset = "0x37B78F4", VA = "0x37B78F4")]
    public WeaponData? Weapons(int j) => new WeaponData?();

    [Token(Token = "0x17004D70")]
    public int WeaponsLength
    {
      [Token(Token = "0x6017C4D"), Address(RVA = "0x37B79C0", Offset = "0x37B79C0", VA = "0x37B79C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017C4E")]
    [Address(RVA = "0x37B79F4", Offset = "0x37B79F4", VA = "0x37B79F4")]
    public AccessoryData? Accessories(int j) => new AccessoryData?();

    [Token(Token = "0x17004D71")]
    public int AccessoriesLength
    {
      [Token(Token = "0x6017C4F"), Address(RVA = "0x37B7AC0", Offset = "0x37B7AC0", VA = "0x37B7AC0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017C50")]
    [Address(RVA = "0x37B7AF4", Offset = "0x37B7AF4", VA = "0x37B7AF4")]
    public MindEquipmentData? MindEquipments(int j) => new MindEquipmentData?();

    [Token(Token = "0x17004D72")]
    public int MindEquipmentsLength
    {
      [Token(Token = "0x6017C51"), Address(RVA = "0x37B7BC0", Offset = "0x37B7BC0", VA = "0x37B7BC0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017C52")]
    [Address(RVA = "0x37B7BF4", Offset = "0x37B7BF4", VA = "0x37B7BF4")]
    public TrustData? Trusts(int j) => new TrustData?();

    [Token(Token = "0x17004D73")]
    public int TrustsLength
    {
      [Token(Token = "0x6017C53"), Address(RVA = "0x37B7CC0", Offset = "0x37B7CC0", VA = "0x37B7CC0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017C54")]
    [Address(RVA = "0x37B7CF4", Offset = "0x37B7CF4", VA = "0x37B7CF4")]
    public static Offset<BattleData> CreateBattleData(
      FlatBufferBuilder builder,
      int questType = 0,
      int masterId = 0,
      VectorOffset playerTurnOrderOffset = default (VectorOffset),
      int time = 0,
      int weather = 0,
      VectorOffset effectsOffset = default (VectorOffset),
      VectorOffset skillsOffset = default (VectorOffset),
      VectorOffset unitsOffset = default (VectorOffset),
      VectorOffset weaponsOffset = default (VectorOffset),
      VectorOffset accessoriesOffset = default (VectorOffset),
      VectorOffset mindEquipmentsOffset = default (VectorOffset),
      VectorOffset trustsOffset = default (VectorOffset))
    {
      return new Offset<BattleData>();
    }

    [Token(Token = "0x6017C55")]
    [Address(RVA = "0x37B7FD8", Offset = "0x37B7FD8", VA = "0x37B7FD8")]
    public static void StartBattleData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017C56")]
    [Address(RVA = "0x37B7F68", Offset = "0x37B7F68", VA = "0x37B7F68")]
    public static void AddQuestType(FlatBufferBuilder builder, int questType)
    {
    }

    [Token(Token = "0x6017C57")]
    [Address(RVA = "0x37B7F48", Offset = "0x37B7F48", VA = "0x37B7F48")]
    public static void AddMasterId(FlatBufferBuilder builder, int masterId)
    {
    }

    [Token(Token = "0x6017C58")]
    [Address(RVA = "0x37B7F28", Offset = "0x37B7F28", VA = "0x37B7F28")]
    public static void AddPlayerTurnOrder(
      FlatBufferBuilder builder,
      VectorOffset playerTurnOrderOffset)
    {
    }

    [Token(Token = "0x6017C59")]
    [Address(RVA = "0x37B7FF0", Offset = "0x37B7FF0", VA = "0x37B7FF0")]
    public static VectorOffset CreatePlayerTurnOrderVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017C5A")]
    [Address(RVA = "0x37B8098", Offset = "0x37B8098", VA = "0x37B8098")]
    public static VectorOffset CreatePlayerTurnOrderVectorBlock(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017C5B")]
    [Address(RVA = "0x37B8120", Offset = "0x37B8120", VA = "0x37B8120")]
    public static void StartPlayerTurnOrderVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017C5C")]
    [Address(RVA = "0x37B7F08", Offset = "0x37B7F08", VA = "0x37B7F08")]
    public static void AddTime(FlatBufferBuilder builder, int time)
    {
    }

    [Token(Token = "0x6017C5D")]
    [Address(RVA = "0x37B7EE8", Offset = "0x37B7EE8", VA = "0x37B7EE8")]
    public static void AddWeather(FlatBufferBuilder builder, int weather)
    {
    }

    [Token(Token = "0x6017C5E")]
    [Address(RVA = "0x37B7EC8", Offset = "0x37B7EC8", VA = "0x37B7EC8")]
    public static void AddEffects(FlatBufferBuilder builder, VectorOffset effectsOffset)
    {
    }

    [Token(Token = "0x6017C5F")]
    [Address(RVA = "0x37B8140", Offset = "0x37B8140", VA = "0x37B8140")]
    public static VectorOffset CreateEffectsVector(
      FlatBufferBuilder builder,
      Offset<EffectData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017C60")]
    [Address(RVA = "0x37B81E8", Offset = "0x37B81E8", VA = "0x37B81E8")]
    public static VectorOffset CreateEffectsVectorBlock(
      FlatBufferBuilder builder,
      Offset<EffectData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017C61")]
    [Address(RVA = "0x37B8270", Offset = "0x37B8270", VA = "0x37B8270")]
    public static void StartEffectsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017C62")]
    [Address(RVA = "0x37B7EA8", Offset = "0x37B7EA8", VA = "0x37B7EA8")]
    public static void AddSkills(FlatBufferBuilder builder, VectorOffset skillsOffset)
    {
    }

    [Token(Token = "0x6017C63")]
    [Address(RVA = "0x37B8290", Offset = "0x37B8290", VA = "0x37B8290")]
    public static VectorOffset CreateSkillsVector(
      FlatBufferBuilder builder,
      Offset<SkillData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017C64")]
    [Address(RVA = "0x37B8338", Offset = "0x37B8338", VA = "0x37B8338")]
    public static VectorOffset CreateSkillsVectorBlock(
      FlatBufferBuilder builder,
      Offset<SkillData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017C65")]
    [Address(RVA = "0x37B83C0", Offset = "0x37B83C0", VA = "0x37B83C0")]
    public static void StartSkillsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017C66")]
    [Address(RVA = "0x37B7E88", Offset = "0x37B7E88", VA = "0x37B7E88")]
    public static void AddUnits(FlatBufferBuilder builder, VectorOffset unitsOffset)
    {
    }

    [Token(Token = "0x6017C67")]
    [Address(RVA = "0x37B83E0", Offset = "0x37B83E0", VA = "0x37B83E0")]
    public static VectorOffset CreateUnitsVector(FlatBufferBuilder builder, Offset<UnitData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017C68")]
    [Address(RVA = "0x37B8488", Offset = "0x37B8488", VA = "0x37B8488")]
    public static VectorOffset CreateUnitsVectorBlock(
      FlatBufferBuilder builder,
      Offset<UnitData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017C69")]
    [Address(RVA = "0x37B8510", Offset = "0x37B8510", VA = "0x37B8510")]
    public static void StartUnitsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017C6A")]
    [Address(RVA = "0x37B7E68", Offset = "0x37B7E68", VA = "0x37B7E68")]
    public static void AddWeapons(FlatBufferBuilder builder, VectorOffset weaponsOffset)
    {
    }

    [Token(Token = "0x6017C6B")]
    [Address(RVA = "0x37B8530", Offset = "0x37B8530", VA = "0x37B8530")]
    public static VectorOffset CreateWeaponsVector(
      FlatBufferBuilder builder,
      Offset<WeaponData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017C6C")]
    [Address(RVA = "0x37B85D8", Offset = "0x37B85D8", VA = "0x37B85D8")]
    public static VectorOffset CreateWeaponsVectorBlock(
      FlatBufferBuilder builder,
      Offset<WeaponData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017C6D")]
    [Address(RVA = "0x37B8660", Offset = "0x37B8660", VA = "0x37B8660")]
    public static void StartWeaponsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017C6E")]
    [Address(RVA = "0x37B7E48", Offset = "0x37B7E48", VA = "0x37B7E48")]
    public static void AddAccessories(FlatBufferBuilder builder, VectorOffset accessoriesOffset)
    {
    }

    [Token(Token = "0x6017C6F")]
    [Address(RVA = "0x37B8680", Offset = "0x37B8680", VA = "0x37B8680")]
    public static VectorOffset CreateAccessoriesVector(
      FlatBufferBuilder builder,
      Offset<AccessoryData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017C70")]
    [Address(RVA = "0x37B8728", Offset = "0x37B8728", VA = "0x37B8728")]
    public static VectorOffset CreateAccessoriesVectorBlock(
      FlatBufferBuilder builder,
      Offset<AccessoryData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017C71")]
    [Address(RVA = "0x37B87B0", Offset = "0x37B87B0", VA = "0x37B87B0")]
    public static void StartAccessoriesVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017C72")]
    [Address(RVA = "0x37B7E28", Offset = "0x37B7E28", VA = "0x37B7E28")]
    public static void AddMindEquipments(
      FlatBufferBuilder builder,
      VectorOffset mindEquipmentsOffset)
    {
    }

    [Token(Token = "0x6017C73")]
    [Address(RVA = "0x37B87D0", Offset = "0x37B87D0", VA = "0x37B87D0")]
    public static VectorOffset CreateMindEquipmentsVector(
      FlatBufferBuilder builder,
      Offset<MindEquipmentData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017C74")]
    [Address(RVA = "0x37B8878", Offset = "0x37B8878", VA = "0x37B8878")]
    public static VectorOffset CreateMindEquipmentsVectorBlock(
      FlatBufferBuilder builder,
      Offset<MindEquipmentData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017C75")]
    [Address(RVA = "0x37B8900", Offset = "0x37B8900", VA = "0x37B8900")]
    public static void StartMindEquipmentsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017C76")]
    [Address(RVA = "0x37B7E08", Offset = "0x37B7E08", VA = "0x37B7E08")]
    public static void AddTrusts(FlatBufferBuilder builder, VectorOffset trustsOffset)
    {
    }

    [Token(Token = "0x6017C77")]
    [Address(RVA = "0x37B8920", Offset = "0x37B8920", VA = "0x37B8920")]
    public static VectorOffset CreateTrustsVector(
      FlatBufferBuilder builder,
      Offset<TrustData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017C78")]
    [Address(RVA = "0x37B89C8", Offset = "0x37B89C8", VA = "0x37B89C8")]
    public static VectorOffset CreateTrustsVectorBlock(
      FlatBufferBuilder builder,
      Offset<TrustData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017C79")]
    [Address(RVA = "0x37B8A50", Offset = "0x37B8A50", VA = "0x37B8A50")]
    public static void StartTrustsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017C7A")]
    [Address(RVA = "0x37B7F88", Offset = "0x37B7F88", VA = "0x37B7F88")]
    public static Offset<BattleData> EndBattleData(FlatBufferBuilder builder)
    {
      return new Offset<BattleData>();
    }

    [Token(Token = "0x6017C7B")]
    [Address(RVA = "0x37B8A70", Offset = "0x37B8A70", VA = "0x37B8A70")]
    public static void FinishBattleDataBuffer(FlatBufferBuilder builder, Offset<BattleData> offset)
    {
    }

    [Token(Token = "0x6017C7C")]
    [Address(RVA = "0x37B8ACC", Offset = "0x37B8ACC", VA = "0x37B8ACC")]
    public static void FinishSizePrefixedBattleDataBuffer(
      FlatBufferBuilder builder,
      Offset<BattleData> offset)
    {
    }
  }
}
