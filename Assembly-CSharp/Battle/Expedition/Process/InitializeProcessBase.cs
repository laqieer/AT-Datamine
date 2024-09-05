// Decompiled with JetBrains decompiler
// Type: Battle.Expedition.Process.InitializeProcessBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Expedition.Data;
using Battle.Process;
using Battle.Stage;
using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Battle.Expedition.Process
{
  [Token(Token = "0x20025F3")]
  public abstract class InitializeProcessBase : BattleProcessBase
  {
    [Token(Token = "0x400A30C")]
    protected const string SceneNameBattleStage = "PvEBattleStage";
    [Token(Token = "0x400A30F")]
    [FieldOffset(Offset = "0x30")]
    protected UnitCreator unitCreator;
    [Token(Token = "0x400A310")]
    [FieldOffset(Offset = "0x38")]
    public Action<BattleStage> OnFinishedProcess;

    [Token(Token = "0x170031FB")]
    protected bool IsReload
    {
      [Token(Token = "0x600EA51"), Address(RVA = "0x4B904B8", Offset = "0x4B904B8", VA = "0x4B904B8")] get
      {
        return new bool();
      }
      [Token(Token = "0x600EA52"), Address(RVA = "0x4B904C0", Offset = "0x4B904C0", VA = "0x4B904C0")] set
      {
      }
    }

    [Token(Token = "0x170031FC")]
    protected ExpeditionBattleData OldData
    {
      [Token(Token = "0x600EA53"), Address(RVA = "0x4B904CC", Offset = "0x4B904CC", VA = "0x4B904CC")] get
      {
        return (ExpeditionBattleData) null;
      }
      [Token(Token = "0x600EA54"), Address(RVA = "0x4B904D4", Offset = "0x4B904D4", VA = "0x4B904D4")] set
      {
      }
    }

    [Token(Token = "0x600EA55")]
    [Address(RVA = "0x4B904DC", Offset = "0x4B904DC", VA = "0x4B904DC", Slot = "13")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x600EA56")]
    [Address(RVA = "0x4B904E0", Offset = "0x4B904E0", VA = "0x4B904E0")]
    public IEnumerator StartInitializeBattle(
      bool isReload,
      ExpeditionBattleData oldData,
      Action finishCallback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600EA57")]
    [Address(RVA = "0x4B8B7D0", Offset = "0x4B8B7D0", VA = "0x4B8B7D0", Slot = "16")]
    protected virtual IEnumerator InitializeBattle() => (IEnumerator) null;

    [Token(Token = "0x600EA58")]
    [Address(RVA = "0x4B905C0", Offset = "0x4B905C0", VA = "0x4B905C0")]
    private IEnumerator LoadMapAssetBundle(string mapName) => (IEnumerator) null;

    [Token(Token = "0x600EA59")]
    [Address(RVA = "0x4B90650", Offset = "0x4B90650", VA = "0x4B90650")]
    private IEnumerator LoadDuelSettings() => (IEnumerator) null;

    [Token(Token = "0x600EA5A")]
    [Address(RVA = "0x4B906D8", Offset = "0x4B906D8", VA = "0x4B906D8")]
    private IEnumerator LoadStyleAssetBundle() => (IEnumerator) null;

    [Token(Token = "0x600EA5B")]
    [Address(RVA = "0x4B90768", Offset = "0x4B90768", VA = "0x4B90768")]
    protected MapEditorData GetMapEditorData(string yamlName) => (MapEditorData) null;

    [Token(Token = "0x600EA5C")]
    [Address(RVA = "0x4B90858", Offset = "0x4B90858", VA = "0x4B90858")]
    private void CreateMapGrids(BattleStage stage, ExpeditionBattleData battleData)
    {
    }

    [Token(Token = "0x600EA5D")]
    [Address(RVA = "0x4B909B4", Offset = "0x4B909B4", VA = "0x4B909B4")]
    private void SetupMapCamera(BattleStage stage)
    {
    }

    [Token(Token = "0x600EA5E")]
    [Address(RVA = "0x4B91360", Offset = "0x4B91360", VA = "0x4B91360")]
    private void CreatePlayers()
    {
    }

    [Token(Token = "0x600EA5F")]
    protected abstract void InnerCreatePlayers();

    [Token(Token = "0x600EA60")]
    [Address(RVA = "0x4B916AC", Offset = "0x4B916AC", VA = "0x4B916AC", Slot = "11")]
    protected override void Finish(ProcessCode nextProcess)
    {
    }

    [Token(Token = "0x600EA61")]
    [Address(RVA = "0x4B916FC", Offset = "0x4B916FC", VA = "0x4B916FC")]
    private IEnumerator LoadDamageUIAssetBundle() => (IEnumerator) null;

    [Token(Token = "0x600EA62")]
    [Address(RVA = "0x4B8B7C4", Offset = "0x4B8B7C4", VA = "0x4B8B7C4")]
    protected InitializeProcessBase()
    {
    }
  }
}
