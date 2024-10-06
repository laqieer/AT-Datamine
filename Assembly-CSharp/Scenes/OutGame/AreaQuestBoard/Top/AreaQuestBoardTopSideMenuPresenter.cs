// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.Top.AreaQuestBoardTopSideMenuPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.OutGame.AreaQuestBoard.Top.SideMenu;
using Scenes.OutGame.OutGameMenu.ShopDetail;
using StaqData;
using System.Collections;
using UI.ItemDetail;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard.Top
{
  [Token(Token = "0x20038DE")]
  internal class AreaQuestBoardTopSideMenuPresenter : IAreaQuestTopPresenter
  {
    [Token(Token = "0x400F8C4")]
    [FieldOffset(Offset = "0x10")]
    private readonly AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400F8C5")]
    [FieldOffset(Offset = "0x18")]
    private readonly AreaQuestBoardSubScene subScene;
    [Token(Token = "0x400F8C6")]
    [FieldOffset(Offset = "0x20")]
    private readonly AreaQuestBoardSideMenu sideMenuView;
    [Token(Token = "0x400F8C7")]
    [FieldOffset(Offset = "0x28")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;
    [Token(Token = "0x400F8C8")]
    [FieldOffset(Offset = "0x30")]
    private PopupBase itemDetailPopup;
    [Token(Token = "0x400F8C9")]
    [FieldOffset(Offset = "0x38")]
    private ShopItemDetailPopup otherItemDetailPopup;
    [Token(Token = "0x400F8CA")]
    [FieldOffset(Offset = "0x40")]
    private QuestDetailPopup questDetailPopup;

    [Token(Token = "0x60165C2")]
    [Address(RVA = "0x2073298", Offset = "0x2073298", VA = "0x2073298")]
    public AreaQuestBoardTopSideMenuPresenter(
      AreaQuestBoardSubScene subScene,
      AreaQuestBoardSideMenu sideMenuView,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x60165C3")]
    [Address(RVA = "0x2077788", Offset = "0x2077788", VA = "0x2077788", Slot = "4")]
    public IEnumerator Init() => (IEnumerator) null;

    [Token(Token = "0x60165C4")]
    [Address(RVA = "0x207F92C", Offset = "0x207F92C", VA = "0x207F92C", Slot = "5")]
    public void Setup()
    {
    }

    [Token(Token = "0x60165C5")]
    [Address(RVA = "0x207F930", Offset = "0x207F930", VA = "0x207F930", Slot = "6")]
    public void Execute()
    {
    }

    [Token(Token = "0x60165C6")]
    [Address(RVA = "0x207F934", Offset = "0x207F934", VA = "0x207F934", Slot = "7")]
    public void Release()
    {
    }

    [Token(Token = "0x60165C7")]
    [Address(RVA = "0x20740F0", Offset = "0x20740F0", VA = "0x20740F0")]
    public void Refresh(int nodeId, QuestDifficultyTypeEnum difficulty, bool isEvent)
    {
    }

    [Token(Token = "0x60165C8")]
    [Address(RVA = "0x207F984", Offset = "0x207F984", VA = "0x207F984")]
    private IEnumerator OpenQuestDetailPopup(QuestInfo info) => (IEnumerator) null;

    [Token(Token = "0x60165C9")]
    [Address(RVA = "0x207FA20", Offset = "0x207FA20", VA = "0x207FA20")]
    private void OnClickRewardItem(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x60165CA")]
    [Address(RVA = "0x207FCB4", Offset = "0x207FCB4", VA = "0x207FCB4")]
    private void OpenSingleItemDetailPopup(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x60165CB")]
    [Address(RVA = "0x207FB3C", Offset = "0x207FB3C", VA = "0x207FB3C")]
    private void OpenOtherDetailPopup(RewardTypeEnum rewardType, int rewardId)
    {
    }
  }
}
