// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaPsBattleAdv
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.PsBattleAdv;
using Il2CppDummyDll;
using MoonSharp.Interpreter;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EC5")]
  [MoonSharpUserData]
  public class LuaPsBattleAdv : LuaSignal
  {
    [Token(Token = "0x4011354")]
    [FieldOffset(Offset = "0x18")]
    protected PsBattleAdvMain advObject;

    [Token(Token = "0x170051DF")]
    public PsBattleAdvMain Instance
    {
      [Token(Token = "0x60194D3"), Address(RVA = "0x2FF74C4", Offset = "0x2FF74C4", VA = "0x2FF74C4")] get
      {
        return (PsBattleAdvMain) null;
      }
    }

    [Token(Token = "0x60194D4")]
    [Address(RVA = "0x2FF74CC", Offset = "0x2FF74CC", VA = "0x2FF74CC")]
    public LuaPsBattleAdv(PsBattleAdvMain instance)
    {
    }

    [Token(Token = "0x60194D5")]
    [Address(RVA = "0x2FF74F4", Offset = "0x2FF74F4", VA = "0x2FF74F4")]
    public void CreateStage(string mapname, string mapdata)
    {
    }

    [Token(Token = "0x60194D6")]
    [Address(RVA = "0x2FF7524", Offset = "0x2FF7524", VA = "0x2FF7524")]
    public void ChangeTimeAndWeather(int timeslot, int weather)
    {
    }

    [Token(Token = "0x60194D7")]
    [Address(RVA = "0x2FF7540", Offset = "0x2FF7540", VA = "0x2FF7540")]
    public void SetUpCompleteUnit()
    {
    }

    [Token(Token = "0x60194D8")]
    [Address(RVA = "0x2FF7570", Offset = "0x2FF7570", VA = "0x2FF7570")]
    public void DispSilhouette(bool BGOccludeDotDisplay)
    {
    }

    [Token(Token = "0x60194D9")]
    [Address(RVA = "0x2FF7590", Offset = "0x2FF7590", VA = "0x2FF7590")]
    public int ReserveAlly(int styleId, int x, int y, int layer) => new int();

    [Token(Token = "0x60194DA")]
    [Address(RVA = "0x2FF75AC", Offset = "0x2FF75AC", VA = "0x2FF75AC")]
    public void SetWeapon(int id, int weaponId)
    {
    }

    [Token(Token = "0x60194DB")]
    [Address(RVA = "0x2FF75C8", Offset = "0x2FF75C8", VA = "0x2FF75C8")]
    public void ReserveParticle(string fileName)
    {
    }

    [Token(Token = "0x60194DC")]
    [Address(RVA = "0x2FF75E4", Offset = "0x2FF75E4", VA = "0x2FF75E4")]
    public int ReserveEnemy(int unitId, int x, int y, int layer) => new int();

    [Token(Token = "0x60194DD")]
    [Address(RVA = "0x2FF7600", Offset = "0x2FF7600", VA = "0x2FF7600")]
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

    [Token(Token = "0x60194DE")]
    [Address(RVA = "0x2FF7620", Offset = "0x2FF7620", VA = "0x2FF7620")]
    public void ChangeCameraDistance(float dist, float duration)
    {
    }

    [Token(Token = "0x60194DF")]
    [Address(RVA = "0x2FF763C", Offset = "0x2FF763C", VA = "0x2FF763C")]
    public void ChangeCameraAngle(float angle, float duration)
    {
    }

    [Token(Token = "0x60194E0")]
    [Address(RVA = "0x2FF7658", Offset = "0x2FF7658", VA = "0x2FF7658")]
    public void MoveCamera(int x, int y, float duration)
    {
    }

    [Token(Token = "0x60194E1")]
    [Address(RVA = "0x2FF7674", Offset = "0x2FF7674", VA = "0x2FF7674")]
    public bool isCameraBusy() => new bool();

    [Token(Token = "0x60194E2")]
    [Address(RVA = "0x2FF7690", Offset = "0x2FF7690", VA = "0x2FF7690")]
    public void ChangeUnitDir(int id, int dir)
    {
    }

    [Token(Token = "0x60194E3")]
    [Address(RVA = "0x2FF76AC", Offset = "0x2FF76AC", VA = "0x2FF76AC")]
    public void ChangeAnim(int id, int anim)
    {
    }

    [Token(Token = "0x60194E4")]
    [Address(RVA = "0x2FF76C8", Offset = "0x2FF76C8", VA = "0x2FF76C8")]
    public void ChangeAnimSpeed(int id, float speed)
    {
    }

    [Token(Token = "0x60194E5")]
    [Address(RVA = "0x2FF76E4", Offset = "0x2FF76E4", VA = "0x2FF76E4")]
    public void ChangeLayer(int id, int layer)
    {
    }

    [Token(Token = "0x60194E6")]
    [Address(RVA = "0x2FF7700", Offset = "0x2FF7700", VA = "0x2FF7700")]
    public void DispWeapon(int id, bool active)
    {
    }

    [Token(Token = "0x60194E7")]
    [Address(RVA = "0x2FF7720", Offset = "0x2FF7720", VA = "0x2FF7720")]
    public void DispUnit(int id, bool active, float duration)
    {
    }

    [Token(Token = "0x60194E8")]
    [Address(RVA = "0x2FF7740", Offset = "0x2FF7740", VA = "0x2FF7740")]
    public void DispFacility(int id, bool active)
    {
    }

    [Token(Token = "0x60194E9")]
    [Address(RVA = "0x2FF7760", Offset = "0x2FF7760", VA = "0x2FF7760")]
    public void DoubleUnit(int id, int backId)
    {
    }

    [Token(Token = "0x60194EA")]
    [Address(RVA = "0x2FF777C", Offset = "0x2FF777C", VA = "0x2FF777C")]
    public void MoveUnitSeq(int id, int x, int y, float speed)
    {
    }

    [Token(Token = "0x60194EB")]
    [Address(RVA = "0x2FF7798", Offset = "0x2FF7798", VA = "0x2FF7798")]
    public void DyingUnitSeq(int id)
    {
    }

    [Token(Token = "0x60194EC")]
    [Address(RVA = "0x2FF77B4", Offset = "0x2FF77B4", VA = "0x2FF77B4")]
    public void DodgeUnitSeq(int id)
    {
    }

    [Token(Token = "0x60194ED")]
    [Address(RVA = "0x2FF77D0", Offset = "0x2FF77D0", VA = "0x2FF77D0")]
    public void ReserveMoveUnit(int id, int x, int y, float speed)
    {
    }

    [Token(Token = "0x60194EE")]
    [Address(RVA = "0x2FF77EC", Offset = "0x2FF77EC", VA = "0x2FF77EC")]
    public void ExecParallelSeq()
    {
    }

    [Token(Token = "0x60194EF")]
    [Address(RVA = "0x2FF7808", Offset = "0x2FF7808", VA = "0x2FF7808")]
    public void PlaceUnit(int id, int x, int y)
    {
    }

    [Token(Token = "0x60194F0")]
    [Address(RVA = "0x2FF7824", Offset = "0x2FF7824", VA = "0x2FF7824")]
    public void RemoveUnit(int id)
    {
    }

    [Token(Token = "0x60194F1")]
    [Address(RVA = "0x2FF7840", Offset = "0x2FF7840", VA = "0x2FF7840")]
    public void ChangeUnit(int id, int changeId, float duration)
    {
    }

    [Token(Token = "0x60194F2")]
    [Address(RVA = "0x2FF785C", Offset = "0x2FF785C", VA = "0x2FF785C")]
    public DynValue GetGridPosition(int x, int y) => (DynValue) null;

    [Token(Token = "0x60194F3")]
    [Address(RVA = "0x2FF7948", Offset = "0x2FF7948", VA = "0x2FF7948")]
    public int PlayParticleGrid(string name, int x, int y) => new int();

    [Token(Token = "0x60194F4")]
    [Address(RVA = "0x2FF7964", Offset = "0x2FF7964", VA = "0x2FF7964")]
    public int PlayParticleUnit(int id, string name, int locator, bool dir) => new int();

    [Token(Token = "0x60194F5")]
    [Address(RVA = "0x2FF7984", Offset = "0x2FF7984", VA = "0x2FF7984")]
    public DynValue GetUnitLocator(int id, int locator) => (DynValue) null;

    [Token(Token = "0x60194F6")]
    [Address(RVA = "0x2FF7A70", Offset = "0x2FF7A70", VA = "0x2FF7A70")]
    public void StopParticle(int hashcode)
    {
    }

    [Token(Token = "0x60194F7")]
    [Address(RVA = "0x2FF7A8C", Offset = "0x2FF7A8C", VA = "0x2FF7A8C")]
    public bool isPlayingParticle(int hashcode) => new bool();

    [Token(Token = "0x60194F8")]
    [Address(RVA = "0x2FF7AA8", Offset = "0x2FF7AA8", VA = "0x2FF7AA8")]
    public void ChangeWeapon(int id, int index)
    {
    }

    [Token(Token = "0x60194F9")]
    [Address(RVA = "0x2FF7AC4", Offset = "0x2FF7AC4", VA = "0x2FF7AC4")]
    public bool isPlayingAnim(int id) => new bool();

    [Token(Token = "0x60194FA")]
    [Address(RVA = "0x2FF7AE0", Offset = "0x2FF7AE0", VA = "0x2FF7AE0")]
    public void NormalAttackUnitSeq(int id, int targetId)
    {
    }

    [Token(Token = "0x60194FB")]
    [Address(RVA = "0x2FF7AFC", Offset = "0x2FF7AFC", VA = "0x2FF7AFC")]
    public void DamageUnitSeq(int id, int attackerId, bool critical)
    {
    }

    [Token(Token = "0x60194FC")]
    [Address(RVA = "0x2FF7B1C", Offset = "0x2FF7B1C", VA = "0x2FF7B1C")]
    public void HealingUnitSeq(int id)
    {
    }

    [Token(Token = "0x60194FD")]
    [Address(RVA = "0x2FF7B38", Offset = "0x2FF7B38", VA = "0x2FF7B38")]
    public void InteractFacility(int groupId)
    {
    }

    [Token(Token = "0x60194FE")]
    [Address(RVA = "0x2FF7B54", Offset = "0x2FF7B54", VA = "0x2FF7B54")]
    public LuaSignalMini MoveUnitHeight(int id, float height, float duration, int easing)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x60194FF")]
    [Address(RVA = "0x2FF7B70", Offset = "0x2FF7B70", VA = "0x2FF7B70")]
    public LuaSignalMini ShakeCamera(float volume, float count, float duration)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x6019500")]
    [Address(RVA = "0x2FF7B8C", Offset = "0x2FF7B8C", VA = "0x2FF7B8C")]
    public float GetGridHeight(int id, int x, int y) => new float();

    [Token(Token = "0x6019501")]
    [Address(RVA = "0x2FF7BA8", Offset = "0x2FF7BA8", VA = "0x2FF7BA8")]
    public LuaSignalMini MoveUnitKnockBack(int id, int x, int y, float duration, int easing)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x6019502")]
    [Address(RVA = "0x2FF7BC4", Offset = "0x2FF7BC4", VA = "0x2FF7BC4")]
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

    [Token(Token = "0x6019503")]
    [Address(RVA = "0x2FF7BE0", Offset = "0x2FF7BE0", VA = "0x2FF7BE0")]
    public LuaSignalMini MoveUnit(int id, int x, int y, float speed) => (LuaSignalMini) null;

    [Token(Token = "0x6019504")]
    [Address(RVA = "0x2FF7BFC", Offset = "0x2FF7BFC", VA = "0x2FF7BFC")]
    public LuaSignalMini DamageUnit(int id, int attackerId, bool critical) => (LuaSignalMini) null;

    [Token(Token = "0x6019505")]
    [Address(RVA = "0x2FF7C1C", Offset = "0x2FF7C1C", VA = "0x2FF7C1C")]
    public LuaSignalMini DodgeUnit(int id) => (LuaSignalMini) null;

    [Token(Token = "0x6019506")]
    [Address(RVA = "0x2FF7C38", Offset = "0x2FF7C38", VA = "0x2FF7C38")]
    public LuaSignalMini DyingUnit(int id) => (LuaSignalMini) null;

    [Token(Token = "0x6019507")]
    [Address(RVA = "0x2FF7C54", Offset = "0x2FF7C54", VA = "0x2FF7C54")]
    public LuaSignalMini HealingUnit(int id) => (LuaSignalMini) null;

    [Token(Token = "0x6019508")]
    [Address(RVA = "0x2FF7C70", Offset = "0x2FF7C70", VA = "0x2FF7C70")]
    public LuaSignalMini NormalAttackUnit(int id, int targetId) => (LuaSignalMini) null;

    [Token(Token = "0x6019509")]
    [Address(RVA = "0x2FF7C8C", Offset = "0x2FF7C8C", VA = "0x2FF7C8C")]
    public bool isPlayingStaging() => new bool();
  }
}
