// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.EffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002797")]
  public class EffectData
  {
    [Token(Token = "0x17003511")]
    public BattleIconTypeEnum BattleIconType
    {
      [Token(Token = "0x600F71B"), Address(RVA = "0x1ED90D0", Offset = "0x1ED90D0", VA = "0x1ED90D0")] get
      {
        return new BattleIconTypeEnum();
      }
    }

    [Token(Token = "0x17003512")]
    public int Id
    {
      [Token(Token = "0x600F71C"), Address(RVA = "0x1ED90E0", Offset = "0x1ED90E0", VA = "0x1ED90E0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F71D"), Address(RVA = "0x1ED90E8", Offset = "0x1ED90E8", VA = "0x1ED90E8")] private set
      {
      }
    }

    [Token(Token = "0x17003513")]
    public SkillTriggerTimingTypeEnum Trigger
    {
      [Token(Token = "0x600F71E"), Address(RVA = "0x1ED90F0", Offset = "0x1ED90F0", VA = "0x1ED90F0")] get
      {
        return new SkillTriggerTimingTypeEnum();
      }
      [Token(Token = "0x600F71F"), Address(RVA = "0x1ED90F8", Offset = "0x1ED90F8", VA = "0x1ED90F8")] private set
      {
      }
    }

    [Token(Token = "0x17003514")]
    public TargettableUnitTypeEnum Target
    {
      [Token(Token = "0x600F720"), Address(RVA = "0x1ED9100", Offset = "0x1ED9100", VA = "0x1ED9100")] get
      {
        return new TargettableUnitTypeEnum();
      }
      [Token(Token = "0x600F721"), Address(RVA = "0x1ED9108", Offset = "0x1ED9108", VA = "0x1ED9108")] private set
      {
      }
    }

    [Token(Token = "0x17003515")]
    public List<ConditionDetail> Conditions
    {
      [Token(Token = "0x600F722"), Address(RVA = "0x1ED9110", Offset = "0x1ED9110", VA = "0x1ED9110")] get
      {
        return (List<ConditionDetail>) null;
      }
      [Token(Token = "0x600F723"), Address(RVA = "0x1ED9118", Offset = "0x1ED9118", VA = "0x1ED9118")] private set
      {
      }
    }

    [Token(Token = "0x17003516")]
    public int Range
    {
      [Token(Token = "0x600F724"), Address(RVA = "0x1ED9120", Offset = "0x1ED9120", VA = "0x1ED9120")] get
      {
        return new int();
      }
      [Token(Token = "0x600F725"), Address(RVA = "0x1ED9128", Offset = "0x1ED9128", VA = "0x1ED9128")] private set
      {
      }
    }

    [Token(Token = "0x17003517")]
    public EffectiveLengthTypeEnum DurationType
    {
      [Token(Token = "0x600F726"), Address(RVA = "0x1ED9130", Offset = "0x1ED9130", VA = "0x1ED9130")] get
      {
        return new EffectiveLengthTypeEnum();
      }
      [Token(Token = "0x600F727"), Address(RVA = "0x1ED9138", Offset = "0x1ED9138", VA = "0x1ED9138")] protected set
      {
      }
    }

    [Token(Token = "0x17003518")]
    public int Duration
    {
      [Token(Token = "0x600F728"), Address(RVA = "0x1ED9140", Offset = "0x1ED9140", VA = "0x1ED9140")] get
      {
        return new int();
      }
      [Token(Token = "0x600F729"), Address(RVA = "0x1ED9148", Offset = "0x1ED9148", VA = "0x1ED9148")] private set
      {
      }
    }

    [Token(Token = "0x17003519")]
    public bool HitCheck
    {
      [Token(Token = "0x600F72A"), Address(RVA = "0x1ED9150", Offset = "0x1ED9150", VA = "0x1ED9150")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F72B"), Address(RVA = "0x1ED9158", Offset = "0x1ED9158", VA = "0x1ED9158")] private set
      {
      }
    }

    [Token(Token = "0x1700351A")]
    public bool DependedHit
    {
      [Token(Token = "0x600F72C"), Address(RVA = "0x1ED9164", Offset = "0x1ED9164", VA = "0x1ED9164")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F72D"), Address(RVA = "0x1ED916C", Offset = "0x1ED916C", VA = "0x1ED916C")] private set
      {
      }
    }

    [Token(Token = "0x1700351B")]
    public int EffectGroup
    {
      [Token(Token = "0x600F72E"), Address(RVA = "0x1ED9178", Offset = "0x1ED9178", VA = "0x1ED9178")] get
      {
        return new int();
      }
      [Token(Token = "0x600F72F"), Address(RVA = "0x1ED9180", Offset = "0x1ED9180", VA = "0x1ED9180")] private set
      {
      }
    }

    [Token(Token = "0x1700351C")]
    public BattleEffectTypeEnum EffectType
    {
      [Token(Token = "0x600F730"), Address(RVA = "0x1ED9188", Offset = "0x1ED9188", VA = "0x1ED9188")] get
      {
        return new BattleEffectTypeEnum();
      }
      [Token(Token = "0x600F731"), Address(RVA = "0x1ED9190", Offset = "0x1ED9190", VA = "0x1ED9190")] private set
      {
      }
    }

    [Token(Token = "0x1700351D")]
    public ConditionTargetTypeEnum EffectiveBase
    {
      [Token(Token = "0x600F732"), Address(RVA = "0x1ED9198", Offset = "0x1ED9198", VA = "0x1ED9198")] get
      {
        return new ConditionTargetTypeEnum();
      }
      [Token(Token = "0x600F733"), Address(RVA = "0x1ED91A0", Offset = "0x1ED91A0", VA = "0x1ED91A0")] private set
      {
      }
    }

    [Token(Token = "0x1700351E")]
    public IBasicRangeData EffectiveRange
    {
      [Token(Token = "0x600F734"), Address(RVA = "0x1ED91A8", Offset = "0x1ED91A8", VA = "0x1ED91A8")] get
      {
        return (IBasicRangeData) null;
      }
      [Token(Token = "0x600F735"), Address(RVA = "0x1ED91B0", Offset = "0x1ED91B0", VA = "0x1ED91B0")] private set
      {
      }
    }

    [Token(Token = "0x1700351F")]
    public List<int> Contexts
    {
      [Token(Token = "0x600F736"), Address(RVA = "0x1ED91B8", Offset = "0x1ED91B8", VA = "0x1ED91B8")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x600F737"), Address(RVA = "0x1ED91C0", Offset = "0x1ED91C0", VA = "0x1ED91C0")] private set
      {
      }
    }

    [Token(Token = "0x17003520")]
    protected string DisplayNameTemplate
    {
      [Token(Token = "0x600F738"), Address(RVA = "0x1ED91C8", Offset = "0x1ED91C8", VA = "0x1ED91C8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F739"), Address(RVA = "0x1ED91D0", Offset = "0x1ED91D0", VA = "0x1ED91D0")] set
      {
      }
    }

    [Token(Token = "0x17003521")]
    public virtual string DisplayName
    {
      [Token(Token = "0x600F73A"), Address(RVA = "0x1ED91D8", Offset = "0x1ED91D8", VA = "0x1ED91D8", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17003522")]
    public string Description
    {
      [Token(Token = "0x600F73B"), Address(RVA = "0x1ED91E0", Offset = "0x1ED91E0", VA = "0x1ED91E0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F73C"), Address(RVA = "0x1ED91E8", Offset = "0x1ED91E8", VA = "0x1ED91E8")] private set
      {
      }
    }

    [Token(Token = "0x17003523")]
    public EffectKey Key
    {
      [Token(Token = "0x600F73D"), Address(RVA = "0x1ED91F0", Offset = "0x1ED91F0", VA = "0x1ED91F0")] get
      {
        return new EffectKey();
      }
      [Token(Token = "0x600F73E"), Address(RVA = "0x1ED91FC", Offset = "0x1ED91FC", VA = "0x1ED91FC")] protected set
      {
      }
    }

    [Token(Token = "0x17003524")]
    public int MaxPutOperationCount
    {
      [Token(Token = "0x600F73F"), Address(RVA = "0x1ED9204", Offset = "0x1ED9204", VA = "0x1ED9204")] get
      {
        return new int();
      }
      [Token(Token = "0x600F740"), Address(RVA = "0x1ED920C", Offset = "0x1ED920C", VA = "0x1ED920C")] protected set
      {
      }
    }

    [Token(Token = "0x17003525")]
    public BuffDebuffTypeEnum BuffDebuffType
    {
      [Token(Token = "0x600F741"), Address(RVA = "0x1ED9214", Offset = "0x1ED9214", VA = "0x1ED9214")] get
      {
        return new BuffDebuffTypeEnum();
      }
      [Token(Token = "0x600F742"), Address(RVA = "0x1ED921C", Offset = "0x1ED921C", VA = "0x1ED921C")] protected set
      {
      }
    }

    [Token(Token = "0x17003526")]
    public bool IsBuffEffect
    {
      [Token(Token = "0x600F743"), Address(RVA = "0x1ED9224", Offset = "0x1ED9224", VA = "0x1ED9224")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003527")]
    public bool IsDebuffEffect
    {
      [Token(Token = "0x600F744"), Address(RVA = "0x1ED9234", Offset = "0x1ED9234", VA = "0x1ED9234")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600F745")]
    [Address(RVA = "0x1ED9244", Offset = "0x1ED9244", VA = "0x1ED9244")]
    public static EffectData Create(EffectSource source) => (EffectData) null;

    [Token(Token = "0x600F746")]
    [Address(RVA = "0x1ED61B4", Offset = "0x1ED61B4", VA = "0x1ED61B4")]
    protected EffectData(EffectSource source)
    {
    }

    [Token(Token = "0x600F747")]
    [Address(RVA = "0x1ED92E0", Offset = "0x1ED92E0", VA = "0x1ED92E0")]
    public bool MatchTo(
      BoardData board,
      ITargettable from,
      WeaponParameterData fromWeaponParam,
      ITargettable to,
      WeaponParameterData toWeaponParam,
      ITargettable ex = null,
      WeaponParameterData exWeaponParam = null,
      ActionResult actionResult = null)
    {
      return new bool();
    }

    [Token(Token = "0x600F748")]
    [Address(RVA = "0x1ED9484", Offset = "0x1ED9484", VA = "0x1ED9484")]
    public bool MatchTo(BoardData board, BattlePlayerData from, UnitParameterData to) => new bool();

    [Token(Token = "0x600F749")]
    [Address(RVA = "0x1ED939C", Offset = "0x1ED939C", VA = "0x1ED939C")]
    public bool MatchTo(ConditionParamUnit conditionParam) => new bool();

    [Token(Token = "0x600F74A")]
    [Address(RVA = "0x1ED9508", Offset = "0x1ED9508", VA = "0x1ED9508", Slot = "5")]
    public virtual bool IsEffectable(UnitParameterData from, UnitParameterData to) => new bool();

    [Token(Token = "0x600F74B")]
    [Address(RVA = "0x1ED9510", Offset = "0x1ED9510", VA = "0x1ED9510", Slot = "6")]
    public virtual bool CanTriggerEffect(UnitParameterData target) => new bool();

    [Token(Token = "0x600F74C")]
    [Address(RVA = "0x1ED9518", Offset = "0x1ED9518", VA = "0x1ED9518", Slot = "7")]
    protected virtual void CreateKey()
    {
    }

    [Token(Token = "0x600F74D")]
    [Address(RVA = "0x1ED95A8", Offset = "0x1ED95A8", VA = "0x1ED95A8")]
    public BattleBuffTagEnum? GetBattleBuffTag() => new BattleBuffTagEnum?();

    [Token(Token = "0x600F74E")]
    [Address(RVA = "0x1ED996C", Offset = "0x1ED996C", VA = "0x1ED996C", Slot = "3")]
    public override string ToString() => (string) null;
  }
}
