// Decompiled with JetBrains decompiler
// Type: Battle.Data.ArenaBattleConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using Scenes.Guild.Data;
using staq.SaveData;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x20026DF")]
  public class ArenaBattleConfig : BattleConfigData
  {
    [Token(Token = "0x400A652")]
    [FieldOffset(Offset = "0x68")]
    public bool NeedSkip;

    [Token(Token = "0x170032C1")]
    public ArenaBattleData BattleMaster
    {
      [Token(Token = "0x600F075"), Address(RVA = "0x41A7584", Offset = "0x41A7584", VA = "0x41A7584")] get
      {
        return (ArenaBattleData) null;
      }
      [Token(Token = "0x600F076"), Address(RVA = "0x41A758C", Offset = "0x41A758C", VA = "0x41A758C")] private set
      {
      }
    }

    [Token(Token = "0x170032C2")]
    public Dictionary<int, IReadOnlyList<IUnitPlacementData>> UnitPlacements
    {
      [Token(Token = "0x600F077"), Address(RVA = "0x41A7594", Offset = "0x41A7594", VA = "0x41A7594")] get
      {
        return (Dictionary<int, IReadOnlyList<IUnitPlacementData>>) null;
      }
      [Token(Token = "0x600F078"), Address(RVA = "0x41A759C", Offset = "0x41A759C", VA = "0x41A759C")] protected set
      {
      }
    }

    [Token(Token = "0x170032C3")]
    public int OpponentRanking
    {
      [Token(Token = "0x600F079"), Address(RVA = "0x41A75A4", Offset = "0x41A75A4", VA = "0x41A75A4")] get
      {
        return new int();
      }
      [Token(Token = "0x600F07A"), Address(RVA = "0x41A75AC", Offset = "0x41A75AC", VA = "0x41A75AC")] protected set
      {
      }
    }

    [Token(Token = "0x170032C4")]
    public PlayerProfile Opponent
    {
      [Token(Token = "0x600F07B"), Address(RVA = "0x41A75B4", Offset = "0x41A75B4", VA = "0x41A75B4")] get
      {
        return (PlayerProfile) null;
      }
      [Token(Token = "0x600F07C"), Address(RVA = "0x41A75BC", Offset = "0x41A75BC", VA = "0x41A75BC")] private set
      {
      }
    }

    [Token(Token = "0x170032C5")]
    public bool IsVersusNpc
    {
      [Token(Token = "0x600F07D"), Address(RVA = "0x41A75C4", Offset = "0x41A75C4", VA = "0x41A75C4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170032C6")]
    public GuildFacilityInfo OpponentGuildFacility
    {
      [Token(Token = "0x600F07E"), Address(RVA = "0x41A75D4", Offset = "0x41A75D4", VA = "0x41A75D4")] get
      {
        return (GuildFacilityInfo) null;
      }
      [Token(Token = "0x600F07F"), Address(RVA = "0x41A75DC", Offset = "0x41A75DC", VA = "0x41A75DC")] private set
      {
      }
    }

    [Token(Token = "0x170032C7")]
    public override BattleTimeTypeEnum TimeSlot
    {
      [Token(Token = "0x600F080"), Address(RVA = "0x41A75E4", Offset = "0x41A75E4", VA = "0x41A75E4", Slot = "38")] get
      {
        return new BattleTimeTypeEnum();
      }
    }

    [Token(Token = "0x170032C8")]
    public override BattleWeatherTypeEnum Weather
    {
      [Token(Token = "0x600F081"), Address(RVA = "0x41A7600", Offset = "0x41A7600", VA = "0x41A7600", Slot = "39")] get
      {
        return new BattleWeatherTypeEnum();
      }
    }

    [Token(Token = "0x170032C9")]
    public int ArenaGroupId
    {
      [Token(Token = "0x600F082"), Address(RVA = "0x41A761C", Offset = "0x41A761C", VA = "0x41A761C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600F083")]
    [Address(RVA = "0x41A7638", Offset = "0x41A7638", VA = "0x41A7638")]
    protected ArenaBattleConfig()
    {
    }

    [Token(Token = "0x600F084")]
    [Address(RVA = "0x41A7844", Offset = "0x41A7844", VA = "0x41A7844")]
    public ArenaBattleConfig(PvEBattle.ArenaBattleSceneParameter parameter)
    {
    }

    [Token(Token = "0x600F085")]
    [Address(RVA = "0x41A78A8", Offset = "0x41A78A8", VA = "0x41A78A8")]
    protected void SetupMasterData(int arenaGroupId)
    {
    }

    [Token(Token = "0x600F086")]
    [Address(RVA = "0x41A7B68", Offset = "0x41A7B68", VA = "0x41A7B68", Slot = "46")]
    protected virtual void SetupSortieInformation()
    {
    }

    [Token(Token = "0x600F087")]
    [Address(RVA = "0x41A7964", Offset = "0x41A7964", VA = "0x41A7964")]
    private void SetupOpponentPlayer(EnemyArenaRankingDetailType opponent)
    {
    }

    [Token(Token = "0x600F088")]
    [Address(RVA = "0x41A808C", Offset = "0x41A808C", VA = "0x41A808C", Slot = "40")]
    public override string GetDefaultBgmName() => (string) null;

    [Token(Token = "0x600F089")]
    [Address(RVA = "0x41A80A8", Offset = "0x41A80A8", VA = "0x41A80A8", Slot = "41")]
    public override List<string> GetAllBgmNames() => (List<string>) null;

    [Token(Token = "0x600F08A")]
    [Address(RVA = "0x41A7570", Offset = "0x41A7570", VA = "0x41A7570")]
    public void EnableStagingMode()
    {
    }

    [Token(Token = "0x600F08B")]
    [Address(RVA = "0x41A81A8", Offset = "0x41A81A8", VA = "0x41A81A8", Slot = "42")]
    public override void SaveSettings()
    {
    }

    [Token(Token = "0x600F08C")]
    [Address(RVA = "0x41A8250", Offset = "0x41A8250", VA = "0x41A8250", Slot = "43")]
    public override BattleSettingsSaveData.BattleCamera[] GetCameraSettings()
    {
      return (BattleSettingsSaveData.BattleCamera[]) null;
    }

    [Token(Token = "0x600F08D")]
    [Address(RVA = "0x41A82D4", Offset = "0x41A82D4", VA = "0x41A82D4", Slot = "44")]
    public override void SaveCameraSettings(BattleSettingsSaveData.BattleCamera[] cameras)
    {
    }

    [Token(Token = "0x600F08E")]
    [Address(RVA = "0x41A83A0", Offset = "0x41A83A0", VA = "0x41A83A0", Slot = "45")]
    public override void OnOnUpdateCameraDistance(float distance)
    {
    }
  }
}
