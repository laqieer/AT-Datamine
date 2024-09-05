// Decompiled with JetBrains decompiler
// Type: Battle.Data.UnitEffectContainer
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
  [Token(Token = "0x200273E")]
  public sealed class UnitEffectContainer : IEffectParameterContainer
  {
    [Token(Token = "0x400A7B0")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<EffectKey, EffectParameterContainer> duplicatedDic;
    [Token(Token = "0x400A7B1")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<EffectKey, EffectParameterContainer> partySkillDuplicatedDic;
    [Token(Token = "0x400A7B2")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<EffectKey, EffectParameterContainer> useItemDuplicatedDic;
    [Token(Token = "0x400A7B4")]
    [FieldOffset(Offset = "0x30")]
    private EffectParameterContainer landEffect;

    [Token(Token = "0x1700343C")]
    public System.Collections.Generic.List<EffectParameterData> DuplicatedEffectParameters
    {
      [Token(Token = "0x600F47E"), Address(RVA = "0x1FABB54", Offset = "0x1FABB54", VA = "0x1FABB54")] get
      {
        return (System.Collections.Generic.List<EffectParameterData>) null;
      }
    }

    [Token(Token = "0x1700343D")]
    public System.Collections.Generic.List<EffectParameterData> PartySkillEffectParameters
    {
      [Token(Token = "0x600F47F"), Address(RVA = "0x1FABD1C", Offset = "0x1FABD1C", VA = "0x1FABD1C")] get
      {
        return (System.Collections.Generic.List<EffectParameterData>) null;
      }
    }

    [Token(Token = "0x1700343E")]
    public System.Collections.Generic.List<EffectParameterData> UseItemEffectParameters
    {
      [Token(Token = "0x600F480"), Address(RVA = "0x1FABEE4", Offset = "0x1FABEE4", VA = "0x1FABEE4")] get
      {
        return (System.Collections.Generic.List<EffectParameterData>) null;
      }
    }

    [Token(Token = "0x1700343F")]
    public UnitBadStatusContainer BadStatus
    {
      [Token(Token = "0x600F481"), Address(RVA = "0x1FAC0AC", Offset = "0x1FAC0AC", VA = "0x1FAC0AC")] get
      {
        return (UnitBadStatusContainer) null;
      }
      [Token(Token = "0x600F482"), Address(RVA = "0x1FAC0B4", Offset = "0x1FAC0B4", VA = "0x1FAC0B4")] private set
      {
      }
    }

    [Token(Token = "0x17003440")]
    public System.Collections.Generic.List<EffectParameterData> List
    {
      [Token(Token = "0x600F483"), Address(RVA = "0x1FAC0BC", Offset = "0x1FAC0BC", VA = "0x1FAC0BC", Slot = "4")] get
      {
        return (System.Collections.Generic.List<EffectParameterData>) null;
      }
    }

    [Token(Token = "0x17003441")]
    public System.Collections.Generic.List<EffectParameterData> ExceptForLand
    {
      [Token(Token = "0x600F484"), Address(RVA = "0x1FAC178", Offset = "0x1FAC178", VA = "0x1FAC178")] get
      {
        return (System.Collections.Generic.List<EffectParameterData>) null;
      }
    }

    [Token(Token = "0x17003442")]
    public int Count
    {
      [Token(Token = "0x600F485"), Address(RVA = "0x1FAC26C", Offset = "0x1FAC26C", VA = "0x1FAC26C", Slot = "5")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003443")]
    public bool Any
    {
      [Token(Token = "0x600F486"), Address(RVA = "0x1FAC2B8", Offset = "0x1FAC2B8", VA = "0x1FAC2B8", Slot = "6")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600F487")]
    [Address(RVA = "0x1FAC2D0", Offset = "0x1FAC2D0", VA = "0x1FAC2D0", Slot = "8")]
    public void AddRange(IEnumerable<EffectParameterData> effects)
    {
    }

    [Token(Token = "0x600F488")]
    [Address(RVA = "0x1FAC5A8", Offset = "0x1FAC5A8", VA = "0x1FAC5A8", Slot = "7")]
    public void Add(EffectParameterData effectParam)
    {
    }

    [Token(Token = "0x600F489")]
    [Address(RVA = "0x1FAC718", Offset = "0x1FAC718", VA = "0x1FAC718")]
    public void ResetLandEffect()
    {
    }

    [Token(Token = "0x600F48A")]
    [Address(RVA = "0x1FAC730", Offset = "0x1FAC730", VA = "0x1FAC730")]
    public void AddLandEffect(System.Collections.Generic.List<EffectParameterData> effects)
    {
    }

    [Token(Token = "0x600F48B")]
    [Address(RVA = "0x1FAC748", Offset = "0x1FAC748", VA = "0x1FAC748")]
    public void AddUseItemEffect(System.Collections.Generic.List<EffectParameterData> effects)
    {
    }

    [Token(Token = "0x600F48C")]
    [Address(RVA = "0x1FAC998", Offset = "0x1FAC998", VA = "0x1FAC998", Slot = "9")]
    public void Remove(EffectParameterData effectParam)
    {
    }

    [Token(Token = "0x600F48D")]
    [Address(RVA = "0x1FACABC", Offset = "0x1FACABC", VA = "0x1FACABC", Slot = "10")]
    public System.Collections.Generic.List<EffectParameterData> RemoveExpiredEffects()
    {
      return (System.Collections.Generic.List<EffectParameterData>) null;
    }

    [Token(Token = "0x600F48E")]
    [Address(RVA = "0x1FACCF0", Offset = "0x1FACCF0", VA = "0x1FACCF0", Slot = "11")]
    public void Clear()
    {
    }

    [Token(Token = "0x600F48F")]
    [Address(RVA = "0x1FACD6C", Offset = "0x1FACD6C", VA = "0x1FACD6C")]
    public IEffectParameterContainer GetEffectParameterContainer(EffectData effect)
    {
      return (IEffectParameterContainer) null;
    }

    [Token(Token = "0x600F490")]
    [Address(RVA = "0x1FACF94", Offset = "0x1FACF94", VA = "0x1FACF94")]
    public IEffectParameterContainer GetEffectParameterContainer(EffectKey key)
    {
      return (IEffectParameterContainer) null;
    }

    [Token(Token = "0x600F491")]
    [Address(RVA = "0x1FAD1F8", Offset = "0x1FAD1F8", VA = "0x1FAD1F8")]
    public System.Collections.Generic.List<System.Collections.Generic.List<EffectParameterData>> GetEffectParametersExceptForLand(
      EffectKey key)
    {
      return (System.Collections.Generic.List<System.Collections.Generic.List<EffectParameterData>>) null;
    }

    [Token(Token = "0x600F492")]
    private System.Collections.Generic.List<(TEffect, EffectParameterData)> GetEffectTuples<TEffect>() where TEffect : EffectData
    {
      return (System.Collections.Generic.List<(TEffect, EffectParameterData)>) null;
    }

    [Token(Token = "0x600F493")]
    [Address(RVA = "0x1FAD58C", Offset = "0x1FAD58C", VA = "0x1FAD58C")]
    public Dictionary<int, int> GetModifierEffectValue(EffectKey key)
    {
      return (Dictionary<int, int>) null;
    }

    [Token(Token = "0x600F494")]
    [Address(RVA = "0x1FAD8C4", Offset = "0x1FAD8C4", VA = "0x1FAD8C4")]
    private void SetBuffDebuffEffectValue(
      System.Collections.Generic.List<EffectParameterData> effectParameters,
      Dictionary<int, int> setDic)
    {
    }

    [Token(Token = "0x600F495")]
    private Dictionary<int, int> GetBuffDebuffEffectValueInternal<TEffect>(
      System.Collections.Generic.List<EffectParameterData> effectParameters,
      BattleEffectValueTypeEnum baseValueType)
      where TEffect : ModifierEffectData
    {
      return (Dictionary<int, int>) null;
    }

    [Token(Token = "0x600F496")]
    [Address(RVA = "0x1FADEF8", Offset = "0x1FADEF8", VA = "0x1FADEF8", Slot = "12")]
    public System.Collections.Generic.List<EffectParameterData> GetDeactivateTriggeredEffects(
      EffectiveLengthTypeEnum length)
    {
      return (System.Collections.Generic.List<EffectParameterData>) null;
    }

    [Token(Token = "0x600F497")]
    [Address(RVA = "0x1FAE124", Offset = "0x1FAE124", VA = "0x1FAE124")]
    public (bool, bool) CheckEffects() => ();

    [Token(Token = "0x600F498")]
    [Address(RVA = "0x1FAE320", Offset = "0x1FAE320", VA = "0x1FAE320")]
    public IDuelFlowControlEffect GetDuelFlowControl() => (IDuelFlowControlEffect) null;

    [Token(Token = "0x600F499")]
    [Address(RVA = "0x1FAE4B8", Offset = "0x1FAE4B8", VA = "0x1FAE4B8")]
    public IRestrictedInfo GetRestrictedInfo() => (IRestrictedInfo) null;

    [Token(Token = "0x600F49A")]
    [Address(RVA = "0x1FAE4D0", Offset = "0x1FAE4D0", VA = "0x1FAE4D0")]
    public System.Collections.Generic.List<BattleBadStatusDetailData> GetNullBadStatusDetailId(
      bool isExceptForLand = false)
    {
      return (System.Collections.Generic.List<BattleBadStatusDetailData>) null;
    }

    [Token(Token = "0x600F49B")]
    [Address(RVA = "0x1FAED8C", Offset = "0x1FAED8C", VA = "0x1FAED8C")]
    public Dictionary<LandTagEnum, int> GetOverrideLandFormDic()
    {
      return (Dictionary<LandTagEnum, int>) null;
    }

    [Token(Token = "0x600F49C")]
    [Address(RVA = "0x1FAF27C", Offset = "0x1FAF27C", VA = "0x1FAF27C")]
    public bool IsEffectiveDuplicated(EffectKey key, int modifierType, IEffectValue effectValue)
    {
      return new bool();
    }

    [Token(Token = "0x600F49D")]
    [Address(RVA = "0x1FAF78C", Offset = "0x1FAF78C", VA = "0x1FAF78C")]
    public UnitEffectContainer()
    {
    }
  }
}
