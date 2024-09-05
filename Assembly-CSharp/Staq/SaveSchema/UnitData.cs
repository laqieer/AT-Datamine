// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.UnitData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C6C")]
  public struct UnitData : IFlatbufferObject
  {
    [Token(Token = "0x4010BCB")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004D7E")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017CA3"), Address(RVA = "0x37B91EC", Offset = "0x37B91EC", VA = "0x37B91EC", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017CA4")]
    [Address(RVA = "0x37B91F4", Offset = "0x37B91F4", VA = "0x37B91F4")]
    public static UnitData GetRootAsUnitData(ByteBuffer _bb) => new UnitData();

    [Token(Token = "0x6017CA5")]
    [Address(RVA = "0x37B9200", Offset = "0x37B9200", VA = "0x37B9200")]
    public static UnitData GetRootAsUnitData(ByteBuffer _bb, UnitData obj) => new UnitData();

    [Token(Token = "0x6017CA6")]
    [Address(RVA = "0x37B9244", Offset = "0x37B9244", VA = "0x37B9244", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017CA7")]
    [Address(RVA = "0x37B78A8", Offset = "0x37B78A8", VA = "0x37B78A8")]
    public UnitData __assign(int _i, ByteBuffer _bb) => new UnitData();

    [Token(Token = "0x17004D7F")]
    public int Id
    {
      [Token(Token = "0x6017CA8"), Address(RVA = "0x37B9250", Offset = "0x37B9250", VA = "0x37B9250")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D80")]
    public string UniqueId
    {
      [Token(Token = "0x6017CA9"), Address(RVA = "0x37B9294", Offset = "0x37B9294", VA = "0x37B9294")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6017CAA")]
    [Address(RVA = "0x37B92D0", Offset = "0x37B92D0", VA = "0x37B92D0")]
    public ArraySegment<byte>? GetUniqueIdBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017CAB")]
    [Address(RVA = "0x37B9308", Offset = "0x37B9308", VA = "0x37B9308")]
    public byte[] GetUniqueIdArray() => (byte[]) null;

    [Token(Token = "0x17004D81")]
    public int Style
    {
      [Token(Token = "0x6017CAC"), Address(RVA = "0x37B9354", Offset = "0x37B9354", VA = "0x37B9354")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D82")]
    public int Rarity
    {
      [Token(Token = "0x6017CAD"), Address(RVA = "0x37B9398", Offset = "0x37B9398", VA = "0x37B9398")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D83")]
    public int ReincarnationCount
    {
      [Token(Token = "0x6017CAE"), Address(RVA = "0x37B93DC", Offset = "0x37B93DC", VA = "0x37B93DC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D84")]
    public int InitialExp
    {
      [Token(Token = "0x6017CAF"), Address(RVA = "0x37B9420", Offset = "0x37B9420", VA = "0x37B9420")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D85")]
    public int InitialLp
    {
      [Token(Token = "0x6017CB0"), Address(RVA = "0x37B9464", Offset = "0x37B9464", VA = "0x37B9464")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D86")]
    public int InitialDamage
    {
      [Token(Token = "0x6017CB1"), Address(RVA = "0x37B94A8", Offset = "0x37B94A8", VA = "0x37B94A8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D87")]
    public BasicParameter? InitialParameter
    {
      [Token(Token = "0x6017CB2"), Address(RVA = "0x37B94EC", Offset = "0x37B94EC", VA = "0x37B94EC")] get
      {
        return new BasicParameter?();
      }
    }

    [Token(Token = "0x6017CB3")]
    [Address(RVA = "0x37B9584", Offset = "0x37B9584", VA = "0x37B9584")]
    public int ReinforceAtk(int j) => new int();

    [Token(Token = "0x17004D88")]
    public int ReinforceAtkLength
    {
      [Token(Token = "0x6017CB4"), Address(RVA = "0x37B95E4", Offset = "0x37B95E4", VA = "0x37B95E4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017CB5")]
    [Address(RVA = "0x37B9618", Offset = "0x37B9618", VA = "0x37B9618")]
    public ArraySegment<byte>? GetReinforceAtkBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017CB6")]
    [Address(RVA = "0x37B9650", Offset = "0x37B9650", VA = "0x37B9650")]
    public int[] GetReinforceAtkArray() => (int[]) null;

    [Token(Token = "0x6017CB7")]
    [Address(RVA = "0x37B969C", Offset = "0x37B969C", VA = "0x37B969C")]
    public int ResistAtk(int j) => new int();

    [Token(Token = "0x17004D89")]
    public int ResistAtkLength
    {
      [Token(Token = "0x6017CB8"), Address(RVA = "0x37B96FC", Offset = "0x37B96FC", VA = "0x37B96FC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017CB9")]
    [Address(RVA = "0x37B9730", Offset = "0x37B9730", VA = "0x37B9730")]
    public ArraySegment<byte>? GetResistAtkBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017CBA")]
    [Address(RVA = "0x37B9768", Offset = "0x37B9768", VA = "0x37B9768")]
    public int[] GetResistAtkArray() => (int[]) null;

    [Token(Token = "0x6017CBB")]
    [Address(RVA = "0x37B97B4", Offset = "0x37B97B4", VA = "0x37B97B4")]
    public int ReinforceElement(int j) => new int();

    [Token(Token = "0x17004D8A")]
    public int ReinforceElementLength
    {
      [Token(Token = "0x6017CBC"), Address(RVA = "0x37B9814", Offset = "0x37B9814", VA = "0x37B9814")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017CBD")]
    [Address(RVA = "0x37B9848", Offset = "0x37B9848", VA = "0x37B9848")]
    public ArraySegment<byte>? GetReinforceElementBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017CBE")]
    [Address(RVA = "0x37B9880", Offset = "0x37B9880", VA = "0x37B9880")]
    public int[] GetReinforceElementArray() => (int[]) null;

    [Token(Token = "0x6017CBF")]
    [Address(RVA = "0x37B98CC", Offset = "0x37B98CC", VA = "0x37B98CC")]
    public int ResistElement(int j) => new int();

    [Token(Token = "0x17004D8B")]
    public int ResistElementLength
    {
      [Token(Token = "0x6017CC0"), Address(RVA = "0x37B992C", Offset = "0x37B992C", VA = "0x37B992C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017CC1")]
    [Address(RVA = "0x37B9960", Offset = "0x37B9960", VA = "0x37B9960")]
    public ArraySegment<byte>? GetResistElementBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017CC2")]
    [Address(RVA = "0x37B9998", Offset = "0x37B9998", VA = "0x37B9998")]
    public int[] GetResistElementArray() => (int[]) null;

    [Token(Token = "0x17004D8C")]
    public BattleParameter? StyleMasterBonus
    {
      [Token(Token = "0x6017CC3"), Address(RVA = "0x37B99E4", Offset = "0x37B99E4", VA = "0x37B99E4")] get
      {
        return new BattleParameter?();
      }
    }

    [Token(Token = "0x17004D8D")]
    public BattleParameter? BaseRatedBuff
    {
      [Token(Token = "0x6017CC4"), Address(RVA = "0x37B9A94", Offset = "0x37B9A94", VA = "0x37B9A94")] get
      {
        return new BattleParameter?();
      }
    }

    [Token(Token = "0x17004D8E")]
    public int Force
    {
      [Token(Token = "0x6017CC5"), Address(RVA = "0x37B9B2C", Offset = "0x37B9B2C", VA = "0x37B9B2C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D8F")]
    public int GridSize
    {
      [Token(Token = "0x6017CC6"), Address(RVA = "0x37B9B70", Offset = "0x37B9B70", VA = "0x37B9B70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017CC7")]
    [Address(RVA = "0x37B9BB4", Offset = "0x37B9BB4", VA = "0x37B9BB4")]
    public string Weapons(int j) => (string) null;

    [Token(Token = "0x17004D90")]
    public int WeaponsLength
    {
      [Token(Token = "0x6017CC8"), Address(RVA = "0x37B9C0C", Offset = "0x37B9C0C", VA = "0x37B9C0C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017CC9")]
    [Address(RVA = "0x37B9C40", Offset = "0x37B9C40", VA = "0x37B9C40")]
    public staq.SaveSchema.Proficiency? Proficiency(int j) => new staq.SaveSchema.Proficiency?();

    [Token(Token = "0x17004D91")]
    public int ProficiencyLength
    {
      [Token(Token = "0x6017CCA"), Address(RVA = "0x37B9D0C", Offset = "0x37B9D0C", VA = "0x37B9D0C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017CCB")]
    [Address(RVA = "0x37B9D40", Offset = "0x37B9D40", VA = "0x37B9D40")]
    public string Accessories(int j) => (string) null;

    [Token(Token = "0x17004D92")]
    public int AccessoriesLength
    {
      [Token(Token = "0x6017CCC"), Address(RVA = "0x37B9D98", Offset = "0x37B9D98", VA = "0x37B9D98")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017CCD")]
    [Address(RVA = "0x37B9DCC", Offset = "0x37B9DCC", VA = "0x37B9DCC")]
    public int MindEquipments(int j) => new int();

    [Token(Token = "0x17004D93")]
    public int MindEquipmentsLength
    {
      [Token(Token = "0x6017CCE"), Address(RVA = "0x37B9E2C", Offset = "0x37B9E2C", VA = "0x37B9E2C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017CCF")]
    [Address(RVA = "0x37B9E60", Offset = "0x37B9E60", VA = "0x37B9E60")]
    public ArraySegment<byte>? GetMindEquipmentsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017CD0")]
    [Address(RVA = "0x37B9E98", Offset = "0x37B9E98", VA = "0x37B9E98")]
    public int[] GetMindEquipmentsArray() => (int[]) null;

    [Token(Token = "0x6017CD1")]
    [Address(RVA = "0x37B9EE4", Offset = "0x37B9EE4", VA = "0x37B9EE4")]
    public int Trusts(int j) => new int();

    [Token(Token = "0x17004D94")]
    public int TrustsLength
    {
      [Token(Token = "0x6017CD2"), Address(RVA = "0x37B9F44", Offset = "0x37B9F44", VA = "0x37B9F44")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017CD3")]
    [Address(RVA = "0x37B9F78", Offset = "0x37B9F78", VA = "0x37B9F78")]
    public ArraySegment<byte>? GetTrustsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017CD4")]
    [Address(RVA = "0x37B9FB0", Offset = "0x37B9FB0", VA = "0x37B9FB0")]
    public int[] GetTrustsArray() => (int[]) null;

    [Token(Token = "0x6017CD5")]
    [Address(RVA = "0x37B9FFC", Offset = "0x37B9FFC", VA = "0x37B9FFC")]
    public int CustomSkills(int j) => new int();

    [Token(Token = "0x17004D95")]
    public int CustomSkillsLength
    {
      [Token(Token = "0x6017CD6"), Address(RVA = "0x37BA05C", Offset = "0x37BA05C", VA = "0x37BA05C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017CD7")]
    [Address(RVA = "0x37BA090", Offset = "0x37BA090", VA = "0x37BA090")]
    public ArraySegment<byte>? GetCustomSkillsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017CD8")]
    [Address(RVA = "0x37BA0C8", Offset = "0x37BA0C8", VA = "0x37BA0C8")]
    public int[] GetCustomSkillsArray() => (int[]) null;

    [Token(Token = "0x6017CD9")]
    [Address(RVA = "0x37BA114", Offset = "0x37BA114", VA = "0x37BA114")]
    public int UnitSkills(int j) => new int();

    [Token(Token = "0x17004D96")]
    public int UnitSkillsLength
    {
      [Token(Token = "0x6017CDA"), Address(RVA = "0x37BA174", Offset = "0x37BA174", VA = "0x37BA174")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017CDB")]
    [Address(RVA = "0x37BA1A8", Offset = "0x37BA1A8", VA = "0x37BA1A8")]
    public ArraySegment<byte>? GetUnitSkillsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017CDC")]
    [Address(RVA = "0x37BA1E0", Offset = "0x37BA1E0", VA = "0x37BA1E0")]
    public int[] GetUnitSkillsArray() => (int[]) null;

    [Token(Token = "0x6017CDD")]
    [Address(RVA = "0x37BA22C", Offset = "0x37BA22C", VA = "0x37BA22C")]
    public int CommuSkills(int j) => new int();

    [Token(Token = "0x17004D97")]
    public int CommuSkillsLength
    {
      [Token(Token = "0x6017CDE"), Address(RVA = "0x37BA28C", Offset = "0x37BA28C", VA = "0x37BA28C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017CDF")]
    [Address(RVA = "0x37BA2C0", Offset = "0x37BA2C0", VA = "0x37BA2C0")]
    public ArraySegment<byte>? GetCommuSkillsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017CE0")]
    [Address(RVA = "0x37BA2F8", Offset = "0x37BA2F8", VA = "0x37BA2F8")]
    public int[] GetCommuSkillsArray() => (int[]) null;

    [Token(Token = "0x17004D98")]
    public int AiType
    {
      [Token(Token = "0x6017CE1"), Address(RVA = "0x37BA344", Offset = "0x37BA344", VA = "0x37BA344")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D99")]
    public int Troops
    {
      [Token(Token = "0x6017CE2"), Address(RVA = "0x37BA388", Offset = "0x37BA388", VA = "0x37BA388")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017CE3")]
    [Address(RVA = "0x37BA3CC", Offset = "0x37BA3CC", VA = "0x37BA3CC")]
    public LvUpParam? LvUpParams(int j) => new LvUpParam?();

    [Token(Token = "0x17004D9A")]
    public int LvUpParamsLength
    {
      [Token(Token = "0x6017CE4"), Address(RVA = "0x37BA480", Offset = "0x37BA480", VA = "0x37BA480")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D9B")]
    public int BaseExp
    {
      [Token(Token = "0x6017CE5"), Address(RVA = "0x37BA4B4", Offset = "0x37BA4B4", VA = "0x37BA4B4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D9C")]
    public int QuestCorrectMoveAmount
    {
      [Token(Token = "0x6017CE6"), Address(RVA = "0x37BA4F8", Offset = "0x37BA4F8", VA = "0x37BA4F8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D9D")]
    public int LimitBreak
    {
      [Token(Token = "0x6017CE7"), Address(RVA = "0x37BA53C", Offset = "0x37BA53C", VA = "0x37BA53C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017CE8")]
    [Address(RVA = "0x37BA580", Offset = "0x37BA580", VA = "0x37BA580")]
    public static Offset<UnitData> CreateUnitData(
      FlatBufferBuilder builder,
      int id = 0,
      StringOffset uniqueIdOffset = default (StringOffset),
      int style = 0,
      int rarity = 0,
      int reincarnationCount = 0,
      int initialExp = 0,
      int initialLp = 0,
      int initialDamage = 0,
      Offset<BasicParameter> initialParameterOffset = default (Offset<BasicParameter>),
      VectorOffset reinforceAtkOffset = default (VectorOffset),
      VectorOffset resistAtkOffset = default (VectorOffset),
      VectorOffset reinforceElementOffset = default (VectorOffset),
      VectorOffset resistElementOffset = default (VectorOffset),
      Offset<BattleParameter> styleMasterBonusOffset = default (Offset<BattleParameter>),
      Offset<BattleParameter> baseRatedBuffOffset = default (Offset<BattleParameter>),
      int force = 0,
      int gridSize = 0,
      VectorOffset weaponsOffset = default (VectorOffset),
      VectorOffset proficiencyOffset = default (VectorOffset),
      VectorOffset accessoriesOffset = default (VectorOffset),
      VectorOffset mindEquipmentsOffset = default (VectorOffset),
      VectorOffset trustsOffset = default (VectorOffset),
      VectorOffset customSkillsOffset = default (VectorOffset),
      VectorOffset unitSkillsOffset = default (VectorOffset),
      VectorOffset commuSkillsOffset = default (VectorOffset),
      int aiType = 0,
      int troops = 0,
      VectorOffset lvUpParamsOffset = default (VectorOffset),
      int baseExp = 0,
      int questCorrectMoveAmount = 0,
      int limitBreak = 0)
    {
      return new Offset<UnitData>();
    }

    [Token(Token = "0x6017CE9")]
    [Address(RVA = "0x37BAC58", Offset = "0x37BAC58", VA = "0x37BAC58")]
    public static void StartUnitData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017CEA")]
    [Address(RVA = "0x37BABE8", Offset = "0x37BABE8", VA = "0x37BABE8")]
    public static void AddId(FlatBufferBuilder builder, int id)
    {
    }

    [Token(Token = "0x6017CEB")]
    [Address(RVA = "0x37BABC8", Offset = "0x37BABC8", VA = "0x37BABC8")]
    public static void AddUniqueId(FlatBufferBuilder builder, StringOffset uniqueIdOffset)
    {
    }

    [Token(Token = "0x6017CEC")]
    [Address(RVA = "0x37BABA8", Offset = "0x37BABA8", VA = "0x37BABA8")]
    public static void AddStyle(FlatBufferBuilder builder, int style)
    {
    }

    [Token(Token = "0x6017CED")]
    [Address(RVA = "0x37BAB88", Offset = "0x37BAB88", VA = "0x37BAB88")]
    public static void AddRarity(FlatBufferBuilder builder, int rarity)
    {
    }

    [Token(Token = "0x6017CEE")]
    [Address(RVA = "0x37BAB68", Offset = "0x37BAB68", VA = "0x37BAB68")]
    public static void AddReincarnationCount(FlatBufferBuilder builder, int reincarnationCount)
    {
    }

    [Token(Token = "0x6017CEF")]
    [Address(RVA = "0x37BAB48", Offset = "0x37BAB48", VA = "0x37BAB48")]
    public static void AddInitialExp(FlatBufferBuilder builder, int initialExp)
    {
    }

    [Token(Token = "0x6017CF0")]
    [Address(RVA = "0x37BAB28", Offset = "0x37BAB28", VA = "0x37BAB28")]
    public static void AddInitialLp(FlatBufferBuilder builder, int initialLp)
    {
    }

    [Token(Token = "0x6017CF1")]
    [Address(RVA = "0x37BAB08", Offset = "0x37BAB08", VA = "0x37BAB08")]
    public static void AddInitialDamage(FlatBufferBuilder builder, int initialDamage)
    {
    }

    [Token(Token = "0x6017CF2")]
    [Address(RVA = "0x37BAAE8", Offset = "0x37BAAE8", VA = "0x37BAAE8")]
    public static void AddInitialParameter(
      FlatBufferBuilder builder,
      Offset<BasicParameter> initialParameterOffset)
    {
    }

    [Token(Token = "0x6017CF3")]
    [Address(RVA = "0x37BAAC8", Offset = "0x37BAAC8", VA = "0x37BAAC8")]
    public static void AddReinforceAtk(FlatBufferBuilder builder, VectorOffset reinforceAtkOffset)
    {
    }

    [Token(Token = "0x6017CF4")]
    [Address(RVA = "0x37BAC70", Offset = "0x37BAC70", VA = "0x37BAC70")]
    public static VectorOffset CreateReinforceAtkVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017CF5")]
    [Address(RVA = "0x37BAD18", Offset = "0x37BAD18", VA = "0x37BAD18")]
    public static VectorOffset CreateReinforceAtkVectorBlock(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017CF6")]
    [Address(RVA = "0x37BADA0", Offset = "0x37BADA0", VA = "0x37BADA0")]
    public static void StartReinforceAtkVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017CF7")]
    [Address(RVA = "0x37BAAA8", Offset = "0x37BAAA8", VA = "0x37BAAA8")]
    public static void AddResistAtk(FlatBufferBuilder builder, VectorOffset resistAtkOffset)
    {
    }

    [Token(Token = "0x6017CF8")]
    [Address(RVA = "0x37BADC0", Offset = "0x37BADC0", VA = "0x37BADC0")]
    public static VectorOffset CreateResistAtkVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017CF9")]
    [Address(RVA = "0x37BAE68", Offset = "0x37BAE68", VA = "0x37BAE68")]
    public static VectorOffset CreateResistAtkVectorBlock(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017CFA")]
    [Address(RVA = "0x37BAEF0", Offset = "0x37BAEF0", VA = "0x37BAEF0")]
    public static void StartResistAtkVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017CFB")]
    [Address(RVA = "0x37BAA88", Offset = "0x37BAA88", VA = "0x37BAA88")]
    public static void AddReinforceElement(
      FlatBufferBuilder builder,
      VectorOffset reinforceElementOffset)
    {
    }

    [Token(Token = "0x6017CFC")]
    [Address(RVA = "0x37BAF10", Offset = "0x37BAF10", VA = "0x37BAF10")]
    public static VectorOffset CreateReinforceElementVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017CFD")]
    [Address(RVA = "0x37BAFB8", Offset = "0x37BAFB8", VA = "0x37BAFB8")]
    public static VectorOffset CreateReinforceElementVectorBlock(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017CFE")]
    [Address(RVA = "0x37BB040", Offset = "0x37BB040", VA = "0x37BB040")]
    public static void StartReinforceElementVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017CFF")]
    [Address(RVA = "0x37BAA68", Offset = "0x37BAA68", VA = "0x37BAA68")]
    public static void AddResistElement(FlatBufferBuilder builder, VectorOffset resistElementOffset)
    {
    }

    [Token(Token = "0x6017D00")]
    [Address(RVA = "0x37BB060", Offset = "0x37BB060", VA = "0x37BB060")]
    public static VectorOffset CreateResistElementVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D01")]
    [Address(RVA = "0x37BB108", Offset = "0x37BB108", VA = "0x37BB108")]
    public static VectorOffset CreateResistElementVectorBlock(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D02")]
    [Address(RVA = "0x37BB190", Offset = "0x37BB190", VA = "0x37BB190")]
    public static void StartResistElementVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017D03")]
    [Address(RVA = "0x37BAA48", Offset = "0x37BAA48", VA = "0x37BAA48")]
    public static void AddStyleMasterBonus(
      FlatBufferBuilder builder,
      Offset<BattleParameter> styleMasterBonusOffset)
    {
    }

    [Token(Token = "0x6017D04")]
    [Address(RVA = "0x37BAA28", Offset = "0x37BAA28", VA = "0x37BAA28")]
    public static void AddBaseRatedBuff(
      FlatBufferBuilder builder,
      Offset<BattleParameter> baseRatedBuffOffset)
    {
    }

    [Token(Token = "0x6017D05")]
    [Address(RVA = "0x37BAA08", Offset = "0x37BAA08", VA = "0x37BAA08")]
    public static void AddForce(FlatBufferBuilder builder, int force)
    {
    }

    [Token(Token = "0x6017D06")]
    [Address(RVA = "0x37BA9E8", Offset = "0x37BA9E8", VA = "0x37BA9E8")]
    public static void AddGridSize(FlatBufferBuilder builder, int gridSize)
    {
    }

    [Token(Token = "0x6017D07")]
    [Address(RVA = "0x37BA9C8", Offset = "0x37BA9C8", VA = "0x37BA9C8")]
    public static void AddWeapons(FlatBufferBuilder builder, VectorOffset weaponsOffset)
    {
    }

    [Token(Token = "0x6017D08")]
    [Address(RVA = "0x37BB1B0", Offset = "0x37BB1B0", VA = "0x37BB1B0")]
    public static VectorOffset CreateWeaponsVector(FlatBufferBuilder builder, StringOffset[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D09")]
    [Address(RVA = "0x37BB258", Offset = "0x37BB258", VA = "0x37BB258")]
    public static VectorOffset CreateWeaponsVectorBlock(
      FlatBufferBuilder builder,
      StringOffset[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D0A")]
    [Address(RVA = "0x37BB2E0", Offset = "0x37BB2E0", VA = "0x37BB2E0")]
    public static void StartWeaponsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017D0B")]
    [Address(RVA = "0x37BA9A8", Offset = "0x37BA9A8", VA = "0x37BA9A8")]
    public static void AddProficiency(FlatBufferBuilder builder, VectorOffset proficiencyOffset)
    {
    }

    [Token(Token = "0x6017D0C")]
    [Address(RVA = "0x37BB300", Offset = "0x37BB300", VA = "0x37BB300")]
    public static VectorOffset CreateProficiencyVector(
      FlatBufferBuilder builder,
      Offset<staq.SaveSchema.Proficiency>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D0D")]
    [Address(RVA = "0x37BB3A8", Offset = "0x37BB3A8", VA = "0x37BB3A8")]
    public static VectorOffset CreateProficiencyVectorBlock(
      FlatBufferBuilder builder,
      Offset<staq.SaveSchema.Proficiency>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D0E")]
    [Address(RVA = "0x37BB430", Offset = "0x37BB430", VA = "0x37BB430")]
    public static void StartProficiencyVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017D0F")]
    [Address(RVA = "0x37BA988", Offset = "0x37BA988", VA = "0x37BA988")]
    public static void AddAccessories(FlatBufferBuilder builder, VectorOffset accessoriesOffset)
    {
    }

    [Token(Token = "0x6017D10")]
    [Address(RVA = "0x37BB450", Offset = "0x37BB450", VA = "0x37BB450")]
    public static VectorOffset CreateAccessoriesVector(
      FlatBufferBuilder builder,
      StringOffset[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D11")]
    [Address(RVA = "0x37BB4F8", Offset = "0x37BB4F8", VA = "0x37BB4F8")]
    public static VectorOffset CreateAccessoriesVectorBlock(
      FlatBufferBuilder builder,
      StringOffset[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D12")]
    [Address(RVA = "0x37BB580", Offset = "0x37BB580", VA = "0x37BB580")]
    public static void StartAccessoriesVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017D13")]
    [Address(RVA = "0x37BA968", Offset = "0x37BA968", VA = "0x37BA968")]
    public static void AddMindEquipments(
      FlatBufferBuilder builder,
      VectorOffset mindEquipmentsOffset)
    {
    }

    [Token(Token = "0x6017D14")]
    [Address(RVA = "0x37BB5A0", Offset = "0x37BB5A0", VA = "0x37BB5A0")]
    public static VectorOffset CreateMindEquipmentsVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D15")]
    [Address(RVA = "0x37BB648", Offset = "0x37BB648", VA = "0x37BB648")]
    public static VectorOffset CreateMindEquipmentsVectorBlock(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D16")]
    [Address(RVA = "0x37BB6D0", Offset = "0x37BB6D0", VA = "0x37BB6D0")]
    public static void StartMindEquipmentsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017D17")]
    [Address(RVA = "0x37BA948", Offset = "0x37BA948", VA = "0x37BA948")]
    public static void AddTrusts(FlatBufferBuilder builder, VectorOffset trustsOffset)
    {
    }

    [Token(Token = "0x6017D18")]
    [Address(RVA = "0x37BB6F0", Offset = "0x37BB6F0", VA = "0x37BB6F0")]
    public static VectorOffset CreateTrustsVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D19")]
    [Address(RVA = "0x37BB798", Offset = "0x37BB798", VA = "0x37BB798")]
    public static VectorOffset CreateTrustsVectorBlock(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D1A")]
    [Address(RVA = "0x37BB820", Offset = "0x37BB820", VA = "0x37BB820")]
    public static void StartTrustsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017D1B")]
    [Address(RVA = "0x37BA928", Offset = "0x37BA928", VA = "0x37BA928")]
    public static void AddCustomSkills(FlatBufferBuilder builder, VectorOffset customSkillsOffset)
    {
    }

    [Token(Token = "0x6017D1C")]
    [Address(RVA = "0x37BB840", Offset = "0x37BB840", VA = "0x37BB840")]
    public static VectorOffset CreateCustomSkillsVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D1D")]
    [Address(RVA = "0x37BB8E8", Offset = "0x37BB8E8", VA = "0x37BB8E8")]
    public static VectorOffset CreateCustomSkillsVectorBlock(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D1E")]
    [Address(RVA = "0x37BB970", Offset = "0x37BB970", VA = "0x37BB970")]
    public static void StartCustomSkillsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017D1F")]
    [Address(RVA = "0x37BA908", Offset = "0x37BA908", VA = "0x37BA908")]
    public static void AddUnitSkills(FlatBufferBuilder builder, VectorOffset unitSkillsOffset)
    {
    }

    [Token(Token = "0x6017D20")]
    [Address(RVA = "0x37BB990", Offset = "0x37BB990", VA = "0x37BB990")]
    public static VectorOffset CreateUnitSkillsVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D21")]
    [Address(RVA = "0x37BBA38", Offset = "0x37BBA38", VA = "0x37BBA38")]
    public static VectorOffset CreateUnitSkillsVectorBlock(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D22")]
    [Address(RVA = "0x37BBAC0", Offset = "0x37BBAC0", VA = "0x37BBAC0")]
    public static void StartUnitSkillsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017D23")]
    [Address(RVA = "0x37BA8E8", Offset = "0x37BA8E8", VA = "0x37BA8E8")]
    public static void AddCommuSkills(FlatBufferBuilder builder, VectorOffset commuSkillsOffset)
    {
    }

    [Token(Token = "0x6017D24")]
    [Address(RVA = "0x37BBAE0", Offset = "0x37BBAE0", VA = "0x37BBAE0")]
    public static VectorOffset CreateCommuSkillsVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D25")]
    [Address(RVA = "0x37BBB88", Offset = "0x37BBB88", VA = "0x37BBB88")]
    public static VectorOffset CreateCommuSkillsVectorBlock(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D26")]
    [Address(RVA = "0x37BBC10", Offset = "0x37BBC10", VA = "0x37BBC10")]
    public static void StartCommuSkillsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017D27")]
    [Address(RVA = "0x37BA8C8", Offset = "0x37BA8C8", VA = "0x37BA8C8")]
    public static void AddAiType(FlatBufferBuilder builder, int aiType)
    {
    }

    [Token(Token = "0x6017D28")]
    [Address(RVA = "0x37BA8A8", Offset = "0x37BA8A8", VA = "0x37BA8A8")]
    public static void AddTroops(FlatBufferBuilder builder, int troops)
    {
    }

    [Token(Token = "0x6017D29")]
    [Address(RVA = "0x37BA888", Offset = "0x37BA888", VA = "0x37BA888")]
    public static void AddLvUpParams(FlatBufferBuilder builder, VectorOffset lvUpParamsOffset)
    {
    }

    [Token(Token = "0x6017D2A")]
    [Address(RVA = "0x37BBC30", Offset = "0x37BBC30", VA = "0x37BBC30")]
    public static VectorOffset CreateLvUpParamsVector(
      FlatBufferBuilder builder,
      Offset<LvUpParam>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D2B")]
    [Address(RVA = "0x37BBCD8", Offset = "0x37BBCD8", VA = "0x37BBCD8")]
    public static VectorOffset CreateLvUpParamsVectorBlock(
      FlatBufferBuilder builder,
      Offset<LvUpParam>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D2C")]
    [Address(RVA = "0x37BBD60", Offset = "0x37BBD60", VA = "0x37BBD60")]
    public static void StartLvUpParamsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017D2D")]
    [Address(RVA = "0x37BA868", Offset = "0x37BA868", VA = "0x37BA868")]
    public static void AddBaseExp(FlatBufferBuilder builder, int baseExp)
    {
    }

    [Token(Token = "0x6017D2E")]
    [Address(RVA = "0x37BA848", Offset = "0x37BA848", VA = "0x37BA848")]
    public static void AddQuestCorrectMoveAmount(
      FlatBufferBuilder builder,
      int questCorrectMoveAmount)
    {
    }

    [Token(Token = "0x6017D2F")]
    [Address(RVA = "0x37BA828", Offset = "0x37BA828", VA = "0x37BA828")]
    public static void AddLimitBreak(FlatBufferBuilder builder, int limitBreak)
    {
    }

    [Token(Token = "0x6017D30")]
    [Address(RVA = "0x37BAC08", Offset = "0x37BAC08", VA = "0x37BAC08")]
    public static Offset<UnitData> EndUnitData(FlatBufferBuilder builder) => new Offset<UnitData>();
  }
}
