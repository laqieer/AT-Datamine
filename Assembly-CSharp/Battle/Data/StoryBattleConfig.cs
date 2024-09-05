// Decompiled with JetBrains decompiler
// Type: Battle.Data.StoryBattleConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using staq.SaveData;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002713")]
  public class StoryBattleConfig : BattleConfigData
  {
    [Token(Token = "0x400A728")]
    [FieldOffset(Offset = "0x88")]
    private BattleTimeTypeEnum timeSlot;
    [Token(Token = "0x400A729")]
    [FieldOffset(Offset = "0x8C")]
    private BattleWeatherTypeEnum weather;
    [Token(Token = "0x400A72A")]
    [FieldOffset(Offset = "0x90")]
    public Dictionary<int, int> ChestDropInfos;
    [Token(Token = "0x400A72B")]
    [FieldOffset(Offset = "0x98")]
    public Dictionary<int, int> EnemyDropInfo;

    [Token(Token = "0x17003392")]
    public int UserDeckIdx
    {
      [Token(Token = "0x600F26F"), Address(RVA = "0x41B75E0", Offset = "0x41B75E0", VA = "0x41B75E0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F270"), Address(RVA = "0x41B75E8", Offset = "0x41B75E8", VA = "0x41B75E8")] private set
      {
      }
    }

    [Token(Token = "0x17003393")]
    public int[] SortieDeckSlots
    {
      [Token(Token = "0x600F271"), Address(RVA = "0x41B75F0", Offset = "0x41B75F0", VA = "0x41B75F0")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x600F272"), Address(RVA = "0x41B75F8", Offset = "0x41B75F8", VA = "0x41B75F8")] private set
      {
      }
    }

    [Token(Token = "0x17003394")]
    public QuestTypeEnum QuestType
    {
      [Token(Token = "0x600F273"), Address(RVA = "0x41B7600", Offset = "0x41B7600", VA = "0x41B7600")] get
      {
        return new QuestTypeEnum();
      }
      [Token(Token = "0x600F274"), Address(RVA = "0x41B7608", Offset = "0x41B7608", VA = "0x41B7608")] private set
      {
      }
    }

    [Token(Token = "0x17003395")]
    public int QuestID
    {
      [Token(Token = "0x600F275"), Address(RVA = "0x41B7610", Offset = "0x41B7610", VA = "0x41B7610")] get
      {
        return new int();
      }
      [Token(Token = "0x600F276"), Address(RVA = "0x41B7618", Offset = "0x41B7618", VA = "0x41B7618")] private set
      {
      }
    }

    [Token(Token = "0x17003396")]
    public IQuestStage Stage
    {
      [Token(Token = "0x600F277"), Address(RVA = "0x41B7620", Offset = "0x41B7620", VA = "0x41B7620")] get
      {
        return (IQuestStage) null;
      }
      [Token(Token = "0x600F278"), Address(RVA = "0x41B7628", Offset = "0x41B7628", VA = "0x41B7628")] private set
      {
      }
    }

    [Token(Token = "0x17003397")]
    public BattleData BattleMaster
    {
      [Token(Token = "0x600F279"), Address(RVA = "0x41B7630", Offset = "0x41B7630", VA = "0x41B7630")] get
      {
        return (BattleData) null;
      }
      [Token(Token = "0x600F27A"), Address(RVA = "0x41B7638", Offset = "0x41B7638", VA = "0x41B7638")] private set
      {
      }
    }

    [Token(Token = "0x17003398")]
    public int FirstClearRewardGroupID
    {
      [Token(Token = "0x600F27B"), Address(RVA = "0x41B7640", Offset = "0x41B7640", VA = "0x41B7640")] get
      {
        return new int();
      }
      [Token(Token = "0x600F27C"), Address(RVA = "0x41B7648", Offset = "0x41B7648", VA = "0x41B7648")] private set
      {
      }
    }

    [Token(Token = "0x17003399")]
    public int MissionID
    {
      [Token(Token = "0x600F27D"), Address(RVA = "0x41B7650", Offset = "0x41B7650", VA = "0x41B7650")] get
      {
        return new int();
      }
      [Token(Token = "0x600F27E"), Address(RVA = "0x41B7658", Offset = "0x41B7658", VA = "0x41B7658")] private set
      {
      }
    }

    [Token(Token = "0x1700339A")]
    public int ApCost
    {
      [Token(Token = "0x600F27F"), Address(RVA = "0x41B7660", Offset = "0x41B7660", VA = "0x41B7660")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700339B")]
    public Dictionary<int, IReadOnlyList<IUnitPlacementData>> UnitPlacements
    {
      [Token(Token = "0x600F280"), Address(RVA = "0x41B7704", Offset = "0x41B7704", VA = "0x41B7704")] get
      {
        return (Dictionary<int, IReadOnlyList<IUnitPlacementData>>) null;
      }
      [Token(Token = "0x600F281"), Address(RVA = "0x41B770C", Offset = "0x41B770C", VA = "0x41B770C")] protected set
      {
      }
    }

    [Token(Token = "0x1700339C")]
    public Dictionary<int, ITroopsMaster> Troops
    {
      [Token(Token = "0x600F282"), Address(RVA = "0x41B7714", Offset = "0x41B7714", VA = "0x41B7714")] get
      {
        return (Dictionary<int, ITroopsMaster>) null;
      }
      [Token(Token = "0x600F283"), Address(RVA = "0x41B771C", Offset = "0x41B771C", VA = "0x41B771C")] protected set
      {
      }
    }

    [Token(Token = "0x1700339D")]
    public int StyleExpPoolMaxCapacity
    {
      [Token(Token = "0x600F284"), Address(RVA = "0x41B7724", Offset = "0x41B7724", VA = "0x41B7724")] get
      {
        return new int();
      }
      [Token(Token = "0x600F285"), Address(RVA = "0x41B772C", Offset = "0x41B772C", VA = "0x41B772C")] protected set
      {
      }
    }

    [Token(Token = "0x1700339E")]
    public int HostileUnitTotalCount
    {
      [Token(Token = "0x600F286"), Address(RVA = "0x41B7734", Offset = "0x41B7734", VA = "0x41B7734")] get
      {
        return new int();
      }
      [Token(Token = "0x600F287"), Address(RVA = "0x41B773C", Offset = "0x41B773C", VA = "0x41B773C")] protected set
      {
      }
    }

    [Token(Token = "0x1700339F")]
    public override BattleTimeTypeEnum TimeSlot
    {
      [Token(Token = "0x600F288"), Address(RVA = "0x41B7744", Offset = "0x41B7744", VA = "0x41B7744", Slot = "38")] get
      {
        return new BattleTimeTypeEnum();
      }
    }

    [Token(Token = "0x170033A0")]
    public override BattleWeatherTypeEnum Weather
    {
      [Token(Token = "0x600F289"), Address(RVA = "0x41B774C", Offset = "0x41B774C", VA = "0x41B774C", Slot = "39")] get
      {
        return new BattleWeatherTypeEnum();
      }
    }

    [Token(Token = "0x600F28A")]
    [Address(RVA = "0x41B3F8C", Offset = "0x41B3F8C", VA = "0x41B3F8C")]
    public StoryBattleConfig(PvEBattle.QuestBattleSceneParameter parameter)
    {
    }

    [Token(Token = "0x600F28B")]
    [Address(RVA = "0x41B83F4", Offset = "0x41B83F4", VA = "0x41B83F4")]
    protected StoryBattleConfig()
    {
    }

    [Token(Token = "0x600F28C")]
    [Address(RVA = "0x41B7754", Offset = "0x41B7754", VA = "0x41B7754")]
    protected void SetupMasterData(QuestTypeEnum questType, int questId)
    {
    }

    [Token(Token = "0x600F28D")]
    [Address(RVA = "0x41B84EC", Offset = "0x41B84EC", VA = "0x41B84EC", Slot = "46")]
    protected virtual void SetupSortieInformation(int lapCnt)
    {
    }

    [Token(Token = "0x600F28E")]
    [Address(RVA = "0x41B7FA0", Offset = "0x41B7FA0", VA = "0x41B7FA0")]
    protected void SetupDropInformation(
      PlayerBattleChestDropType[] chestDropInfos,
      PlayerBattleEnemyDrop[] enemyDrops)
    {
    }

    [Token(Token = "0x600F28F")]
    [Address(RVA = "0x41B81FC", Offset = "0x41B81FC", VA = "0x41B81FC")]
    protected void SetupTimeAndWeather(
      BattleTimeTypeEnum overrideTimeSlot,
      BattleWeatherTypeEnum overrideWeather)
    {
    }

    [Token(Token = "0x600F290")]
    [Address(RVA = "0x41B8234", Offset = "0x41B8234", VA = "0x41B8234")]
    private void SetupBattleSetting()
    {
    }

    [Token(Token = "0x600F291")]
    [Address(RVA = "0x41B96A8", Offset = "0x41B96A8", VA = "0x41B96A8", Slot = "40")]
    public override string GetDefaultBgmName() => (string) null;

    [Token(Token = "0x600F292")]
    [Address(RVA = "0x41B96C4", Offset = "0x41B96C4", VA = "0x41B96C4", Slot = "41")]
    public override List<string> GetAllBgmNames() => (List<string>) null;

    [Token(Token = "0x600F293")]
    [Address(RVA = "0x41B99A4", Offset = "0x41B99A4", VA = "0x41B99A4", Slot = "47")]
    public virtual string GetPhaseFieldBgmName(ForceTypeEnum force) => (string) null;

    [Token(Token = "0x600F294")]
    [Address(RVA = "0x41B9A28", Offset = "0x41B9A28", VA = "0x41B9A28", Slot = "42")]
    public override void SaveSettings()
    {
    }

    [Token(Token = "0x600F295")]
    [Address(RVA = "0x41B9B44", Offset = "0x41B9B44", VA = "0x41B9B44", Slot = "43")]
    public override BattleSettingsSaveData.BattleCamera[] GetCameraSettings()
    {
      return (BattleSettingsSaveData.BattleCamera[]) null;
    }

    [Token(Token = "0x600F296")]
    [Address(RVA = "0x41B9BC8", Offset = "0x41B9BC8", VA = "0x41B9BC8", Slot = "44")]
    public override void SaveCameraSettings(BattleSettingsSaveData.BattleCamera[] cameras)
    {
    }

    [Token(Token = "0x600F297")]
    [Address(RVA = "0x41B9C94", Offset = "0x41B9C94", VA = "0x41B9C94", Slot = "45")]
    public override void OnOnUpdateCameraDistance(float distance)
    {
    }

    [Token(Token = "0x600F298")]
    [Address(RVA = "0x41B9D64", Offset = "0x41B9D64", VA = "0x41B9D64", Slot = "3")]
    public override string ToString() => (string) null;
  }
}
