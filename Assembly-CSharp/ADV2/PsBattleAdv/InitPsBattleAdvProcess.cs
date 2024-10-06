// Decompiled with JetBrains decompiler
// Type: ADV2.PsBattleAdv.InitPsBattleAdvProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Process;
using Battle.Stage;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace ADV2.PsBattleAdv
{
  [Token(Token = "0x2003E71")]
  public sealed class InitPsBattleAdvProcess : BattleProcessBase
  {
    [Token(Token = "0x40111F4")]
    private const string SceneNameBattleStage = "PvEBattleStage";

    [Token(Token = "0x601921A")]
    [Address(RVA = "0x2CF4AB8", Offset = "0x2CF4AB8", VA = "0x2CF4AB8")]
    private IEnumerator InitMapScene(Adv2Manager.OnProccessSignal signal) => (IEnumerator) null;

    [Token(Token = "0x601921B")]
    [Address(RVA = "0x2CF4B58", Offset = "0x2CF4B58", VA = "0x2CF4B58")]
    public void InitMapData(Adv2Manager.OnProccessSignal signal)
    {
    }

    [Token(Token = "0x601921C")]
    [Address(RVA = "0x2CF4C14", Offset = "0x2CF4C14", VA = "0x2CF4C14")]
    private IEnumerator CreateFacilityData() => (IEnumerator) null;

    [Token(Token = "0x601921D")]
    [Address(RVA = "0x2CF4CA4", Offset = "0x2CF4CA4", VA = "0x2CF4CA4")]
    private void SetupFacilityView()
    {
    }

    [Token(Token = "0x601921E")]
    [Address(RVA = "0x2CF53A0", Offset = "0x2CF53A0", VA = "0x2CF53A0")]
    private IEnumerator CreateAlly() => (IEnumerator) null;

    [Token(Token = "0x601921F")]
    [Address(RVA = "0x2CF5430", Offset = "0x2CF5430", VA = "0x2CF5430")]
    private IEnumerator CreateEnemy() => (IEnumerator) null;

    [Token(Token = "0x6019220")]
    [Address(RVA = "0x2CF54C0", Offset = "0x2CF54C0", VA = "0x2CF54C0")]
    private IEnumerator SetupUnitCoroutine(Adv2Manager.OnProccessSignal signal)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6019221")]
    [Address(RVA = "0x2CF555C", Offset = "0x2CF555C", VA = "0x2CF555C")]
    public void SetUpCompleteUnit(Adv2Manager.OnProccessSignal signal)
    {
    }

    [Token(Token = "0x6019222")]
    [Address(RVA = "0x2CF5618", Offset = "0x2CF5618", VA = "0x2CF5618")]
    private void SetupMapCamera(BattleStage stage)
    {
    }

    [Token(Token = "0x6019223")]
    [Address(RVA = "0x2CF5D8C", Offset = "0x2CF5D8C", VA = "0x2CF5D8C")]
    private void CreateParticles()
    {
    }

    [Token(Token = "0x6019224")]
    [Address(RVA = "0x2CF6064", Offset = "0x2CF6064", VA = "0x2CF6064")]
    private void CreateMapGrids(BattleStage stage, MapEditorData mapEditorData)
    {
    }

    [Token(Token = "0x6019225")]
    [Address(RVA = "0x2CF61BC", Offset = "0x2CF61BC", VA = "0x2CF61BC")]
    private MapEditorData GetMapEditorData(string abName, string yamlName) => (MapEditorData) null;

    [Token(Token = "0x6019226")]
    [Address(RVA = "0x2CF62B8", Offset = "0x2CF62B8", VA = "0x2CF62B8", Slot = "13")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x6019227")]
    [Address(RVA = "0x2CF62BC", Offset = "0x2CF62BC", VA = "0x2CF62BC")]
    public InitPsBattleAdvProcess()
    {
    }
  }
}
