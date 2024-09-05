// Decompiled with JetBrains decompiler
// Type: Battle.Data.UnitParameterChange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Logic;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x200272F")]
  public sealed class UnitParameterChange
  {
    [Token(Token = "0x400A779")]
    public const int ConsumeLPOnDead = 1;
    [Token(Token = "0x400A77C")]
    [FieldOffset(Offset = "0x18")]
    private Battle.Data.HPStockData hpStockData;
    [Token(Token = "0x400A792")]
    [FieldOffset(Offset = "0x90")]
    private List<EffectParameterData> addedEffectsByUnit;
    [Token(Token = "0x400A793")]
    [FieldOffset(Offset = "0x98")]
    private List<EffectParameterData> removedSkillEffectsFromUnit;

    [Token(Token = "0x600F3CD")]
    [Address(RVA = "0x1FA53E8", Offset = "0x1FA53E8", VA = "0x1FA53E8")]
    public static UnitParameterChange Create(UnitParameterData unit) => (UnitParameterChange) null;

    [Token(Token = "0x600F3CE")]
    [Address(RVA = "0x1FA58B4", Offset = "0x1FA58B4", VA = "0x1FA58B4")]
    public static UnitParameterChange Create(
      EffectData effect,
      EffectLogic.EffectLogicInputParam input)
    {
      return (UnitParameterChange) null;
    }

    [Token(Token = "0x600F3CF")]
    [Address(RVA = "0x1FA5BEC", Offset = "0x1FA5BEC", VA = "0x1FA5BEC")]
    public static BattleBadStatusData GetMostEffectPriorityBadStatusFromDiff(
      UnitParameterChange prev,
      UnitParameterChange after)
    {
      return (BattleBadStatusData) null;
    }

    [Token(Token = "0x600F3D0")]
    [Address(RVA = "0x1FA5D44", Offset = "0x1FA5D44", VA = "0x1FA5D44")]
    public static EffectData GetMostPriorityParameterEffectFromDiff(
      UnitParameterChange prev,
      UnitParameterChange after)
    {
      return (EffectData) null;
    }

    [Token(Token = "0x17003406")]
    public bool IsAlive
    {
      [Token(Token = "0x600F3D1"), Address(RVA = "0x1FA6124", Offset = "0x1FA6124", VA = "0x1FA6124")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003407")]
    public bool IsImmortal
    {
      [Token(Token = "0x600F3D2"), Address(RVA = "0x1FA61C8", Offset = "0x1FA61C8", VA = "0x1FA61C8")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F3D3"), Address(RVA = "0x1FA61D0", Offset = "0x1FA61D0", VA = "0x1FA61D0")] private set
      {
      }
    }

    [Token(Token = "0x17003408")]
    public bool IsWeaponCare
    {
      [Token(Token = "0x600F3D4"), Address(RVA = "0x1FA61DC", Offset = "0x1FA61DC", VA = "0x1FA61DC")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F3D5"), Address(RVA = "0x1FA61E4", Offset = "0x1FA61E4", VA = "0x1FA61E4")] private set
      {
      }
    }

    [Token(Token = "0x17003409")]
    public IReadableHPStockData HPStockData
    {
      [Token(Token = "0x600F3D6"), Address(RVA = "0x1FA61F0", Offset = "0x1FA61F0", VA = "0x1FA61F0")] get
      {
        return (IReadableHPStockData) null;
      }
    }

    [Token(Token = "0x1700340A")]
    public BarrierContainer Barrier
    {
      [Token(Token = "0x600F3D7"), Address(RVA = "0x1FA61F8", Offset = "0x1FA61F8", VA = "0x1FA61F8")] get
      {
        return (BarrierContainer) null;
      }
      [Token(Token = "0x600F3D8"), Address(RVA = "0x1FA6200", Offset = "0x1FA6200", VA = "0x1FA6200")] private set
      {
      }
    }

    [Token(Token = "0x1700340B")]
    public List<int> TotalBarrierDamages
    {
      [Token(Token = "0x600F3D9"), Address(RVA = "0x1FA6208", Offset = "0x1FA6208", VA = "0x1FA6208")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x600F3DA"), Address(RVA = "0x1FA6210", Offset = "0x1FA6210", VA = "0x1FA6210")] private set
      {
      }
    }

    [Token(Token = "0x1700340C")]
    public List<int> TotalBarrierRepaires
    {
      [Token(Token = "0x600F3DB"), Address(RVA = "0x1FA6218", Offset = "0x1FA6218", VA = "0x1FA6218")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x600F3DC"), Address(RVA = "0x1FA6220", Offset = "0x1FA6220", VA = "0x1FA6220")] private set
      {
      }
    }

    [Token(Token = "0x1700340D")]
    public Vector2Int From
    {
      [Token(Token = "0x600F3DD"), Address(RVA = "0x1FA6228", Offset = "0x1FA6228", VA = "0x1FA6228")] get
      {
        return new Vector2Int();
      }
      [Token(Token = "0x600F3DE"), Address(RVA = "0x1FA6230", Offset = "0x1FA6230", VA = "0x1FA6230")] private set
      {
      }
    }

    [Token(Token = "0x1700340E")]
    public Vector2Int To
    {
      [Token(Token = "0x600F3DF"), Address(RVA = "0x1FA6238", Offset = "0x1FA6238", VA = "0x1FA6238")] get
      {
        return new Vector2Int();
      }
      [Token(Token = "0x600F3E0"), Address(RVA = "0x1FA6240", Offset = "0x1FA6240", VA = "0x1FA6240")] private set
      {
      }
    }

    [Token(Token = "0x1700340F")]
    public int TotalUnitDamageValue
    {
      [Token(Token = "0x600F3E1"), Address(RVA = "0x1FA6248", Offset = "0x1FA6248", VA = "0x1FA6248")] get
      {
        return new int();
      }
      [Token(Token = "0x600F3E2"), Address(RVA = "0x1FA6250", Offset = "0x1FA6250", VA = "0x1FA6250")] private set
      {
      }
    }

    [Token(Token = "0x17003410")]
    public bool HasAnyDamage
    {
      [Token(Token = "0x600F3E3"), Address(RVA = "0x1FA6258", Offset = "0x1FA6258", VA = "0x1FA6258")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F3E4"), Address(RVA = "0x1FA6260", Offset = "0x1FA6260", VA = "0x1FA6260")] private set
      {
      }
    }

    [Token(Token = "0x17003411")]
    public int TotalOverKillDamageValue
    {
      [Token(Token = "0x600F3E5"), Address(RVA = "0x1FA626C", Offset = "0x1FA626C", VA = "0x1FA626C")] get
      {
        return new int();
      }
      [Token(Token = "0x600F3E6"), Address(RVA = "0x1FA6274", Offset = "0x1FA6274", VA = "0x1FA6274")] private set
      {
      }
    }

    [Token(Token = "0x17003412")]
    public int NormalHealValue
    {
      [Token(Token = "0x600F3E7"), Address(RVA = "0x1FA627C", Offset = "0x1FA627C", VA = "0x1FA627C")] get
      {
        return new int();
      }
      [Token(Token = "0x600F3E8"), Address(RVA = "0x1FA6284", Offset = "0x1FA6284", VA = "0x1FA6284")] private set
      {
      }
    }

    [Token(Token = "0x17003413")]
    public int TotalHealingValue
    {
      [Token(Token = "0x600F3E9"), Address(RVA = "0x1FA628C", Offset = "0x1FA628C", VA = "0x1FA628C")] get
      {
        return new int();
      }
      [Token(Token = "0x600F3EA"), Address(RVA = "0x1FA6294", Offset = "0x1FA6294", VA = "0x1FA6294")] private set
      {
      }
    }

    [Token(Token = "0x17003414")]
    public bool HasAnyHealing
    {
      [Token(Token = "0x600F3EB"), Address(RVA = "0x1FA629C", Offset = "0x1FA629C", VA = "0x1FA629C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F3EC"), Address(RVA = "0x1FA62A4", Offset = "0x1FA62A4", VA = "0x1FA62A4")] private set
      {
      }
    }

    [Token(Token = "0x17003415")]
    public int TotalConsumeDurability
    {
      [Token(Token = "0x600F3ED"), Address(RVA = "0x1FA62B0", Offset = "0x1FA62B0", VA = "0x1FA62B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F3EE"), Address(RVA = "0x1FA62B8", Offset = "0x1FA62B8", VA = "0x1FA62B8")] private set
      {
      }
    }

    [Token(Token = "0x17003416")]
    public Dictionary<int, int> SkillStockCountDic
    {
      [Token(Token = "0x600F3EF"), Address(RVA = "0x1FA62C0", Offset = "0x1FA62C0", VA = "0x1FA62C0")] get
      {
        return (Dictionary<int, int>) null;
      }
      [Token(Token = "0x600F3F0"), Address(RVA = "0x1FA62C8", Offset = "0x1FA62C8", VA = "0x1FA62C8")] private set
      {
      }
    }

    [Token(Token = "0x17003417")]
    public int StockCountId
    {
      [Token(Token = "0x600F3F1"), Address(RVA = "0x1FA62D0", Offset = "0x1FA62D0", VA = "0x1FA62D0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F3F2"), Address(RVA = "0x1FA62D8", Offset = "0x1FA62D8", VA = "0x1FA62D8")] private set
      {
      }
    }

    [Token(Token = "0x17003418")]
    public int CurrentStockCounter
    {
      [Token(Token = "0x600F3F3"), Address(RVA = "0x1FA62E0", Offset = "0x1FA62E0", VA = "0x1FA62E0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F3F4"), Address(RVA = "0x1FA62E8", Offset = "0x1FA62E8", VA = "0x1FA62E8")] private set
      {
      }
    }

    [Token(Token = "0x17003419")]
    public int MaxStockCounter
    {
      [Token(Token = "0x600F3F5"), Address(RVA = "0x1FA62F0", Offset = "0x1FA62F0", VA = "0x1FA62F0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F3F6"), Address(RVA = "0x1FA62F8", Offset = "0x1FA62F8", VA = "0x1FA62F8")] private set
      {
      }
    }

    [Token(Token = "0x1700341A")]
    public int TotalConsumeLP
    {
      [Token(Token = "0x600F3F7"), Address(RVA = "0x1FA6300", Offset = "0x1FA6300", VA = "0x1FA6300")] get
      {
        return new int();
      }
      [Token(Token = "0x600F3F8"), Address(RVA = "0x1FA6308", Offset = "0x1FA6308", VA = "0x1FA6308")] private set
      {
      }
    }

    [Token(Token = "0x1700341B")]
    public bool IsActionRecovery
    {
      [Token(Token = "0x600F3F9"), Address(RVA = "0x1FA6310", Offset = "0x1FA6310", VA = "0x1FA6310")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F3FA"), Address(RVA = "0x1FA6318", Offset = "0x1FA6318", VA = "0x1FA6318")] private set
      {
      }
    }

    [Token(Token = "0x1700341C")]
    public bool IsMoveRecovery
    {
      [Token(Token = "0x600F3FB"), Address(RVA = "0x1FA6324", Offset = "0x1FA6324", VA = "0x1FA6324")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F3FC"), Address(RVA = "0x1FA632C", Offset = "0x1FA632C", VA = "0x1FA632C")] private set
      {
      }
    }

    [Token(Token = "0x1700341D")]
    public int RecoverMovePoint
    {
      [Token(Token = "0x600F3FD"), Address(RVA = "0x1FA6338", Offset = "0x1FA6338", VA = "0x1FA6338")] get
      {
        return new int();
      }
      [Token(Token = "0x600F3FE"), Address(RVA = "0x1FA6340", Offset = "0x1FA6340", VA = "0x1FA6340")] private set
      {
      }
    }

    [Token(Token = "0x1700341E")]
    public int MovePointChange
    {
      [Token(Token = "0x600F3FF"), Address(RVA = "0x1FA6348", Offset = "0x1FA6348", VA = "0x1FA6348")] get
      {
        return new int();
      }
      [Token(Token = "0x600F400"), Address(RVA = "0x1FA6350", Offset = "0x1FA6350", VA = "0x1FA6350")] private set
      {
      }
    }

    [Token(Token = "0x1700341F")]
    public List<EffectParameterData> AddedSkillEffectsByUnit
    {
      [Token(Token = "0x600F401"), Address(RVA = "0x1FA6358", Offset = "0x1FA6358", VA = "0x1FA6358")] get
      {
        return (List<EffectParameterData>) null;
      }
    }

    [Token(Token = "0x17003420")]
    public List<EffectParameterData> RemovedSkillEffectsFromUnit
    {
      [Token(Token = "0x600F402"), Address(RVA = "0x1FA6360", Offset = "0x1FA6360", VA = "0x1FA6360")] get
      {
        return (List<EffectParameterData>) null;
      }
    }

    [Token(Token = "0x17003421")]
    public List<EffectParameterData> UseItemEffects
    {
      [Token(Token = "0x600F403"), Address(RVA = "0x1FA6368", Offset = "0x1FA6368", VA = "0x1FA6368")] get
      {
        return (List<EffectParameterData>) null;
      }
      [Token(Token = "0x600F404"), Address(RVA = "0x1FA6370", Offset = "0x1FA6370", VA = "0x1FA6370")] private set
      {
      }
    }

    [Token(Token = "0x17003422")]
    public List<BattleBadStatusDetailData> BadStatuses
    {
      [Token(Token = "0x600F405"), Address(RVA = "0x1FA6378", Offset = "0x1FA6378", VA = "0x1FA6378")] get
      {
        return (List<BattleBadStatusDetailData>) null;
      }
      [Token(Token = "0x600F406"), Address(RVA = "0x1FA6380", Offset = "0x1FA6380", VA = "0x1FA6380")] private set
      {
      }
    }

    [Token(Token = "0x17003423")]
    public Dictionary<BattleBadStatusTypeEnum, int> TakeBadStatusDamageDic
    {
      [Token(Token = "0x600F407"), Address(RVA = "0x1FA6388", Offset = "0x1FA6388", VA = "0x1FA6388")] get
      {
        return (Dictionary<BattleBadStatusTypeEnum, int>) null;
      }
      [Token(Token = "0x600F408"), Address(RVA = "0x1FA6390", Offset = "0x1FA6390", VA = "0x1FA6390")] private set
      {
      }
    }

    [Token(Token = "0x17003424")]
    public BattleBadStatusData MostDisplayEffectPriorityBadStatus
    {
      [Token(Token = "0x600F409"), Address(RVA = "0x1FA6398", Offset = "0x1FA6398", VA = "0x1FA6398")] get
      {
        return (BattleBadStatusData) null;
      }
      [Token(Token = "0x600F40A"), Address(RVA = "0x1FA63A0", Offset = "0x1FA63A0", VA = "0x1FA63A0")] private set
      {
      }
    }

    [Token(Token = "0x17003425")]
    public bool IsForceDeath
    {
      [Token(Token = "0x600F40B"), Address(RVA = "0x1FA63A8", Offset = "0x1FA63A8", VA = "0x1FA63A8")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F40C"), Address(RVA = "0x1FA63B0", Offset = "0x1FA63B0", VA = "0x1FA63B0")] private set
      {
      }
    }

    [Token(Token = "0x17003426")]
    public bool IsModified
    {
      [Token(Token = "0x600F40D"), Address(RVA = "0x1FA63BC", Offset = "0x1FA63BC", VA = "0x1FA63BC")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F40E"), Address(RVA = "0x1FA63C4", Offset = "0x1FA63C4", VA = "0x1FA63C4")] private set
      {
      }
    }

    [Token(Token = "0x600F40F")]
    [Address(RVA = "0x1FA63D0", Offset = "0x1FA63D0", VA = "0x1FA63D0")]
    private UnitParameterChange()
    {
    }

    [Token(Token = "0x600F410")]
    [Address(RVA = "0x1FA5448", Offset = "0x1FA5448", VA = "0x1FA5448")]
    private UnitParameterChange(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600F411")]
    [Address(RVA = "0x1FA65B8", Offset = "0x1FA65B8", VA = "0x1FA65B8")]
    private UnitParameterChange(UnitParameterChange source)
    {
    }

    [Token(Token = "0x600F412")]
    [Address(RVA = "0x1FA69D0", Offset = "0x1FA69D0", VA = "0x1FA69D0")]
    public UnitParameterChange Clone() => (UnitParameterChange) null;

    [Token(Token = "0x600F413")]
    [Address(RVA = "0x1FA6A30", Offset = "0x1FA6A30", VA = "0x1FA6A30")]
    public void Apply(UnitParameterChange upc)
    {
    }

    [Token(Token = "0x600F414")]
    [Address(RVA = "0x1FA75F4", Offset = "0x1FA75F4", VA = "0x1FA75F4")]
    public void InstantDeath()
    {
    }

    [Token(Token = "0x600F415")]
    [Address(RVA = "0x1FA75E8", Offset = "0x1FA75E8", VA = "0x1FA75E8")]
    public void ForceDeath()
    {
    }

    [Token(Token = "0x600F416")]
    [Address(RVA = "0x1FA6F94", Offset = "0x1FA6F94", VA = "0x1FA6F94")]
    public void AddUnitDamage(int value)
    {
    }

    [Token(Token = "0x600F417")]
    [Address(RVA = "0x1FA76C8", Offset = "0x1FA76C8", VA = "0x1FA76C8")]
    public void TakeBadStatusDamage(BattleBadStatusTypeEnum badStatus, int damage)
    {
    }

    [Token(Token = "0x600F418")]
    [Address(RVA = "0x1FA70D4", Offset = "0x1FA70D4", VA = "0x1FA70D4")]
    public void AddBarrierDamageTo(int barrierIndex, int value)
    {
    }

    [Token(Token = "0x600F419")]
    [Address(RVA = "0x1FA71E0", Offset = "0x1FA71E0", VA = "0x1FA71E0")]
    public void AddBarrierReviveTo(int barrierIndex, int value)
    {
    }

    [Token(Token = "0x600F41A")]
    [Address(RVA = "0x1FA77D0", Offset = "0x1FA77D0", VA = "0x1FA77D0")]
    public void NormalHeal(int value)
    {
    }

    [Token(Token = "0x600F41B")]
    [Address(RVA = "0x1FA702C", Offset = "0x1FA702C", VA = "0x1FA702C")]
    public void AddHealing(int value)
    {
    }

    [Token(Token = "0x600F41C")]
    [Address(RVA = "0x1FA7324", Offset = "0x1FA7324", VA = "0x1FA7324")]
    public void AddConsumeDurability(int value)
    {
    }

    [Token(Token = "0x600F41D")]
    [Address(RVA = "0x1FA734C", Offset = "0x1FA734C", VA = "0x1FA734C")]
    public void AddConsumeLP(int value = 1)
    {
    }

    [Token(Token = "0x600F41E")]
    [Address(RVA = "0x1FA7470", Offset = "0x1FA7470", VA = "0x1FA7470")]
    public void AddMovePoint(int value)
    {
    }

    [Token(Token = "0x600F41F")]
    [Address(RVA = "0x1FA7374", Offset = "0x1FA7374", VA = "0x1FA7374")]
    public void AddSkillStock(int id, int value)
    {
    }

    [Token(Token = "0x600F420")]
    [Address(RVA = "0x1FA744C", Offset = "0x1FA744C", VA = "0x1FA744C")]
    public void RecoverAction()
    {
    }

    [Token(Token = "0x600F421")]
    [Address(RVA = "0x1FA745C", Offset = "0x1FA745C", VA = "0x1FA745C")]
    public void RecoverMove(int point)
    {
    }

    [Token(Token = "0x600F422")]
    [Address(RVA = "0x1FA748C", Offset = "0x1FA748C", VA = "0x1FA748C")]
    public void AddEffect(EffectParameterData effectParam)
    {
    }

    [Token(Token = "0x600F423")]
    [Address(RVA = "0x1FA77D8", Offset = "0x1FA77D8", VA = "0x1FA77D8")]
    private void AddAddedEffect(EffectParameterData effectParam)
    {
    }

    [Token(Token = "0x600F424")]
    [Address(RVA = "0x1FA5B40", Offset = "0x1FA5B40", VA = "0x1FA5B40")]
    public void RemoveSkillEffect(EffectParameterData skillEffectParam)
    {
    }

    [Token(Token = "0x600F425")]
    [Address(RVA = "0x1FA7884", Offset = "0x1FA7884", VA = "0x1FA7884")]
    private void AddBadStatus(BadStatusEffectData eff)
    {
    }

    [Token(Token = "0x600F426")]
    [Address(RVA = "0x1FA753C", Offset = "0x1FA753C", VA = "0x1FA753C")]
    public void SetUseItemEffect(EffectParameterData effectParam)
    {
    }

    [Token(Token = "0x600F427")]
    [Address(RVA = "0x1FA72E8", Offset = "0x1FA72E8", VA = "0x1FA72E8")]
    public void ChangePositionTo(int x, int y)
    {
    }

    [Token(Token = "0x600F428")]
    [Address(RVA = "0x1FA7994", Offset = "0x1FA7994", VA = "0x1FA7994")]
    public string ToJson() => (string) null;
  }
}
