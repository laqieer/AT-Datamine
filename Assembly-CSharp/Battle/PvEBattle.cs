// Decompiled with JetBrains decompiler
// Type: Battle.PvEBattle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2;
using Battle.Data;
using Battle.Data.Board;
using Battle.Logger;
using Battle.Process;
using GameCore.MasterData;
using GameCore.Scene;
using Il2CppDummyDll;
using Network.API;
using Network.Param;
using Scenes.Arena;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle
{
  [Token(Token = "0x2002291")]
  public sealed class PvEBattle : GameCore.Scene.Scene, IProcessOwner<ProcessCode>
  {
    [Token(Token = "0x40091B5")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private MainDirector mainDirector;
    [Token(Token = "0x40091B6")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private PvEBattle.TransitionSceneParam giveupTransitionScene;
    [Token(Token = "0x40091B7")]
    [FieldOffset(Offset = "0x78")]
    private BattleCore battleCore;
    [Token(Token = "0x40091B8")]
    [FieldOffset(Offset = "0x80")]
    private IBattleProcessFactory processFactory;
    [Token(Token = "0x40091B9")]
    [FieldOffset(Offset = "0x88")]
    private BattleProcessBase process;
    [Token(Token = "0x40091BA")]
    [FieldOffset(Offset = "0x90")]
    private ProcessCode nextProcess;
    [Token(Token = "0x40091BB")]
    [FieldOffset(Offset = "0x98")]
    private BattleClientLogger clientLogger;
    [Token(Token = "0x40091BC")]
    [FieldOffset(Offset = "0xA0")]
    public bool Initialized;

    [Token(Token = "0x17002DB5")]
    public bool IsPlayingBattle
    {
      [Token(Token = "0x600D2C2"), Address(RVA = "0x1965350", Offset = "0x1965350", VA = "0x1965350")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D2C3"), Address(RVA = "0x1965358", Offset = "0x1965358", VA = "0x1965358")] private set
      {
      }
    }

    [Token(Token = "0x600D2C4")]
    [Address(RVA = "0x1965364", Offset = "0x1965364", VA = "0x1965364", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x600D2C5")]
    [Address(RVA = "0x1965CC4", Offset = "0x1965CC4", VA = "0x1965CC4", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x600D2C6")]
    [Address(RVA = "0x1965D2C", Offset = "0x1965D2C", VA = "0x1965D2C")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x600D2C7")]
    [Address(RVA = "0x1966208", Offset = "0x1966208", VA = "0x1966208", Slot = "23")]
    public void OnFinishProcess(ProcessCode code)
    {
    }

    [Token(Token = "0x600D2C8")]
    [Address(RVA = "0x1966218", Offset = "0x1966218", VA = "0x1966218", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x600D2C9")]
    [Address(RVA = "0x19662EC", Offset = "0x19662EC", VA = "0x19662EC")]
    public void OnDestroy()
    {
    }

    [Token(Token = "0x600D2CA")]
    [Address(RVA = "0x19662F8", Offset = "0x19662F8", VA = "0x19662F8")]
    public void OnApplicationFocus(bool hasFocus)
    {
    }

    [Token(Token = "0x600D2CB")]
    [Address(RVA = "0x1966318", Offset = "0x1966318", VA = "0x1966318")]
    public void OnApplicationPause(bool isPaused)
    {
    }

    [Token(Token = "0x600D2CC")]
    [Address(RVA = "0x1965448", Offset = "0x1965448", VA = "0x1965448")]
    internal void ExecuteQuestBattle(PvEBattle.QuestBattleSceneParameter parameter)
    {
    }

    [Token(Token = "0x600D2CD")]
    [Address(RVA = "0x1966338", Offset = "0x1966338", VA = "0x1966338")]
    private StoryBattleConfig CreateQuestBattleConfig(PvEBattle.QuestBattleSceneParameter param)
    {
      return (StoryBattleConfig) null;
    }

    [Token(Token = "0x600D2CE")]
    [Address(RVA = "0x1965FC4", Offset = "0x1965FC4", VA = "0x1965FC4")]
    private void FinishQuestBattle()
    {
    }

    [Token(Token = "0x600D2CF")]
    [Address(RVA = "0x1965F8C", Offset = "0x1965F8C", VA = "0x1965F8C")]
    private void FinishRaidBattle()
    {
    }

    [Token(Token = "0x600D2D0")]
    [Address(RVA = "0x196641C", Offset = "0x196641C", VA = "0x196641C")]
    private void CloseBattleByWin()
    {
    }

    [Token(Token = "0x600D2D1")]
    [Address(RVA = "0x1966B2C", Offset = "0x1966B2C", VA = "0x1966B2C")]
    private void ChangeResultScene(StoryBattleConfig battleConfig)
    {
    }

    [Token(Token = "0x600D2D2")]
    [Address(RVA = "0x1967030", Offset = "0x1967030", VA = "0x1967030")]
    private void ChangeStoryBattleResultScene(
      StoryBattleConfig battleConfig,
      IReadOnlyList<IUnitPlacementData> enemyPlacements)
    {
    }

    [Token(Token = "0x600D2D3")]
    [Address(RVA = "0x1966DBC", Offset = "0x1966DBC", VA = "0x1966DBC")]
    private void ChangeScoreAttackResultScene(
      ScoreAttackConfig battleConfig,
      IReadOnlyList<IUnitPlacementData> enemyPlacements)
    {
    }

    [Token(Token = "0x600D2D4")]
    [Address(RVA = "0x1966C98", Offset = "0x1966C98", VA = "0x1966C98")]
    private void ChangeRaidBattleResultScene(
      RaidBattleConfig battleConfig,
      IReadOnlyList<IUnitPlacementData> enemyPlacements)
    {
    }

    [Token(Token = "0x600D2D5")]
    [Address(RVA = "0x1966508", Offset = "0x1966508", VA = "0x1966508")]
    private void LoseBattle()
    {
    }

    [Token(Token = "0x600D2D6")]
    [Address(RVA = "0x1967504", Offset = "0x1967504", VA = "0x1967504")]
    public IEnumerator CallBattleRetreatAPI() => (IEnumerator) null;

    [Token(Token = "0x600D2D7")]
    [Address(RVA = "0x1966538", Offset = "0x1966538", VA = "0x1966538")]
    private void CloseBattleByRetreat()
    {
    }

    [Token(Token = "0x600D2D8")]
    [Address(RVA = "0x19659D4", Offset = "0x19659D4", VA = "0x19659D4")]
    private void ExecuteArenaBattle(PvEBattle.ArenaBattleSceneParameter parameter)
    {
    }

    [Token(Token = "0x600D2D9")]
    [Address(RVA = "0x1966040", Offset = "0x1966040", VA = "0x1966040")]
    private void FinishArenaBattle()
    {
    }

    [Token(Token = "0x600D2DA")]
    [Address(RVA = "0x1965754", Offset = "0x1965754", VA = "0x1965754")]
    internal void ExecuteArenaPlace(PvEBattle.ArenaPlaceSceneParameter parameter)
    {
    }

    [Token(Token = "0x600D2DB")]
    [Address(RVA = "0x196600C", Offset = "0x196600C", VA = "0x196600C")]
    private void FinishArenaPlace()
    {
    }

    [Token(Token = "0x600D2DC")]
    [Address(RVA = "0x196756C", Offset = "0x196756C", VA = "0x196756C")]
    public IEnumerator CallDeckEditPlacementAPI() => (IEnumerator) null;

    [Token(Token = "0x600D2DD")]
    [Address(RVA = "0x19675D4", Offset = "0x19675D4", VA = "0x19675D4")]
    private void CloseArenaPlace(APIDeckEditPlacementResponse response)
    {
    }

    [Token(Token = "0x600D2DE")]
    [Address(RVA = "0x1966A64", Offset = "0x1966A64", VA = "0x1966A64")]
    private void ReleaseCache()
    {
    }

    [Token(Token = "0x600D2DF")]
    [Address(RVA = "0x196778C", Offset = "0x196778C", VA = "0x196778C")]
    private void UnloadFieldBgmPacks()
    {
    }

    [Token(Token = "0x600D2E0")]
    [Address(RVA = "0x1967954", Offset = "0x1967954", VA = "0x1967954")]
    private void UnloadVoicePacks()
    {
    }

    [Token(Token = "0x600D2E1")]
    [Address(RVA = "0x1967B10", Offset = "0x1967B10", VA = "0x1967B10")]
    private void OnGiveupButton()
    {
    }

    [Token(Token = "0x600D2E2")]
    [Address(RVA = "0x1967B24", Offset = "0x1967B24", VA = "0x1967B24")]
    private void PauseBattle()
    {
    }

    [Token(Token = "0x600D2E3")]
    [Address(RVA = "0x1967BB4", Offset = "0x1967BB4", VA = "0x1967BB4")]
    private void PauseCancellationBattle()
    {
    }

    [Token(Token = "0x600D2E4")]
    [Address(RVA = "0x19662E0", Offset = "0x19662E0", VA = "0x19662E0")]
    private void ResetTimeScale()
    {
    }

    [Token(Token = "0x600D2E5")]
    [Address(RVA = "0x1967C50", Offset = "0x1967C50", VA = "0x1967C50")]
    public ConnectBattleProcessToAdv CreateAdvConnet() => (ConnectBattleProcessToAdv) null;

    [Token(Token = "0x600D2E6")]
    [Address(RVA = "0x1967CB8", Offset = "0x1967CB8", VA = "0x1967CB8")]
    public PvEBattle()
    {
    }

    [Token(Token = "0x600D2E7")]
    [Address(RVA = "0x1967CC8", Offset = "0x1967CC8", VA = "0x1967CC8", Slot = "24")]
    private Coroutine Battle\u002EProcess\u002EIProcessOwner\u003CBattle\u002EProcess\u002EProcessCode\u003E\u002EStartCoroutine(
      IEnumerator routine)
    {
      return (Coroutine) null;
    }

    [Token(Token = "0x600D2E8")]
    [Address(RVA = "0x1967CD0", Offset = "0x1967CD0", VA = "0x1967CD0", Slot = "25")]
    private void Battle\u002EProcess\u002EIProcessOwner\u003CBattle\u002EProcess\u002EProcessCode\u003E\u002EStopCoroutine(
      IEnumerator routine)
    {
    }

    [Token(Token = "0x2002292")]
    [Serializable]
    public struct TransitionSceneParam
    {
      [Token(Token = "0x40091BE")]
      [FieldOffset(Offset = "0x0")]
      public string SceneName;
      [Token(Token = "0x40091BF")]
      [FieldOffset(Offset = "0x8")]
      public string SubSceneAssetBundleName;
      [Token(Token = "0x40091C0")]
      [FieldOffset(Offset = "0x10")]
      public string SubSceneName;
    }

    [Token(Token = "0x2002293")]
    public sealed class QuestBattleSceneParameter : ChangeSceneParameter
    {
      [Token(Token = "0x40091C1")]
      [FieldOffset(Offset = "0x18")]
      public string dlcVersion;
      [Token(Token = "0x40091C2")]
      [FieldOffset(Offset = "0x20")]
      public string appVersion;
      [Token(Token = "0x40091C3")]
      [FieldOffset(Offset = "0x28")]
      public string battleUuid;
      [Token(Token = "0x40091C4")]
      [FieldOffset(Offset = "0x30")]
      public int randomSeed;
      [Token(Token = "0x40091C5")]
      [FieldOffset(Offset = "0x34")]
      public QuestTypeEnum questType;
      [Token(Token = "0x40091C6")]
      [FieldOffset(Offset = "0x38")]
      public int questID;
      [Token(Token = "0x40091C7")]
      [FieldOffset(Offset = "0x3C")]
      public int lapCount;
      [Token(Token = "0x40091C8")]
      [FieldOffset(Offset = "0x40")]
      public int initDamage;
      [Token(Token = "0x40091C9")]
      [FieldOffset(Offset = "0x44")]
      public int deckIdx;
      [Token(Token = "0x40091CA")]
      [FieldOffset(Offset = "0x48")]
      public int[] sortieDeckSlots;
      [Token(Token = "0x40091CB")]
      [FieldOffset(Offset = "0x50")]
      public PlayerUnitLevelUpType[] unitLvUps;
      [Token(Token = "0x40091CC")]
      [FieldOffset(Offset = "0x58")]
      public int subquestTaskID;
      [Token(Token = "0x40091CD")]
      [FieldOffset(Offset = "0x60")]
      public Dictionary<int, int> battleItems;
      [Token(Token = "0x40091CE")]
      [FieldOffset(Offset = "0x68")]
      public BattleTimeTypeEnum TimeSlot;
      [Token(Token = "0x40091CF")]
      [FieldOffset(Offset = "0x6C")]
      public BattleWeatherTypeEnum Weather;
      [Token(Token = "0x40091D0")]
      [FieldOffset(Offset = "0x70")]
      public PlayerBattleChestDropType[] chestDropList;
      [Token(Token = "0x40091D1")]
      [FieldOffset(Offset = "0x78")]
      public PlayerBattleEnemyDrop[] enemyDropList;
      [Token(Token = "0x40091D2")]
      [FieldOffset(Offset = "0x80")]
      public BoardData suspendData;
      [Token(Token = "0x40091D3")]
      [FieldOffset(Offset = "0x88")]
      public int rollbackCnt;
      [Token(Token = "0x40091D4")]
      [FieldOffset(Offset = "0x8C")]
      public bool isMockBattle;

      [Token(Token = "0x600D2EF")]
      [Address(RVA = "0x19D24FC", Offset = "0x19D24FC", VA = "0x19D24FC")]
      public QuestBattleSceneParameter()
      {
      }
    }

    [Token(Token = "0x2002294")]
    public sealed class ArenaBattleSceneParameter : ChangeSceneParameter
    {
      [Token(Token = "0x40091D5")]
      [FieldOffset(Offset = "0x18")]
      public long arenaId;
      [Token(Token = "0x40091D6")]
      [FieldOffset(Offset = "0x20")]
      public int arenaGroupId;
      [Token(Token = "0x40091D7")]
      [FieldOffset(Offset = "0x28")]
      public APIArenaBattleStartResponse startResponse;
      [Token(Token = "0x40091D8")]
      [FieldOffset(Offset = "0x30")]
      public APIArenaBattleEndResponse endResponse;
      [Token(Token = "0x40091D9")]
      [FieldOffset(Offset = "0x38")]
      public bool stagingSkip;

      [Token(Token = "0x600D2F0")]
      [Address(RVA = "0x19D25B0", Offset = "0x19D25B0", VA = "0x19D25B0")]
      public ArenaBattleSceneParameter()
      {
      }
    }

    [Token(Token = "0x2002295")]
    public sealed class ArenaPlaceSceneParameter : ChangeSceneParameter
    {
      [Token(Token = "0x40091DA")]
      [FieldOffset(Offset = "0x18")]
      public long arenaId;
      [Token(Token = "0x40091DB")]
      [FieldOffset(Offset = "0x20")]
      public int arenaGroupId;
      [Token(Token = "0x40091DC")]
      [FieldOffset(Offset = "0x24")]
      public int userPlayerId;
      [Token(Token = "0x40091DD")]
      [FieldOffset(Offset = "0x28")]
      public ArenaTopSceneBase arenaSceneBase;

      [Token(Token = "0x600D2F1")]
      [Address(RVA = "0x19D25BC", Offset = "0x19D25BC", VA = "0x19D25BC")]
      public ArenaPlaceSceneParameter()
      {
      }
    }
  }
}
