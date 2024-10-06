// Decompiled with JetBrains decompiler
// Type: Scenes.Mission.MissionSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace Scenes.Mission
{
  [Token(Token = "0x2002A99")]
  public class MissionSubScene : GlobalMenuFrontContentsBase
  {
    [Token(Token = "0x400B548")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400B549")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400B54A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private MissionContainer missionPanel;
    [Token(Token = "0x400B54B")]
    [FieldOffset(Offset = "0x40")]
    private MissionSideMenu missionBoxSideMenu;
    [Token(Token = "0x400B54C")]
    [FieldOffset(Offset = "0x48")]
    private UITweenGroup badgeController;
    [Token(Token = "0x400B54D")]
    [FieldOffset(Offset = "0x50")]
    private ItemRewardPopupManage popupObj;
    [Token(Token = "0x400B54E")]
    [FieldOffset(Offset = "0x58")]
    private MissionSubScene.TabType currentTypeMode;
    [Token(Token = "0x400B54F")]
    [FieldOffset(Offset = "0x60")]
    private GameCore.AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400B551")]
    public const string SubSceneMissionSideList = "ui_page_header";
    [Token(Token = "0x400B552")]
    public const string SubSceneMissionSideListPrefabName = "Container_SideMenu_Mission";

    [Token(Token = "0x6010AAB")]
    [Address(RVA = "0x4BCF460", Offset = "0x4BCF460", VA = "0x4BCF460")]
    public GameCore.AssetCachedSpawner AssetCachedSpawner() => (GameCore.AssetCachedSpawner) null;

    [Token(Token = "0x170039C3")]
    public ItemDetailPopupProvider ItemDetailPopupProvider
    {
      [Token(Token = "0x6010AAC"), Address(RVA = "0x4BCF468", Offset = "0x4BCF468", VA = "0x4BCF468")] get
      {
        return (ItemDetailPopupProvider) null;
      }
    }

    [Token(Token = "0x6010AAD")]
    [Address(RVA = "0x4BCF470", Offset = "0x4BCF470", VA = "0x4BCF470")]
    private void Update()
    {
    }

    [Token(Token = "0x6010AAE")]
    [Address(RVA = "0x4BCF48C", Offset = "0x4BCF48C", VA = "0x4BCF48C")]
    private void SetInteractable(bool value)
    {
    }

    [Token(Token = "0x6010AAF")]
    [Address(RVA = "0x4BCAF8C", Offset = "0x4BCAF8C", VA = "0x4BCAF8C")]
    public void DisableInteractable()
    {
    }

    [Token(Token = "0x6010AB0")]
    [Address(RVA = "0x4BCF524", Offset = "0x4BCF524", VA = "0x4BCF524")]
    public void EnableInteractable()
    {
    }

    [Token(Token = "0x6010AB1")]
    [Address(RVA = "0x4BCF550", Offset = "0x4BCF550", VA = "0x4BCF550")]
    public IEnumerator LoadWaitByAssetBundle(string label, Action<string, bool> successAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010AB2")]
    [Address(RVA = "0x4BCF5EC", Offset = "0x4BCF5EC", VA = "0x4BCF5EC", Slot = "4")]
    public override void Initialize(Transform left, Scenes.GlobalMenuFrontView.GlobalMenuFrontView view)
    {
    }

    [Token(Token = "0x6010AB3")]
    [Address(RVA = "0x4BCF920", Offset = "0x4BCF920", VA = "0x4BCF920")]
    private new IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6010AB4")]
    [Address(RVA = "0x4BCF9B0", Offset = "0x4BCF9B0", VA = "0x4BCF9B0")]
    private IEnumerator SetBadgeState(int currIndex = 0) => (IEnumerator) null;

    [Token(Token = "0x6010AB5")]
    [Address(RVA = "0x4BCFA50", Offset = "0x4BCFA50", VA = "0x4BCFA50")]
    public void GoToReceivedList(List<Reward> receivedItems, Action callback)
    {
    }

    [Token(Token = "0x6010AB6")]
    [Address(RVA = "0x4BCFD7C", Offset = "0x4BCFD7C", VA = "0x4BCFD7C")]
    public IEnumerator GoToUnreceivedList(List<Reward> unreceivedRewards, Action finishAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010AB7")]
    [Address(RVA = "0x4BCBAD8", Offset = "0x4BCBAD8", VA = "0x4BCBAD8")]
    public void GoToRewardList(MissionProgressRewardDescriptionData rewardData, Action callback)
    {
    }

    [Token(Token = "0x6010AB8")]
    [Address(RVA = "0x4BCFCEC", Offset = "0x4BCFCEC", VA = "0x4BCFCEC")]
    private IEnumerator ShowRewardNofity(
      List<DisplayItemRewardInfoData> infos,
      bool showEffect = true,
      Action callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010AB9")]
    [Address(RVA = "0x4BCFE48", Offset = "0x4BCFE48", VA = "0x4BCFE48")]
    private IEnumerator PopupSetBGAlpha() => (IEnumerator) null;

    [Token(Token = "0x6010ABA")]
    [Address(RVA = "0x4BCAD58", Offset = "0x4BCAD58", VA = "0x4BCAD58")]
    public IEnumerator ChangeMode() => (IEnumerator) null;

    [Token(Token = "0x6010ABB")]
    [Address(RVA = "0x4BCFF00", Offset = "0x4BCFF00", VA = "0x4BCFF00")]
    private MissionContentsModel GetContentsModel(MissionSubScene.TabType tabType)
    {
      return (MissionContentsModel) null;
    }

    [Token(Token = "0x6010ABC")]
    [Address(RVA = "0x4BCFF38", Offset = "0x4BCFF38", VA = "0x4BCFF38")]
    private int GetGroupID(int index) => new int();

    [Token(Token = "0x6010ABD")]
    [Address(RVA = "0x4BD00D4", Offset = "0x4BD00D4", VA = "0x4BD00D4")]
    public MissionSubScene()
    {
    }

    [Token(Token = "0x2002A9A")]
    public enum TabType
    {
      [Token(Token = "0x400B554")] Daily,
      [Token(Token = "0x400B555")] Weakly,
      [Token(Token = "0x400B556")] Main,
      [Token(Token = "0x400B557")] Event,
    }
  }
}
