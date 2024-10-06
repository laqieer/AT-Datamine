// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaBattleAdv
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EA3")]
  [MoonSharpUserData]
  public class LuaBattleAdv : LuaSignal
  {
    [Token(Token = "0x40112E9")]
    [FieldOffset(Offset = "0x18")]
    private ConnectBattleProcessToAdv conectAdv;

    [Token(Token = "0x601936A")]
    [Address(RVA = "0x2D07478", Offset = "0x2D07478", VA = "0x2D07478")]
    public LuaBattleAdv()
    {
    }

    [Token(Token = "0x601936B")]
    [Address(RVA = "0x2D0749C", Offset = "0x2D0749C", VA = "0x2D0749C")]
    public void debugPrint()
    {
    }

    [Token(Token = "0x601936C")]
    [Address(RVA = "0x2D07770", Offset = "0x2D07770", VA = "0x2D07770")]
    public void ChangeCameraDistance(float dist, float duration)
    {
    }

    [Token(Token = "0x601936D")]
    [Address(RVA = "0x2D07784", Offset = "0x2D07784", VA = "0x2D07784")]
    public void ChangeCameraAngle(float angle, float duration)
    {
    }

    [Token(Token = "0x601936E")]
    [Address(RVA = "0x2D07798", Offset = "0x2D07798", VA = "0x2D07798")]
    public void ChangeTimeAndWeather(int timeslot, int weather)
    {
    }

    [Token(Token = "0x601936F")]
    [Address(RVA = "0x2D077AC", Offset = "0x2D077AC", VA = "0x2D077AC")]
    public void MoveCamera(int x, int y, float duration)
    {
    }

    [Token(Token = "0x6019370")]
    [Address(RVA = "0x2D077C0", Offset = "0x2D077C0", VA = "0x2D077C0")]
    public bool isCameraBusy() => new bool();

    [Token(Token = "0x6019371")]
    [Address(RVA = "0x2D077D4", Offset = "0x2D077D4", VA = "0x2D077D4")]
    public void ChangeUnitDir(int id, int dir)
    {
    }

    [Token(Token = "0x6019372")]
    [Address(RVA = "0x2D077E8", Offset = "0x2D077E8", VA = "0x2D077E8")]
    public void ChangeAnim(int id, int anim)
    {
    }

    [Token(Token = "0x6019373")]
    [Address(RVA = "0x2D077FC", Offset = "0x2D077FC", VA = "0x2D077FC")]
    public void DispWeapon(int id, bool active)
    {
    }

    [Token(Token = "0x6019374")]
    [Address(RVA = "0x2D07814", Offset = "0x2D07814", VA = "0x2D07814")]
    public void DispUnit(int id, bool active)
    {
    }

    [Token(Token = "0x6019375")]
    [Address(RVA = "0x2D0782C", Offset = "0x2D0782C", VA = "0x2D0782C")]
    public void MoveUnit(int id, int x, int y)
    {
    }

    [Token(Token = "0x6019376")]
    [Address(RVA = "0x2D07840", Offset = "0x2D07840", VA = "0x2D07840")]
    public void DyingUnit(int id)
    {
    }

    [Token(Token = "0x6019377")]
    [Address(RVA = "0x2D07844", Offset = "0x2D07844", VA = "0x2D07844")]
    public void DoubleUnit(int id, int backId)
    {
    }

    [Token(Token = "0x6019378")]
    [Address(RVA = "0x2D07858", Offset = "0x2D07858", VA = "0x2D07858")]
    public void DodgeUnit(int id)
    {
    }

    [Token(Token = "0x6019379")]
    [Address(RVA = "0x2D0786C", Offset = "0x2D0786C", VA = "0x2D0786C")]
    public void NormalAttackUnit(int id, int targetId)
    {
    }

    [Token(Token = "0x601937A")]
    [Address(RVA = "0x2D07880", Offset = "0x2D07880", VA = "0x2D07880")]
    public void DamageUnit(int id, int attackerId, int damage, bool critical)
    {
    }

    [Token(Token = "0x601937B")]
    [Address(RVA = "0x2D07898", Offset = "0x2D07898", VA = "0x2D07898")]
    public void HealingUnit(int id, int healValue)
    {
    }

    [Token(Token = "0x601937C")]
    [Address(RVA = "0x2D078AC", Offset = "0x2D078AC", VA = "0x2D078AC")]
    public void ChangeLayer(int id, int layer)
    {
    }

    [Token(Token = "0x601937D")]
    [Address(RVA = "0x2D078C0", Offset = "0x2D078C0", VA = "0x2D078C0")]
    public bool isPlayingAnim(int id) => new bool();

    [Token(Token = "0x601937E")]
    [Address(RVA = "0x2D078D4", Offset = "0x2D078D4", VA = "0x2D078D4")]
    public void ReserveMoveUnit(int id, int x, int y)
    {
    }

    [Token(Token = "0x601937F")]
    [Address(RVA = "0x2D078E8", Offset = "0x2D078E8", VA = "0x2D078E8")]
    public void ExecParallelSeq()
    {
    }

    [Token(Token = "0x6019380")]
    [Address(RVA = "0x2D078FC", Offset = "0x2D078FC", VA = "0x2D078FC")]
    public bool isPlayingStaging() => new bool();

    [Token(Token = "0x6019381")]
    [Address(RVA = "0x2D07910", Offset = "0x2D07910", VA = "0x2D07910")]
    public void ReserveParticle(string fileName)
    {
    }

    [Token(Token = "0x6019382")]
    [Address(RVA = "0x2D07924", Offset = "0x2D07924", VA = "0x2D07924")]
    public void LoadParticle()
    {
    }

    [Token(Token = "0x6019383")]
    [Address(RVA = "0x2D07938", Offset = "0x2D07938", VA = "0x2D07938")]
    public bool IsLoadingParticle() => new bool();

    [Token(Token = "0x6019384")]
    [Address(RVA = "0x2D0794C", Offset = "0x2D0794C", VA = "0x2D0794C")]
    public int PlayParticleGrid(string name, int x, int y) => new int();

    [Token(Token = "0x6019385")]
    [Address(RVA = "0x2D07964", Offset = "0x2D07964", VA = "0x2D07964")]
    public int PlayParticleUnit(int id, string name, int locator, bool dir) => new int();

    [Token(Token = "0x6019386")]
    [Address(RVA = "0x2D07980", Offset = "0x2D07980", VA = "0x2D07980")]
    public void StopParticle(int hashcode)
    {
    }

    [Token(Token = "0x6019387")]
    [Address(RVA = "0x2D07994", Offset = "0x2D07994", VA = "0x2D07994")]
    public bool isPlayingParticle(int hashcode) => new bool();

    [Token(Token = "0x6019388")]
    [Address(RVA = "0x2D079A8", Offset = "0x2D079A8", VA = "0x2D079A8")]
    public void UnitCommandStay(int unitId, bool switchDouble)
    {
    }

    [Token(Token = "0x6019389")]
    [Address(RVA = "0x2D079C8", Offset = "0x2D079C8", VA = "0x2D079C8")]
    public void UnitCommandMoveOnly(int unitId, int moveToX, int moveToY, bool switchDouble)
    {
    }

    [Token(Token = "0x601938A")]
    [Address(RVA = "0x2D079E8", Offset = "0x2D079E8", VA = "0x2D079E8")]
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

    [Token(Token = "0x601938B")]
    [Address(RVA = "0x2D07A08", Offset = "0x2D07A08", VA = "0x2D07A08")]
    public void UnitCommandDouble(
      int unitId,
      int moveToX,
      int moveToY,
      int targetToX,
      int targetToY)
    {
    }

    [Token(Token = "0x601938C")]
    [Address(RVA = "0x2D07A24", Offset = "0x2D07A24", VA = "0x2D07A24")]
    public void UnitCommandReleaseDouble(
      int unitId,
      int moveToX,
      int moveToY,
      int targetToX,
      int targetToY,
      bool switchDouble)
    {
    }

    [Token(Token = "0x601938D")]
    [Address(RVA = "0x2D07A44", Offset = "0x2D07A44", VA = "0x2D07A44")]
    public void SettingManualCommandSkill(
      int unitId,
      int moveToX,
      int moveToY,
      int targetToX,
      int targetToY,
      int skillIdx)
    {
    }

    [Token(Token = "0x601938E")]
    [Address(RVA = "0x2D07A60", Offset = "0x2D07A60", VA = "0x2D07A60")]
    public void SettingManualCommandMoveOnly(int unitId, int moveToX, int moveToY)
    {
    }

    [Token(Token = "0x601938F")]
    [Address(RVA = "0x2D07A7C", Offset = "0x2D07A7C", VA = "0x2D07A7C")]
    public void SettingManualCommandDouble(
      int unitId,
      int moveToX,
      int moveToY,
      int targetToX,
      int targetToY)
    {
    }

    [Token(Token = "0x6019390")]
    [Address(RVA = "0x2D07A98", Offset = "0x2D07A98", VA = "0x2D07A98")]
    public void SettingManualReleaseDouble(
      int unitId,
      int moveToX,
      int moveToY,
      int targetToX,
      int targetToY)
    {
    }

    [Token(Token = "0x6019391")]
    [Address(RVA = "0x2D07AB4", Offset = "0x2D07AB4", VA = "0x2D07AB4")]
    public void SettingManualSwapWeapon(int unitId, int weaponIndex)
    {
    }

    [Token(Token = "0x6019392")]
    [Address(RVA = "0x2D07AD0", Offset = "0x2D07AD0", VA = "0x2D07AD0")]
    public void SortieTroops(int playerId, int troopId)
    {
    }

    [Token(Token = "0x6019393")]
    [Address(RVA = "0x2D07AE4", Offset = "0x2D07AE4", VA = "0x2D07AE4")]
    public bool GetBattleAdvAutoSetting() => new bool();
  }
}
