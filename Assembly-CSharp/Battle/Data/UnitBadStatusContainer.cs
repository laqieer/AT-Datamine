// Decompiled with JetBrains decompiler
// Type: Battle.Data.UnitBadStatusContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002736")]
  public sealed class UnitBadStatusContainer : IEffectParameterContainer
  {
    [Token(Token = "0x400A7A6")]
    [FieldOffset(Offset = "0x0")]
    private static IComparer<BattleBadStatusData> IconPriorityComparison;
    [Token(Token = "0x400A7A7")]
    [FieldOffset(Offset = "0x8")]
    private static IComparer<BattleBadStatusData> EffectPriorityComparison;
    [Token(Token = "0x400A7A8")]
    [FieldOffset(Offset = "0x10")]
    private SortedSet<BattleBadStatusData> iconOrderedConditions;
    [Token(Token = "0x400A7A9")]
    [FieldOffset(Offset = "0x18")]
    private SortedSet<BattleBadStatusData> effectOrderedConditions;
    [Token(Token = "0x400A7AA")]
    [FieldOffset(Offset = "0x20")]
    private EffectParameterContainer container;
    [Token(Token = "0x400A7AB")]
    [FieldOffset(Offset = "0x28")]
    private Dictionary<BattleBadStatusData, UnitBadStatusContainer.EffectedBadStatus> effectedBadStatusDic;
    [Token(Token = "0x400A7AD")]
    [FieldOffset(Offset = "0x38")]
    private Dictionary<int, EffectParameterContainer> effectedNullBadstatusDic;

    [Token(Token = "0x17003431")]
    public System.Collections.Generic.List<BattleBadStatusData> IconOrderedConditions
    {
      [Token(Token = "0x600F43F"), Address(RVA = "0x1FA87AC", Offset = "0x1FA87AC", VA = "0x1FA87AC")] get
      {
        return (System.Collections.Generic.List<BattleBadStatusData>) null;
      }
    }

    [Token(Token = "0x17003432")]
    public System.Collections.Generic.List<BattleBadStatusData> EffectOrderedConditions
    {
      [Token(Token = "0x600F440"), Address(RVA = "0x1FA8828", Offset = "0x1FA8828", VA = "0x1FA8828")] get
      {
        return (System.Collections.Generic.List<BattleBadStatusData>) null;
      }
    }

    [Token(Token = "0x17003433")]
    public System.Collections.Generic.List<EffectParameterData> List
    {
      [Token(Token = "0x600F441"), Address(RVA = "0x1FA88A4", Offset = "0x1FA88A4", VA = "0x1FA88A4", Slot = "4")] get
      {
        return (System.Collections.Generic.List<EffectParameterData>) null;
      }
    }

    [Token(Token = "0x17003434")]
    public int Count
    {
      [Token(Token = "0x600F442"), Address(RVA = "0x1FA88BC", Offset = "0x1FA88BC", VA = "0x1FA88BC", Slot = "5")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003435")]
    public bool Any
    {
      [Token(Token = "0x600F443"), Address(RVA = "0x1FA890C", Offset = "0x1FA890C", VA = "0x1FA890C", Slot = "6")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003436")]
    public BattleBadStatusData PrimaryDisableControlBadStatus
    {
      [Token(Token = "0x600F444"), Address(RVA = "0x1FA8924", Offset = "0x1FA8924", VA = "0x1FA8924")] get
      {
        return (BattleBadStatusData) null;
      }
      [Token(Token = "0x600F445"), Address(RVA = "0x1FA892C", Offset = "0x1FA892C", VA = "0x1FA892C")] private set
      {
      }
    }

    [Token(Token = "0x600F446")]
    [Address(RVA = "0x1FA8934", Offset = "0x1FA8934", VA = "0x1FA8934")]
    public bool Has(BattleBadStatusTypeEnum type) => new bool();

    [Token(Token = "0x600F447")]
    [Address(RVA = "0x1FA8A2C", Offset = "0x1FA8A2C", VA = "0x1FA8A2C")]
    public bool IsUnusableActiveSkillCategory(SkillCategoryTypeEnum type) => new bool();

    [Token(Token = "0x600F448")]
    [Address(RVA = "0x1FA8A34", Offset = "0x1FA8A34", VA = "0x1FA8A34")]
    public bool IsUnusableActiveSkillTag(SkillTagTypeEnum tag) => new bool();

    [Token(Token = "0x600F449")]
    [Address(RVA = "0x1FA8A3C", Offset = "0x1FA8A3C", VA = "0x1FA8A3C")]
    public bool IsResponsible(EffectParameterData effectParam) => new bool();

    [Token(Token = "0x600F44A")]
    [Address(RVA = "0x1FA8AC0", Offset = "0x1FA8AC0", VA = "0x1FA8AC0", Slot = "7")]
    public void Add(EffectParameterData param)
    {
    }

    [Token(Token = "0x600F44B")]
    [Address(RVA = "0x1FA8C78", Offset = "0x1FA8C78", VA = "0x1FA8C78", Slot = "8")]
    public void AddRange(IEnumerable<EffectParameterData> list)
    {
    }

    [Token(Token = "0x600F44C")]
    [Address(RVA = "0x1FA8B58", Offset = "0x1FA8B58", VA = "0x1FA8B58")]
    private void AddBadStatus(EffectParameterData effectParam, BadStatusEffectData badStatusEffect)
    {
    }

    [Token(Token = "0x600F44D")]
    [Address(RVA = "0x1FA9160", Offset = "0x1FA9160", VA = "0x1FA9160", Slot = "10")]
    public System.Collections.Generic.List<EffectParameterData> RemoveExpiredEffects()
    {
      return (System.Collections.Generic.List<EffectParameterData>) null;
    }

    [Token(Token = "0x600F44E")]
    [Address(RVA = "0x1FA92BC", Offset = "0x1FA92BC", VA = "0x1FA92BC", Slot = "9")]
    public void Remove(EffectParameterData effectParam)
    {
    }

    [Token(Token = "0x600F44F")]
    [Address(RVA = "0x1FA9354", Offset = "0x1FA9354", VA = "0x1FA9354")]
    private void RemoveBadStatus(
      BadStatusEffectData badStatusEffect,
      EffectParameterData effectParam)
    {
    }

    [Token(Token = "0x600F450")]
    [Address(RVA = "0x1FA94AC", Offset = "0x1FA94AC", VA = "0x1FA94AC")]
    public bool IsNullBadStatus(BattleBadStatusTypeEnum type) => new bool();

    [Token(Token = "0x600F451")]
    [Address(RVA = "0x1FA9538", Offset = "0x1FA9538", VA = "0x1FA9538")]
    public EffectParameterData GetBadStatusEffectiveMain(BattleBadStatusTypeEnum type)
    {
      return (EffectParameterData) null;
    }

    [Token(Token = "0x600F452")]
    [Address(RVA = "0x1FA9570", Offset = "0x1FA9570", VA = "0x1FA9570")]
    public UnitBadStatusContainer.EffectedBadStatus GetBadStatusEffects(BattleBadStatusTypeEnum type)
    {
      return (UnitBadStatusContainer.EffectedBadStatus) null;
    }

    [Token(Token = "0x600F453")]
    [Address(RVA = "0x1FA9660", Offset = "0x1FA9660", VA = "0x1FA9660")]
    public IEffectValue GetBadStatusEffectValue(BattleBadStatusTypeEnum type)
    {
      return (IEffectValue) null;
    }

    [Token(Token = "0x600F454")]
    [Address(RVA = "0x1FA9774", Offset = "0x1FA9774", VA = "0x1FA9774")]
    public int GetEnhanceValue(
      BattleBadStatusTypeEnum type,
      BattleEffectValueTypeEnum effectValueType)
    {
      return new int();
    }

    [Token(Token = "0x600F455")]
    [Address(RVA = "0x1FA977C", Offset = "0x1FA977C", VA = "0x1FA977C")]
    public int GetResistValue(
      BattleBadStatusTypeEnum type,
      BattleEffectValueTypeEnum effectValueType)
    {
      return new int();
    }

    [Token(Token = "0x600F456")]
    [Address(RVA = "0x1FA9784", Offset = "0x1FA9784", VA = "0x1FA9784", Slot = "11")]
    public void Clear()
    {
    }

    [Token(Token = "0x600F457")]
    [Address(RVA = "0x1FA981C", Offset = "0x1FA981C", VA = "0x1FA981C", Slot = "12")]
    public System.Collections.Generic.List<EffectParameterData> GetDeactivateTriggeredEffects(
      EffectiveLengthTypeEnum length)
    {
      return (System.Collections.Generic.List<EffectParameterData>) null;
    }

    [Token(Token = "0x600F458")]
    [Address(RVA = "0x1FA9A4C", Offset = "0x1FA9A4C", VA = "0x1FA9A4C")]
    public void Elapse(int turnNumber, int phaseIndex)
    {
    }

    [Token(Token = "0x600F459")]
    [Address(RVA = "0x1FA9BA8", Offset = "0x1FA9BA8", VA = "0x1FA9BA8")]
    public IRestrictedInfo GetRestrictedInfo() => (IRestrictedInfo) null;

    [Token(Token = "0x600F45A")]
    [Address(RVA = "0x1FA9F20", Offset = "0x1FA9F20", VA = "0x1FA9F20")]
    public UnitBadStatusContainer()
    {
    }

    [Token(Token = "0x600F45B")]
    [Address(RVA = "0x1FAA0C0", Offset = "0x1FAA0C0", VA = "0x1FAA0C0")]
    static UnitBadStatusContainer()
    {
    }

    [Token(Token = "0x2002737")]
    public class EffectedBadStatus : IEffectParameterContainer
    {
      [Token(Token = "0x400A7AE")]
      [FieldOffset(Offset = "0x10")]
      private System.Collections.Generic.List<EffectParameterData> list;
      [Token(Token = "0x400A7AF")]
      [FieldOffset(Offset = "0x18")]
      private UnitBadStatusContainer.EffectiveRule effectiveRule;

      [Token(Token = "0x17003437")]
      public System.Collections.Generic.List<EffectParameterData> List
      {
        [Token(Token = "0x600F45C"), Address(RVA = "0x1FAA170", Offset = "0x1FAA170", VA = "0x1FAA170", Slot = "4")] get
        {
          return (System.Collections.Generic.List<EffectParameterData>) null;
        }
      }

      [Token(Token = "0x17003438")]
      public EffectParameterData GetEffectiveMain
      {
        [Token(Token = "0x600F45D"), Address(RVA = "0x1FA9640", Offset = "0x1FA9640", VA = "0x1FA9640")] get
        {
          return (EffectParameterData) null;
        }
      }

      [Token(Token = "0x17003439")]
      public IEffectValue EffectValue
      {
        [Token(Token = "0x600F45E"), Address(RVA = "0x1FA9754", Offset = "0x1FA9754", VA = "0x1FA9754")] get
        {
          return (IEffectValue) null;
        }
      }

      [Token(Token = "0x600F45F")]
      [Address(RVA = "0x1FA8F64", Offset = "0x1FA8F64", VA = "0x1FA8F64")]
      public EffectedBadStatus(BadStatusEffectData badStatusEffect)
      {
      }

      [Token(Token = "0x1700343A")]
      public int Count
      {
        [Token(Token = "0x600F460"), Address(RVA = "0x1FAA214", Offset = "0x1FAA214", VA = "0x1FAA214", Slot = "5")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x1700343B")]
      public bool Any
      {
        [Token(Token = "0x600F461"), Address(RVA = "0x1FA8A14", Offset = "0x1FA8A14", VA = "0x1FA8A14", Slot = "6")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x600F462")]
      [Address(RVA = "0x1FA90B8", Offset = "0x1FA90B8", VA = "0x1FA90B8", Slot = "7")]
      public void Add(EffectParameterData effectParam)
      {
      }

      [Token(Token = "0x600F463")]
      [Address(RVA = "0x1FAA260", Offset = "0x1FAA260", VA = "0x1FAA260", Slot = "8")]
      public void AddRange(IEnumerable<EffectParameterData> list)
      {
      }

      [Token(Token = "0x600F464")]
      [Address(RVA = "0x1FAA538", Offset = "0x1FAA538", VA = "0x1FAA538")]
      public void Elapse(int turnNumber, int phaseIndex)
      {
      }

      [Token(Token = "0x600F465")]
      [Address(RVA = "0x1FA9454", Offset = "0x1FA9454", VA = "0x1FA9454", Slot = "9")]
      public void Remove(EffectParameterData effectParam)
      {
      }

      [Token(Token = "0x600F466")]
      [Address(RVA = "0x1FAA68C", Offset = "0x1FAA68C", VA = "0x1FAA68C", Slot = "10")]
      public System.Collections.Generic.List<EffectParameterData> RemoveExpiredEffects()
      {
        return (System.Collections.Generic.List<EffectParameterData>) null;
      }

      [Token(Token = "0x600F467")]
      [Address(RVA = "0x1FAA818", Offset = "0x1FAA818", VA = "0x1FAA818", Slot = "11")]
      public void Clear()
      {
      }

      [Token(Token = "0x600F468")]
      [Address(RVA = "0x1FAA888", Offset = "0x1FAA888", VA = "0x1FAA888", Slot = "12")]
      public System.Collections.Generic.List<EffectParameterData> GetDeactivateTriggeredEffects(
        EffectiveLengthTypeEnum length)
      {
        return (System.Collections.Generic.List<EffectParameterData>) null;
      }

      [Token(Token = "0x600F469")]
      [Address(RVA = "0x1FAAAB0", Offset = "0x1FAAAB0", VA = "0x1FAAAB0")]
      public bool IsMainEffect(EffectParameterData effectParam) => new bool();
    }

    [Token(Token = "0x2002738")]
    public abstract class EffectiveRule
    {
      [Token(Token = "0x600F46A")]
      public abstract EffectParameterData GetMainEffect(System.Collections.Generic.List<EffectParameterData> list);

      [Token(Token = "0x600F46B")]
      [Address(RVA = "0x1FAAAD8", Offset = "0x1FAAAD8", VA = "0x1FAAAD8", Slot = "5")]
      public virtual bool IsMainEffect(
        EffectParameterData effectParam,
        System.Collections.Generic.List<EffectParameterData> list)
      {
        return new bool();
      }

      [Token(Token = "0x600F46C")]
      [Address(RVA = "0x1FAAB04", Offset = "0x1FAAB04", VA = "0x1FAAB04", Slot = "6")]
      public virtual IEffectValue GetEffectValue(System.Collections.Generic.List<EffectParameterData> list)
      {
        return (IEffectValue) null;
      }

      [Token(Token = "0x600F46D")]
      [Address(RVA = "0x1FAABA0", Offset = "0x1FAABA0", VA = "0x1FAABA0")]
      protected EffectParameterData GetMaxTurnInfo(IReadOnlyList<EffectParameterData> list)
      {
        return (EffectParameterData) null;
      }

      [Token(Token = "0x600F46E")]
      [Address(RVA = "0x1FAAF00", Offset = "0x1FAAF00", VA = "0x1FAAF00")]
      protected EffectParameterData GetMinTurnInfo(IReadOnlyList<EffectParameterData> list)
      {
        return (EffectParameterData) null;
      }

      [Token(Token = "0x600F46F")]
      [Address(RVA = "0x1FAB264", Offset = "0x1FAB264", VA = "0x1FAB264")]
      protected EffectParameterData GetMaxValueInfo(IReadOnlyList<EffectParameterData> list)
      {
        return (EffectParameterData) null;
      }

      [Token(Token = "0x600F470")]
      [Address(RVA = "0x1FAB634", Offset = "0x1FAB634", VA = "0x1FAB634")]
      protected EffectParameterData GetLastIndexInfo(IReadOnlyList<EffectParameterData> list)
      {
        return (EffectParameterData) null;
      }

      [Token(Token = "0x600F471")]
      [Address(RVA = "0x1FAB7B4", Offset = "0x1FAB7B4", VA = "0x1FAB7B4")]
      protected EffectiveRule()
      {
      }
    }

    [Token(Token = "0x2002739")]
    public class Later : UnitBadStatusContainer.EffectiveRule
    {
      [Token(Token = "0x600F472")]
      [Address(RVA = "0x1FAB7BC", Offset = "0x1FAB7BC", VA = "0x1FAB7BC", Slot = "4")]
      public override EffectParameterData GetMainEffect(System.Collections.Generic.List<EffectParameterData> list)
      {
        return (EffectParameterData) null;
      }

      [Token(Token = "0x600F473")]
      [Address(RVA = "0x1FAA20C", Offset = "0x1FAA20C", VA = "0x1FAA20C")]
      public Later()
      {
      }
    }

    [Token(Token = "0x200273A")]
    public class MaxValue : UnitBadStatusContainer.EffectiveRule
    {
      [Token(Token = "0x600F474")]
      [Address(RVA = "0x1FAB7C0", Offset = "0x1FAB7C0", VA = "0x1FAB7C0", Slot = "4")]
      public override EffectParameterData GetMainEffect(System.Collections.Generic.List<EffectParameterData> list)
      {
        return (EffectParameterData) null;
      }

      [Token(Token = "0x600F475")]
      [Address(RVA = "0x1FAA1EC", Offset = "0x1FAA1EC", VA = "0x1FAA1EC")]
      public MaxValue()
      {
      }
    }

    [Token(Token = "0x200273B")]
    public class MaxTurn : UnitBadStatusContainer.EffectiveRule
    {
      [Token(Token = "0x600F476")]
      [Address(RVA = "0x1FAB7C4", Offset = "0x1FAB7C4", VA = "0x1FAB7C4", Slot = "4")]
      public override EffectParameterData GetMainEffect(System.Collections.Generic.List<EffectParameterData> list)
      {
        return (EffectParameterData) null;
      }

      [Token(Token = "0x600F477")]
      [Address(RVA = "0x1FAA1F4", Offset = "0x1FAA1F4", VA = "0x1FAA1F4")]
      public MaxTurn()
      {
      }
    }

    [Token(Token = "0x200273C")]
    public class MinTurn : UnitBadStatusContainer.EffectiveRule
    {
      [Token(Token = "0x600F478")]
      [Address(RVA = "0x1FAB7C8", Offset = "0x1FAB7C8", VA = "0x1FAB7C8", Slot = "4")]
      public override EffectParameterData GetMainEffect(System.Collections.Generic.List<EffectParameterData> list)
      {
        return (EffectParameterData) null;
      }

      [Token(Token = "0x600F479")]
      [Address(RVA = "0x1FAA1FC", Offset = "0x1FAA1FC", VA = "0x1FAA1FC")]
      public MinTurn()
      {
      }
    }

    [Token(Token = "0x200273D")]
    public class Duplicate : UnitBadStatusContainer.EffectiveRule
    {
      [Token(Token = "0x600F47A")]
      [Address(RVA = "0x1FAB7CC", Offset = "0x1FAB7CC", VA = "0x1FAB7CC", Slot = "4")]
      public override EffectParameterData GetMainEffect(System.Collections.Generic.List<EffectParameterData> list)
      {
        return (EffectParameterData) null;
      }

      [Token(Token = "0x600F47B")]
      [Address(RVA = "0x1FAB7D0", Offset = "0x1FAB7D0", VA = "0x1FAB7D0", Slot = "5")]
      public override bool IsMainEffect(
        EffectParameterData effectParam,
        System.Collections.Generic.List<EffectParameterData> list)
      {
        return new bool();
      }

      [Token(Token = "0x600F47C")]
      [Address(RVA = "0x1FAB92C", Offset = "0x1FAB92C", VA = "0x1FAB92C", Slot = "6")]
      public override IEffectValue GetEffectValue(System.Collections.Generic.List<EffectParameterData> list)
      {
        return (IEffectValue) null;
      }

      [Token(Token = "0x600F47D")]
      [Address(RVA = "0x1FAA204", Offset = "0x1FAA204", VA = "0x1FAA204")]
      public Duplicate()
      {
      }
    }
  }
}
