// Decompiled with JetBrains decompiler
// Type: Battle.Process.InitializeProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Stage;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x200263E")]
  public sealed class InitializeProcess : InitializeProcessBase
  {
    [Token(Token = "0x400A44D")]
    [FieldOffset(Offset = "0x38")]
    private UnitCreator unitCreator;

    [Token(Token = "0x17003267")]
    private StoryBattleConfig config
    {
      [Token(Token = "0x600ECD8"), Address(RVA = "0x448D5A8", Offset = "0x448D5A8", VA = "0x448D5A8")] get
      {
        return (StoryBattleConfig) null;
      }
    }

    [Token(Token = "0x600ECD9")]
    [Address(RVA = "0x448D630", Offset = "0x448D630", VA = "0x448D630", Slot = "10")]
    public override void Initialize(IProcessOwner<ProcessCode> ownerBehaviour, BattleCore core)
    {
    }

    [Token(Token = "0x600ECDA")]
    [Address(RVA = "0x448D718", Offset = "0x448D718", VA = "0x448D718", Slot = "18")]
    protected override void InitializeBoard()
    {
    }

    [Token(Token = "0x600ECDB")]
    [Address(RVA = "0x44903E0", Offset = "0x44903E0", VA = "0x44903E0", Slot = "20")]
    protected override IEnumerator LoadItemIcon() => (IEnumerator) null;

    [Token(Token = "0x600ECDC")]
    [Address(RVA = "0x448DF74", Offset = "0x448DF74", VA = "0x448DF74")]
    private void CreateFacilityData()
    {
    }

    [Token(Token = "0x600ECDD")]
    [Address(RVA = "0x448E42C", Offset = "0x448E42C", VA = "0x448E42C")]
    private void CreatePlayersFromInitData()
    {
    }

    [Token(Token = "0x600ECDE")]
    [Address(RVA = "0x449021C", Offset = "0x449021C", VA = "0x449021C")]
    private void CreatePlayersOnResume()
    {
    }

    [Token(Token = "0x600ECDF")]
    [Address(RVA = "0x44912B4", Offset = "0x44912B4", VA = "0x44912B4")]
    private void SetupPlayerController()
    {
    }

    [Token(Token = "0x600ECE0")]
    [Address(RVA = "0x448FB54", Offset = "0x448FB54", VA = "0x448FB54")]
    private void PlaceInitSortieUnits(BattlePlayerData player)
    {
    }

    [Token(Token = "0x600ECE1")]
    [Address(RVA = "0x4491524", Offset = "0x4491524", VA = "0x4491524", Slot = "19")]
    protected override void CreateMapGrids(BattleStage stage, MapEditorData mapEditorData)
    {
    }

    [Token(Token = "0x600ECE2")]
    [Address(RVA = "0x44916B0", Offset = "0x44916B0", VA = "0x44916B0", Slot = "22")]
    protected override IEnumerator InitializeUI() => (IEnumerator) null;

    [Token(Token = "0x600ECE3")]
    [Address(RVA = "0x448CA00", Offset = "0x448CA00", VA = "0x448CA00")]
    public InitializeProcess()
    {
    }
  }
}
