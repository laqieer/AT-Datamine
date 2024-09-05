// Decompiled with JetBrains decompiler
// Type: Battle.Data.BattleAdvDataManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using GameCore.MasterData;
using Il2CppDummyDll;
using staq.SaveSchema;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x20026E4")]
  public sealed class BattleAdvDataManager
  {
    [Token(Token = "0x400A65C")]
    [FieldOffset(Offset = "0x10")]
    private int questId;
    [Token(Token = "0x400A65D")]
    [FieldOffset(Offset = "0x18")]
    private Queue<BattleAdvData> playList;
    [Token(Token = "0x400A65E")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, int> advMatchCountDic;
    [Token(Token = "0x400A65F")]
    [FieldOffset(Offset = "0x28")]
    private Dictionary<int, WatchedBattleAdvData> activatedAdvs;
    [Token(Token = "0x400A660")]
    [FieldOffset(Offset = "0x30")]
    private List<BattleAdvData> stageAdvs;

    [Token(Token = "0x170032CA")]
    public IReadOnlyDictionary<int, WatchedBattleAdvData> ActivatedAdvs
    {
      [Token(Token = "0x600F09F"), Address(RVA = "0x41A8C88", Offset = "0x41A8C88", VA = "0x41A8C88")] get
      {
        return (IReadOnlyDictionary<int, WatchedBattleAdvData>) null;
      }
    }

    [Token(Token = "0x600F0A0")]
    [Address(RVA = "0x41A8C90", Offset = "0x41A8C90", VA = "0x41A8C90")]
    public BattleAdvDataManager(int questId)
    {
    }

    [Token(Token = "0x600F0A1")]
    [Address(RVA = "0x41A8FAC", Offset = "0x41A8FAC", VA = "0x41A8FAC")]
    public static BattleAdvDataManager CreateFromSchema(BattleAdvProgress schema)
    {
      return (BattleAdvDataManager) null;
    }

    [Token(Token = "0x600F0A2")]
    [Address(RVA = "0x41A960C", Offset = "0x41A960C", VA = "0x41A960C")]
    public BattleAdvDataManager Copy() => (BattleAdvDataManager) null;

    [Token(Token = "0x600F0A3")]
    [Address(RVA = "0x41A9B5C", Offset = "0x41A9B5C", VA = "0x41A9B5C")]
    public void Release()
    {
    }

    [Token(Token = "0x600F0A4")]
    [Address(RVA = "0x41A9CA8", Offset = "0x41A9CA8", VA = "0x41A9CA8")]
    public Offset<BattleAdvProgress> Serialize(FlatBufferBuilder fbb)
    {
      return new Offset<BattleAdvProgress>();
    }

    [Token(Token = "0x600F0A5")]
    [Address(RVA = "0x41AA24C", Offset = "0x41AA24C", VA = "0x41AA24C")]
    public void ReservePlayableAdv(BattleEventTimingTypeEnum timing, Battle.Data.Board.BoardData board)
    {
    }

    [Token(Token = "0x600F0A6")]
    [Address(RVA = "0x41AA768", Offset = "0x41AA768", VA = "0x41AA768")]
    public void ReservePlayableAdv(
      BattleEventTimingTypeEnum timing,
      Battle.Data.Board.BoardData board,
      Battle.Data.Board.UnitParameterData actionOwner,
      IReadOnlyList<Battle.Data.Board.UnitParameterData> actionTargets,
      Battle.Data.Board.SkillParameterData useSkill)
    {
    }

    [Token(Token = "0x600F0A7")]
    [Address(RVA = "0x41AACCC", Offset = "0x41AACCC", VA = "0x41AACCC")]
    public void ReservePlayableAdv(
      BattleEventTimingTypeEnum timing,
      Battle.Data.Board.BoardData board,
      Battle.Data.Board.UnitParameterData actionOwner,
      Battle.Data.Board.FacilityData facility)
    {
    }

    [Token(Token = "0x600F0A8")]
    [Address(RVA = "0x41AB240", Offset = "0x41AB240", VA = "0x41AB240")]
    public IReadOnlyList<BattleAdvData> GetReservedAdv() => (IReadOnlyList<BattleAdvData>) null;

    [Token(Token = "0x600F0A9")]
    [Address(RVA = "0x41A9460", Offset = "0x41A9460", VA = "0x41A9460")]
    public void RegisterPlayedAdv(BattleAdvData advData)
    {
    }

    [Token(Token = "0x600F0AA")]
    [Address(RVA = "0x41A953C", Offset = "0x41A953C", VA = "0x41A953C")]
    public void RegisterWatchedActivated(
      BattleAdvData advData,
      IEnumerable<int> playerSelectedIds,
      IEnumerable<int> unlockedOptions)
    {
    }
  }
}
