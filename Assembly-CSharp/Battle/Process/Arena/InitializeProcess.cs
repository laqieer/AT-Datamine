// Decompiled with JetBrains decompiler
// Type: Battle.Process.Arena.InitializeProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Stage;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Battle.Process.Arena
{
  [Token(Token = "0x20026C2")]
  public class InitializeProcess : InitializeProcessBase
  {
    [Token(Token = "0x400A60E")]
    [FieldOffset(Offset = "0x38")]
    protected UnitCreator unitCreator;

    [Token(Token = "0x170032B1")]
    private ArenaBattleConfig config
    {
      [Token(Token = "0x600EFF0"), Address(RVA = "0x40E01C8", Offset = "0x40E01C8", VA = "0x40E01C8")] get
      {
        return (ArenaBattleConfig) null;
      }
    }

    [Token(Token = "0x600EFF1")]
    [Address(RVA = "0x40E024C", Offset = "0x40E024C", VA = "0x40E024C", Slot = "18")]
    protected override void InitializeBoard()
    {
    }

    [Token(Token = "0x600EFF2")]
    [Address(RVA = "0x40E221C", Offset = "0x40E221C", VA = "0x40E221C", Slot = "11")]
    protected override void Finish(ProcessCode nextProcess)
    {
    }

    [Token(Token = "0x600EFF3")]
    [Address(RVA = "0x40E225C", Offset = "0x40E225C", VA = "0x40E225C", Slot = "17")]
    protected override IEnumerator LoadBasicAssets() => (IEnumerator) null;

    [Token(Token = "0x600EFF4")]
    [Address(RVA = "0x40E07B4", Offset = "0x40E07B4", VA = "0x40E07B4")]
    private void CreateFacilityData()
    {
    }

    [Token(Token = "0x600EFF5")]
    [Address(RVA = "0x40E22EC", Offset = "0x40E22EC", VA = "0x40E22EC", Slot = "23")]
    protected virtual void CreatePlayers()
    {
    }

    [Token(Token = "0x600EFF6")]
    [Address(RVA = "0x40E3038", Offset = "0x40E3038", VA = "0x40E3038")]
    private void SetupPlayerController()
    {
    }

    [Token(Token = "0x600EFF7")]
    [Address(RVA = "0x40E0C8C", Offset = "0x40E0C8C", VA = "0x40E0C8C")]
    private void PlaceInitSortieUnits(BattlePlayerData player)
    {
    }

    [Token(Token = "0x600EFF8")]
    [Address(RVA = "0x40E17B0", Offset = "0x40E17B0", VA = "0x40E17B0")]
    private void CreateSortieSecurityLog()
    {
    }

    [Token(Token = "0x600EFF9")]
    [Address(RVA = "0x40E1C38", Offset = "0x40E1C38", VA = "0x40E1C38")]
    public void ApplySpecialRuleEffect()
    {
    }

    [Token(Token = "0x600EFFA")]
    [Address(RVA = "0x40E3194", Offset = "0x40E3194", VA = "0x40E3194", Slot = "19")]
    protected override void CreateMapGrids(BattleStage stage, MapEditorData mapEditorData)
    {
    }

    [Token(Token = "0x600EFFB")]
    [Address(RVA = "0x40DFF0C", Offset = "0x40DFF0C", VA = "0x40DFF0C", Slot = "22")]
    protected override IEnumerator InitializeUI() => (IEnumerator) null;

    [Token(Token = "0x600EFFC")]
    [Address(RVA = "0x40DF34C", Offset = "0x40DF34C", VA = "0x40DF34C")]
    public InitializeProcess()
    {
    }
  }
}
