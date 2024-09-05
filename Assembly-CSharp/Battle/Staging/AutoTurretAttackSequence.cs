// Decompiled with JetBrains decompiler
// Type: Battle.Staging.AutoTurretAttackSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.DuelScene;
using Battle.RouteSearch;
using Battle.Unit;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x200256E")]
  public class AutoTurretAttackSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A09E")]
    [FieldOffset(Offset = "0x18")]
    private IDirector mainDirector;
    [Token(Token = "0x400A09F")]
    [FieldOffset(Offset = "0x20")]
    private FacilityView turret;
    [Token(Token = "0x400A0A0")]
    [FieldOffset(Offset = "0x28")]
    private SkillParameterData useSkill;
    [Token(Token = "0x400A0A1")]
    [FieldOffset(Offset = "0x30")]
    private GridData castFrom;
    [Token(Token = "0x400A0A2")]
    [FieldOffset(Offset = "0x38")]
    private GridData castTo;
    [Token(Token = "0x400A0A3")]
    [FieldOffset(Offset = "0x40")]
    private IReadOnlyList<ActionData> turretResults;
    [Token(Token = "0x400A0A4")]
    [FieldOffset(Offset = "0x48")]
    private AttackableAreaSearcher attackableArea;
    [Token(Token = "0x400A0A5")]
    [FieldOffset(Offset = "0x50")]
    private AttackableAreaSearcher effectiveArea;
    [Token(Token = "0x400A0A6")]
    [FieldOffset(Offset = "0x58")]
    private BattlePlayerData player;
    [Token(Token = "0x400A0A7")]
    private const float cameraMoveSpeed = 0.25f;
    [Token(Token = "0x400A0A8")]
    private const string ATTACK_EFFECT_NAME = "Ef_F_Map_Automata_Atk01";
    [Token(Token = "0x400A0A9")]
    private const string HIT_EFFECT_NAME = "Ef_F_Map_Automata_Hit01";
    [Token(Token = "0x400A0AA")]
    private const string DEFAULT_ELEMENT_TYPE = "N";

    [Token(Token = "0x600E6CC")]
    [Address(RVA = "0x4876FE4", Offset = "0x4876FE4", VA = "0x4876FE4")]
    public static AutoTurretAttackSequence Create(
      IDirector mainDirector,
      FacilityView turret,
      SkillParameterData useSkill,
      GridData castFrom,
      GridData castTo,
      IReadOnlyList<ActionData> turretResults,
      AttackableAreaSearcher attackableArea,
      AttackableAreaSearcher effectiveArea,
      BattlePlayerData player)
    {
      return (AutoTurretAttackSequence) null;
    }

    [Token(Token = "0x1700317F")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E6CD"), Address(RVA = "0x487710C", Offset = "0x487710C", VA = "0x487710C", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E6CE"), Address(RVA = "0x4877114", Offset = "0x4877114", VA = "0x4877114")] private set
      {
      }
    }

    [Token(Token = "0x600E6CF")]
    [Address(RVA = "0x4877098", Offset = "0x4877098", VA = "0x4877098")]
    private AutoTurretAttackSequence(
      IDirector mainDirector,
      FacilityView turret,
      SkillParameterData useSkill,
      GridData castFrom,
      GridData castTo,
      IReadOnlyList<ActionData> turretResults,
      AttackableAreaSearcher attackableArea,
      AttackableAreaSearcher effectiveArea,
      BattlePlayerData player)
    {
    }

    [Token(Token = "0x600E6D0")]
    [Address(RVA = "0x4877120", Offset = "0x4877120", VA = "0x4877120", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E6D1")]
    [Address(RVA = "0x48787B4", Offset = "0x48787B4", VA = "0x48787B4")]
    private string GetEffectName(string prefix, EffectData effect) => (string) null;

    [Token(Token = "0x600E6D2")]
    [Address(RVA = "0x487875C", Offset = "0x487875C", VA = "0x487875C")]
    private string GetAttackEffectAssetName(EffectData effect) => (string) null;

    [Token(Token = "0x600E6D3")]
    [Address(RVA = "0x48788C4", Offset = "0x48788C4", VA = "0x48788C4")]
    private string GetHitEffectAssetName(EffectData effect) => (string) null;

    [Token(Token = "0x600E6D4")]
    [Address(RVA = "0x487890C", Offset = "0x487890C", VA = "0x487890C")]
    private void TurretRotate()
    {
    }

    [Token(Token = "0x600E6D5")]
    [Address(RVA = "0x4878910", Offset = "0x4878910", VA = "0x4878910", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E6D6")]
    [Address(RVA = "0x487891C", Offset = "0x487891C", VA = "0x487891C", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E6D7")]
    [Address(RVA = "0x4878928", Offset = "0x4878928", VA = "0x4878928", Slot = "6")]
    public void Abort()
    {
    }
  }
}
