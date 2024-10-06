// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.BadStatusEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002772")]
  public class BadStatusEffectData : EffectData, IEffectValue, IRestrictedInfo
  {
    [Token(Token = "0x400A878")]
    [FieldOffset(Offset = "0x80")]
    private string displayName;
    [Token(Token = "0x400A87B")]
    [FieldOffset(Offset = "0x98")]
    private RestrictedInfo restrictedInfo;

    [Token(Token = "0x170034BE")]
    public override string DisplayName
    {
      [Token(Token = "0x600F669"), Address(RVA = "0x1ED6504", Offset = "0x1ED6504", VA = "0x1ED6504", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170034BF")]
    public BattleBadStatusData BadStatus
    {
      [Token(Token = "0x600F66A"), Address(RVA = "0x1ED650C", Offset = "0x1ED650C", VA = "0x1ED650C")] get
      {
        return (BattleBadStatusData) null;
      }
      [Token(Token = "0x600F66B"), Address(RVA = "0x1ED6514", Offset = "0x1ED6514", VA = "0x1ED6514")] private set
      {
      }
    }

    [Token(Token = "0x170034C0")]
    public BattleBadStatusDetailData BadStatusDetail
    {
      [Token(Token = "0x600F66C"), Address(RVA = "0x1ED651C", Offset = "0x1ED651C", VA = "0x1ED651C")] get
      {
        return (BattleBadStatusDetailData) null;
      }
      [Token(Token = "0x600F66D"), Address(RVA = "0x1ED6524", Offset = "0x1ED6524", VA = "0x1ED6524")] private set
      {
      }
    }

    [Token(Token = "0x170034C1")]
    public virtual BattleEffectValueTypeEnum ValueType
    {
      [Token(Token = "0x600F66E"), Address(RVA = "0x1ED652C", Offset = "0x1ED652C", VA = "0x1ED652C", Slot = "18")] get
      {
        return new BattleEffectValueTypeEnum();
      }
    }

    [Token(Token = "0x170034C2")]
    public virtual int Value
    {
      [Token(Token = "0x600F66F"), Address(RVA = "0x1ED6534", Offset = "0x1ED6534", VA = "0x1ED6534", Slot = "19")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170034C3")]
    public bool DisableControl
    {
      [Token(Token = "0x600F670"), Address(RVA = "0x1ED653C", Offset = "0x1ED653C", VA = "0x1ED653C", Slot = "10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170034C4")]
    public bool DisableAction
    {
      [Token(Token = "0x600F671"), Address(RVA = "0x1ED6544", Offset = "0x1ED6544", VA = "0x1ED6544", Slot = "11")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170034C5")]
    public bool DisableMove
    {
      [Token(Token = "0x600F672"), Address(RVA = "0x1ED654C", Offset = "0x1ED654C", VA = "0x1ED654C", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170034C6")]
    public bool DisableAvoid
    {
      [Token(Token = "0x600F673"), Address(RVA = "0x1ED6554", Offset = "0x1ED6554", VA = "0x1ED6554", Slot = "13")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170034C7")]
    public bool DisableHit
    {
      [Token(Token = "0x600F674"), Address(RVA = "0x1ED655C", Offset = "0x1ED655C", VA = "0x1ED655C", Slot = "14")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170034C8")]
    public bool DisableSecondAttack
    {
      [Token(Token = "0x600F675"), Address(RVA = "0x1ED6564", Offset = "0x1ED6564", VA = "0x1ED6564", Slot = "15")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170034C9")]
    public List<SkillCategoryTypeEnum> DisableUseSkillCategories
    {
      [Token(Token = "0x600F676"), Address(RVA = "0x1ED656C", Offset = "0x1ED656C", VA = "0x1ED656C", Slot = "16")] get
      {
        return (List<SkillCategoryTypeEnum>) null;
      }
    }

    [Token(Token = "0x170034CA")]
    public bool DisableBattle
    {
      [Token(Token = "0x600F677"), Address(RVA = "0x1ED6574", Offset = "0x1ED6574", VA = "0x1ED6574", Slot = "17")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600F678")]
    [Address(RVA = "0x1ED657C", Offset = "0x1ED657C", VA = "0x1ED657C")]
    public static BadStatusEffectData Create(EffectSource source) => (BadStatusEffectData) null;

    [Token(Token = "0x600F679")]
    [Address(RVA = "0x1ED6650", Offset = "0x1ED6650", VA = "0x1ED6650")]
    protected BadStatusEffectData(
      EffectSource source,
      BadStatusEffectData.IContextIndexInfo indexInfo)
    {
    }

    [Token(Token = "0x600F67A")]
    [Address(RVA = "0x1ED68F4", Offset = "0x1ED68F4", VA = "0x1ED68F4", Slot = "20")]
    protected virtual void Initialize()
    {
    }

    [Token(Token = "0x600F67B")]
    [Address(RVA = "0x1ED68F8", Offset = "0x1ED68F8", VA = "0x1ED68F8")]
    private void Setup()
    {
    }

    [Token(Token = "0x2002773")]
    protected interface IContextIndexInfo
    {
      [Token(Token = "0x170034CB")]
      int BadStatusMasterId { [Token(Token = "0x600F67C")] get; }
    }

    [Token(Token = "0x2002774")]
    public struct ContextIndexInfo : BadStatusEffectData.IContextIndexInfo
    {
      [Token(Token = "0x170034CC")]
      public int BadStatusMasterId
      {
        [Token(Token = "0x600F67D"), Address(RVA = "0x1ED6A78", Offset = "0x1ED6A78", VA = "0x1ED6A78", Slot = "4")] get
        {
          return new int();
        }
      }
    }
  }
}
