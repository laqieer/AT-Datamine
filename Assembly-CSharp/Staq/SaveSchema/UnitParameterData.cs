// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.UnitParameterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C91")]
  public struct UnitParameterData : IFlatbufferObject
  {
    [Token(Token = "0x4010BF0")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004E89")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60180B9"), Address(RVA = "0x3B1D210", Offset = "0x3B1D210", VA = "0x3B1D210", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60180BA")]
    [Address(RVA = "0x3B1D218", Offset = "0x3B1D218", VA = "0x3B1D218")]
    public static UnitParameterData GetRootAsUnitParameterData(ByteBuffer _bb)
    {
      return new UnitParameterData();
    }

    [Token(Token = "0x60180BB")]
    [Address(RVA = "0x3B1D224", Offset = "0x3B1D224", VA = "0x3B1D224")]
    public static UnitParameterData GetRootAsUnitParameterData(
      ByteBuffer _bb,
      UnitParameterData obj)
    {
      return new UnitParameterData();
    }

    [Token(Token = "0x60180BC")]
    [Address(RVA = "0x3B1D268", Offset = "0x3B1D268", VA = "0x3B1D268", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60180BD")]
    [Address(RVA = "0x3B17FC8", Offset = "0x3B17FC8", VA = "0x3B17FC8")]
    public UnitParameterData __assign(int _i, ByteBuffer _bb) => new UnitParameterData();

    [Token(Token = "0x17004E8A")]
    public int Unit
    {
      [Token(Token = "0x60180BE"), Address(RVA = "0x3B1D274", Offset = "0x3B1D274", VA = "0x3B1D274")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E8B")]
    public AIData? Ai
    {
      [Token(Token = "0x60180BF"), Address(RVA = "0x3B1D2B8", Offset = "0x3B1D2B8", VA = "0x3B1D2B8")] get
      {
        return new AIData?();
      }
    }

    [Token(Token = "0x17004E8C")]
    public Vec2Int? Coordinate
    {
      [Token(Token = "0x60180C0"), Address(RVA = "0x3B1D350", Offset = "0x3B1D350", VA = "0x3B1D350")] get
      {
        return new Vec2Int?();
      }
    }

    [Token(Token = "0x17004E8D")]
    public int Lp
    {
      [Token(Token = "0x60180C1"), Address(RVA = "0x3B1D400", Offset = "0x3B1D400", VA = "0x3B1D400")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E8E")]
    public int Exp
    {
      [Token(Token = "0x60180C2"), Address(RVA = "0x3B1D444", Offset = "0x3B1D444", VA = "0x3B1D444")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E8F")]
    public HPStockData? Hp
    {
      [Token(Token = "0x60180C3"), Address(RVA = "0x3B1D488", Offset = "0x3B1D488", VA = "0x3B1D488")] get
      {
        return new HPStockData?();
      }
    }

    [Token(Token = "0x17004E90")]
    public int Barrier
    {
      [Token(Token = "0x60180C4"), Address(RVA = "0x3B1D520", Offset = "0x3B1D520", VA = "0x3B1D520")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60180C5")]
    [Address(RVA = "0x3B1D564", Offset = "0x3B1D564", VA = "0x3B1D564")]
    public BarrierData? BarrierList(int j) => new BarrierData?();

    [Token(Token = "0x17004E91")]
    public int BarrierListLength
    {
      [Token(Token = "0x60180C6"), Address(RVA = "0x3B1D618", Offset = "0x3B1D618", VA = "0x3B1D618")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E92")]
    public BasicParameter? BasicParam
    {
      [Token(Token = "0x60180C7"), Address(RVA = "0x3B1D64C", Offset = "0x3B1D64C", VA = "0x3B1D64C")] get
      {
        return new BasicParameter?();
      }
    }

    [Token(Token = "0x17004E93")]
    public int DoubledAt
    {
      [Token(Token = "0x60180C8"), Address(RVA = "0x3B1D70C", Offset = "0x3B1D70C", VA = "0x3B1D70C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E94")]
    public int Leader
    {
      [Token(Token = "0x60180C9"), Address(RVA = "0x3B1D750", Offset = "0x3B1D750", VA = "0x3B1D750")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60180CA")]
    [Address(RVA = "0x3B1D794", Offset = "0x3B1D794", VA = "0x3B1D794")]
    public WeaponParameterData? WeaponParams(int j) => new WeaponParameterData?();

    [Token(Token = "0x17004E95")]
    public int WeaponParamsLength
    {
      [Token(Token = "0x60180CB"), Address(RVA = "0x3B1D860", Offset = "0x3B1D860", VA = "0x3B1D860")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60180CC")]
    [Address(RVA = "0x3B1D894", Offset = "0x3B1D894", VA = "0x3B1D894")]
    public WeaponProficiency? AchieveWeaponProficiencyDic(int j) => new WeaponProficiency?();

    [Token(Token = "0x17004E96")]
    public int AchieveWeaponProficiencyDicLength
    {
      [Token(Token = "0x60180CD"), Address(RVA = "0x3B1D960", Offset = "0x3B1D960", VA = "0x3B1D960")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E97")]
    public int CurrentWeaponIdx
    {
      [Token(Token = "0x60180CE"), Address(RVA = "0x3B1D994", Offset = "0x3B1D994", VA = "0x3B1D994")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E98")]
    public int CurrentStockCounter
    {
      [Token(Token = "0x60180CF"), Address(RVA = "0x3B1D9D8", Offset = "0x3B1D9D8", VA = "0x3B1D9D8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60180D0")]
    [Address(RVA = "0x3B1DA1C", Offset = "0x3B1DA1C", VA = "0x3B1DA1C")]
    public EffectParameterData? DuplicatedEffectParameters(int j) => new EffectParameterData?();

    [Token(Token = "0x17004E99")]
    public int DuplicatedEffectParametersLength
    {
      [Token(Token = "0x60180D1"), Address(RVA = "0x3B1DAE8", Offset = "0x3B1DAE8", VA = "0x3B1DAE8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60180D2")]
    [Address(RVA = "0x3B1DB1C", Offset = "0x3B1DB1C", VA = "0x3B1DB1C")]
    public EffectParameterData? PartySkillEffectParameters(int j) => new EffectParameterData?();

    [Token(Token = "0x17004E9A")]
    public int PartySkillEffectParametersLength
    {
      [Token(Token = "0x60180D3"), Address(RVA = "0x3B1DBD0", Offset = "0x3B1DBD0", VA = "0x3B1DBD0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60180D4")]
    [Address(RVA = "0x3B1DC04", Offset = "0x3B1DC04", VA = "0x3B1DC04")]
    public EffectParameterData? UseItemEffectParameters(int j) => new EffectParameterData?();

    [Token(Token = "0x17004E9B")]
    public int UseItemEffectParametersLength
    {
      [Token(Token = "0x60180D5"), Address(RVA = "0x3B1DCB8", Offset = "0x3B1DCB8", VA = "0x3B1DCB8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60180D6")]
    [Address(RVA = "0x3B1DCEC", Offset = "0x3B1DCEC", VA = "0x3B1DCEC")]
    public EffectParameterData? BadStatusEffectParameters(int j) => new EffectParameterData?();

    [Token(Token = "0x17004E9C")]
    public int BadStatusEffectParametersLength
    {
      [Token(Token = "0x60180D7"), Address(RVA = "0x3B1DDA0", Offset = "0x3B1DDA0", VA = "0x3B1DDA0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60180D8")]
    [Address(RVA = "0x3B1DDD4", Offset = "0x3B1DDD4", VA = "0x3B1DDD4")]
    public int SkillParams(int j) => new int();

    [Token(Token = "0x17004E9D")]
    public int SkillParamsLength
    {
      [Token(Token = "0x60180D9"), Address(RVA = "0x3B1DE34", Offset = "0x3B1DE34", VA = "0x3B1DE34")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60180DA")]
    [Address(RVA = "0x3B1DE68", Offset = "0x3B1DE68", VA = "0x3B1DE68")]
    public ArraySegment<byte>? GetSkillParamsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x60180DB")]
    [Address(RVA = "0x3B1DEA0", Offset = "0x3B1DEA0", VA = "0x3B1DEA0")]
    public int[] GetSkillParamsArray() => (int[]) null;

    [Token(Token = "0x17004E9E")]
    public int ChargeTargetSkill
    {
      [Token(Token = "0x60180DC"), Address(RVA = "0x3B1DEEC", Offset = "0x3B1DEEC", VA = "0x3B1DEEC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E9F")]
    public int SkillChargingCount
    {
      [Token(Token = "0x60180DD"), Address(RVA = "0x3B1DF30", Offset = "0x3B1DF30", VA = "0x3B1DF30")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EA0")]
    public int ChargeTargetX
    {
      [Token(Token = "0x60180DE"), Address(RVA = "0x3B1DF74", Offset = "0x3B1DF74", VA = "0x3B1DF74")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EA1")]
    public int ChargeTargetY
    {
      [Token(Token = "0x60180DF"), Address(RVA = "0x3B1DFB8", Offset = "0x3B1DFB8", VA = "0x3B1DFB8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EA2")]
    public int PrevAttackToUnit
    {
      [Token(Token = "0x60180E0"), Address(RVA = "0x3B1DFFC", Offset = "0x3B1DFFC", VA = "0x3B1DFFC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EA3")]
    public int BeAttackedUnit
    {
      [Token(Token = "0x60180E1"), Address(RVA = "0x3B1E040", Offset = "0x3B1E040", VA = "0x3B1E040")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EA4")]
    public int CurrentMovePoint
    {
      [Token(Token = "0x60180E2"), Address(RVA = "0x3B1E084", Offset = "0x3B1E084", VA = "0x3B1E084")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EA5")]
    public int TotalMoveDistanceDuringATurn
    {
      [Token(Token = "0x60180E3"), Address(RVA = "0x3B1E0C8", Offset = "0x3B1E0C8", VA = "0x3B1E0C8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EA6")]
    public int SortieState
    {
      [Token(Token = "0x60180E4"), Address(RVA = "0x3B1E10C", Offset = "0x3B1E10C", VA = "0x3B1E10C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EA7")]
    public int ActionState
    {
      [Token(Token = "0x60180E5"), Address(RVA = "0x3B1E150", Offset = "0x3B1E150", VA = "0x3B1E150")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EA8")]
    public int WaitTurnCountFromSortied
    {
      [Token(Token = "0x60180E6"), Address(RVA = "0x3B1E194", Offset = "0x3B1E194", VA = "0x3B1E194")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EA9")]
    public int PassedWaitTurnCountFromSortied
    {
      [Token(Token = "0x60180E7"), Address(RVA = "0x3B1E1D8", Offset = "0x3B1E1D8", VA = "0x3B1E1D8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EAA")]
    public bool IsImmortal
    {
      [Token(Token = "0x60180E8"), Address(RVA = "0x3B1E21C", Offset = "0x3B1E21C", VA = "0x3B1E21C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004EAB")]
    public bool IsWeaponCare
    {
      [Token(Token = "0x60180E9"), Address(RVA = "0x3B1E264", Offset = "0x3B1E264", VA = "0x3B1E264")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004EAC")]
    public int DropItem
    {
      [Token(Token = "0x60180EA"), Address(RVA = "0x3B1E2AC", Offset = "0x3B1E2AC", VA = "0x3B1E2AC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EAD")]
    public int ExpGain
    {
      [Token(Token = "0x60180EB"), Address(RVA = "0x3B1E2F0", Offset = "0x3B1E2F0", VA = "0x3B1E2F0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EAE")]
    public int ExpPool
    {
      [Token(Token = "0x60180EC"), Address(RVA = "0x3B1E334", Offset = "0x3B1E334", VA = "0x3B1E334")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EAF")]
    public int TotalDealtDamage
    {
      [Token(Token = "0x60180ED"), Address(RVA = "0x3B1E378", Offset = "0x3B1E378", VA = "0x3B1E378")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EB0")]
    public int HighestDealtDamage
    {
      [Token(Token = "0x60180EE"), Address(RVA = "0x3B1E3BC", Offset = "0x3B1E3BC", VA = "0x3B1E3BC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EB1")]
    public int BreakBarrierCount
    {
      [Token(Token = "0x60180EF"), Address(RVA = "0x3B1E400", Offset = "0x3B1E400", VA = "0x3B1E400")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60180F0")]
    [Address(RVA = "0x3B1E444", Offset = "0x3B1E444", VA = "0x3B1E444")]
    public int ArmorBreakUnitId(int j) => new int();

    [Token(Token = "0x17004EB2")]
    public int ArmorBreakUnitIdLength
    {
      [Token(Token = "0x60180F1"), Address(RVA = "0x3B1E4A4", Offset = "0x3B1E4A4", VA = "0x3B1E4A4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60180F2")]
    [Address(RVA = "0x3B1E4D8", Offset = "0x3B1E4D8", VA = "0x3B1E4D8")]
    public ArraySegment<byte>? GetArmorBreakUnitIdBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x60180F3")]
    [Address(RVA = "0x3B1E510", Offset = "0x3B1E510", VA = "0x3B1E510")]
    public int[] GetArmorBreakUnitIdArray() => (int[]) null;

    [Token(Token = "0x60180F4")]
    [Address(RVA = "0x3B1E55C", Offset = "0x3B1E55C", VA = "0x3B1E55C")]
    public int KillUnitId(int j) => new int();

    [Token(Token = "0x17004EB3")]
    public int KillUnitIdLength
    {
      [Token(Token = "0x60180F5"), Address(RVA = "0x3B1E5BC", Offset = "0x3B1E5BC", VA = "0x3B1E5BC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60180F6")]
    [Address(RVA = "0x3B1E5F0", Offset = "0x3B1E5F0", VA = "0x3B1E5F0")]
    public ArraySegment<byte>? GetKillUnitIdBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x60180F7")]
    [Address(RVA = "0x3B1E628", Offset = "0x3B1E628", VA = "0x3B1E628")]
    public int[] GetKillUnitIdArray() => (int[]) null;

    [Token(Token = "0x17004EB4")]
    public int TurnNumberWhenDied
    {
      [Token(Token = "0x60180F8"), Address(RVA = "0x3B1E674", Offset = "0x3B1E674", VA = "0x3B1E674")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60180F9")]
    [Address(RVA = "0x3B1E6B8", Offset = "0x3B1E6B8", VA = "0x3B1E6B8")]
    public static void StartUnitParameterData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60180FA")]
    [Address(RVA = "0x3B1E6D0", Offset = "0x3B1E6D0", VA = "0x3B1E6D0")]
    public static void AddUnit(FlatBufferBuilder builder, int unit)
    {
    }

    [Token(Token = "0x60180FB")]
    [Address(RVA = "0x3B1E6F0", Offset = "0x3B1E6F0", VA = "0x3B1E6F0")]
    public static void AddAi(FlatBufferBuilder builder, Offset<AIData> aiOffset)
    {
    }

    [Token(Token = "0x60180FC")]
    [Address(RVA = "0x3B1E710", Offset = "0x3B1E710", VA = "0x3B1E710")]
    public static void AddCoordinate(FlatBufferBuilder builder, Offset<Vec2Int> coordinateOffset)
    {
    }

    [Token(Token = "0x60180FD")]
    [Address(RVA = "0x3B1E730", Offset = "0x3B1E730", VA = "0x3B1E730")]
    public static void AddLp(FlatBufferBuilder builder, int lp)
    {
    }

    [Token(Token = "0x60180FE")]
    [Address(RVA = "0x3B1E750", Offset = "0x3B1E750", VA = "0x3B1E750")]
    public static void AddExp(FlatBufferBuilder builder, int exp)
    {
    }

    [Token(Token = "0x60180FF")]
    [Address(RVA = "0x3B1E770", Offset = "0x3B1E770", VA = "0x3B1E770")]
    public static void AddHp(FlatBufferBuilder builder, Offset<HPStockData> hpOffset)
    {
    }

    [Token(Token = "0x6018100")]
    [Address(RVA = "0x3B1E790", Offset = "0x3B1E790", VA = "0x3B1E790")]
    public static void AddBarrier(FlatBufferBuilder builder, int barrier)
    {
    }

    [Token(Token = "0x6018101")]
    [Address(RVA = "0x3B1E7B0", Offset = "0x3B1E7B0", VA = "0x3B1E7B0")]
    public static void AddBarrierList(FlatBufferBuilder builder, VectorOffset barrierListOffset)
    {
    }

    [Token(Token = "0x6018102")]
    [Address(RVA = "0x3B1E7D0", Offset = "0x3B1E7D0", VA = "0x3B1E7D0")]
    public static VectorOffset CreateBarrierListVector(
      FlatBufferBuilder builder,
      Offset<BarrierData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018103")]
    [Address(RVA = "0x3B1E878", Offset = "0x3B1E878", VA = "0x3B1E878")]
    public static VectorOffset CreateBarrierListVectorBlock(
      FlatBufferBuilder builder,
      Offset<BarrierData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018104")]
    [Address(RVA = "0x3B1E900", Offset = "0x3B1E900", VA = "0x3B1E900")]
    public static void StartBarrierListVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018105")]
    [Address(RVA = "0x3B1E920", Offset = "0x3B1E920", VA = "0x3B1E920")]
    public static void AddBasicParam(
      FlatBufferBuilder builder,
      Offset<BasicParameter> basicParamOffset)
    {
    }

    [Token(Token = "0x6018106")]
    [Address(RVA = "0x3B1E940", Offset = "0x3B1E940", VA = "0x3B1E940")]
    public static void AddDoubledAt(FlatBufferBuilder builder, int doubledAt)
    {
    }

    [Token(Token = "0x6018107")]
    [Address(RVA = "0x3B1E960", Offset = "0x3B1E960", VA = "0x3B1E960")]
    public static void AddLeader(FlatBufferBuilder builder, int leader)
    {
    }

    [Token(Token = "0x6018108")]
    [Address(RVA = "0x3B1E980", Offset = "0x3B1E980", VA = "0x3B1E980")]
    public static void AddWeaponParams(FlatBufferBuilder builder, VectorOffset weaponParamsOffset)
    {
    }

    [Token(Token = "0x6018109")]
    [Address(RVA = "0x3B1E9A0", Offset = "0x3B1E9A0", VA = "0x3B1E9A0")]
    public static VectorOffset CreateWeaponParamsVector(
      FlatBufferBuilder builder,
      Offset<WeaponParameterData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601810A")]
    [Address(RVA = "0x3B1EA48", Offset = "0x3B1EA48", VA = "0x3B1EA48")]
    public static VectorOffset CreateWeaponParamsVectorBlock(
      FlatBufferBuilder builder,
      Offset<WeaponParameterData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601810B")]
    [Address(RVA = "0x3B1EAD0", Offset = "0x3B1EAD0", VA = "0x3B1EAD0")]
    public static void StartWeaponParamsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601810C")]
    [Address(RVA = "0x3B1EAF0", Offset = "0x3B1EAF0", VA = "0x3B1EAF0")]
    public static void AddAchieveWeaponProficiencyDic(
      FlatBufferBuilder builder,
      VectorOffset achieveWeaponProficiencyDicOffset)
    {
    }

    [Token(Token = "0x601810D")]
    [Address(RVA = "0x3B1EB10", Offset = "0x3B1EB10", VA = "0x3B1EB10")]
    public static VectorOffset CreateAchieveWeaponProficiencyDicVector(
      FlatBufferBuilder builder,
      Offset<WeaponProficiency>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601810E")]
    [Address(RVA = "0x3B1EBB8", Offset = "0x3B1EBB8", VA = "0x3B1EBB8")]
    public static VectorOffset CreateAchieveWeaponProficiencyDicVectorBlock(
      FlatBufferBuilder builder,
      Offset<WeaponProficiency>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601810F")]
    [Address(RVA = "0x3B1EC40", Offset = "0x3B1EC40", VA = "0x3B1EC40")]
    public static void StartAchieveWeaponProficiencyDicVector(
      FlatBufferBuilder builder,
      int numElems)
    {
    }

    [Token(Token = "0x6018110")]
    [Address(RVA = "0x3B1EC60", Offset = "0x3B1EC60", VA = "0x3B1EC60")]
    public static void AddCurrentWeaponIdx(FlatBufferBuilder builder, int currentWeaponIdx)
    {
    }

    [Token(Token = "0x6018111")]
    [Address(RVA = "0x3B1EC80", Offset = "0x3B1EC80", VA = "0x3B1EC80")]
    public static void AddCurrentStockCounter(FlatBufferBuilder builder, int currentStockCounter)
    {
    }

    [Token(Token = "0x6018112")]
    [Address(RVA = "0x3B1ECA0", Offset = "0x3B1ECA0", VA = "0x3B1ECA0")]
    public static void AddDuplicatedEffectParameters(
      FlatBufferBuilder builder,
      VectorOffset duplicatedEffectParametersOffset)
    {
    }

    [Token(Token = "0x6018113")]
    [Address(RVA = "0x3B1ECC0", Offset = "0x3B1ECC0", VA = "0x3B1ECC0")]
    public static VectorOffset CreateDuplicatedEffectParametersVector(
      FlatBufferBuilder builder,
      Offset<EffectParameterData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018114")]
    [Address(RVA = "0x3B1ED68", Offset = "0x3B1ED68", VA = "0x3B1ED68")]
    public static VectorOffset CreateDuplicatedEffectParametersVectorBlock(
      FlatBufferBuilder builder,
      Offset<EffectParameterData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018115")]
    [Address(RVA = "0x3B1EDF0", Offset = "0x3B1EDF0", VA = "0x3B1EDF0")]
    public static void StartDuplicatedEffectParametersVector(
      FlatBufferBuilder builder,
      int numElems)
    {
    }

    [Token(Token = "0x6018116")]
    [Address(RVA = "0x3B1EE10", Offset = "0x3B1EE10", VA = "0x3B1EE10")]
    public static void AddPartySkillEffectParameters(
      FlatBufferBuilder builder,
      VectorOffset partySkillEffectParametersOffset)
    {
    }

    [Token(Token = "0x6018117")]
    [Address(RVA = "0x3B1EE30", Offset = "0x3B1EE30", VA = "0x3B1EE30")]
    public static VectorOffset CreatePartySkillEffectParametersVector(
      FlatBufferBuilder builder,
      Offset<EffectParameterData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018118")]
    [Address(RVA = "0x3B1EED8", Offset = "0x3B1EED8", VA = "0x3B1EED8")]
    public static VectorOffset CreatePartySkillEffectParametersVectorBlock(
      FlatBufferBuilder builder,
      Offset<EffectParameterData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018119")]
    [Address(RVA = "0x3B1EF60", Offset = "0x3B1EF60", VA = "0x3B1EF60")]
    public static void StartPartySkillEffectParametersVector(
      FlatBufferBuilder builder,
      int numElems)
    {
    }

    [Token(Token = "0x601811A")]
    [Address(RVA = "0x3B1EF80", Offset = "0x3B1EF80", VA = "0x3B1EF80")]
    public static void AddUseItemEffectParameters(
      FlatBufferBuilder builder,
      VectorOffset useItemEffectParametersOffset)
    {
    }

    [Token(Token = "0x601811B")]
    [Address(RVA = "0x3B1EFA0", Offset = "0x3B1EFA0", VA = "0x3B1EFA0")]
    public static VectorOffset CreateUseItemEffectParametersVector(
      FlatBufferBuilder builder,
      Offset<EffectParameterData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601811C")]
    [Address(RVA = "0x3B1F048", Offset = "0x3B1F048", VA = "0x3B1F048")]
    public static VectorOffset CreateUseItemEffectParametersVectorBlock(
      FlatBufferBuilder builder,
      Offset<EffectParameterData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601811D")]
    [Address(RVA = "0x3B1F0D0", Offset = "0x3B1F0D0", VA = "0x3B1F0D0")]
    public static void StartUseItemEffectParametersVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601811E")]
    [Address(RVA = "0x3B1F0F0", Offset = "0x3B1F0F0", VA = "0x3B1F0F0")]
    public static void AddBadStatusEffectParameters(
      FlatBufferBuilder builder,
      VectorOffset badStatusEffectParametersOffset)
    {
    }

    [Token(Token = "0x601811F")]
    [Address(RVA = "0x3B1F110", Offset = "0x3B1F110", VA = "0x3B1F110")]
    public static VectorOffset CreateBadStatusEffectParametersVector(
      FlatBufferBuilder builder,
      Offset<EffectParameterData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018120")]
    [Address(RVA = "0x3B1F1B8", Offset = "0x3B1F1B8", VA = "0x3B1F1B8")]
    public static VectorOffset CreateBadStatusEffectParametersVectorBlock(
      FlatBufferBuilder builder,
      Offset<EffectParameterData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018121")]
    [Address(RVA = "0x3B1F240", Offset = "0x3B1F240", VA = "0x3B1F240")]
    public static void StartBadStatusEffectParametersVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018122")]
    [Address(RVA = "0x3B1F260", Offset = "0x3B1F260", VA = "0x3B1F260")]
    public static void AddSkillParams(FlatBufferBuilder builder, VectorOffset skillParamsOffset)
    {
    }

    [Token(Token = "0x6018123")]
    [Address(RVA = "0x3B1F280", Offset = "0x3B1F280", VA = "0x3B1F280")]
    public static VectorOffset CreateSkillParamsVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018124")]
    [Address(RVA = "0x3B1F328", Offset = "0x3B1F328", VA = "0x3B1F328")]
    public static VectorOffset CreateSkillParamsVectorBlock(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018125")]
    [Address(RVA = "0x3B1F3B0", Offset = "0x3B1F3B0", VA = "0x3B1F3B0")]
    public static void StartSkillParamsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018126")]
    [Address(RVA = "0x3B1F3D0", Offset = "0x3B1F3D0", VA = "0x3B1F3D0")]
    public static void AddChargeTargetSkill(FlatBufferBuilder builder, int chargeTargetSkill)
    {
    }

    [Token(Token = "0x6018127")]
    [Address(RVA = "0x3B1F3F0", Offset = "0x3B1F3F0", VA = "0x3B1F3F0")]
    public static void AddSkillChargingCount(FlatBufferBuilder builder, int skillChargingCount)
    {
    }

    [Token(Token = "0x6018128")]
    [Address(RVA = "0x3B1F410", Offset = "0x3B1F410", VA = "0x3B1F410")]
    public static void AddChargeTargetX(FlatBufferBuilder builder, int chargeTargetX)
    {
    }

    [Token(Token = "0x6018129")]
    [Address(RVA = "0x3B1F430", Offset = "0x3B1F430", VA = "0x3B1F430")]
    public static void AddChargeTargetY(FlatBufferBuilder builder, int chargeTargetY)
    {
    }

    [Token(Token = "0x601812A")]
    [Address(RVA = "0x3B1F450", Offset = "0x3B1F450", VA = "0x3B1F450")]
    public static void AddPrevAttackToUnit(FlatBufferBuilder builder, int prevAttackToUnit)
    {
    }

    [Token(Token = "0x601812B")]
    [Address(RVA = "0x3B1F470", Offset = "0x3B1F470", VA = "0x3B1F470")]
    public static void AddBeAttackedUnit(FlatBufferBuilder builder, int beAttackedUnit)
    {
    }

    [Token(Token = "0x601812C")]
    [Address(RVA = "0x3B1F490", Offset = "0x3B1F490", VA = "0x3B1F490")]
    public static void AddCurrentMovePoint(FlatBufferBuilder builder, int currentMovePoint)
    {
    }

    [Token(Token = "0x601812D")]
    [Address(RVA = "0x3B1F4B0", Offset = "0x3B1F4B0", VA = "0x3B1F4B0")]
    public static void AddTotalMoveDistanceDuringATurn(
      FlatBufferBuilder builder,
      int totalMoveDistanceDuringATurn)
    {
    }

    [Token(Token = "0x601812E")]
    [Address(RVA = "0x3B1F4D0", Offset = "0x3B1F4D0", VA = "0x3B1F4D0")]
    public static void AddSortieState(FlatBufferBuilder builder, int sortieState)
    {
    }

    [Token(Token = "0x601812F")]
    [Address(RVA = "0x3B1F4F0", Offset = "0x3B1F4F0", VA = "0x3B1F4F0")]
    public static void AddActionState(FlatBufferBuilder builder, int actionState)
    {
    }

    [Token(Token = "0x6018130")]
    [Address(RVA = "0x3B1F510", Offset = "0x3B1F510", VA = "0x3B1F510")]
    public static void AddWaitTurnCountFromSortied(
      FlatBufferBuilder builder,
      int waitTurnCountFromSortied)
    {
    }

    [Token(Token = "0x6018131")]
    [Address(RVA = "0x3B1F530", Offset = "0x3B1F530", VA = "0x3B1F530")]
    public static void AddPassedWaitTurnCountFromSortied(
      FlatBufferBuilder builder,
      int passedWaitTurnCountFromSortied)
    {
    }

    [Token(Token = "0x6018132")]
    [Address(RVA = "0x3B1F550", Offset = "0x3B1F550", VA = "0x3B1F550")]
    public static void AddIsImmortal(FlatBufferBuilder builder, bool isImmortal)
    {
    }

    [Token(Token = "0x6018133")]
    [Address(RVA = "0x3B1F570", Offset = "0x3B1F570", VA = "0x3B1F570")]
    public static void AddIsWeaponCare(FlatBufferBuilder builder, bool isWeaponCare)
    {
    }

    [Token(Token = "0x6018134")]
    [Address(RVA = "0x3B1F590", Offset = "0x3B1F590", VA = "0x3B1F590")]
    public static void AddDropItem(FlatBufferBuilder builder, int dropItem)
    {
    }

    [Token(Token = "0x6018135")]
    [Address(RVA = "0x3B1F5B0", Offset = "0x3B1F5B0", VA = "0x3B1F5B0")]
    public static void AddExpGain(FlatBufferBuilder builder, int expGain)
    {
    }

    [Token(Token = "0x6018136")]
    [Address(RVA = "0x3B1F5D0", Offset = "0x3B1F5D0", VA = "0x3B1F5D0")]
    public static void AddExpPool(FlatBufferBuilder builder, int expPool)
    {
    }

    [Token(Token = "0x6018137")]
    [Address(RVA = "0x3B1F5F0", Offset = "0x3B1F5F0", VA = "0x3B1F5F0")]
    public static void AddTotalDealtDamage(FlatBufferBuilder builder, int totalDealtDamage)
    {
    }

    [Token(Token = "0x6018138")]
    [Address(RVA = "0x3B1F610", Offset = "0x3B1F610", VA = "0x3B1F610")]
    public static void AddHighestDealtDamage(FlatBufferBuilder builder, int highestDealtDamage)
    {
    }

    [Token(Token = "0x6018139")]
    [Address(RVA = "0x3B1F630", Offset = "0x3B1F630", VA = "0x3B1F630")]
    public static void AddBreakBarrierCount(FlatBufferBuilder builder, int breakBarrierCount)
    {
    }

    [Token(Token = "0x601813A")]
    [Address(RVA = "0x3B1F650", Offset = "0x3B1F650", VA = "0x3B1F650")]
    public static void AddArmorBreakUnitId(
      FlatBufferBuilder builder,
      VectorOffset armorBreakUnitIdOffset)
    {
    }

    [Token(Token = "0x601813B")]
    [Address(RVA = "0x3B1F670", Offset = "0x3B1F670", VA = "0x3B1F670")]
    public static VectorOffset CreateArmorBreakUnitIdVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601813C")]
    [Address(RVA = "0x3B1F718", Offset = "0x3B1F718", VA = "0x3B1F718")]
    public static VectorOffset CreateArmorBreakUnitIdVectorBlock(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601813D")]
    [Address(RVA = "0x3B1F7A0", Offset = "0x3B1F7A0", VA = "0x3B1F7A0")]
    public static void StartArmorBreakUnitIdVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601813E")]
    [Address(RVA = "0x3B1F7C0", Offset = "0x3B1F7C0", VA = "0x3B1F7C0")]
    public static void AddKillUnitId(FlatBufferBuilder builder, VectorOffset killUnitIdOffset)
    {
    }

    [Token(Token = "0x601813F")]
    [Address(RVA = "0x3B1F7E0", Offset = "0x3B1F7E0", VA = "0x3B1F7E0")]
    public static VectorOffset CreateKillUnitIdVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018140")]
    [Address(RVA = "0x3B1F888", Offset = "0x3B1F888", VA = "0x3B1F888")]
    public static VectorOffset CreateKillUnitIdVectorBlock(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018141")]
    [Address(RVA = "0x3B1F910", Offset = "0x3B1F910", VA = "0x3B1F910")]
    public static void StartKillUnitIdVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018142")]
    [Address(RVA = "0x3B1F930", Offset = "0x3B1F930", VA = "0x3B1F930")]
    public static void AddTurnNumberWhenDied(FlatBufferBuilder builder, int turnNumberWhenDied)
    {
    }

    [Token(Token = "0x6018143")]
    [Address(RVA = "0x3B1F950", Offset = "0x3B1F950", VA = "0x3B1F950")]
    public static Offset<UnitParameterData> EndUnitParameterData(FlatBufferBuilder builder)
    {
      return new Offset<UnitParameterData>();
    }
  }
}
