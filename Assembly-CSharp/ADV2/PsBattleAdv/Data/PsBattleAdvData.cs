// Decompiled with JetBrains decompiler
// Type: ADV2.PsBattleAdv.Data.PsBattleAdvData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using Battle.Data;
using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace ADV2.PsBattleAdv.Data
{
  [Token(Token = "0x2003E87")]
  public class PsBattleAdvData : BattleConfigData
  {
    [Token(Token = "0x4011261")]
    [FieldOffset(Offset = "0x48")]
    private BattleTimeTypeEnum storyTimeSlot;
    [Token(Token = "0x4011262")]
    [FieldOffset(Offset = "0x4C")]
    private BattleWeatherTypeEnum storyWeather;
    [Token(Token = "0x4011263")]
    [FieldOffset(Offset = "0x50")]
    public Dictionary<int, UnitParameterData> UnitDic;
    [Token(Token = "0x4011264")]
    [FieldOffset(Offset = "0x58")]
    public Dictionary<int, FacilityData> FacilityDic;
    [Token(Token = "0x4011266")]
    [FieldOffset(Offset = "0x68")]
    public List<PsBattleAdvData.ReserveLoadAllyUnit> reserveLoadAllyUnitList;
    [Token(Token = "0x4011267")]
    [FieldOffset(Offset = "0x70")]
    public List<PsBattleAdvData.ReserveLoadEnemyUnit> reserveLoadEnemyUnitList;
    [Token(Token = "0x4011268")]
    [FieldOffset(Offset = "0x78")]
    public List<PsBattleAdvData.ReserveLoadFacility> reserveFacilityList;
    [Token(Token = "0x4011269")]
    [FieldOffset(Offset = "0x80")]
    public List<string> reserveParticleList;
    [Token(Token = "0x401126A")]
    [FieldOffset(Offset = "0x88")]
    public List<PsBattleAdvData.ReserveMoveUnit> reserveMoveUnitList;
    [Token(Token = "0x401126B")]
    [FieldOffset(Offset = "0x90")]
    public Dictionary<int, Battle.Data.Board.SkillData> skillDic;
    [Token(Token = "0x401126C")]
    [FieldOffset(Offset = "0x98")]
    public Dictionary<int, SkillParameterData> usingSkillDic;

    [Token(Token = "0x170051AF")]
    public CorrelationDataBase CorrelationData
    {
      [Token(Token = "0x60192CF"), Address(RVA = "0x2D01914", Offset = "0x2D01914", VA = "0x2D01914")] get
      {
        return (CorrelationDataBase) null;
      }
      [Token(Token = "0x60192D0"), Address(RVA = "0x2D0191C", Offset = "0x2D0191C", VA = "0x2D0191C")] protected set
      {
      }
    }

    [Token(Token = "0x170051B0")]
    public override BattleTimeTypeEnum TimeSlot
    {
      [Token(Token = "0x60192D1"), Address(RVA = "0x2D01924", Offset = "0x2D01924", VA = "0x2D01924", Slot = "38")] get
      {
        return new BattleTimeTypeEnum();
      }
    }

    [Token(Token = "0x170051B1")]
    public override BattleWeatherTypeEnum Weather
    {
      [Token(Token = "0x60192D2"), Address(RVA = "0x2D0192C", Offset = "0x2D0192C", VA = "0x2D0192C", Slot = "39")] get
      {
        return new BattleWeatherTypeEnum();
      }
    }

    [Token(Token = "0x170051B2")]
    public MapEditorData MapEditData
    {
      [Token(Token = "0x60192D3"), Address(RVA = "0x2D01934", Offset = "0x2D01934", VA = "0x2D01934")] get
      {
        return (MapEditorData) null;
      }
      [Token(Token = "0x60192D4"), Address(RVA = "0x2D0193C", Offset = "0x2D0193C", VA = "0x2D0193C")] set
      {
      }
    }

    [Token(Token = "0x60192D5")]
    [Address(RVA = "0x2CFA8BC", Offset = "0x2CFA8BC", VA = "0x2CFA8BC")]
    public PsBattleAdvData()
    {
    }

    [Token(Token = "0x60192D6")]
    [Address(RVA = "0x2D01944", Offset = "0x2D01944", VA = "0x2D01944")]
    private void Initialize()
    {
    }

    [Token(Token = "0x60192D7")]
    [Address(RVA = "0x2CFAD04", Offset = "0x2CFAD04", VA = "0x2CFAD04")]
    public void SetMapName(string mapAssetName, string MapYamlAssetName)
    {
    }

    [Token(Token = "0x60192D8")]
    [Address(RVA = "0x2CFADF4", Offset = "0x2CFADF4", VA = "0x2CFADF4")]
    public void SetTimeAndWeather(BattleTimeTypeEnum timeslot, BattleWeatherTypeEnum weather)
    {
    }

    [Token(Token = "0x60192D9")]
    [Address(RVA = "0x2CF9B40", Offset = "0x2CF9B40", VA = "0x2CF9B40")]
    public void SetFieldBgAndWeatherEffect(IDirector mainDirector)
    {
    }

    [Token(Token = "0x60192DA")]
    [Address(RVA = "0x2CFAD8C", Offset = "0x2CFAD8C", VA = "0x2CFAD8C")]
    public void CreateCorrelationData()
    {
    }

    [Token(Token = "0x60192DB")]
    [Address(RVA = "0x2D01948", Offset = "0x2D01948", VA = "0x2D01948", Slot = "42")]
    public override void SaveSettings()
    {
    }

    [Token(Token = "0x2003E88")]
    public class ReserveLoadAllyUnit
    {
      [Token(Token = "0x401126D")]
      [FieldOffset(Offset = "0x10")]
      public int id;
      [Token(Token = "0x401126E")]
      [FieldOffset(Offset = "0x14")]
      public int styleId;
      [Token(Token = "0x401126F")]
      [FieldOffset(Offset = "0x18")]
      public Vector2Int coord;
      [Token(Token = "0x4011270")]
      [FieldOffset(Offset = "0x20")]
      public List<int> weaponId;
      [Token(Token = "0x4011271")]
      [FieldOffset(Offset = "0x28")]
      public int layer;

      [Token(Token = "0x60192DC")]
      [Address(RVA = "0x2CFB220", Offset = "0x2CFB220", VA = "0x2CFB220")]
      public ReserveLoadAllyUnit()
      {
      }
    }

    [Token(Token = "0x2003E89")]
    public class ReserveLoadEnemyUnit
    {
      [Token(Token = "0x4011272")]
      [FieldOffset(Offset = "0x10")]
      public int id;
      [Token(Token = "0x4011273")]
      [FieldOffset(Offset = "0x14")]
      public int unitId;
      [Token(Token = "0x4011274")]
      [FieldOffset(Offset = "0x18")]
      public Vector2Int coord;
      [Token(Token = "0x4011275")]
      [FieldOffset(Offset = "0x20")]
      public int layer;

      [Token(Token = "0x60192DD")]
      [Address(RVA = "0x2CFB608", Offset = "0x2CFB608", VA = "0x2CFB608")]
      public ReserveLoadEnemyUnit()
      {
      }
    }

    [Token(Token = "0x2003E8A")]
    public class ReserveLoadFacility
    {
      [Token(Token = "0x4011276")]
      [FieldOffset(Offset = "0x10")]
      public int id;
      [Token(Token = "0x4011277")]
      [FieldOffset(Offset = "0x14")]
      public int facilityId;
      [Token(Token = "0x4011278")]
      [FieldOffset(Offset = "0x18")]
      public int x;
      [Token(Token = "0x4011279")]
      [FieldOffset(Offset = "0x1C")]
      public int y;
      [Token(Token = "0x401127A")]
      [FieldOffset(Offset = "0x20")]
      public int dir;
      [Token(Token = "0x401127B")]
      [FieldOffset(Offset = "0x24")]
      public int groupId;
      [Token(Token = "0x401127C")]
      [FieldOffset(Offset = "0x28")]
      public bool defaultSwitch;

      [Token(Token = "0x60192DE")]
      [Address(RVA = "0x2CFB740", Offset = "0x2CFB740", VA = "0x2CFB740")]
      public ReserveLoadFacility()
      {
      }
    }

    [Token(Token = "0x2003E8B")]
    public class ReserveMoveUnit
    {
      [Token(Token = "0x401127D")]
      [FieldOffset(Offset = "0x10")]
      public UnitParameterData param;
      [Token(Token = "0x401127E")]
      [FieldOffset(Offset = "0x18")]
      public Vector2Int coord;
      [Token(Token = "0x401127F")]
      [FieldOffset(Offset = "0x20")]
      public float speed;

      [Token(Token = "0x60192DF")]
      [Address(RVA = "0x2CFD350", Offset = "0x2CFD350", VA = "0x2CFD350")]
      public ReserveMoveUnit()
      {
      }
    }
  }
}
