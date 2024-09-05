// Decompiled with JetBrains decompiler
// Type: Battle.Process.BattleCore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.PsBattleAdv.Data;
using Battle.Command;
using Battle.Data;
using Battle.Data.Board;
using Battle.DuelScene;
using Battle.Expedition.Data;
using Battle.Logic;
using Battle.Stage;
using Cysharp.Threading.Tasks;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x200262E")]
  public class BattleCore
  {
    [Token(Token = "0x400A40F")]
    [FieldOffset(Offset = "0x10")]
    public bool IsResume;
    [Token(Token = "0x400A410")]
    [FieldOffset(Offset = "0x14")]
    public BattleResult BattleResult;
    [Token(Token = "0x400A415")]
    [FieldOffset(Offset = "0x38")]
    protected BattleDecision battleDecision;
    [Token(Token = "0x400A418")]
    [FieldOffset(Offset = "0x50")]
    protected BattleLevelUpProcessor lvUpProcess;
    [Token(Token = "0x400A419")]
    [FieldOffset(Offset = "0x58")]
    protected BattleSupportValueProcessor supportValueProcess;
    [Token(Token = "0x400A41A")]
    [FieldOffset(Offset = "0x60")]
    protected BattleWeaponProficiencyProcessor weaponProficiencyProcess;
    [Token(Token = "0x400A41B")]
    [FieldOffset(Offset = "0x68")]
    protected BattleAdvProcessor advProcess;
    [Token(Token = "0x400A41C")]
    [FieldOffset(Offset = "0x70")]
    protected BattleSortieProcessor reinforceProcess;
    [Token(Token = "0x400A41D")]
    [FieldOffset(Offset = "0x78")]
    protected IRollbackProcessor rollbackProcess;
    [Token(Token = "0x400A41E")]
    [FieldOffset(Offset = "0x80")]
    protected BattleLogProcessor battleLogProcess;
    [Token(Token = "0x400A41F")]
    [FieldOffset(Offset = "0x88")]
    protected BattleSuspendSave suspendSave;
    [Token(Token = "0x400A420")]
    [FieldOffset(Offset = "0x90")]
    public BattleTaskManager TaskManager;

    [Token(Token = "0x17003257")]
    public BattleConfigData BattleConfig
    {
      [Token(Token = "0x600EC46"), Address(RVA = "0x4483090", Offset = "0x4483090", VA = "0x4483090")] get
      {
        return (BattleConfigData) null;
      }
      [Token(Token = "0x600EC47"), Address(RVA = "0x4483098", Offset = "0x4483098", VA = "0x4483098")] private set
      {
      }
    }

    [Token(Token = "0x17003258")]
    public BoardData BoardData
    {
      [Token(Token = "0x600EC48"), Address(RVA = "0x44830A0", Offset = "0x44830A0", VA = "0x44830A0")] get
      {
        return (BoardData) null;
      }
      [Token(Token = "0x600EC49"), Address(RVA = "0x44830A8", Offset = "0x44830A8", VA = "0x44830A8")] private set
      {
      }
    }

    [Token(Token = "0x17003259")]
    public IDirector MainDirector
    {
      [Token(Token = "0x600EC4A"), Address(RVA = "0x44830B0", Offset = "0x44830B0", VA = "0x44830B0")] get
      {
        return (IDirector) null;
      }
      [Token(Token = "0x600EC4B"), Address(RVA = "0x44830B8", Offset = "0x44830B8", VA = "0x44830B8")] private set
      {
      }
    }

    [Token(Token = "0x1700325A")]
    public BattleStage BattleStage
    {
      [Token(Token = "0x600EC4C"), Address(RVA = "0x44830C0", Offset = "0x44830C0", VA = "0x44830C0")] get
      {
        return (BattleStage) null;
      }
      [Token(Token = "0x600EC4D"), Address(RVA = "0x44830C8", Offset = "0x44830C8", VA = "0x44830C8")] set
      {
      }
    }

    [Token(Token = "0x1700325B")]
    public DangerAreaViewProcessor DangerAreaView
    {
      [Token(Token = "0x600EC4E"), Address(RVA = "0x44830D0", Offset = "0x44830D0", VA = "0x44830D0")] get
      {
        return (DangerAreaViewProcessor) null;
      }
      [Token(Token = "0x600EC4F"), Address(RVA = "0x44830D8", Offset = "0x44830D8", VA = "0x44830D8")] private set
      {
      }
    }

    [Token(Token = "0x1700325C")]
    public AIScript AiScript
    {
      [Token(Token = "0x600EC50"), Address(RVA = "0x44830E0", Offset = "0x44830E0", VA = "0x44830E0")] get
      {
        return (AIScript) null;
      }
      [Token(Token = "0x600EC51"), Address(RVA = "0x44830E8", Offset = "0x44830E8", VA = "0x44830E8")] private set
      {
      }
    }

    [Token(Token = "0x1700325D")]
    public bool IsAdvAuto
    {
      [Token(Token = "0x600EC52"), Address(RVA = "0x44830F0", Offset = "0x44830F0", VA = "0x44830F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600EC53")]
    [Address(RVA = "0x4483124", Offset = "0x4483124", VA = "0x4483124")]
    public static BattleCore CreateForStory(
      StoryBattleConfig config,
      BoardData boardData,
      IDirector mainDirector,
      MonoBehaviour coroutineOwner,
      bool isResume)
    {
      return (BattleCore) null;
    }

    [Token(Token = "0x600EC54")]
    [Address(RVA = "0x44834E8", Offset = "0x44834E8", VA = "0x44834E8")]
    public static BattleCore CreateForEvent(
      StoryBattleConfig config,
      BoardData boardData,
      IDirector mainDirector,
      MonoBehaviour coroutineOwner,
      bool isResume)
    {
      return (BattleCore) null;
    }

    [Token(Token = "0x600EC55")]
    [Address(RVA = "0x4483758", Offset = "0x4483758", VA = "0x4483758")]
    public static BattleCore CreateForExpedition(
      ExpeditionBattleData battleData,
      BoardData boardData,
      IDirector mainDirector,
      MonoBehaviour coroutineOwner)
    {
      return (BattleCore) null;
    }

    [Token(Token = "0x600EC56")]
    [Address(RVA = "0x4483830", Offset = "0x4483830", VA = "0x4483830")]
    public static BattleCore CreateForPsBattleAdv(
      PsBattleAdvData battleData,
      BoardData boardData,
      IDirector mainDirector,
      MonoBehaviour coroutineOwner)
    {
      return (BattleCore) null;
    }

    [Token(Token = "0x600EC57")]
    [Address(RVA = "0x44838A8", Offset = "0x44838A8", VA = "0x44838A8")]
    public static BattleCore CreateForArena(
      ArenaBattleConfig config,
      BoardData boardData,
      IDirector mainDirector,
      MonoBehaviour coroutineOwner)
    {
      return (BattleCore) null;
    }

    [Token(Token = "0x600EC58")]
    [Address(RVA = "0x44839B4", Offset = "0x44839B4", VA = "0x44839B4")]
    private BattleCore()
    {
    }

    [Token(Token = "0x600EC59")]
    [Address(RVA = "0x4483450", Offset = "0x4483450", VA = "0x4483450")]
    private BattleCore(BattleConfigData battleConfig, BoardData boardData, IDirector mainDirector)
    {
    }

    [Token(Token = "0x600EC5A")]
    [Address(RVA = "0x4483A24", Offset = "0x4483A24", VA = "0x4483A24")]
    public void ResumeSubProcess()
    {
    }

    [Token(Token = "0x600EC5B")]
    [Address(RVA = "0x4482D70", Offset = "0x4482D70", VA = "0x4482D70")]
    public void ApplyBoard(BoardData boardData)
    {
    }

    [Token(Token = "0x600EC5C")]
    [Address(RVA = "0x4483A94", Offset = "0x4483A94", VA = "0x4483A94")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600EC5D")]
    [Address(RVA = "0x4483B3C", Offset = "0x4483B3C", VA = "0x4483B3C")]
    public void SaveBoard(PhaseCode resumePhase, Queue<UnitCommandBase> commands = null)
    {
    }

    [Token(Token = "0x1700325E")]
    public List<BoardData> BackupBoard
    {
      [Token(Token = "0x600EC5E"), Address(RVA = "0x4483BA4", Offset = "0x4483BA4", VA = "0x4483BA4")] get
      {
        return (List<BoardData>) null;
      }
    }

    [Token(Token = "0x1700325F")]
    public int RollbackCount
    {
      [Token(Token = "0x600EC5F"), Address(RVA = "0x4483C98", Offset = "0x4483C98", VA = "0x4483C98")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600EC60")]
    [Address(RVA = "0x4483D48", Offset = "0x4483D48", VA = "0x4483D48")]
    public void BackupCurrentBoard(Queue<UnitCommandBase> executedCommand = null)
    {
    }

    [Token(Token = "0x600EC61")]
    [Address(RVA = "0x4483DFC", Offset = "0x4483DFC", VA = "0x4483DFC")]
    public void RollbackBoard(int index)
    {
    }

    [Token(Token = "0x600EC62")]
    [Address(RVA = "0x4484164", Offset = "0x4484164", VA = "0x4484164")]
    public void RollbackOne()
    {
    }

    [Token(Token = "0x600EC63")]
    [Address(RVA = "0x44844C4", Offset = "0x44844C4", VA = "0x44844C4")]
    public void PreviewRollback(int index)
    {
    }

    [Token(Token = "0x600EC64")]
    [Address(RVA = "0x4484578", Offset = "0x4484578", VA = "0x4484578")]
    public bool NeedRollbackResume() => new bool();

    [Token(Token = "0x600EC65")]
    [Address(RVA = "0x4484644", Offset = "0x4484644", VA = "0x4484644")]
    public BattlePlayerData GetPlayer(int id) => (BattlePlayerData) null;

    [Token(Token = "0x600EC66")]
    [Address(RVA = "0x4484660", Offset = "0x4484660", VA = "0x4484660")]
    public BattleResult GetBattleResult() => new BattleResult();

    [Token(Token = "0x600EC67")]
    [Address(RVA = "0x4484684", Offset = "0x4484684", VA = "0x4484684")]
    public void UpdateAllUnitBaseParameterOffsets()
    {
    }

    [Token(Token = "0x600EC68")]
    [Address(RVA = "0x4484994", Offset = "0x4484994", VA = "0x4484994")]
    public void UpdateAllUnitActor()
    {
    }

    [Token(Token = "0x600EC69")]
    [Address(RVA = "0x44850F4", Offset = "0x44850F4", VA = "0x44850F4")]
    public void SetAllUnitDefaultAnimation()
    {
    }

    [Token(Token = "0x600EC6A")]
    [Address(RVA = "0x4485488", Offset = "0x4485488", VA = "0x4485488")]
    public void UpdateAllUnitActorByTargetState()
    {
    }

    [Token(Token = "0x600EC6B")]
    [Address(RVA = "0x4482794", Offset = "0x4482794", VA = "0x4482794")]
    public void ResetAllUnitPrediction()
    {
    }

    [Token(Token = "0x600EC6C")]
    [Address(RVA = "0x4482FF4", Offset = "0x4482FF4", VA = "0x4482FF4")]
    public void ChangeEquipWeapon(UnitParameterData unit, int weaponIdx)
    {
    }

    [Token(Token = "0x600EC6D")]
    [Address(RVA = "0x4485EFC", Offset = "0x4485EFC", VA = "0x4485EFC")]
    public void AwakeCommonStack()
    {
    }

    [Token(Token = "0x600EC6E")]
    [Address(RVA = "0x44863B4", Offset = "0x44863B4", VA = "0x44863B4")]
    private void ExecUnitDying(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600EC6F")]
    [Address(RVA = "0x4487060", Offset = "0x4487060", VA = "0x4487060")]
    private void RemoveDiedUnit(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600EC70")]
    [Address(RVA = "0x448772C", Offset = "0x448772C", VA = "0x448772C")]
    private void ExecUnitSwitchNextHP(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600EC71")]
    [Address(RVA = "0x4487A90", Offset = "0x4487A90", VA = "0x4487A90")]
    public void ExecBarrierBreak()
    {
    }

    [Token(Token = "0x600EC72")]
    [Address(RVA = "0x44881D4", Offset = "0x44881D4", VA = "0x44881D4")]
    public void UpdateDangerArea()
    {
    }

    [Token(Token = "0x600EC73")]
    [Address(RVA = "0x4485AA0", Offset = "0x4485AA0", VA = "0x4485AA0")]
    public void ApplyAllUnitPassiveSkillEffectives()
    {
    }

    [Token(Token = "0x600EC74")]
    [Address(RVA = "0x448582C", Offset = "0x448582C", VA = "0x448582C")]
    public void ApplyRemovedWeaponSkillEffectives(
      UnitParameterData unit,
      WeaponParameterData unEquipped)
    {
    }

    [Token(Token = "0x600EC75")]
    [Address(RVA = "0x44881E8", Offset = "0x44881E8", VA = "0x44881E8")]
    public IReadOnlyDictionary<UnitParameterData, IReadOnlyList<SkillParameterData>> SwitchPassiveSkill(
      SkillTriggerTimingTypeEnum timing)
    {
      return (IReadOnlyDictionary<UnitParameterData, IReadOnlyList<SkillParameterData>>) null;
    }

    [Token(Token = "0x600EC76")]
    [Address(RVA = "0x4488554", Offset = "0x4488554", VA = "0x4488554")]
    public List<SkillLogic.EffectedTriggerSkillInfo> IgnitionTriggerSkill(
      SkillTriggerTimingTypeEnum timing)
    {
      return (List<SkillLogic.EffectedTriggerSkillInfo>) null;
    }

    [Token(Token = "0x600EC77")]
    [Address(RVA = "0x4488910", Offset = "0x4488910", VA = "0x4488910")]
    public SkillLogic.EffectedTriggerSkillInfo IgnitionTriggerSkill(
      SkillTriggerTimingTypeEnum timing,
      UnitParameterData unit)
    {
      return (SkillLogic.EffectedTriggerSkillInfo) null;
    }

    [Token(Token = "0x600EC78")]
    [Address(RVA = "0x4485A38", Offset = "0x4485A38", VA = "0x4485A38")]
    public IReadOnlyList<SkillParameterData> SwitchPassiveSkill(
      SkillTriggerTimingTypeEnum timing,
      UnitParameterData unit)
    {
      return (IReadOnlyList<SkillParameterData>) null;
    }

    [Token(Token = "0x600EC79")]
    [Address(RVA = "0x4488AD4", Offset = "0x4488AD4", VA = "0x4488AD4")]
    public void DeactivePassiveSkill(SkillTriggerTimingTypeEnum timing)
    {
    }

    [Token(Token = "0x600EC7A")]
    [Address(RVA = "0x4488DCC", Offset = "0x4488DCC", VA = "0x4488DCC")]
    public void DeactivePassiveSkill(SkillTriggerTimingTypeEnum timing, UnitParameterData unit)
    {
    }

    [Token(Token = "0x600EC7B")]
    [Address(RVA = "0x4488DE4", Offset = "0x4488DE4", VA = "0x4488DE4")]
    public void PlayTriggerSkillIgnition(List<SkillLogic.EffectedTriggerSkillInfo> infos)
    {
    }

    [Token(Token = "0x600EC7C")]
    [Address(RVA = "0x44895C0", Offset = "0x44895C0", VA = "0x44895C0")]
    public void PlayBadStatusDamageEffect(
      UnitParameterData unit,
      UnitParameterChange paramChange,
      Action onComplete = null)
    {
    }

    [Token(Token = "0x600EC7D")]
    [Address(RVA = "0x44896C4", Offset = "0x44896C4", VA = "0x44896C4")]
    public void UpdateSkillEffectCount(EffectiveLengthTypeEnum timing)
    {
    }

    [Token(Token = "0x600EC7E")]
    [Address(RVA = "0x44899B8", Offset = "0x44899B8", VA = "0x44899B8")]
    public void UpdateSkillEffectCount(EffectiveLengthTypeEnum timing, UnitParameterData unit)
    {
    }

    [Token(Token = "0x600EC7F")]
    [Address(RVA = "0x4489C28", Offset = "0x4489C28", VA = "0x4489C28")]
    public void Grow(IEnumerable<UnitCommandBase> commands)
    {
    }

    [Token(Token = "0x600EC80")]
    [Address(RVA = "0x4489FE0", Offset = "0x4489FE0", VA = "0x4489FE0")]
    public void SetManualAction(
      int id,
      LuaActionCommandEnum action,
      int x = 0,
      int y = 0,
      int targetX = 0,
      int targetY = 0,
      int skillIdx = 0,
      int weaponIndex = 0)
    {
    }

    [Token(Token = "0x600EC81")]
    [Address(RVA = "0x448A098", Offset = "0x448A098", VA = "0x448A098")]
    public void ReserveUnitCommand(
      CommandType type,
      int ownerUnitId,
      Vector2Int moveTo,
      Vector2Int targetTo,
      int useSkillIdx,
      bool switchDouble)
    {
    }

    [Token(Token = "0x600EC82")]
    [Address(RVA = "0x448A224", Offset = "0x448A224", VA = "0x448A224")]
    public void ReservePlayableAdv(BattleEventTimingTypeEnum timing)
    {
    }

    [Token(Token = "0x600EC83")]
    [Address(RVA = "0x4486A30", Offset = "0x4486A30", VA = "0x4486A30")]
    public void ReservePlayableAdv(
      BattleEventTimingTypeEnum timing,
      UnitParameterData actionOwner,
      UnitParameterData actionTarget = null)
    {
    }

    [Token(Token = "0x600EC84")]
    [Address(RVA = "0x448A238", Offset = "0x448A238", VA = "0x448A238")]
    public void ReservePlayableAdv(
      BattleEventTimingTypeEnum timing,
      UnitParameterData actionOwner,
      IReadOnlyList<UnitParameterData> actionTargets,
      SkillParameterData useSkill = null)
    {
    }

    [Token(Token = "0x600EC85")]
    [Address(RVA = "0x448A24C", Offset = "0x448A24C", VA = "0x448A24C")]
    public void ReservePlayableAdv(
      BattleEventTimingTypeEnum timing,
      UnitParameterData actionOwner,
      FacilityData facility)
    {
    }

    [Token(Token = "0x600EC86")]
    [Address(RVA = "0x4486B5C", Offset = "0x4486B5C", VA = "0x4486B5C")]
    public void PlayBattleAdv()
    {
    }

    [Token(Token = "0x600EC87")]
    [Address(RVA = "0x448A260", Offset = "0x448A260", VA = "0x448A260")]
    public UniTask SortieTroops(int playerId, int troopId) => new UniTask();

    [Token(Token = "0x600EC88")]
    [Address(RVA = "0x448A3B4", Offset = "0x448A3B4", VA = "0x448A3B4")]
    public void UpdateHate(ActionResult result)
    {
    }

    [Token(Token = "0x600EC89")]
    [Address(RVA = "0x448AD58", Offset = "0x448AD58", VA = "0x448AD58")]
    public void AggregateMissionScore(UnitCommandBase command)
    {
    }

    [Token(Token = "0x600EC8A")]
    [Address(RVA = "0x448ADA8", Offset = "0x448ADA8", VA = "0x448ADA8")]
    public void AggregateMissionScore(UnitParameterData unit, UnitParameterChange paramChange)
    {
    }

    [Token(Token = "0x600EC8B")]
    [Address(RVA = "0x448ADE0", Offset = "0x448ADE0", VA = "0x448ADE0")]
    public void AggregateMissionScoreOnBadStateDamage(
      UnitParameterData unit,
      UnitParameterChange paramChange)
    {
    }

    [Token(Token = "0x600EC8C")]
    [Address(RVA = "0x448AE50", Offset = "0x448AE50", VA = "0x448AE50")]
    public List<BattleLogData> GetBattleLog() => (List<BattleLogData>) null;

    [Token(Token = "0x600EC8D")]
    [Address(RVA = "0x448AE64", Offset = "0x448AE64", VA = "0x448AE64")]
    public BattleLogData GetLastBattleLog() => (BattleLogData) null;

    [Token(Token = "0x600EC8E")]
    [Address(RVA = "0x4487034", Offset = "0x4487034", VA = "0x4487034")]
    public void CreateSystemLog(
      BattleLogTextTypeEnum type,
      int value1 = 0,
      int value2 = 0,
      int value3 = 0,
      int unitId = 0,
      bool isDelay = false)
    {
    }

    [Token(Token = "0x600EC8F")]
    [Address(RVA = "0x4489C14", Offset = "0x4489C14", VA = "0x4489C14")]
    public void CreateClearEffectLog(List<EffectParameterData> removeList, int unitId)
    {
    }

    [Token(Token = "0x600EC90")]
    [Address(RVA = "0x448AE78", Offset = "0x448AE78", VA = "0x448AE78")]
    public void CreateCommandLog(
      Queue<UnitCommandBase> command,
      int value = 0,
      int value2 = 0,
      int value3 = 0,
      int value4 = 0)
    {
    }

    [Token(Token = "0x600EC91")]
    [Address(RVA = "0x448AE8C", Offset = "0x448AE8C", VA = "0x448AE8C")]
    public void CreateEffectLog(
      UnitParameterChange paramChange,
      UnitParameterData unit,
      string name)
    {
    }

    [Token(Token = "0x600EC92")]
    [Address(RVA = "0x448AEA0", Offset = "0x448AEA0", VA = "0x448AEA0")]
    public void CreateTakeBadStatusLog(UnitParameterChange paramChange, UnitParameterData unit)
    {
    }

    [Token(Token = "0x600EC93")]
    [Address(RVA = "0x448AEB4", Offset = "0x448AEB4", VA = "0x448AEB4")]
    public void CreateSortieLog(BattlePlayerData player)
    {
    }

    [Token(Token = "0x600EC94")]
    [Address(RVA = "0x448AEC8", Offset = "0x448AEC8", VA = "0x448AEC8")]
    public void CreateAutoTurretLog(FacilityData turret, IReadOnlyList<ActionData> results)
    {
    }

    [Token(Token = "0x600EC95")]
    [Address(RVA = "0x4489FCC", Offset = "0x4489FCC", VA = "0x4489FCC")]
    public void CreateLevelUpLog(List<BattleExpInfo> expInfos)
    {
    }

    [Token(Token = "0x600EC96")]
    [Address(RVA = "0x4486A18", Offset = "0x4486A18", VA = "0x4486A18")]
    public void CreateDeadLog(
      UnitParameterChange paramChange,
      UnitParameterData unit,
      bool enableLost)
    {
    }

    [Token(Token = "0x600EC97")]
    [Address(RVA = "0x448AEDC", Offset = "0x448AEDC", VA = "0x448AEDC")]
    public void CreateBarrierDamage(UnitParameterData unit, int index, BarrierDamageLogic logic)
    {
    }

    [Token(Token = "0x600EC98")]
    [Address(RVA = "0x448AEF0", Offset = "0x448AEF0", VA = "0x448AEF0")]
    public void CreateRollBackLog(int turnBoardCount, int actionBoardCount, int index)
    {
    }

    [Token(Token = "0x600EC99")]
    [Address(RVA = "0x448AF04", Offset = "0x448AF04", VA = "0x448AF04")]
    public string GetBoardDescription() => (string) null;

    [Token(Token = "0x600EC9A")]
    [Address(RVA = "0x4486998", Offset = "0x4486998", VA = "0x4486998")]
    public void AddSecurityLog(string text)
    {
    }

    [Token(Token = "0x600EC9B")]
    [Address(RVA = "0x448AF64", Offset = "0x448AF64", VA = "0x448AF64")]
    public void AddSecurityLog(Queue<UnitCommandBase> commands)
    {
    }
  }
}
