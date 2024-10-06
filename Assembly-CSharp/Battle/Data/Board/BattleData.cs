// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.BattleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002755")]
  public class BattleData : 
    IBattleDataHandler,
    IUnitDataHandler,
    IWeaponDataHandler,
    IAccessoryDataHandler,
    IMindEquipmentDataHandler,
    ITrustDataHandler,
    ISkillDataHandler,
    IItemDataHandler,
    IEffectHandler,
    IBadStatusEffectHandler
  {
    [Token(Token = "0x400A80C")]
    [FieldOffset(Offset = "0x68")]
    private Dictionary<int, BadStatusEffectData> badStatusDic;
    [Token(Token = "0x400A80D")]
    [FieldOffset(Offset = "0x70")]
    private Dictionary<(int skill, int level, int rarity), int> processingSkillId;
    [Token(Token = "0x400A80E")]
    [FieldOffset(Offset = "0x78")]
    private Dictionary<int, ItemData> itemDic;

    [Token(Token = "0x17003485")]
    public GameCore.MasterData.BattleData BattleMaster
    {
      [Token(Token = "0x600F555"), Address(RVA = "0x1FB50E8", Offset = "0x1FB50E8", VA = "0x1FB50E8")] get
      {
        return (GameCore.MasterData.BattleData) null;
      }
      [Token(Token = "0x600F556"), Address(RVA = "0x1FB50F0", Offset = "0x1FB50F0", VA = "0x1FB50F0")] private set
      {
      }
    }

    [Token(Token = "0x17003486")]
    public int[] PlayerTurnOrder
    {
      [Token(Token = "0x600F557"), Address(RVA = "0x1FB50F8", Offset = "0x1FB50F8", VA = "0x1FB50F8")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x600F558"), Address(RVA = "0x1FB5100", Offset = "0x1FB5100", VA = "0x1FB5100")] private set
      {
      }
    }

    [Token(Token = "0x17003487")]
    public List<EffectData> Effects
    {
      [Token(Token = "0x600F559"), Address(RVA = "0x1FB5108", Offset = "0x1FB5108", VA = "0x1FB5108")] get
      {
        return (List<EffectData>) null;
      }
      [Token(Token = "0x600F55A"), Address(RVA = "0x1FB5110", Offset = "0x1FB5110", VA = "0x1FB5110")] private set
      {
      }
    }

    [Token(Token = "0x17003488")]
    public List<SkillData> Skills
    {
      [Token(Token = "0x600F55B"), Address(RVA = "0x1FB5118", Offset = "0x1FB5118", VA = "0x1FB5118")] get
      {
        return (List<SkillData>) null;
      }
      [Token(Token = "0x600F55C"), Address(RVA = "0x1FB5120", Offset = "0x1FB5120", VA = "0x1FB5120")] private set
      {
      }
    }

    [Token(Token = "0x17003489")]
    public List<UnitData> Units
    {
      [Token(Token = "0x600F55D"), Address(RVA = "0x1FB5128", Offset = "0x1FB5128", VA = "0x1FB5128")] get
      {
        return (List<UnitData>) null;
      }
      [Token(Token = "0x600F55E"), Address(RVA = "0x1FB5130", Offset = "0x1FB5130", VA = "0x1FB5130")] private set
      {
      }
    }

    [Token(Token = "0x1700348A")]
    public List<WeaponData> Weapons
    {
      [Token(Token = "0x600F55F"), Address(RVA = "0x1FB5138", Offset = "0x1FB5138", VA = "0x1FB5138")] get
      {
        return (List<WeaponData>) null;
      }
      [Token(Token = "0x600F560"), Address(RVA = "0x1FB5140", Offset = "0x1FB5140", VA = "0x1FB5140")] private set
      {
      }
    }

    [Token(Token = "0x1700348B")]
    public List<AccessoryData> Accessories
    {
      [Token(Token = "0x600F561"), Address(RVA = "0x1FB5148", Offset = "0x1FB5148", VA = "0x1FB5148")] get
      {
        return (List<AccessoryData>) null;
      }
      [Token(Token = "0x600F562"), Address(RVA = "0x1FB5150", Offset = "0x1FB5150", VA = "0x1FB5150")] private set
      {
      }
    }

    [Token(Token = "0x1700348C")]
    public List<MindEquipmentData> MindEquipments
    {
      [Token(Token = "0x600F563"), Address(RVA = "0x1FB5158", Offset = "0x1FB5158", VA = "0x1FB5158")] get
      {
        return (List<MindEquipmentData>) null;
      }
      [Token(Token = "0x600F564"), Address(RVA = "0x1FB5160", Offset = "0x1FB5160", VA = "0x1FB5160")] private set
      {
      }
    }

    [Token(Token = "0x1700348D")]
    public List<TrustData> Trusts
    {
      [Token(Token = "0x600F565"), Address(RVA = "0x1FB5168", Offset = "0x1FB5168", VA = "0x1FB5168")] get
      {
        return (List<TrustData>) null;
      }
      [Token(Token = "0x600F566"), Address(RVA = "0x1FB5170", Offset = "0x1FB5170", VA = "0x1FB5170")] private set
      {
      }
    }

    [Token(Token = "0x1700348E")]
    public QuestTypeEnum QuestType
    {
      [Token(Token = "0x600F567"), Address(RVA = "0x1FB5178", Offset = "0x1FB5178", VA = "0x1FB5178")] get
      {
        return new QuestTypeEnum();
      }
      [Token(Token = "0x600F568"), Address(RVA = "0x1FB5180", Offset = "0x1FB5180", VA = "0x1FB5180")] private set
      {
      }
    }

    [Token(Token = "0x1700348F")]
    public BattleTimeTypeEnum Time
    {
      [Token(Token = "0x600F569"), Address(RVA = "0x1FB5188", Offset = "0x1FB5188", VA = "0x1FB5188")] get
      {
        return new BattleTimeTypeEnum();
      }
      [Token(Token = "0x600F56A"), Address(RVA = "0x1FB5190", Offset = "0x1FB5190", VA = "0x1FB5190")] private set
      {
      }
    }

    [Token(Token = "0x17003490")]
    public BattleWeatherTypeEnum Weather
    {
      [Token(Token = "0x600F56B"), Address(RVA = "0x1FB5198", Offset = "0x1FB5198", VA = "0x1FB5198")] get
      {
        return new BattleWeatherTypeEnum();
      }
      [Token(Token = "0x600F56C"), Address(RVA = "0x1FB51A0", Offset = "0x1FB51A0", VA = "0x1FB51A0")] private set
      {
      }
    }

    [Token(Token = "0x17003491")]
    public CorrelationDataBase CorrelationData
    {
      [Token(Token = "0x600F56D"), Address(RVA = "0x1FB51A8", Offset = "0x1FB51A8", VA = "0x1FB51A8")] get
      {
        return (CorrelationDataBase) null;
      }
      [Token(Token = "0x600F56E"), Address(RVA = "0x1FB51B0", Offset = "0x1FB51B0", VA = "0x1FB51B0")] private set
      {
      }
    }

    [Token(Token = "0x17003492")]
    public EffectFactory EffectFactory
    {
      [Token(Token = "0x600F56F"), Address(RVA = "0x1FB51B8", Offset = "0x1FB51B8", VA = "0x1FB51B8")] get
      {
        return (EffectFactory) null;
      }
      [Token(Token = "0x600F570"), Address(RVA = "0x1FB51C0", Offset = "0x1FB51C0", VA = "0x1FB51C0")] private set
      {
      }
    }

    [Token(Token = "0x600F571")]
    [Address(RVA = "0x1FB51C8", Offset = "0x1FB51C8", VA = "0x1FB51C8")]
    private BattleData()
    {
    }

    [Token(Token = "0x600F572")]
    [Address(RVA = "0x1FB54A8", Offset = "0x1FB54A8", VA = "0x1FB54A8")]
    public static BattleData Create(GameCore.MasterData.BattleData battle, CorrelationDataBase correlationData)
    {
      return (BattleData) null;
    }

    [Token(Token = "0x600F573")]
    [Address(RVA = "0x1FB554C", Offset = "0x1FB554C", VA = "0x1FB554C")]
    public static BattleData CreateFromSchema(
      staq.SaveSchema.BattleData schema,
      CorrelationDataBase correlationData)
    {
      return (BattleData) null;
    }

    [Token(Token = "0x600F574")]
    [Address(RVA = "0x1FB5C3C", Offset = "0x1FB5C3C", VA = "0x1FB5C3C")]
    public void SetTurnOrder(int[] order)
    {
    }

    [Token(Token = "0x600F575")]
    [Address(RVA = "0x1FB5C44", Offset = "0x1FB5C44", VA = "0x1FB5C44")]
    public void SetEmvironment(BattleTimeTypeEnum time, BattleWeatherTypeEnum weather)
    {
    }

    [Token(Token = "0x600F576")]
    [Address(RVA = "0x1FB5C4C", Offset = "0x1FB5C4C", VA = "0x1FB5C4C")]
    public void SetQuestType(QuestTypeEnum questType)
    {
    }

    [Token(Token = "0x600F577")]
    [Address(RVA = "0x1FB5C54", Offset = "0x1FB5C54", VA = "0x1FB5C54", Slot = "6")]
    public bool TryGetWeapon(string id, out WeaponData weapon) => new bool();

    [Token(Token = "0x600F578")]
    [Address(RVA = "0x1FB5DD8", Offset = "0x1FB5DD8", VA = "0x1FB5DD8", Slot = "7")]
    public bool RegisterWeapon(WeaponData weapon) => new bool();

    [Token(Token = "0x600F579")]
    [Address(RVA = "0x1FB5EAC", Offset = "0x1FB5EAC", VA = "0x1FB5EAC", Slot = "8")]
    public bool TryGetAccessory(string id, out AccessoryData accessory) => new bool();

    [Token(Token = "0x600F57A")]
    [Address(RVA = "0x1FB6030", Offset = "0x1FB6030", VA = "0x1FB6030", Slot = "9")]
    public bool RegisterAccessory(AccessoryData accessory) => new bool();

    [Token(Token = "0x600F57B")]
    [Address(RVA = "0x1FB6104", Offset = "0x1FB6104", VA = "0x1FB6104", Slot = "10")]
    public int CreateMindEquipmentId() => new int();

    [Token(Token = "0x600F57C")]
    [Address(RVA = "0x1FB6150", Offset = "0x1FB6150", VA = "0x1FB6150", Slot = "11")]
    public bool TryGetMindEquipment(int id, out MindEquipmentData mindEquipment) => new bool();

    [Token(Token = "0x600F57D")]
    [Address(RVA = "0x1FB62B8", Offset = "0x1FB62B8", VA = "0x1FB62B8", Slot = "12")]
    public bool RegisterMindEquipment(MindEquipmentData mindEquipment) => new bool();

    [Token(Token = "0x600F57E")]
    [Address(RVA = "0x1FB638C", Offset = "0x1FB638C", VA = "0x1FB638C", Slot = "13")]
    public int CreateTrustId() => new int();

    [Token(Token = "0x600F57F")]
    [Address(RVA = "0x1FB63D8", Offset = "0x1FB63D8", VA = "0x1FB63D8", Slot = "14")]
    public bool TryGetTrust(int id, out TrustData trust) => new bool();

    [Token(Token = "0x600F580")]
    [Address(RVA = "0x1FB6540", Offset = "0x1FB6540", VA = "0x1FB6540", Slot = "15")]
    public bool RegisterTrust(TrustData trust) => new bool();

    [Token(Token = "0x600F581")]
    [Address(RVA = "0x1FB6614", Offset = "0x1FB6614", VA = "0x1FB6614", Slot = "4")]
    public bool TryGetUnit(int id, out UnitData unit) => new bool();

    [Token(Token = "0x600F582")]
    [Address(RVA = "0x1FB677C", Offset = "0x1FB677C", VA = "0x1FB677C", Slot = "5")]
    public bool RegisterUnit(UnitData unit) => new bool();

    [Token(Token = "0x600F583")]
    [Address(RVA = "0x1FB6850", Offset = "0x1FB6850", VA = "0x1FB6850", Slot = "16")]
    public int RequestSkillId(int skill, int level, int rarity) => new int();

    [Token(Token = "0x600F584")]
    [Address(RVA = "0x1FB6B24", Offset = "0x1FB6B24", VA = "0x1FB6B24", Slot = "17")]
    public bool TryGetSkill(int id, out SkillData skill) => new bool();

    [Token(Token = "0x600F585")]
    [Address(RVA = "0x1FB6C8C", Offset = "0x1FB6C8C", VA = "0x1FB6C8C", Slot = "18")]
    public bool RegisterSkill(SkillData skill) => new bool();

    [Token(Token = "0x600F586")]
    [Address(RVA = "0x1FB6DC8", Offset = "0x1FB6DC8", VA = "0x1FB6DC8", Slot = "21")]
    public EffectFactory GetEffectFactory() => (EffectFactory) null;

    [Token(Token = "0x600F587")]
    [Address(RVA = "0x1FB6DD0", Offset = "0x1FB6DD0", VA = "0x1FB6DD0", Slot = "22")]
    public bool TryGetEffect(int id, out EffectData effect) => new bool();

    [Token(Token = "0x600F588")]
    [Address(RVA = "0x1FB6F38", Offset = "0x1FB6F38", VA = "0x1FB6F38", Slot = "23")]
    public bool RegisterEffect(EffectData effect) => new bool();

    [Token(Token = "0x600F589")]
    [Address(RVA = "0x1FB700C", Offset = "0x1FB700C", VA = "0x1FB700C", Slot = "24")]
    public bool TryGetBadStatus(int badStatusDetail, out BadStatusEffectData badStatusEffect)
    {
      return new bool();
    }

    [Token(Token = "0x600F58A")]
    [Address(RVA = "0x1FB7074", Offset = "0x1FB7074", VA = "0x1FB7074", Slot = "25")]
    public bool RegisterBadStatus(BadStatusEffectData badStatusEffect) => new bool();

    [Token(Token = "0x600F58B")]
    [Address(RVA = "0x1FB7120", Offset = "0x1FB7120", VA = "0x1FB7120", Slot = "19")]
    public bool TryGetItem(int id, out ItemData item) => new bool();

    [Token(Token = "0x600F58C")]
    [Address(RVA = "0x1FB7188", Offset = "0x1FB7188", VA = "0x1FB7188", Slot = "20")]
    public bool RegisterItem(ItemData item) => new bool();
  }
}
