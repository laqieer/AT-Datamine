// Decompiled with JetBrains decompiler
// Type: GlandMenu.GlobalMenuButtonGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Scene;
using GlobalMenu;
using Home;
using Home.Bannner;
using Home.Event;
using Home.Guild;
using Il2CppDummyDll;
using Scenes.Home.HotDeal;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace GlandMenu
{
  [Token(Token = "0x200095C")]
  public class GlobalMenuButtonGroup : MonoBehaviour
  {
    [Token(Token = "0x4002B58")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button optionButton;
    [Token(Token = "0x4002B59")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button mailButton;
    [Token(Token = "0x4002B5A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button missionButton;
    [Token(Token = "0x4002B5B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button presentButton;
    [Token(Token = "0x4002B5C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button returnButton;
    [Token(Token = "0x4002B5D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button playerInfoButton;
    [Token(Token = "0x4002B5E")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Button gachaButton;
    [Token(Token = "0x4002B5F")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Button shopButton;
    [Token(Token = "0x4002B60")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Button teamEditButton;
    [Token(Token = "0x4002B61")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Button armouryButton;
    [Token(Token = "0x4002B62")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Button chartButton;
    [Token(Token = "0x4002B63")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Button storyArchiveButton;
    [Token(Token = "0x4002B64")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Header header;
    [Token(Token = "0x4002B65")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private PlayerData playerData;
    [Token(Token = "0x4002B66")]
    [FieldOffset(Offset = "0x88")]
    private Action backSceneAction;
    [Token(Token = "0x4002B67")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GuildButtonGroup guildButtonGroup;
    [Token(Token = "0x4002B68")]
    [FieldOffset(Offset = "0x98")]
    private Button guildButton;
    [Token(Token = "0x4002B69")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Button arenaButton;
    [Token(Token = "0x4002B6A")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Button questButton;
    [Token(Token = "0x4002B6B")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Button expeditionButton;
    [Token(Token = "0x4002B6C")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Button storyButton;
    [Token(Token = "0x4002B6D")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Button panelMissionButton;
    [Token(Token = "0x4002B6E")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Button changeUnitButton;
    [Token(Token = "0x4002B6F")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private HotDealController hotDealButton;
    [Token(Token = "0x4002B70")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private HomeEventHomeButton homeEventButton;
    [Token(Token = "0x4002B71")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private Button storyShopButton;
    [Token(Token = "0x4002B72")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private GameObject extraMenuObj1;
    [Token(Token = "0x4002B73")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private Button styleRankingButton;
    [Token(Token = "0x4002B74")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private HomeBannerController bannerController;
    [Token(Token = "0x4002B75")]
    [FieldOffset(Offset = "0x100")]
    private HomeNetworkConnector networkConnector;
    [Token(Token = "0x4002B76")]
    [FieldOffset(Offset = "0x108")]
    private HomeTransitionContoller transitionContoller;
    [Token(Token = "0x4002B77")]
    [FieldOffset(Offset = "0x110")]
    public Action<bool> OnClickTransitionFunc;

    [Token(Token = "0x17000771")]
    public HotDealController HotDeal
    {
      [Token(Token = "0x60034CD"), Address(RVA = "0x36359C0", Offset = "0x36359C0", VA = "0x36359C0")] get
      {
        return (HotDealController) null;
      }
    }

    [Token(Token = "0x17000772")]
    public HomeEventHomeButton HomeEventButton
    {
      [Token(Token = "0x60034CE"), Address(RVA = "0x36359C8", Offset = "0x36359C8", VA = "0x36359C8")] get
      {
        return (HomeEventHomeButton) null;
      }
    }

    [Token(Token = "0x17000773")]
    public HomeBannerController BannerController
    {
      [Token(Token = "0x60034CF"), Address(RVA = "0x36359D0", Offset = "0x36359D0", VA = "0x36359D0")] get
      {
        return (HomeBannerController) null;
      }
    }

    [Token(Token = "0x17000774")]
    private SceneHandler sceneHandler
    {
      [Token(Token = "0x60034D0"), Address(RVA = "0x36359D8", Offset = "0x36359D8", VA = "0x36359D8")] get
      {
        return (SceneHandler) null;
      }
    }

    [Token(Token = "0x60034D1")]
    [Address(RVA = "0x3635A44", Offset = "0x3635A44", VA = "0x3635A44")]
    private void Awake()
    {
    }

    [Token(Token = "0x60034D2")]
    [Address(RVA = "0x363621C", Offset = "0x363621C", VA = "0x363621C")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60034D3")]
    [Address(RVA = "0x36362E0", Offset = "0x36362E0", VA = "0x36362E0")]
    public void StartButtonControl(Action backSceneAction)
    {
    }

    [Token(Token = "0x60034D4")]
    [Address(RVA = "0x36362E8", Offset = "0x36362E8", VA = "0x36362E8")]
    public void UpdateData(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x60034D5")]
    [Address(RVA = "0x3636448", Offset = "0x3636448", VA = "0x3636448")]
    public void UpdateExtraButtonActive()
    {
    }

    [Token(Token = "0x60034D6")]
    [Address(RVA = "0x3636184", Offset = "0x3636184", VA = "0x3636184")]
    private void AddOnClickListener(Button button, UnityAction call)
    {
    }

    [Token(Token = "0x60034D7")]
    [Address(RVA = "0x363654C", Offset = "0x363654C", VA = "0x363654C")]
    private void OnClickBack()
    {
    }

    [Token(Token = "0x60034D8")]
    [Address(RVA = "0x3636568", Offset = "0x3636568", VA = "0x3636568")]
    private void OnClickGacha()
    {
    }

    [Token(Token = "0x60034D9")]
    [Address(RVA = "0x3636588", Offset = "0x3636588", VA = "0x3636588")]
    private void OnClickShop()
    {
    }

    [Token(Token = "0x60034DA")]
    [Address(RVA = "0x36365A4", Offset = "0x36365A4", VA = "0x36365A4")]
    private void OnClickTeamEdit()
    {
    }

    [Token(Token = "0x60034DB")]
    [Address(RVA = "0x36365C0", Offset = "0x36365C0", VA = "0x36365C0")]
    private void OnClickArmoury()
    {
    }

    [Token(Token = "0x60034DC")]
    [Address(RVA = "0x36365DC", Offset = "0x36365DC", VA = "0x36365DC")]
    private void OnClickOption()
    {
    }

    [Token(Token = "0x60034DD")]
    [Address(RVA = "0x3636668", Offset = "0x3636668", VA = "0x3636668")]
    private void OnClickPlayerInfo()
    {
    }

    [Token(Token = "0x60034DE")]
    [Address(RVA = "0x36366F4", Offset = "0x36366F4", VA = "0x36366F4")]
    private void OnClickMail()
    {
    }

    [Token(Token = "0x60034DF")]
    [Address(RVA = "0x3636780", Offset = "0x3636780", VA = "0x3636780")]
    private void OnClickChart()
    {
    }

    [Token(Token = "0x60034E0")]
    [Address(RVA = "0x3636784", Offset = "0x3636784", VA = "0x3636784")]
    private void OnClickMission()
    {
    }

    [Token(Token = "0x60034E1")]
    [Address(RVA = "0x3636810", Offset = "0x3636810", VA = "0x3636810")]
    private void OnClickPresent()
    {
    }

    [Token(Token = "0x60034E2")]
    [Address(RVA = "0x363689C", Offset = "0x363689C", VA = "0x363689C")]
    private void OnClickGuild()
    {
    }

    [Token(Token = "0x60034E3")]
    [Address(RVA = "0x3636948", Offset = "0x3636948", VA = "0x3636948")]
    private void OnUpdateGuildBadge(bool sw)
    {
    }

    [Token(Token = "0x60034E4")]
    [Address(RVA = "0x3636A40", Offset = "0x3636A40", VA = "0x3636A40")]
    private void OnClickArena()
    {
    }

    [Token(Token = "0x60034E5")]
    [Address(RVA = "0x36370D8", Offset = "0x36370D8", VA = "0x36370D8")]
    private void OnClickQuest()
    {
    }

    [Token(Token = "0x60034E6")]
    [Address(RVA = "0x36370F4", Offset = "0x36370F4", VA = "0x36370F4")]
    private void OnClickExpedition()
    {
    }

    [Token(Token = "0x60034E7")]
    [Address(RVA = "0x363724C", Offset = "0x363724C", VA = "0x363724C")]
    private void OnClickQuestContentsList()
    {
    }

    [Token(Token = "0x60034E8")]
    [Address(RVA = "0x36372D8", Offset = "0x36372D8", VA = "0x36372D8")]
    private void OnClickPanelMission()
    {
    }

    [Token(Token = "0x60034E9")]
    [Address(RVA = "0x3637364", Offset = "0x3637364", VA = "0x3637364")]
    private void OnClickChangeUnit()
    {
    }

    [Token(Token = "0x60034EA")]
    [Address(RVA = "0x36373F0", Offset = "0x36373F0", VA = "0x36373F0")]
    private void OnClickStoryShop()
    {
    }

    [Token(Token = "0x60034EB")]
    [Address(RVA = "0x363747C", Offset = "0x363747C", VA = "0x363747C")]
    private void OnClickStyleRanking()
    {
    }

    [Token(Token = "0x60034EC")]
    [Address(RVA = "0x3637498", Offset = "0x3637498", VA = "0x3637498")]
    private void OnClickStoryArchive()
    {
    }

    [Token(Token = "0x60034ED")]
    [Address(RVA = "0x3636328", Offset = "0x3636328", VA = "0x3636328")]
    private void SetActivePanelMissionIcon()
    {
    }

    [Token(Token = "0x60034EE")]
    [Address(RVA = "0x363607C", Offset = "0x363607C", VA = "0x363607C")]
    private void GuildButtonSetup()
    {
    }

    [Token(Token = "0x60034EF")]
    [Address(RVA = "0x3637528", Offset = "0x3637528", VA = "0x3637528")]
    public GlobalMenuButtonGroup()
    {
    }
  }
}
