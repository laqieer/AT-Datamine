// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.EffectParameterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027AB")]
  public class EffectParameterData
  {
    [Token(Token = "0x400A915")]
    [FieldOffset(Offset = "0x20")]
    public int PutOperationCount;
    [Token(Token = "0x400A916")]
    [FieldOffset(Offset = "0x28")]
    private TurnCounter turnCounter;
    [Token(Token = "0x400A917")]
    [FieldOffset(Offset = "0x30")]
    private IEffectDuration effectDuration;

    [Token(Token = "0x17003541")]
    public EffectData Effect
    {
      [Token(Token = "0x600F7A3"), Address(RVA = "0x1EDD0A4", Offset = "0x1EDD0A4", VA = "0x1EDD0A4")] get
      {
        return (EffectData) null;
      }
      [Token(Token = "0x600F7A4"), Address(RVA = "0x1EDD0AC", Offset = "0x1EDD0AC", VA = "0x1EDD0AC")] private set
      {
      }
    }

    [Token(Token = "0x17003542")]
    public int AffectUnitParamId
    {
      [Token(Token = "0x600F7A5"), Address(RVA = "0x1EDD0B4", Offset = "0x1EDD0B4", VA = "0x1EDD0B4")] get
      {
        return new int();
      }
      [Token(Token = "0x600F7A6"), Address(RVA = "0x1EDD0BC", Offset = "0x1EDD0BC", VA = "0x1EDD0BC")] private set
      {
      }
    }

    [Token(Token = "0x17003543")]
    public int AffectSkillParamId
    {
      [Token(Token = "0x600F7A7"), Address(RVA = "0x1EDD0C4", Offset = "0x1EDD0C4", VA = "0x1EDD0C4")] get
      {
        return new int();
      }
      [Token(Token = "0x600F7A8"), Address(RVA = "0x1EDD0CC", Offset = "0x1EDD0CC", VA = "0x1EDD0CC")] private set
      {
      }
    }

    [Token(Token = "0x17003544")]
    public int EffectedTurnNumber
    {
      [Token(Token = "0x600F7A9"), Address(RVA = "0x1EDD0D4", Offset = "0x1EDD0D4", VA = "0x1EDD0D4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003545")]
    public int EffectedPhaseIndex
    {
      [Token(Token = "0x600F7AA"), Address(RVA = "0x1EDD0F0", Offset = "0x1EDD0F0", VA = "0x1EDD0F0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003546")]
    public int ElapsedTurn
    {
      [Token(Token = "0x600F7AB"), Address(RVA = "0x1EDD10C", Offset = "0x1EDD10C", VA = "0x1EDD10C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003547")]
    public List<int> DurationContexts
    {
      [Token(Token = "0x600F7AC"), Address(RVA = "0x1EDD128", Offset = "0x1EDD128", VA = "0x1EDD128")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x17003548")]
    public string DisplayName
    {
      [Token(Token = "0x600F7AD"), Address(RVA = "0x1EDD1CC", Offset = "0x1EDD1CC", VA = "0x1EDD1CC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17003549")]
    public bool IsBuffEffect
    {
      [Token(Token = "0x600F7AE"), Address(RVA = "0x1ED8468", Offset = "0x1ED8468", VA = "0x1ED8468")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700354A")]
    public bool IsDebuffEffect
    {
      [Token(Token = "0x600F7AF"), Address(RVA = "0x1ED848C", Offset = "0x1ED848C", VA = "0x1ED848C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700354B")]
    public bool ExpiredEffect
    {
      [Token(Token = "0x600F7B0"), Address(RVA = "0x1EDD1EC", Offset = "0x1EDD1EC", VA = "0x1EDD1EC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700354C")]
    public BattleEffectTypeEnum EffectType
    {
      [Token(Token = "0x600F7B1"), Address(RVA = "0x1EDD28C", Offset = "0x1EDD28C", VA = "0x1EDD28C")] get
      {
        return new BattleEffectTypeEnum();
      }
    }

    [Token(Token = "0x1700354D")]
    public int LeftTurn
    {
      [Token(Token = "0x600F7B2"), Address(RVA = "0x1EDD2A8", Offset = "0x1EDD2A8", VA = "0x1EDD2A8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700354E")]
    public EffectiveLengthTypeEnum DurationType
    {
      [Token(Token = "0x600F7B3"), Address(RVA = "0x1EDD388", Offset = "0x1EDD388", VA = "0x1EDD388")] get
      {
        return new EffectiveLengthTypeEnum();
      }
    }

    [Token(Token = "0x1700354F")]
    public int Context
    {
      [Token(Token = "0x600F7B4"), Address(RVA = "0x1EDD3A4", Offset = "0x1EDD3A4", VA = "0x1EDD3A4")] get
      {
        return new int();
      }
      [Token(Token = "0x600F7B5"), Address(RVA = "0x1EDD3AC", Offset = "0x1EDD3AC", VA = "0x1EDD3AC")] set
      {
      }
    }

    [Token(Token = "0x17003550")]
    public bool IsRemainingOperationCount
    {
      [Token(Token = "0x600F7B6"), Address(RVA = "0x1EDD3B4", Offset = "0x1EDD3B4", VA = "0x1EDD3B4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600F7B7")]
    [Address(RVA = "0x1EDD3EC", Offset = "0x1EDD3EC", VA = "0x1EDD3EC")]
    public EffectParameterData Copy() => (EffectParameterData) null;

    [Token(Token = "0x600F7B8")]
    [Address(RVA = "0x1EDD468", Offset = "0x1EDD468", VA = "0x1EDD468")]
    public static EffectParameterData Create(
      EffectData effect,
      int effectedTurnNumber,
      int effectedPhaseIndex,
      UnitParameterData affectUnit,
      SkillParameterData affectSkill,
      int context = 0,
      List<int> durationContexts = null,
      int putOperationCount = 0)
    {
      return (EffectParameterData) null;
    }

    [Token(Token = "0x600F7B9")]
    [Address(RVA = "0x1EDCD50", Offset = "0x1EDCD50", VA = "0x1EDCD50")]
    public static EffectParameterData Create(
      EffectData effect,
      int effectedTurnNumber,
      int effectedPhaseIndex,
      int affectUnitId,
      int affectSkillId,
      int context,
      List<int> durationContexts = null,
      int putOperationCount = 0)
    {
      return (EffectParameterData) null;
    }

    [Token(Token = "0x600F7BA")]
    [Address(RVA = "0x1EDD794", Offset = "0x1EDD794", VA = "0x1EDD794")]
    public void Elapse(int turnNumber, int phaseIndex)
    {
    }

    [Token(Token = "0x600F7BB")]
    [Address(RVA = "0x1EDD870", Offset = "0x1EDD870", VA = "0x1EDD870")]
    public void ResetElapsed(int turnNumber, int phaseIndex)
    {
    }

    [Token(Token = "0x600F7BC")]
    [Address(RVA = "0x1EDD92C", Offset = "0x1EDD92C", VA = "0x1EDD92C")]
    public bool IsDeactivateTriggered(EffectiveLengthTypeEnum length) => new bool();

    [Token(Token = "0x600F7BD")]
    [Address(RVA = "0x1EDD950", Offset = "0x1EDD950", VA = "0x1EDD950")]
    public bool IsActivatable(BoardData boardData, UnitParameterData from, UnitParameterData to)
    {
      return new bool();
    }

    [Token(Token = "0x600F7BE")]
    [Address(RVA = "0x1EDD9F0", Offset = "0x1EDD9F0", VA = "0x1EDD9F0")]
    public bool CanTriggerEffect(UnitParameterData target) => new bool();

    [Token(Token = "0x600F7BF")]
    [Address(RVA = "0x1ED8410", Offset = "0x1ED8410", VA = "0x1ED8410")]
    public BattleBuffTagEnum? GetBattleBuffTag() => new BattleBuffTagEnum?();

    [Token(Token = "0x600F7C0")]
    [Address(RVA = "0x1EDD4EC", Offset = "0x1EDD4EC", VA = "0x1EDD4EC")]
    private IEffectDuration CreateElapseCounter() => (IEffectDuration) null;

    [Token(Token = "0x600F7C1")]
    [Address(RVA = "0x1EDD6D8", Offset = "0x1EDD6D8", VA = "0x1EDD6D8")]
    private IEffectDuration CreateElapseCounter(List<int> contexts) => (IEffectDuration) null;

    [Token(Token = "0x600F7C2")]
    [Address(RVA = "0x1EDDA54", Offset = "0x1EDDA54", VA = "0x1EDDA54", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F7C3")]
    [Address(RVA = "0x1EDD4E4", Offset = "0x1EDD4E4", VA = "0x1EDD4E4")]
    public EffectParameterData()
    {
    }
  }
}
