// Decompiled with JetBrains decompiler
// Type: Battle.Expedition.Data.ExpeditionBattleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using StaqData;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Expedition.Data
{
  [Token(Token = "0x2002608")]
  public class ExpeditionBattleData : BattleConfigData
  {
    [Token(Token = "0x1700320D")]
    public override BattleTimeTypeEnum TimeSlot
    {
      [Token(Token = "0x600EAC4"), Address(RVA = "0x4B96B30", Offset = "0x4B96B30", VA = "0x4B96B30", Slot = "38")] get
      {
        return new BattleTimeTypeEnum();
      }
    }

    [Token(Token = "0x1700320E")]
    public override BattleWeatherTypeEnum Weather
    {
      [Token(Token = "0x600EAC5"), Address(RVA = "0x4B96B38", Offset = "0x4B96B38", VA = "0x4B96B38", Slot = "39")] get
      {
        return new BattleWeatherTypeEnum();
      }
    }

    [Token(Token = "0x1700320F")]
    public bool IsBossBattle
    {
      [Token(Token = "0x600EAC6"), Address(RVA = "0x4B96B40", Offset = "0x4B96B40", VA = "0x4B96B40")] get
      {
        return new bool();
      }
      [Token(Token = "0x600EAC7"), Address(RVA = "0x4B96B48", Offset = "0x4B96B48", VA = "0x4B96B48")] protected set
      {
      }
    }

    [Token(Token = "0x17003210")]
    public DateTime BattleStartTime
    {
      [Token(Token = "0x600EAC8"), Address(RVA = "0x4B96B54", Offset = "0x4B96B54", VA = "0x4B96B54")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600EAC9"), Address(RVA = "0x4B96B5C", Offset = "0x4B96B5C", VA = "0x4B96B5C")] set
      {
      }
    }

    [Token(Token = "0x17003211")]
    public MapEditorData MapEditData
    {
      [Token(Token = "0x600EACA"), Address(RVA = "0x4B96B64", Offset = "0x4B96B64", VA = "0x4B96B64")] get
      {
        return (MapEditorData) null;
      }
      [Token(Token = "0x600EACB"), Address(RVA = "0x4B96B6C", Offset = "0x4B96B6C", VA = "0x4B96B6C")] set
      {
      }
    }

    [Token(Token = "0x17003212")]
    public ExpeditionStageData StageData
    {
      [Token(Token = "0x600EACC"), Address(RVA = "0x4B96B74", Offset = "0x4B96B74", VA = "0x4B96B74")] get
      {
        return (ExpeditionStageData) null;
      }
      [Token(Token = "0x600EACD"), Address(RVA = "0x4B96B7C", Offset = "0x4B96B7C", VA = "0x4B96B7C")] private set
      {
      }
    }

    [Token(Token = "0x17003213")]
    public ExpeditionStageDescriptionData StageDescriptionData
    {
      [Token(Token = "0x600EACE"), Address(RVA = "0x4B96B84", Offset = "0x4B96B84", VA = "0x4B96B84")] get
      {
        return (ExpeditionStageDescriptionData) null;
      }
      [Token(Token = "0x600EACF"), Address(RVA = "0x4B96B8C", Offset = "0x4B96B8C", VA = "0x4B96B8C")] private set
      {
      }
    }

    [Token(Token = "0x17003214")]
    public List<ExpeditionBattleData.PlaceAllyData> PlaceAllyDataList
    {
      [Token(Token = "0x600EAD0"), Address(RVA = "0x4B96B94", Offset = "0x4B96B94", VA = "0x4B96B94")] get
      {
        return (List<ExpeditionBattleData.PlaceAllyData>) null;
      }
      [Token(Token = "0x600EAD1"), Address(RVA = "0x4B96B9C", Offset = "0x4B96B9C", VA = "0x4B96B9C")] private set
      {
      }
    }

    [Token(Token = "0x17003215")]
    public List<ExpeditionBattleData.CreateAllyData> CreateAllyDataList
    {
      [Token(Token = "0x600EAD2"), Address(RVA = "0x4B96BA4", Offset = "0x4B96BA4", VA = "0x4B96BA4")] get
      {
        return (List<ExpeditionBattleData.CreateAllyData>) null;
      }
      [Token(Token = "0x600EAD3"), Address(RVA = "0x4B96BAC", Offset = "0x4B96BAC", VA = "0x4B96BAC")] private set
      {
      }
    }

    [Token(Token = "0x17003216")]
    public List<ExpeditionBattleData.CreateEnemyData> CreateEnemyDataList
    {
      [Token(Token = "0x600EAD4"), Address(RVA = "0x4B96BB4", Offset = "0x4B96BB4", VA = "0x4B96BB4")] get
      {
        return (List<ExpeditionBattleData.CreateEnemyData>) null;
      }
      [Token(Token = "0x600EAD5"), Address(RVA = "0x4B96BBC", Offset = "0x4B96BBC", VA = "0x4B96BBC")] private set
      {
      }
    }

    [Token(Token = "0x17003217")]
    public ExpeditionBossDescriptionData BossData
    {
      [Token(Token = "0x600EAD6"), Address(RVA = "0x4B96BC4", Offset = "0x4B96BC4", VA = "0x4B96BC4")] get
      {
        return (ExpeditionBossDescriptionData) null;
      }
      [Token(Token = "0x600EAD7"), Address(RVA = "0x4B96BCC", Offset = "0x4B96BCC", VA = "0x4B96BCC")] private set
      {
      }
    }

    [Token(Token = "0x17003218")]
    public Dictionary<int, ExpeditionBattleData.UnitInfo> UnitInfoDic
    {
      [Token(Token = "0x600EAD8"), Address(RVA = "0x4B96BD4", Offset = "0x4B96BD4", VA = "0x4B96BD4")] get
      {
        return (Dictionary<int, ExpeditionBattleData.UnitInfo>) null;
      }
      [Token(Token = "0x600EAD9"), Address(RVA = "0x4B96BDC", Offset = "0x4B96BDC", VA = "0x4B96BDC")] set
      {
      }
    }

    [Token(Token = "0x17003219")]
    public CorrelationDataBase CorrelationData
    {
      [Token(Token = "0x600EADA"), Address(RVA = "0x4B96BE4", Offset = "0x4B96BE4", VA = "0x4B96BE4")] get
      {
        return (CorrelationDataBase) null;
      }
      [Token(Token = "0x600EADB"), Address(RVA = "0x4B96BEC", Offset = "0x4B96BEC", VA = "0x4B96BEC")] protected set
      {
      }
    }

    [Token(Token = "0x600EADC")]
    [Address(RVA = "0x4B96BF4", Offset = "0x4B96BF4", VA = "0x4B96BF4")]
    public ExpeditionBattleData()
    {
    }

    [Token(Token = "0x600EADD")]
    [Address(RVA = "0x4B96C78", Offset = "0x4B96C78", VA = "0x4B96C78")]
    private void Initialize(ExpeditionBattle.BattleParameter param)
    {
    }

    [Token(Token = "0x600EADE")]
    [Address(RVA = "0x4B96E7C", Offset = "0x4B96E7C", VA = "0x4B96E7C")]
    public void BossInitialize(ExpeditionBattle.BattleParameter param)
    {
    }

    [Token(Token = "0x600EADF")]
    [Address(RVA = "0x4B97180", Offset = "0x4B97180", VA = "0x4B97180")]
    public void NormalInitialize(ExpeditionBattle.BattleParameter param)
    {
    }

    [Token(Token = "0x600EAE0")]
    [Address(RVA = "0x4B973B0", Offset = "0x4B973B0", VA = "0x4B973B0")]
    private PlayerExpeditionPartyType GetUnitSetParty(int partyNo)
    {
      return (PlayerExpeditionPartyType) null;
    }

    [Token(Token = "0x600EAE1")]
    [Address(RVA = "0x4B96DCC", Offset = "0x4B96DCC", VA = "0x4B96DCC")]
    protected void CreateCorrelationData()
    {
    }

    [Token(Token = "0x600EAE2")]
    [Address(RVA = "0x4B8DEC8", Offset = "0x4B8DEC8", VA = "0x4B8DEC8")]
    public void UpdateCreateAllyData(
      IEnumerable<PlayerExpeditionStageBossPartyUnitType> networkParams)
    {
    }

    [Token(Token = "0x600EAE3")]
    [Address(RVA = "0x4B979AC", Offset = "0x4B979AC", VA = "0x4B979AC")]
    public void UpdateCreateAllyData(
      IEnumerable<PlayerExpeditionPartyCharacterType> networkParams)
    {
    }

    [Token(Token = "0x600EAE4")]
    [Address(RVA = "0x4B96E2C", Offset = "0x4B96E2C", VA = "0x4B96E2C")]
    public void ClearUnits()
    {
    }

    [Token(Token = "0x600EAE5")]
    [Address(RVA = "0x4B97E94", Offset = "0x4B97E94", VA = "0x4B97E94", Slot = "40")]
    public override string GetDefaultBgmName() => (string) null;

    [Token(Token = "0x600EAE6")]
    [Address(RVA = "0x4B97ED4", Offset = "0x4B97ED4", VA = "0x4B97ED4")]
    public string GetPhaseFieldBgmName(ForceTypeEnum force) => (string) null;

    [Token(Token = "0x600EAE7")]
    [Address(RVA = "0x4B97F1C", Offset = "0x4B97F1C", VA = "0x4B97F1C", Slot = "42")]
    public override void SaveSettings()
    {
    }

    [Token(Token = "0x2002609")]
    public sealed class UnitInfo
    {
      [Token(Token = "0x1700321A")]
      public int SlotId
      {
        [Token(Token = "0x600EAE9"), Address(RVA = "0x4B97FB8", Offset = "0x4B97FB8", VA = "0x4B97FB8")] get
        {
          return new int();
        }
        [Token(Token = "0x600EAEA"), Address(RVA = "0x4B97FC0", Offset = "0x4B97FC0", VA = "0x4B97FC0")] private set
        {
        }
      }

      [Token(Token = "0x1700321B")]
      public UnitParameterData UnitParameter
      {
        [Token(Token = "0x600EAEB"), Address(RVA = "0x4B97FC8", Offset = "0x4B97FC8", VA = "0x4B97FC8")] get
        {
          return (UnitParameterData) null;
        }
        [Token(Token = "0x600EAEC"), Address(RVA = "0x4B97FD0", Offset = "0x4B97FD0", VA = "0x4B97FD0")] private set
        {
        }
      }

      [Token(Token = "0x1700321C")]
      public Style Style
      {
        [Token(Token = "0x600EAED"), Address(RVA = "0x4B97FD8", Offset = "0x4B97FD8", VA = "0x4B97FD8")] get
        {
          return (Style) null;
        }
        [Token(Token = "0x600EAEE"), Address(RVA = "0x4B97FE0", Offset = "0x4B97FE0", VA = "0x4B97FE0")] private set
        {
        }
      }

      [Token(Token = "0x1700321D")]
      public int NpcUnitId
      {
        [Token(Token = "0x600EAEF"), Address(RVA = "0x4B97FE8", Offset = "0x4B97FE8", VA = "0x4B97FE8")] get
        {
          return new int();
        }
        [Token(Token = "0x600EAF0"), Address(RVA = "0x4B97FF0", Offset = "0x4B97FF0", VA = "0x4B97FF0")] private set
        {
        }
      }

      [Token(Token = "0x600EAF1")]
      [Address(RVA = "0x4B96828", Offset = "0x4B96828", VA = "0x4B96828")]
      public UnitInfo(int slotId, UnitParameterData unit, Style style)
      {
      }

      [Token(Token = "0x600EAF2")]
      [Address(RVA = "0x4B96ABC", Offset = "0x4B96ABC", VA = "0x4B96ABC")]
      public UnitInfo(int slotId, UnitParameterData unit, int npcUnitId)
      {
      }
    }

    [Token(Token = "0x200260A")]
    public class PlaceAllyData
    {
      [Token(Token = "0x400A350")]
      [FieldOffset(Offset = "0x10")]
      public int x;
      [Token(Token = "0x400A351")]
      [FieldOffset(Offset = "0x14")]
      public int y;
      [Token(Token = "0x400A352")]
      [FieldOffset(Offset = "0x18")]
      public int slotId;

      [Token(Token = "0x600EAF3")]
      [Address(RVA = "0x4B97FB0", Offset = "0x4B97FB0", VA = "0x4B97FB0")]
      public PlaceAllyData()
      {
      }
    }

    [Token(Token = "0x200260B")]
    public class CreateAllyData
    {
      [Token(Token = "0x400A353")]
      [FieldOffset(Offset = "0x10")]
      public int slotId;
      [Token(Token = "0x400A354")]
      [FieldOffset(Offset = "0x18")]
      public Style style;
      [Token(Token = "0x400A355")]
      [FieldOffset(Offset = "0x20")]
      public Character character;
      [Token(Token = "0x400A356")]
      [FieldOffset(Offset = "0x28")]
      public IBattleParameter masterBonus;

      [Token(Token = "0x600EAF4")]
      [Address(RVA = "0x4B97E8C", Offset = "0x4B97E8C", VA = "0x4B97E8C")]
      public CreateAllyData()
      {
      }
    }

    [Token(Token = "0x200260C")]
    public class CreateEnemyData
    {
      [Token(Token = "0x400A357")]
      [FieldOffset(Offset = "0x10")]
      public int x;
      [Token(Token = "0x400A358")]
      [FieldOffset(Offset = "0x14")]
      public int y;
      [Token(Token = "0x400A359")]
      [FieldOffset(Offset = "0x18")]
      public int enemy;
      [Token(Token = "0x400A35A")]
      [FieldOffset(Offset = "0x1C")]
      public int barrier;
      [Token(Token = "0x400A35B")]
      [FieldOffset(Offset = "0x20")]
      public int barrierMaxHp;
      [Token(Token = "0x400A35C")]
      [FieldOffset(Offset = "0x24")]
      public int barrierRecovery;

      [Token(Token = "0x600EAF5")]
      [Address(RVA = "0x4B97FF8", Offset = "0x4B97FF8", VA = "0x4B97FF8")]
      public CreateEnemyData()
      {
      }
    }
  }
}
