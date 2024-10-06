// Decompiled with JetBrains decompiler
// Type: Battle.Process.BattleLogProcessor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using Battle.Data;
using Battle.DuelScene;
using Battle.Logic;
using GameCore.MasterData;
using Il2CppDummyDll;
using staq.SaveSchema;
using System.Collections.Generic;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x200269E")]
  public class BattleLogProcessor
  {
    [Token(Token = "0x400A5A1")]
    [FieldOffset(Offset = "0x10")]
    private Battle.Data.Board.BoardData boardData;
    [Token(Token = "0x400A5A2")]
    [FieldOffset(Offset = "0x18")]
    private IReadOnlyDictionary<int, BattleLogTextFormatData> textFormatData;
    [Token(Token = "0x400A5A3")]
    [FieldOffset(Offset = "0x20")]
    private List<BattleLogData> LogDataList;
    [Token(Token = "0x400A5A4")]
    [FieldOffset(Offset = "0x28")]
    private Queue<BattleLogData> LogDataQueue;
    [Token(Token = "0x400A5A5")]
    [FieldOffset(Offset = "0x30")]
    private BattleLogData BoardDataDescriptionData;
    [Token(Token = "0x400A5A6")]
    [FieldOffset(Offset = "0x38")]
    private Queue<BattleLogData> DelayLogDataQueue;
    [Token(Token = "0x400A5A7")]
    [FieldOffset(Offset = "0x40")]
    public bool NeedSaveDirty;
    [Token(Token = "0x400A5A8")]
    private const int MAX_SAVE_TURN = 100;

    [Token(Token = "0x600EF14")]
    [Address(RVA = "0x40D1BE4", Offset = "0x40D1BE4", VA = "0x40D1BE4")]
    public BattleLogProcessor(Battle.Data.Board.BoardData board)
    {
    }

    [Token(Token = "0x600EF15")]
    [Address(RVA = "0x40D1C94", Offset = "0x40D1C94", VA = "0x40D1C94")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600EF16")]
    [Address(RVA = "0x40D1D78", Offset = "0x40D1D78", VA = "0x40D1D78")]
    public void Resume()
    {
    }

    [Token(Token = "0x600EF17")]
    [Address(RVA = "0x40D1F08", Offset = "0x40D1F08", VA = "0x40D1F08")]
    public void ApplyBoard(Battle.Data.Board.BoardData board)
    {
    }

    [Token(Token = "0x600EF18")]
    [Address(RVA = "0x40D1F14", Offset = "0x40D1F14", VA = "0x40D1F14")]
    private void AddLogDataList(List<BattleLogData> dataList)
    {
    }

    [Token(Token = "0x600EF19")]
    [Address(RVA = "0x40D2160", Offset = "0x40D2160", VA = "0x40D2160")]
    private void AddLogDataList(BattleLogData data)
    {
    }

    [Token(Token = "0x600EF1A")]
    [Address(RVA = "0x40D2234", Offset = "0x40D2234", VA = "0x40D2234")]
    private void AddDelayBattleLog()
    {
    }

    [Token(Token = "0x600EF1B")]
    [Address(RVA = "0x40D22C8", Offset = "0x40D22C8", VA = "0x40D22C8")]
    public void CreateSystemLog(
      BattleLogTextTypeEnum logType,
      int value1 = 0,
      int value2 = 0,
      int value3 = 0,
      int unitId = 0,
      int paramNum = 0,
      bool isDelay = false)
    {
    }

    [Token(Token = "0x600EF1C")]
    [Address(RVA = "0x40D24F0", Offset = "0x40D24F0", VA = "0x40D24F0")]
    public void CreateCommandLog(Queue<UnitCommandBase> command)
    {
    }

    [Token(Token = "0x600EF1D")]
    [Address(RVA = "0x40D25C4", Offset = "0x40D25C4", VA = "0x40D25C4")]
    public void CreateDeadLog(
      UnitParameterChange paramChange,
      Battle.Data.Board.UnitParameterData unit,
      bool enableLost)
    {
    }

    [Token(Token = "0x600EF1E")]
    [Address(RVA = "0x40D27CC", Offset = "0x40D27CC", VA = "0x40D27CC")]
    public void CreateClearEffect(List<Battle.Data.Board.EffectParameterData> removeEffectList, int unitId)
    {
    }

    [Token(Token = "0x600EF1F")]
    [Address(RVA = "0x40D2E08", Offset = "0x40D2E08", VA = "0x40D2E08")]
    public void CreateBarrierDamage(Battle.Data.Board.UnitParameterData unit, int index, BarrierDamageLogic logic)
    {
    }

    [Token(Token = "0x600EF20")]
    [Address(RVA = "0x40D31A8", Offset = "0x40D31A8", VA = "0x40D31A8")]
    public void CreateLandEffectLog(
      UnitParameterChange paramChange,
      Battle.Data.Board.UnitParameterData unit,
      string name)
    {
    }

    [Token(Token = "0x600EF21")]
    [Address(RVA = "0x40D3288", Offset = "0x40D3288", VA = "0x40D3288")]
    public void CreateTakeBadStatusDamageLog(
      UnitParameterChange paramChange,
      Battle.Data.Board.UnitParameterData unit)
    {
    }

    [Token(Token = "0x600EF22")]
    [Address(RVA = "0x40D3360", Offset = "0x40D3360", VA = "0x40D3360")]
    public void CreateSortieLog(Battle.Data.Board.BattlePlayerData targetPlayer)
    {
    }

    [Token(Token = "0x600EF23")]
    [Address(RVA = "0x40D3400", Offset = "0x40D3400", VA = "0x40D3400")]
    public void CreateAutoTurretLog(Battle.Data.Board.FacilityData turret, IReadOnlyList<ActionData> results)
    {
    }

    [Token(Token = "0x600EF24")]
    [Address(RVA = "0x40D3B0C", Offset = "0x40D3B0C", VA = "0x40D3B0C")]
    public void CreateLevelUpLog(List<BattleExpInfo> expInfos)
    {
    }

    [Token(Token = "0x600EF25")]
    [Address(RVA = "0x40D3C8C", Offset = "0x40D3C8C", VA = "0x40D3C8C")]
    public void CreateRollBackLog(int turnBoardCount, int actionBoardCount, int index)
    {
    }

    [Token(Token = "0x600EF26")]
    [Address(RVA = "0x40D3CF8", Offset = "0x40D3CF8", VA = "0x40D3CF8")]
    public string GetBoardDescription() => (string) null;

    [Token(Token = "0x600EF27")]
    [Address(RVA = "0x40D3D54", Offset = "0x40D3D54", VA = "0x40D3D54")]
    public List<BattleLogData> GetLogData() => (List<BattleLogData>) null;

    [Token(Token = "0x600EF28")]
    [Address(RVA = "0x40D3E9C", Offset = "0x40D3E9C", VA = "0x40D3E9C")]
    public BattleLogData GetLastLogData() => (BattleLogData) null;

    [Token(Token = "0x600EF29")]
    [Address(RVA = "0x40D3EEC", Offset = "0x40D3EEC", VA = "0x40D3EEC")]
    public List<BattleLogData> GetAllLogData() => (List<BattleLogData>) null;

    [Token(Token = "0x600EF2A")]
    [Address(RVA = "0x40D3F04", Offset = "0x40D3F04", VA = "0x40D3F04")]
    public byte[] Serialize() => (byte[]) null;

    [Token(Token = "0x600EF2B")]
    [Address(RVA = "0x40D42B8", Offset = "0x40D42B8", VA = "0x40D42B8")]
    public void Deserialize(BattleLogDataList schema)
    {
    }
  }
}
