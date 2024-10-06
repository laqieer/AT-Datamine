// Decompiled with JetBrains decompiler
// Type: ADV2.ConnectBattleProcessToAdv
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using Battle.Data;
using Battle.Data.Board;
using Battle.Process;
using Battle.RouteSearch;
using Battle.Unit;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003DF1")]
  public class ConnectBattleProcessToAdv
  {
    [Token(Token = "0x4010F7F")]
    [FieldOffset(Offset = "0x10")]
    private List<ConnectBattleProcessToAdv.ReserveMoveUnitData> reserveMoveUnitList;
    [Token(Token = "0x4010F80")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, SkillParameterData> usingSkillDic;
    [Token(Token = "0x4010F81")]
    [FieldOffset(Offset = "0x20")]
    private BattleCore battleCore;
    [Token(Token = "0x4010F82")]
    [FieldOffset(Offset = "0x28")]
    private MovableAreaSearcher searcher;

    [Token(Token = "0x1700510B")]
    private IDirector mainDirector
    {
      [Token(Token = "0x6018E5D"), Address(RVA = "0x2CA611C", Offset = "0x2CA611C", VA = "0x2CA611C")] get
      {
        return (IDirector) null;
      }
    }

    [Token(Token = "0x1700510C")]
    private BattleConfigData battleConfig
    {
      [Token(Token = "0x6018E5E"), Address(RVA = "0x2CA6138", Offset = "0x2CA6138", VA = "0x2CA6138")] get
      {
        return (BattleConfigData) null;
      }
    }

    [Token(Token = "0x1700510D")]
    private BoardData boardData
    {
      [Token(Token = "0x6018E5F"), Address(RVA = "0x2CA6154", Offset = "0x2CA6154", VA = "0x2CA6154")] get
      {
        return (BoardData) null;
      }
    }

    [Token(Token = "0x6018E60")]
    [Address(RVA = "0x2CA6170", Offset = "0x2CA6170", VA = "0x2CA6170")]
    public static ConnectBattleProcessToAdv Create() => (ConnectBattleProcessToAdv) null;

    [Token(Token = "0x6018E61")]
    [Address(RVA = "0x2CA620C", Offset = "0x2CA620C", VA = "0x2CA620C")]
    public ConnectBattleProcessToAdv(BattleCore battleCore)
    {
    }

    [Token(Token = "0x6018E62")]
    [Address(RVA = "0x2CA632C", Offset = "0x2CA632C", VA = "0x2CA632C")]
    public UnitParameterData GetUnit(int id) => (UnitParameterData) null;

    [Token(Token = "0x6018E63")]
    [Address(RVA = "0x2CA6368", Offset = "0x2CA6368", VA = "0x2CA6368")]
    public IReadOnlyList<UnitParameterData> GetAllUnit() => (IReadOnlyList<UnitParameterData>) null;

    [Token(Token = "0x6018E64")]
    [Address(RVA = "0x2CA638C", Offset = "0x2CA638C", VA = "0x2CA638C")]
    private CharacterActor GetCharacterActor(int id) => (CharacterActor) null;

    [Token(Token = "0x6018E65")]
    [Address(RVA = "0x2CA646C", Offset = "0x2CA646C", VA = "0x2CA646C")]
    public void ChangeCameraDistance(float dist, float duration)
    {
    }

    [Token(Token = "0x6018E66")]
    [Address(RVA = "0x2CA65AC", Offset = "0x2CA65AC", VA = "0x2CA65AC")]
    public void ChangeCameraAngle(float angle, float duration)
    {
    }

    [Token(Token = "0x6018E67")]
    [Address(RVA = "0x2CA66F4", Offset = "0x2CA66F4", VA = "0x2CA66F4")]
    public void MoveCamera(int x, int y, float duration)
    {
    }

    [Token(Token = "0x6018E68")]
    [Address(RVA = "0x2CA68C4", Offset = "0x2CA68C4", VA = "0x2CA68C4")]
    public bool isCameraBusy() => new bool();

    [Token(Token = "0x6018E69")]
    [Address(RVA = "0x2CA69EC", Offset = "0x2CA69EC", VA = "0x2CA69EC")]
    public void SwitchGridVisible()
    {
    }

    [Token(Token = "0x6018E6A")]
    [Address(RVA = "0x2CA6B2C", Offset = "0x2CA6B2C", VA = "0x2CA6B2C")]
    public void ChangeTimeAndWeather(int timeslot, int weather)
    {
    }

    [Token(Token = "0x6018E6B")]
    [Address(RVA = "0x2CA6D9C", Offset = "0x2CA6D9C", VA = "0x2CA6D9C")]
    public void Hide()
    {
    }

    [Token(Token = "0x6018E6C")]
    [Address(RVA = "0x2CA6F54", Offset = "0x2CA6F54", VA = "0x2CA6F54")]
    public void ChangeUnitDir(int id, int dir)
    {
    }

    [Token(Token = "0x6018E6D")]
    [Address(RVA = "0x2CA70C8", Offset = "0x2CA70C8", VA = "0x2CA70C8")]
    public void ChangeAnim(int id, int anim)
    {
    }

    [Token(Token = "0x6018E6E")]
    [Address(RVA = "0x2CA73E8", Offset = "0x2CA73E8", VA = "0x2CA73E8")]
    public void DispWeapon(int id, bool active)
    {
    }

    [Token(Token = "0x6018E6F")]
    [Address(RVA = "0x2CA7584", Offset = "0x2CA7584", VA = "0x2CA7584")]
    public void DispUnit(int id, bool active)
    {
    }

    [Token(Token = "0x6018E70")]
    [Address(RVA = "0x2CA7644", Offset = "0x2CA7644", VA = "0x2CA7644")]
    public void MoveUnit(int id, int x, int y)
    {
    }

    [Token(Token = "0x6018E71")]
    [Address(RVA = "0x2CA7B44", Offset = "0x2CA7B44", VA = "0x2CA7B44")]
    public void DodgeUnit(int id)
    {
    }

    [Token(Token = "0x6018E72")]
    [Address(RVA = "0x2CA7CA4", Offset = "0x2CA7CA4", VA = "0x2CA7CA4")]
    public void NormalAttackUnit(int id, int targetId)
    {
    }

    [Token(Token = "0x6018E73")]
    [Address(RVA = "0x2CA81C0", Offset = "0x2CA81C0", VA = "0x2CA81C0")]
    public void DamageUnit(int id, int attackerId, int damage, bool critical)
    {
    }

    [Token(Token = "0x6018E74")]
    [Address(RVA = "0x2CA85F0", Offset = "0x2CA85F0", VA = "0x2CA85F0")]
    public void HealingUnit(int id, int healValue)
    {
    }

    [Token(Token = "0x6018E75")]
    [Address(RVA = "0x2CA8788", Offset = "0x2CA8788", VA = "0x2CA8788")]
    public bool isPlayingAnim(int id) => new bool();

    [Token(Token = "0x6018E76")]
    [Address(RVA = "0x2CA87A4", Offset = "0x2CA87A4", VA = "0x2CA87A4")]
    public void DoubleUnit(int id, int backId)
    {
    }

    [Token(Token = "0x6018E77")]
    [Address(RVA = "0x2CA88A8", Offset = "0x2CA88A8", VA = "0x2CA88A8")]
    public void ReserveMoveUnit(int id, int x, int y)
    {
    }

    [Token(Token = "0x6018E78")]
    [Address(RVA = "0x2CA897C", Offset = "0x2CA897C", VA = "0x2CA897C")]
    public void ExecParallelSeq()
    {
    }

    [Token(Token = "0x6018E79")]
    [Address(RVA = "0x2CA8E14", Offset = "0x2CA8E14", VA = "0x2CA8E14")]
    public void ChangeLayer(int id, int layer)
    {
    }

    [Token(Token = "0x6018E7A")]
    [Address(RVA = "0x2CA8ED8", Offset = "0x2CA8ED8", VA = "0x2CA8ED8")]
    public bool isPlayingStaging() => new bool();

    [Token(Token = "0x6018E7B")]
    [Address(RVA = "0x2CA8F90", Offset = "0x2CA8F90", VA = "0x2CA8F90")]
    public void ReserveParticle(string fileName)
    {
    }

    [Token(Token = "0x6018E7C")]
    [Address(RVA = "0x2CA9054", Offset = "0x2CA9054", VA = "0x2CA9054")]
    public void LoadParticle()
    {
    }

    [Token(Token = "0x1700510E")]
    public bool IsLoadingParticle
    {
      [Token(Token = "0x6018E7D"), Address(RVA = "0x2CA9110", Offset = "0x2CA9110", VA = "0x2CA9110")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6018E7E")]
    [Address(RVA = "0x2CA91C8", Offset = "0x2CA91C8", VA = "0x2CA91C8")]
    public int PlayParticleGrid(string name, int x, int y) => new int();

    [Token(Token = "0x6018E7F")]
    [Address(RVA = "0x2CA9388", Offset = "0x2CA9388", VA = "0x2CA9388")]
    public int PlayParticleUnit(int id, string name, int locator, bool dir) => new int();

    [Token(Token = "0x6018E80")]
    [Address(RVA = "0x2CA979C", Offset = "0x2CA979C", VA = "0x2CA979C")]
    public void StopParticle(int hashcode)
    {
    }

    [Token(Token = "0x6018E81")]
    [Address(RVA = "0x2CA9864", Offset = "0x2CA9864", VA = "0x2CA9864")]
    public bool isPlayingParticle(int hashcode) => new bool();

    [Token(Token = "0x6018E82")]
    [Address(RVA = "0x2CA9924", Offset = "0x2CA9924", VA = "0x2CA9924")]
    public void UnitCommandStay(int unitId, bool switchDouble)
    {
    }

    [Token(Token = "0x6018E83")]
    [Address(RVA = "0x2CA995C", Offset = "0x2CA995C", VA = "0x2CA995C")]
    public void UnitCommandMoveOnly(int unitId, int moveToX, int moveToY, bool switchDouble)
    {
    }

    [Token(Token = "0x6018E84")]
    [Address(RVA = "0x2CA999C", Offset = "0x2CA999C", VA = "0x2CA999C")]
    public void UnitCommandSkill(
      int unitId,
      int moveToX,
      int moveToY,
      int targetToX,
      int targetToY,
      int skillIdx,
      bool switchDouble)
    {
    }

    [Token(Token = "0x6018E85")]
    [Address(RVA = "0x2CA99E4", Offset = "0x2CA99E4", VA = "0x2CA99E4")]
    public void UnitCommandDouble(
      int unitId,
      int moveToX,
      int moveToY,
      int targetToX,
      int targetToY)
    {
    }

    [Token(Token = "0x6018E86")]
    [Address(RVA = "0x2CA9A28", Offset = "0x2CA9A28", VA = "0x2CA9A28")]
    public void UnitCommandReleaseDouble(
      int unitId,
      int moveToX,
      int moveToY,
      int targetToX,
      int targetToY,
      bool switchDouble)
    {
    }

    [Token(Token = "0x6018E87")]
    [Address(RVA = "0x2CA9A6C", Offset = "0x2CA9A6C", VA = "0x2CA9A6C")]
    public void SettingManualCommandSkill(
      int unitId,
      int moveToX,
      int moveToY,
      int targetToX,
      int targetToY,
      int skillIdx)
    {
    }

    [Token(Token = "0x6018E88")]
    [Address(RVA = "0x2CA9ABC", Offset = "0x2CA9ABC", VA = "0x2CA9ABC")]
    public void SettingManualCommandMoveOnly(int unitId, int moveToX, int moveToY)
    {
    }

    [Token(Token = "0x6018E89")]
    [Address(RVA = "0x2CA9B00", Offset = "0x2CA9B00", VA = "0x2CA9B00")]
    public void SettingManualCommandDouble(
      int unitId,
      int moveToX,
      int moveToY,
      int targetToX,
      int targetToY)
    {
    }

    [Token(Token = "0x6018E8A")]
    [Address(RVA = "0x2CA9B44", Offset = "0x2CA9B44", VA = "0x2CA9B44")]
    public void SettingManualReleaseDouble(
      int unitId,
      int moveToX,
      int moveToY,
      int targetToX,
      int targetToY)
    {
    }

    [Token(Token = "0x6018E8B")]
    [Address(RVA = "0x2CA9B88", Offset = "0x2CA9B88", VA = "0x2CA9B88")]
    public void SettingManualSwapWeapon(int unitId, int weaponIndex)
    {
    }

    [Token(Token = "0x6018E8C")]
    [Address(RVA = "0x2CA9BD0", Offset = "0x2CA9BD0", VA = "0x2CA9BD0")]
    public void SortieTroops(int playerId, int troopId)
    {
    }

    [Token(Token = "0x6018E8D")]
    [Address(RVA = "0x2CA78F8", Offset = "0x2CA78F8", VA = "0x2CA78F8")]
    private Stack<GridData> CreateRouteGrids(
      UnitParameterData targetUnit,
      GridData fromGrid,
      GridData toGrid,
      int moveAmount)
    {
      return (Stack<GridData>) null;
    }

    [Token(Token = "0x6018E8E")]
    [Address(RVA = "0x2CA84E0", Offset = "0x2CA84E0", VA = "0x2CA84E0")]
    private AttackTypeEnum GetAttackType(UnitParameterData param, SkillParameterData skill)
    {
      return new AttackTypeEnum();
    }

    [Token(Token = "0x6018E8F")]
    [Address(RVA = "0x2CA8540", Offset = "0x2CA8540", VA = "0x2CA8540")]
    private ElementTypeEnum GetElementType(UnitParameterData param, SkillParameterData skill)
    {
      return new ElementTypeEnum();
    }

    [Token(Token = "0x6018E90")]
    [Address(RVA = "0x2CA9BEC", Offset = "0x2CA9BEC", VA = "0x2CA9BEC")]
    public bool GetBattleAdvAutoSetting() => new bool();

    [Token(Token = "0x2003DF2")]
    private struct ReserveMoveUnitData
    {
      [Token(Token = "0x4010F83")]
      [FieldOffset(Offset = "0x0")]
      public UnitParameterData param;
      [Token(Token = "0x4010F84")]
      [FieldOffset(Offset = "0x8")]
      public Vector2Int coord;
    }
  }
}
