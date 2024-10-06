// Decompiled with JetBrains decompiler
// Type: ADV2.PsBattleAdv.PsBattleAdvMain
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.LuaScript;
using ADV2.PsBattleAdv.Data;
using Battle.Data.Board;
using Battle.Process;
using Battle.Staging;
using Battle.Unit;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace ADV2.PsBattleAdv
{
  [Token(Token = "0x2003E7B")]
  public class PsBattleAdvMain : MonoBehaviour, IProcessOwner<ProcessCode>
  {
    [Token(Token = "0x4011216")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PsBattleAdvMainDirector mainDirector;
    [Token(Token = "0x4011217")]
    [FieldOffset(Offset = "0x20")]
    private PsBattleAdvData battleData;
    [Token(Token = "0x4011218")]
    [FieldOffset(Offset = "0x28")]
    private BoardData boardData;
    [Token(Token = "0x4011219")]
    [FieldOffset(Offset = "0x30")]
    private BattleCore battleCore;
    [Token(Token = "0x401121A")]
    [FieldOffset(Offset = "0x38")]
    public IBattleProcessFactory processFactory;
    [Token(Token = "0x401121B")]
    [FieldOffset(Offset = "0x40")]
    private BattleProcessBase process;
    [Token(Token = "0x401121C")]
    [FieldOffset(Offset = "0x48")]
    private ProcessCode nextProcess;
    [Token(Token = "0x401121D")]
    [FieldOffset(Offset = "0x4C")]
    private bool initialized;
    [Token(Token = "0x401121E")]
    [FieldOffset(Offset = "0x50")]
    private int allyId;
    [Token(Token = "0x401121F")]
    [FieldOffset(Offset = "0x54")]
    private int enemyId;
    [Token(Token = "0x4011220")]
    [FieldOffset(Offset = "0x58")]
    private int facilityPlacementId;

    [Token(Token = "0x170051A2")]
    public Camera mapcamera
    {
      [Token(Token = "0x6019255"), Address(RVA = "0x2CFA470", Offset = "0x2CFA470", VA = "0x2CFA470")] get
      {
        return (Camera) null;
      }
      [Token(Token = "0x6019256"), Address(RVA = "0x2CFA478", Offset = "0x2CFA478", VA = "0x2CFA478")] private set
      {
      }
    }

    [Token(Token = "0x6019257")]
    [Address(RVA = "0x2CFA480", Offset = "0x2CFA480", VA = "0x2CFA480", Slot = "4")]
    public void OnFinishProcess(ProcessCode code)
    {
    }

    [Token(Token = "0x6019258")]
    [Address(RVA = "0x2CFA490", Offset = "0x2CFA490", VA = "0x2CFA490")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x6019259")]
    [Address(RVA = "0x2CF9C48", Offset = "0x2CF9C48", VA = "0x2CF9C48")]
    public void setCamera(Camera camera)
    {
    }

    [Token(Token = "0x601925A")]
    [Address(RVA = "0x2CFA5C0", Offset = "0x2CFA5C0", VA = "0x2CFA5C0")]
    public Adv2Manager.OnProccessSignal CreateStage(string mapname, string mapdata)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x601925B")]
    [Address(RVA = "0x2CFAD0C", Offset = "0x2CFAD0C", VA = "0x2CFAD0C")]
    private void InitTimeAndWeather()
    {
    }

    [Token(Token = "0x601925C")]
    [Address(RVA = "0x2CFADFC", Offset = "0x2CFADFC", VA = "0x2CFADFC")]
    public void ChangeTimeAndWeather(int timeslot, int weather)
    {
    }

    [Token(Token = "0x601925D")]
    [Address(RVA = "0x2CFAF94", Offset = "0x2CFAF94", VA = "0x2CFAF94")]
    public Adv2Manager.OnProccessSignal SetUpCompleteUnit() => (Adv2Manager.OnProccessSignal) null;

    [Token(Token = "0x601925E")]
    [Address(RVA = "0x2CFB030", Offset = "0x2CFB030", VA = "0x2CFB030")]
    public void DispSilhouette(bool BGOccludeDotDisplay)
    {
    }

    [Token(Token = "0x601925F")]
    [Address(RVA = "0x2CFB108", Offset = "0x2CFB108", VA = "0x2CFB108")]
    public int ReserveAlly(int styleId, int x, int y, int layer) => new int();

    [Token(Token = "0x6019260")]
    [Address(RVA = "0x2CFB29C", Offset = "0x2CFB29C", VA = "0x2CFB29C")]
    public void SetWeapon(int id, int weaponId)
    {
    }

    [Token(Token = "0x6019261")]
    [Address(RVA = "0x2CFB408", Offset = "0x2CFB408", VA = "0x2CFB408")]
    public void ReserveParticle(string fileName)
    {
    }

    [Token(Token = "0x6019262")]
    [Address(RVA = "0x2CFB4EC", Offset = "0x2CFB4EC", VA = "0x2CFB4EC")]
    public int ReserveEnemy(int unitId, int x, int y, int layer) => new int();

    [Token(Token = "0x6019263")]
    [Address(RVA = "0x2CFB610", Offset = "0x2CFB610", VA = "0x2CFB610")]
    public int ReserveFacility(
      int facilityId,
      int x,
      int y,
      int dir,
      int groupId,
      bool defaultSwitch)
    {
      return new int();
    }

    [Token(Token = "0x6019264")]
    [Address(RVA = "0x2CFB748", Offset = "0x2CFB748", VA = "0x2CFB748")]
    public int GetBattleTurn() => new int();

    [Token(Token = "0x6019265")]
    [Address(RVA = "0x2CFB764", Offset = "0x2CFB764", VA = "0x2CFB764")]
    public void ChangeCameraDistance(float dist, float duration)
    {
    }

    [Token(Token = "0x6019266")]
    [Address(RVA = "0x2CFB830", Offset = "0x2CFB830", VA = "0x2CFB830")]
    public void ChangeCameraAngle(float angle, float duration)
    {
    }

    [Token(Token = "0x6019267")]
    [Address(RVA = "0x2CFB904", Offset = "0x2CFB904", VA = "0x2CFB904")]
    public void MoveCamera(int x, int y, float duration)
    {
    }

    [Token(Token = "0x6019268")]
    [Address(RVA = "0x2CFBA00", Offset = "0x2CFBA00", VA = "0x2CFBA00")]
    public LuaSignalMini ShakeCamera(float volume, float count, float duration)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x6019269")]
    [Address(RVA = "0x2CFBB5C", Offset = "0x2CFBB5C", VA = "0x2CFBB5C")]
    private IEnumerator ShakeCameraCo(float volume, float count, float duration, Action callback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601926A")]
    [Address(RVA = "0x2CFBC20", Offset = "0x2CFBC20", VA = "0x2CFBC20")]
    public bool isCameraBusy() => new bool();

    [Token(Token = "0x601926B")]
    [Address(RVA = "0x2CFBCD4", Offset = "0x2CFBCD4", VA = "0x2CFBCD4")]
    public void SwitchGridVisible()
    {
    }

    [Token(Token = "0x601926C")]
    [Address(RVA = "0x2CFBCEC", Offset = "0x2CFBCEC", VA = "0x2CFBCEC")]
    public void Hide()
    {
    }

    [Token(Token = "0x601926D")]
    [Address(RVA = "0x2CFBD14", Offset = "0x2CFBD14", VA = "0x2CFBD14")]
    public void Dispose()
    {
    }

    [Token(Token = "0x601926E")]
    [Address(RVA = "0x2CFBE74", Offset = "0x2CFBE74", VA = "0x2CFBE74")]
    public void ChangeUnitDir(int id, int dir)
    {
    }

    [Token(Token = "0x601926F")]
    [Address(RVA = "0x2CFC0B4", Offset = "0x2CFC0B4", VA = "0x2CFC0B4")]
    public void ChangeAnim(int id, int anim)
    {
    }

    [Token(Token = "0x6019270")]
    [Address(RVA = "0x2CFC424", Offset = "0x2CFC424", VA = "0x2CFC424")]
    public void ChangeAnimSpeed(int id, float speed)
    {
    }

    [Token(Token = "0x6019271")]
    [Address(RVA = "0x2CFC4F8", Offset = "0x2CFC4F8", VA = "0x2CFC4F8")]
    public void ChangeLayer(int id, int layer)
    {
    }

    [Token(Token = "0x6019272")]
    [Address(RVA = "0x2CFC5BC", Offset = "0x2CFC5BC", VA = "0x2CFC5BC")]
    public void DispWeapon(int id, bool active)
    {
    }

    [Token(Token = "0x6019273")]
    [Address(RVA = "0x2CFC740", Offset = "0x2CFC740", VA = "0x2CFC740")]
    public void DispUnit(int id, bool active, float duration)
    {
    }

    [Token(Token = "0x6019274")]
    [Address(RVA = "0x2CFC95C", Offset = "0x2CFC95C", VA = "0x2CFC95C")]
    public void DispFacility(int id, bool active)
    {
    }

    [Token(Token = "0x6019275")]
    [Address(RVA = "0x2CFCA20", Offset = "0x2CFCA20", VA = "0x2CFCA20")]
    public void DoubleUnit(int id, int backId)
    {
    }

    [Token(Token = "0x6019276")]
    [Address(RVA = "0x2CFCB6C", Offset = "0x2CFCB6C", VA = "0x2CFCB6C")]
    public void MoveUnitSeq(int id, int x, int y, float speed)
    {
    }

    [Token(Token = "0x6019277")]
    [Address(RVA = "0x2CFCE20", Offset = "0x2CFCE20", VA = "0x2CFCE20")]
    public void DyingUnitSeq(int id)
    {
    }

    [Token(Token = "0x6019278")]
    [Address(RVA = "0x2CFCF7C", Offset = "0x2CFCF7C", VA = "0x2CFCF7C")]
    public void DodgeUnitSeq(int id)
    {
    }

    [Token(Token = "0x6019279")]
    [Address(RVA = "0x2CFCFC0", Offset = "0x2CFCFC0", VA = "0x2CFCFC0")]
    private void RemoveDiedUnit(UnitParameterData unit)
    {
    }

    [Token(Token = "0x601927A")]
    [Address(RVA = "0x2CFD198", Offset = "0x2CFD198", VA = "0x2CFD198")]
    public void ReserveMoveUnit(int id, int x, int y, float speed)
    {
    }

    [Token(Token = "0x601927B")]
    [Address(RVA = "0x2CFD358", Offset = "0x2CFD358", VA = "0x2CFD358")]
    public void ExecParallelSeq()
    {
    }

    [Token(Token = "0x601927C")]
    [Address(RVA = "0x2CFD824", Offset = "0x2CFD824", VA = "0x2CFD824")]
    public void PlaceUnit(int id, int x, int y)
    {
    }

    [Token(Token = "0x601927D")]
    [Address(RVA = "0x2CFDC18", Offset = "0x2CFDC18", VA = "0x2CFDC18")]
    public void RemoveUnit(int id)
    {
    }

    [Token(Token = "0x601927E")]
    [Address(RVA = "0x2CFDC84", Offset = "0x2CFDC84", VA = "0x2CFDC84")]
    public void ChangeUnit(int id, int changeId, float duration)
    {
    }

    [Token(Token = "0x601927F")]
    [Address(RVA = "0x2CFC8D0", Offset = "0x2CFC8D0", VA = "0x2CFC8D0")]
    private IEnumerator UpdateUnitAlphaCoroutine(
      CharacterActor actor,
      float start,
      float end,
      float duration)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6019280")]
    [Address(RVA = "0x2CFE2CC", Offset = "0x2CFE2CC", VA = "0x2CFE2CC")]
    public Vector3 GetGridPosition(int x, int y) => new Vector3();

    [Token(Token = "0x6019281")]
    [Address(RVA = "0x2CFE318", Offset = "0x2CFE318", VA = "0x2CFE318")]
    public int PlayParticleGrid(string name, int x, int y) => new int();

    [Token(Token = "0x6019282")]
    [Address(RVA = "0x2CFE3D0", Offset = "0x2CFE3D0", VA = "0x2CFE3D0")]
    public int PlayParticleUnit(int id, string name, int locator, bool dir) => new int();

    [Token(Token = "0x6019283")]
    [Address(RVA = "0x2CFE648", Offset = "0x2CFE648", VA = "0x2CFE648")]
    public Vector3 GetUnitLocater(int id, int locator) => new Vector3();

    [Token(Token = "0x6019284")]
    [Address(RVA = "0x2CFE774", Offset = "0x2CFE774", VA = "0x2CFE774")]
    public void StopParticle(int hashcode)
    {
    }

    [Token(Token = "0x6019285")]
    [Address(RVA = "0x2CFE7A0", Offset = "0x2CFE7A0", VA = "0x2CFE7A0")]
    public bool isPlayingParticle(int hashcode) => new bool();

    [Token(Token = "0x6019286")]
    [Address(RVA = "0x2CFE7C4", Offset = "0x2CFE7C4", VA = "0x2CFE7C4")]
    public void ChangeWeapon(int id, int index)
    {
    }

    [Token(Token = "0x6019287")]
    [Address(RVA = "0x2CFE87C", Offset = "0x2CFE87C", VA = "0x2CFE87C")]
    public bool isPlayingAnim(int id) => new bool();

    [Token(Token = "0x6019288")]
    [Address(RVA = "0x2CFE898", Offset = "0x2CFE898", VA = "0x2CFE898")]
    public void NormalAttackUnitSeq(int id, int targetId)
    {
    }

    [Token(Token = "0x6019289")]
    [Address(RVA = "0x2CFEB98", Offset = "0x2CFEB98", VA = "0x2CFEB98")]
    public void DamageUnitSeq(int id, int attackerId, bool critical)
    {
    }

    [Token(Token = "0x601928A")]
    [Address(RVA = "0x2CFEE78", Offset = "0x2CFEE78", VA = "0x2CFEE78")]
    public void HealingUnitSeq(int id)
    {
    }

    [Token(Token = "0x601928B")]
    [Address(RVA = "0x2CFEF10", Offset = "0x2CFEF10", VA = "0x2CFEF10")]
    public void InteractFacility(int groupId)
    {
    }

    [Token(Token = "0x601928C")]
    [Address(RVA = "0x2CFF1AC", Offset = "0x2CFF1AC", VA = "0x2CFF1AC")]
    public LuaSignalMini MoveUnitHeight(int id, float height, float duration, int easing)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x601928D")]
    [Address(RVA = "0x2CFF368", Offset = "0x2CFF368", VA = "0x2CFF368")]
    private IEnumerator MoveUnitHeightCoroutin(
      CharacterActor actor,
      float height,
      float duration,
      int easing,
      Adv2Manager.OnProccessSignal signal)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601928E")]
    [Address(RVA = "0x2CFF424", Offset = "0x2CFF424", VA = "0x2CFF424")]
    public float GetGridHeight(int id, int x, int y) => new float();

    [Token(Token = "0x601928F")]
    [Address(RVA = "0x2CFF584", Offset = "0x2CFF584", VA = "0x2CFF584")]
    public LuaSignalMini MoveUnitKnockBack(int id, int x, int y, float duration, int easing)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x6019290")]
    [Address(RVA = "0x2CFF98C", Offset = "0x2CFF98C", VA = "0x2CFF98C")]
    public LuaSignalMini MoveUnitFly(
      int id,
      int x,
      int y,
      float height,
      float duration,
      int easing)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x6019291")]
    [Address(RVA = "0x2CFF8C4", Offset = "0x2CFF8C4", VA = "0x2CFF8C4")]
    private IEnumerator MoveUnitWorldPositionCoroutin(
      CharacterActor actor,
      Vector3 start,
      Vector3 goal,
      float duration,
      int easing,
      Adv2Manager.OnProccessSignal signal)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6019292")]
    [Address(RVA = "0x2CFFCB8", Offset = "0x2CFFCB8", VA = "0x2CFFCB8")]
    public LuaSignalMini MoveUnit(int id, int x, int y, float speed) => (LuaSignalMini) null;

    [Token(Token = "0x6019293")]
    [Address(RVA = "0x2D00050", Offset = "0x2D00050", VA = "0x2D00050")]
    public LuaSignalMini DamageUnit(int id, int attackerId, bool critical) => (LuaSignalMini) null;

    [Token(Token = "0x6019294")]
    [Address(RVA = "0x2D00290", Offset = "0x2D00290", VA = "0x2D00290")]
    public LuaSignalMini DodgeUnit(int id) => (LuaSignalMini) null;

    [Token(Token = "0x6019295")]
    [Address(RVA = "0x2D00364", Offset = "0x2D00364", VA = "0x2D00364")]
    public LuaSignalMini DyingUnit(int id) => (LuaSignalMini) null;

    [Token(Token = "0x6019296")]
    [Address(RVA = "0x2D00528", Offset = "0x2D00528", VA = "0x2D00528")]
    public LuaSignalMini HealingUnit(int id) => (LuaSignalMini) null;

    [Token(Token = "0x6019297")]
    [Address(RVA = "0x2CFFFDC", Offset = "0x2CFFFDC", VA = "0x2CFFFDC")]
    private IEnumerator SequenceCoroutin(
      StagingDirector.ISequence Sequence,
      Adv2Manager.OnProccessSignal signal)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6019298")]
    [Address(RVA = "0x2D00654", Offset = "0x2D00654", VA = "0x2D00654")]
    public LuaSignalMini NormalAttackUnit(int id, int targetId) => (LuaSignalMini) null;

    [Token(Token = "0x6019299")]
    [Address(RVA = "0x2D00990", Offset = "0x2D00990", VA = "0x2D00990")]
    private IEnumerator NormalAttackSequenceCoroutin(
      StartSkillSequence startSkillSequence,
      CastSkillSequence castSkillSequence,
      Adv2Manager.OnProccessSignal signal)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601929A")]
    [Address(RVA = "0x2CFED68", Offset = "0x2CFED68", VA = "0x2CFED68")]
    private AttackTypeEnum GetAttackType(UnitParameterData param, SkillParameterData skill)
    {
      return new AttackTypeEnum();
    }

    [Token(Token = "0x601929B")]
    [Address(RVA = "0x2CFEDC8", Offset = "0x2CFEDC8", VA = "0x2CFEDC8")]
    private ElementTypeEnum GetElementType(UnitParameterData param, SkillParameterData skill)
    {
      return new ElementTypeEnum();
    }

    [Token(Token = "0x601929C")]
    [Address(RVA = "0x2D00A34", Offset = "0x2D00A34", VA = "0x2D00A34")]
    public bool isPlayingStaging() => new bool();

    [Token(Token = "0x601929D")]
    [Address(RVA = "0x2CFBFF4", Offset = "0x2CFBFF4", VA = "0x2CFBFF4")]
    private CharacterActor GetCharacterActor(int id) => (CharacterActor) null;

    [Token(Token = "0x601929E")]
    [Address(RVA = "0x2D00A58", Offset = "0x2D00A58", VA = "0x2D00A58")]
    public PsBattleAdvMain()
    {
    }

    [Token(Token = "0x601929F")]
    [Address(RVA = "0x2D00A74", Offset = "0x2D00A74", VA = "0x2D00A74", Slot = "5")]
    private Coroutine Battle\u002EProcess\u002EIProcessOwner\u003CBattle\u002EProcess\u002EProcessCode\u003E\u002EStartCoroutine(
      IEnumerator routine)
    {
      return (Coroutine) null;
    }

    [Token(Token = "0x60192A0")]
    [Address(RVA = "0x2D00A7C", Offset = "0x2D00A7C", VA = "0x2D00A7C", Slot = "6")]
    private void Battle\u002EProcess\u002EIProcessOwner\u003CBattle\u002EProcess\u002EProcessCode\u003E\u002EStopCoroutine(
      IEnumerator routine)
    {
    }
  }
}
