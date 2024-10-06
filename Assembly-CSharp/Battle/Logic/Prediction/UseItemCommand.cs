// Decompiled with JetBrains decompiler
// Type: Battle.Logic.Prediction.UseItemCommand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Process;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Logic.Prediction
{
  [Token(Token = "0x2002505")]
  public sealed class UseItemCommand
  {
    [Token(Token = "0x4009F18")]
    [FieldOffset(Offset = "0x10")]
    private BattleCore core;
    [Token(Token = "0x4009F19")]
    [FieldOffset(Offset = "0x18")]
    private BoardData origin;
    [Token(Token = "0x4009F1A")]
    [FieldOffset(Offset = "0x20")]
    private int itemUserId;
    [Token(Token = "0x4009F1B")]
    [FieldOffset(Offset = "0x24")]
    private int mainTargetId;
    [Token(Token = "0x4009F1C")]
    [FieldOffset(Offset = "0x28")]
    private (int x, int y) mainTargetCoord;
    [Token(Token = "0x4009F1D")]
    [FieldOffset(Offset = "0x30")]
    private List<(int unitId, int x, int y)> targetParams;
    [Token(Token = "0x4009F1E")]
    [FieldOffset(Offset = "0x38")]
    private int itemParamId;
    [Token(Token = "0x4009F1F")]
    [FieldOffset(Offset = "0x40")]
    private ActionContext context;
    [Token(Token = "0x4009F20")]
    [FieldOffset(Offset = "0xA8")]
    private PredictionResult result;
    [Token(Token = "0x4009F21")]
    [FieldOffset(Offset = "0xB0")]
    private ActionResult actionResult;
    [Token(Token = "0x4009F22")]
    [FieldOffset(Offset = "0xB8")]
    private BattlePlayerData itemUser;
    [Token(Token = "0x4009F23")]
    [FieldOffset(Offset = "0xC0")]
    private TargetPair mainTarget;
    [Token(Token = "0x4009F24")]
    [FieldOffset(Offset = "0xC8")]
    private List<TargetPair> targets;
    [Token(Token = "0x4009F25")]
    [FieldOffset(Offset = "0xD0")]
    private ItemParameterData itemParam;
    [Token(Token = "0x4009F26")]
    [FieldOffset(Offset = "0xD8")]
    private List<(int unitId, int index, BarrierDamageLogic logic)> barrierDamages;

    [Token(Token = "0x170030F0")]
    private BoardData board
    {
      [Token(Token = "0x600E48E"), Address(RVA = "0x47865D8", Offset = "0x47865D8", VA = "0x47865D8")] get
      {
        return (BoardData) null;
      }
    }

    [Token(Token = "0x600E48F")]
    [Address(RVA = "0x47865F4", Offset = "0x47865F4", VA = "0x47865F4")]
    public UseItemCommand(
      BattleCore core,
      BattlePlayerData itemUser,
      List<TargetPair> targets,
      GridData castTo,
      ItemParameterData itemParam)
    {
    }

    [Token(Token = "0x600E490")]
    [Address(RVA = "0x4786A18", Offset = "0x4786A18", VA = "0x4786A18")]
    private void AttachTempBoard()
    {
    }

    [Token(Token = "0x600E491")]
    [Address(RVA = "0x4786EB8", Offset = "0x4786EB8", VA = "0x4786EB8")]
    private void ClearTempBoard()
    {
    }

    [Token(Token = "0x600E492")]
    [Address(RVA = "0x4786EE4", Offset = "0x4786EE4", VA = "0x4786EE4")]
    public PredictionResult Predict() => (PredictionResult) null;

    [Token(Token = "0x600E493")]
    [Address(RVA = "0x47877B8", Offset = "0x47877B8", VA = "0x47877B8")]
    private BarrierDamageLogic GetBarrierDamageLogic(int unit, int index)
    {
      return (BarrierDamageLogic) null;
    }

    [Token(Token = "0x600E494")]
    [Address(RVA = "0x4787920", Offset = "0x4787920", VA = "0x4787920")]
    private void CollectBarrierDamage(ActiveSkillLogicBase logic)
    {
    }

    [Token(Token = "0x600E495")]
    [Address(RVA = "0x4787324", Offset = "0x4787324", VA = "0x4787324")]
    private void ApplyBarrierDamage()
    {
    }

    [Token(Token = "0x600E496")]
    [Address(RVA = "0x47870FC", Offset = "0x47870FC", VA = "0x47870FC")]
    private void ExecEffect()
    {
    }

    [Token(Token = "0x600E497")]
    [Address(RVA = "0x4787B9C", Offset = "0x4787B9C", VA = "0x4787B9C")]
    private void AddResult(
      TargetPair target,
      EffectData effect,
      EffectLogic.EffectLogicOutputParam output)
    {
    }

    [Token(Token = "0x600E498")]
    [Address(RVA = "0x4788088", Offset = "0x4788088", VA = "0x4788088")]
    private void AddReserveBarrierDamageBonus(
      TargetPair targetPair,
      int gridIndex,
      int weakElementBonus,
      int weakAttackTypeBonus,
      int alignmentStratagemBonus)
    {
    }
  }
}
