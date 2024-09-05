// Decompiled with JetBrains decompiler
// Type: Battle.Logic.Prediction.PredictionResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Logic.Prediction
{
  [Token(Token = "0x20024F7")]
  public class PredictionResult
  {
    [Token(Token = "0x4009E9D")]
    [FieldOffset(Offset = "0x10")]
    public List<ActionResult> ActionResults;
    [Token(Token = "0x4009E9E")]
    [FieldOffset(Offset = "0x18")]
    public List<int> ActivatableSkills;
    [Token(Token = "0x4009E9F")]
    [FieldOffset(Offset = "0x20")]
    public bool ActivatorHasSupportAttack;
    [Token(Token = "0x4009EA0")]
    [FieldOffset(Offset = "0x21")]
    public bool ActivatorHasSupportGuard;
    [Token(Token = "0x4009EA1")]
    [FieldOffset(Offset = "0x22")]
    public bool ActivatorHasSupportHeal;
    [Token(Token = "0x4009EA2")]
    [FieldOffset(Offset = "0x24")]
    public int ActivatorSupporter;
    [Token(Token = "0x4009EA3")]
    [FieldOffset(Offset = "0x28")]
    public int ActivatorSupportAttackRate;
    [Token(Token = "0x4009EA4")]
    [FieldOffset(Offset = "0x2C")]
    public int ActivatorSupportGuardRate;
    [Token(Token = "0x4009EA5")]
    [FieldOffset(Offset = "0x30")]
    public int ActivatorSupportHealRate;
    [Token(Token = "0x4009EA6")]
    [FieldOffset(Offset = "0x38")]
    public UnitParameterData ActivatorSupportAttackUnitParam;
    [Token(Token = "0x4009EA7")]
    [FieldOffset(Offset = "0x40")]
    public UnitParameterData ActivatorSupportGuardUnitParam;
    [Token(Token = "0x4009EA8")]
    [FieldOffset(Offset = "0x48")]
    public UnitParameterData ActivatorSupportHealUnitParam;
    [Token(Token = "0x4009EA9")]
    [FieldOffset(Offset = "0x50")]
    public bool ActivatorFirstStrike;
    [Token(Token = "0x4009EAA")]
    [FieldOffset(Offset = "0x51")]
    public bool ActivatorSecondStrike;
    [Token(Token = "0x4009EAB")]
    [FieldOffset(Offset = "0x58")]
    public List<int> MainTargetActivatableSkills;
    [Token(Token = "0x4009EAC")]
    [FieldOffset(Offset = "0x60")]
    public bool MainTargetHasSupportAttack;
    [Token(Token = "0x4009EAD")]
    [FieldOffset(Offset = "0x61")]
    public bool MainTargetHasSupportGuard;
    [Token(Token = "0x4009EAE")]
    [FieldOffset(Offset = "0x62")]
    public bool MainTargetHasSupportHeal;
    [Token(Token = "0x4009EAF")]
    [FieldOffset(Offset = "0x64")]
    public int MainTargetSupporter;
    [Token(Token = "0x4009EB0")]
    [FieldOffset(Offset = "0x68")]
    public int MainTargetSupportAttackRate;
    [Token(Token = "0x4009EB1")]
    [FieldOffset(Offset = "0x6C")]
    public int MainTargetSupportGuardRate;
    [Token(Token = "0x4009EB2")]
    [FieldOffset(Offset = "0x70")]
    public int MainTargetSupportHealRate;
    [Token(Token = "0x4009EB3")]
    [FieldOffset(Offset = "0x78")]
    public UnitParameterData MainTargetSupportAttackUnitParam;
    [Token(Token = "0x4009EB4")]
    [FieldOffset(Offset = "0x80")]
    public UnitParameterData MainTargetSupportGuardUnitParam;
    [Token(Token = "0x4009EB5")]
    [FieldOffset(Offset = "0x88")]
    public UnitParameterData MainTargetSupportHealUnitParam;
    [Token(Token = "0x4009EB6")]
    [FieldOffset(Offset = "0x90")]
    public bool MainTargetFirstStrike;
    [Token(Token = "0x4009EB7")]
    [FieldOffset(Offset = "0x91")]
    public bool MainTargetSecondStrike;
    [Token(Token = "0x4009EB8")]
    [FieldOffset(Offset = "0x94")]
    public int UseItemId;
    [Token(Token = "0x4009EB9")]
    [FieldOffset(Offset = "0x98")]
    public List<(int unitId, int index, BarrierDamageLogic logic)> BarrierDamages;

    [Token(Token = "0x600E3F9")]
    [Address(RVA = "0x477F328", Offset = "0x477F328", VA = "0x477F328")]
    public List<(SkillCategoryTypeEnum, bool, int, UnitParameterData)> GetActivatorSupportData()
    {
      return (List<(SkillCategoryTypeEnum, bool, int, UnitParameterData)>) null;
    }

    [Token(Token = "0x600E3FA")]
    [Address(RVA = "0x477F5E4", Offset = "0x477F5E4", VA = "0x477F5E4")]
    public List<(SkillCategoryTypeEnum, bool, int, UnitParameterData)> GetMainTargetSupportData()
    {
      return (List<(SkillCategoryTypeEnum, bool, int, UnitParameterData)>) null;
    }

    [Token(Token = "0x600E3FB")]
    [Address(RVA = "0x477F8A0", Offset = "0x477F8A0", VA = "0x477F8A0")]
    public PredictionResult()
    {
    }
  }
}
