// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaTopSceneBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Scene;
using Il2CppDummyDll;
using Network;
using Network.API;
using Network.Param;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using Tween.Tweeners;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x2003154")]
  public class ArenaTopSceneBase : ArenaSceneBase
  {
    [Token(Token = "0x400D21D")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private List<ArenaPlayerListEnemy> arenaPlayerListEnemies;
    [Token(Token = "0x400D21E")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private ArenaVersus arenaVersus;
    [Token(Token = "0x400D21F")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Button reloadButton;
    [Token(Token = "0x400D220")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private TweenFill reloadAnim;
    [Token(Token = "0x400D221")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private ArenaTop arenaTop;
    [Token(Token = "0x400D222")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Camera backUICamera;
    [Token(Token = "0x400D223")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Canvas backUI;
    [Token(Token = "0x400D224")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400D227")]
    private const string KeyArenaTopIn = "ArenaTop_In";
    [Token(Token = "0x400D228")]
    private const string KeyArenaTopOut = "ArenaTop_Out";
    [Token(Token = "0x400D229")]
    private const string KeyArenaVersusIn = "ArenaTop_Versus_In";
    [Token(Token = "0x400D22A")]
    private const string KeyArenaVersusOut = "ArenaTop_Versus_Out";
    [Token(Token = "0x400D22B")]
    private const string ArenaTutorialAssetBundle = "content_luascript_story_tutorial";
    [Token(Token = "0x400D22C")]
    private const string ArenaTutorialAssetName1 = "ARENA_TUTORIAL_TOP_1";
    [Token(Token = "0x400D22D")]
    private const string ArenaTutorialAssetName2 = "ARENA_TUTORIAL_TOP_2";
    [Token(Token = "0x400D22E")]
    public const string HomeBGM = "BGM_ADV_Knight";
    [Token(Token = "0x400D22F")]
    [FieldOffset(Offset = "0xC8")]
    private APIArenaResponse arenaResponse;
    [Token(Token = "0x400D230")]
    [FieldOffset(Offset = "0xD0")]
    private APIArenaDetailResponse arenaDetailResponse;
    [Token(Token = "0x400D231")]
    [FieldOffset(Offset = "0xD8")]
    private APIArenaResultDefenseResponse arenaResultDefenseResponse;
    [Token(Token = "0x400D233")]
    [FieldOffset(Offset = "0xE8")]
    private ArenaTopSceneBase.SceneType sceneType;
    [Token(Token = "0x400D234")]
    [FieldOffset(Offset = "0xF0")]
    public Decks playerDeck;
    [Token(Token = "0x400D235")]
    [FieldOffset(Offset = "0xF8")]
    private DateTime topNextReloadTime;
    [Token(Token = "0x400D236")]
    [FieldOffset(Offset = "0x100")]
    private DateTime versusNextReloadTime;
    [Token(Token = "0x400D237")]
    [FieldOffset(Offset = "0x108")]
    private IEnumerator OneMinuteAction;
    [Token(Token = "0x400D238")]
    [FieldOffset(Offset = "0x110")]
    public bool IsBusy;
    [Token(Token = "0x400D239")]
    [FieldOffset(Offset = "0x111")]
    public bool IsTutorial;

    [Token(Token = "0x1700405C")]
    public long arenaId
    {
      [Token(Token = "0x60133EF"), Address(RVA = "0x4A24920", Offset = "0x4A24920", VA = "0x4A24920")] get
      {
        return new long();
      }
      [Token(Token = "0x60133F0"), Address(RVA = "0x4A24928", Offset = "0x4A24928", VA = "0x4A24928")] private set
      {
      }
    }

    [Token(Token = "0x1700405D")]
    public int arenaGroupId
    {
      [Token(Token = "0x60133F1"), Address(RVA = "0x4A24930", Offset = "0x4A24930", VA = "0x4A24930")] get
      {
        return new int();
      }
      [Token(Token = "0x60133F2"), Address(RVA = "0x4A24938", Offset = "0x4A24938", VA = "0x4A24938")] private set
      {
      }
    }

    [Token(Token = "0x1700405E")]
    public PlayerArenaType arenaType
    {
      [Token(Token = "0x60133F3"), Address(RVA = "0x4A24940", Offset = "0x4A24940", VA = "0x4A24940")] get
      {
        return (PlayerArenaType) null;
      }
      [Token(Token = "0x60133F4"), Address(RVA = "0x4A24948", Offset = "0x4A24948", VA = "0x4A24948")] private set
      {
      }
    }

    [Token(Token = "0x60133F5")]
    [Address(RVA = "0x4A24950", Offset = "0x4A24950", VA = "0x4A24950", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x60133F6")]
    [Address(RVA = "0x4A24A10", Offset = "0x4A24A10", VA = "0x4A24A10", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60133F7")]
    [Address(RVA = "0x4A24AA0", Offset = "0x4A24AA0", VA = "0x4A24AA0")]
    private void PlayTutorial()
    {
    }

    [Token(Token = "0x60133F8")]
    [Address(RVA = "0x4A24CF0", Offset = "0x4A24CF0", VA = "0x4A24CF0")]
    private void NoneArenaParty()
    {
    }

    [Token(Token = "0x60133F9")]
    [Address(RVA = "0x4A24F14", Offset = "0x4A24F14", VA = "0x4A24F14")]
    private IEnumerator OneMinutesReload() => (IEnumerator) null;

    [Token(Token = "0x60133FA")]
    [Address(RVA = "0x4A24FA4", Offset = "0x4A24FA4", VA = "0x4A24FA4", Slot = "20")]
    public override void BackKeyDownAction()
    {
    }

    [Token(Token = "0x60133FB")]
    [Address(RVA = "0x4A21CFC", Offset = "0x4A21CFC", VA = "0x4A21CFC")]
    public void TimeRewardReceive()
    {
    }

    [Token(Token = "0x60133FC")]
    [Address(RVA = "0x4A25334", Offset = "0x4A25334", VA = "0x4A25334")]
    private void PartyEdit()
    {
    }

    [Token(Token = "0x60133FD")]
    [Address(RVA = "0x4A2253C", Offset = "0x4A2253C", VA = "0x4A2253C")]
    public void Versus(ArenaPlayerListEnemy.EnemyParam enemy)
    {
    }

    [Token(Token = "0x60133FE")]
    [Address(RVA = "0x4A255C8", Offset = "0x4A255C8", VA = "0x4A255C8")]
    public void ButtonGlobalMenu()
    {
    }

    [Token(Token = "0x60133FF")]
    [Address(RVA = "0x4A256D0", Offset = "0x4A256D0", VA = "0x4A256D0")]
    public void ButtonRule()
    {
    }

    [Token(Token = "0x6013400")]
    [Address(RVA = "0x4A256D4", Offset = "0x4A256D4", VA = "0x4A256D4")]
    public void ButtonReward()
    {
    }

    [Token(Token = "0x6013401")]
    [Address(RVA = "0x4A25788", Offset = "0x4A25788", VA = "0x4A25788")]
    public void ButtonOption()
    {
    }

    [Token(Token = "0x6013402")]
    [Address(RVA = "0x4A258A0", Offset = "0x4A258A0", VA = "0x4A258A0")]
    public void ButtonMedalShop()
    {
    }

    [Token(Token = "0x6013403")]
    [Address(RVA = "0x4A259BC", Offset = "0x4A259BC", VA = "0x4A259BC")]
    public void ButtonChallenge()
    {
    }

    [Token(Token = "0x6013404")]
    [Address(RVA = "0x4A25A70", Offset = "0x4A25A70", VA = "0x4A25A70")]
    public void ButtonReload()
    {
    }

    [Token(Token = "0x6013405")]
    [Address(RVA = "0x4A25BF4", Offset = "0x4A25BF4", VA = "0x4A25BF4")]
    public void ButtonPartyEdit()
    {
    }

    [Token(Token = "0x6013406")]
    [Address(RVA = "0x4A25BF8", Offset = "0x4A25BF8", VA = "0x4A25BF8")]
    public void ButtonBattleLog()
    {
    }

    [Token(Token = "0x6013407")]
    [Address(RVA = "0x4A25CAC", Offset = "0x4A25CAC", VA = "0x4A25CAC")]
    private void RankingRewardPopup(Action callback)
    {
    }

    [Token(Token = "0x6013408")]
    [Address(RVA = "0x4A25DEC", Offset = "0x4A25DEC", VA = "0x4A25DEC")]
    private void DefenseResult(Action callback)
    {
    }

    [Token(Token = "0x6013409")]
    [Address(RVA = "0x4A25F2C", Offset = "0x4A25F2C", VA = "0x4A25F2C")]
    private void BattleHeadsUp()
    {
    }

    [Token(Token = "0x601340A")]
    [Address(RVA = "0x4A25F30", Offset = "0x4A25F30", VA = "0x4A25F30")]
    public IEnumerator VersusAsync(int ranking, bool isSkip) => (IEnumerator) null;

    [Token(Token = "0x601340B")]
    [Address(RVA = "0x4A25FDC", Offset = "0x4A25FDC", VA = "0x4A25FDC")]
    private IEnumerator TransitionArenaTop(NetworkErrorResult networkErrorResult)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601340C")]
    [Address(RVA = "0x4A2606C", Offset = "0x4A2606C", VA = "0x4A2606C")]
    private IEnumerator OnUpdateArenaRanking(NetworkErrorResult networkErrorResult)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601340D")]
    [Address(RVA = "0x4A260FC", Offset = "0x4A260FC", VA = "0x4A260FC")]
    private bool IsOpenArena(ArenaGroupType arenaType) => new bool();

    [Token(Token = "0x601340E")]
    [Address(RVA = "0x4A261EC", Offset = "0x4A261EC", VA = "0x4A261EC")]
    private DateTime StringToTime(string at) => new DateTime();

    [Token(Token = "0x601340F")]
    [Address(RVA = "0x4A26244", Offset = "0x4A26244", VA = "0x4A26244")]
    private void SetRankingEnemy(List<ArenaPlayerListEnemy.EnemyParam> list)
    {
    }

    [Token(Token = "0x6013410")]
    [Address(RVA = "0x4A25B8C", Offset = "0x4A25B8C", VA = "0x4A25B8C")]
    private IEnumerator RankingEnemy() => (IEnumerator) null;

    [Token(Token = "0x6013411")]
    [Address(RVA = "0x4A263CC", Offset = "0x4A263CC", VA = "0x4A263CC")]
    public IEnumerator LoadRankingEnemy(List<ArenaPlayerListEnemy.EnemyParam> list)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6013412")]
    [Address(RVA = "0x4A2645C", Offset = "0x4A2645C", VA = "0x4A2645C", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x6013413")]
    [Address(RVA = "0x4A26484", Offset = "0x4A26484", VA = "0x4A26484")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6013414")]
    [Address(RVA = "0x4A26540", Offset = "0x4A26540", VA = "0x4A26540")]
    private IEnumerator ShowTutorialSummaryPopup() => (IEnumerator) null;

    [Token(Token = "0x6013415")]
    [Address(RVA = "0x4A265D0", Offset = "0x4A265D0", VA = "0x4A265D0")]
    public void ButtonHelp()
    {
    }

    [Token(Token = "0x6013416")]
    [Address(RVA = "0x4A252CC", Offset = "0x4A252CC", VA = "0x4A252CC")]
    private IEnumerator APITimeReward() => (IEnumerator) null;

    [Token(Token = "0x6013417")]
    [Address(RVA = "0x4A26618", Offset = "0x4A26618", VA = "0x4A26618")]
    private IEnumerator APIArenaTop() => (IEnumerator) null;

    [Token(Token = "0x6013418")]
    [Address(RVA = "0x4A266A8", Offset = "0x4A266A8", VA = "0x4A266A8")]
    private IEnumerator APIArenaDetail() => (IEnumerator) null;

    [Token(Token = "0x6013419")]
    [Address(RVA = "0x4A26738", Offset = "0x4A26738", VA = "0x4A26738")]
    private IEnumerator RequestArenaDefense() => (IEnumerator) null;

    [Token(Token = "0x601341A")]
    [Address(RVA = "0x4A267C8", Offset = "0x4A267C8", VA = "0x4A267C8")]
    private PlayerDeckType CreatePlayerDeckType(DeckTypeEnum deckType, int arenaGroupId)
    {
      return (PlayerDeckType) null;
    }

    [Token(Token = "0x601341B")]
    [Address(RVA = "0x4A26884", Offset = "0x4A26884", VA = "0x4A26884")]
    public IEnumerator APIDeckEdit(Deck deck, DeckTypeEnum deckTypeEnum) => (IEnumerator) null;

    [Token(Token = "0x601341C")]
    [Address(RVA = "0x4A26928", Offset = "0x4A26928", VA = "0x4A26928")]
    public int GetCombatPower(PlayerDeckSlotInfo slot) => new int();

    [Token(Token = "0x601341D")]
    [Address(RVA = "0x4A26A94", Offset = "0x4A26A94", VA = "0x4A26A94")]
    public List<Equipment> GetEquipmentList(PlayerDeckSlotInfo slot) => (List<Equipment>) null;

    [Token(Token = "0x601341E")]
    [Address(RVA = "0x4A26F30", Offset = "0x4A26F30", VA = "0x4A26F30")]
    private Equipment GetEquipment(UniqueID? uniqueId) => (Equipment) null;

    [Token(Token = "0x601341F")]
    [Address(RVA = "0x4A271DC", Offset = "0x4A271DC", VA = "0x4A271DC")]
    public ArenaTopSceneBase()
    {
    }

    [Token(Token = "0x2003155")]
    private enum SceneType
    {
      [Token(Token = "0x400D23B")] Top,
      [Token(Token = "0x400D23C")] Versus,
      [Token(Token = "0x400D23D")] Sortie,
    }
  }
}
