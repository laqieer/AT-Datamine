// Decompiled with JetBrains decompiler
// Type: Battle.Process.BattleSystemLogCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.DuelScene;
using Battle.Logic;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x200269F")]
  public class BattleSystemLogCreator : BattleLogCreator
  {
    [Token(Token = "0x600EF2C")]
    [Address(RVA = "0x40D23C8", Offset = "0x40D23C8", VA = "0x40D23C8")]
    public BattleSystemLogCreator(
      IReadOnlyDictionary<int, BattleLogTextFormatData> dic,
      BoardData boardData)
    {
    }

    [Token(Token = "0x600EF2D")]
    [Address(RVA = "0x40D23CC", Offset = "0x40D23CC", VA = "0x40D23CC")]
    public List<BattleLogData> CreateLog(
      BattleLogTextTypeEnum logType,
      int value1,
      int value2,
      int value3,
      int unitId = 0,
      int paramNum = 0,
      bool isDelay = false)
    {
      return (List<BattleLogData>) null;
    }

    [Token(Token = "0x600EF2E")]
    [Address(RVA = "0x40D47D0", Offset = "0x40D47D0", VA = "0x40D47D0")]
    private void CreateTurunLog(BattleLogTextTypeEnum logType)
    {
    }

    [Token(Token = "0x600EF2F")]
    [Address(RVA = "0x40D4904", Offset = "0x40D4904", VA = "0x40D4904")]
    private void CreatePhaseLog(BattleLogTextTypeEnum logType)
    {
    }

    [Token(Token = "0x600EF30")]
    [Address(RVA = "0x40D5130", Offset = "0x40D5130", VA = "0x40D5130")]
    public List<BattleLogData> CreateTakeBadStatusDamageLog(UnitParameterChange target, int unitId)
    {
      return (List<BattleLogData>) null;
    }

    [Token(Token = "0x600EF31")]
    [Address(RVA = "0x40D4DEC", Offset = "0x40D4DEC", VA = "0x40D4DEC")]
    private void CreateBadStatusContinueLog(BattleLogTextTypeEnum logType, int unitId)
    {
    }

    [Token(Token = "0x600EF32")]
    [Address(RVA = "0x40D50C4", Offset = "0x40D50C4", VA = "0x40D50C4")]
    private void CreateSupportHealLog(BattleLogTextTypeEnum logType, int unitId, bool isDelay)
    {
    }

    [Token(Token = "0x600EF33")]
    [Address(RVA = "0x40D3520", Offset = "0x40D3520", VA = "0x40D3520")]
    public List<BattleLogData> CreateAutoTurretActionLog(FacilityData turret, int param)
    {
      return (List<BattleLogData>) null;
    }

    [Token(Token = "0x600EF34")]
    [Address(RVA = "0x40D378C", Offset = "0x40D378C", VA = "0x40D378C")]
    public List<BattleLogData> CreateAutoTurretAttackLog(
      FacilityData turret,
      IReadOnlyList<ActionData> results)
    {
      return (List<BattleLogData>) null;
    }

    [Token(Token = "0x600EF35")]
    [Address(RVA = "0x40D269C", Offset = "0x40D269C", VA = "0x40D269C")]
    public List<BattleLogData> CreateDeadLog(
      UnitParameterChange targetParam,
      UnitParameterData unit,
      bool enableLost)
    {
      return (List<BattleLogData>) null;
    }

    [Token(Token = "0x600EF36")]
    [Address(RVA = "0x40D53A8", Offset = "0x40D53A8", VA = "0x40D53A8")]
    private void CreateLpDownLog(UnitParameterChange targetParam, UnitParameterData unit)
    {
    }

    [Token(Token = "0x600EF37")]
    [Address(RVA = "0x40D55F0", Offset = "0x40D55F0", VA = "0x40D55F0")]
    private List<BattleLogData> CreateLostLog(UnitParameterData unit) => (List<BattleLogData>) null;

    [Token(Token = "0x600EF38")]
    [Address(RVA = "0x40D55BC", Offset = "0x40D55BC", VA = "0x40D55BC")]
    private void ReleaseDoubleLog()
    {
    }

    [Token(Token = "0x600EF39")]
    [Address(RVA = "0x40D289C", Offset = "0x40D289C", VA = "0x40D289C")]
    public List<BattleLogData> CreateClearEffectLog(
      List<EffectParameterData> removeEffectList,
      int unitId)
    {
      return (List<BattleLogData>) null;
    }

    [Token(Token = "0x600EF3A")]
    [Address(RVA = "0x40D2EE0", Offset = "0x40D2EE0", VA = "0x40D2EE0")]
    public List<BattleLogData> CreateBattleBarrierLog(
      UnitParameterData unit,
      int index,
      BarrierDamageLogic logic)
    {
      return (List<BattleLogData>) null;
    }

    [Token(Token = "0x600EF3B")]
    [Address(RVA = "0x40D5100", Offset = "0x40D5100", VA = "0x40D5100")]
    private void CreateSystemLog(BattleLogTextTypeEnum logType, int unitId)
    {
    }

    [Token(Token = "0x600EF3C")]
    [Address(RVA = "0x40D4CC4", Offset = "0x40D4CC4", VA = "0x40D4CC4")]
    private void CreateValueUnitIdLog(BattleLogTextTypeEnum logType, int value1, int unitId)
    {
    }

    [Token(Token = "0x600EF3D")]
    [Address(RVA = "0x40D4B9C", Offset = "0x40D4B9C", VA = "0x40D4B9C")]
    private void CreateValueParamLog(BattleLogTextTypeEnum logType, int value1, int param)
    {
    }
  }
}
