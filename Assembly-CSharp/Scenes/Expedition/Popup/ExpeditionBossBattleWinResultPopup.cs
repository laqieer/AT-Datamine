// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Popup.ExpeditionBossBattleWinResultPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using Network.Param;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.Popup
{
  [Token(Token = "0x2002C60")]
  public class ExpeditionBossBattleWinResultPopup : PopupBase
  {
    [Token(Token = "0x400BD10")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton bgButton;
    [Token(Token = "0x400BD11")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton tapNextButton;
    [Token(Token = "0x400BD12")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject stageUnlockMegObj;
    [Token(Token = "0x400BD13")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text stageUnlockMegText;
    [Token(Token = "0x400BD14")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text subMegText;
    [Token(Token = "0x400BD15")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private List<BossResultUnitSlot> unitSlots;
    [Token(Token = "0x400BD16")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Transform itemParent;
    [Token(Token = "0x400BD17")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private BossResultItemBlock resultItemBlock;
    [Token(Token = "0x400BD18")]
    [FieldOffset(Offset = "0xC8")]
    private List<BossResultItemBlock> itemBlockList;
    [Token(Token = "0x400BD19")]
    [FieldOffset(Offset = "0xD0")]
    private List<ExpeditionBossBattleWinResultPopup.ViewItemData> viewItemDatas;
    [Token(Token = "0x400BD1A")]
    [FieldOffset(Offset = "0xD8")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;
    [Token(Token = "0x400BD1B")]
    private const int ICON_NUM = 6;
    [Token(Token = "0x400BD1C")]
    [FieldOffset(Offset = "0xE0")]
    private Action closeAction;

    [Token(Token = "0x6011612")]
    [Address(RVA = "0x4E1B7C0", Offset = "0x4E1B7C0", VA = "0x4E1B7C0")]
    public void Initialized(
      bool isStageUnlock,
      int stageId,
      int bossLevel,
      List<int> rareRewardIds)
    {
    }

    [Token(Token = "0x6011613")]
    [Address(RVA = "0x4E1CADC", Offset = "0x4E1CADC", VA = "0x4E1CADC")]
    private bool IsPararaUp(PlayerUnitCharacterType beforeUnitChara, Style afterUnit) => new bool();

    [Token(Token = "0x6011614")]
    [Address(RVA = "0x4E1CBE0", Offset = "0x4E1CBE0", VA = "0x4E1CBE0")]
    private IEnumerator PlayVoice(string voicePackId, string voiceId, float delayTime = 0.0f)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011615")]
    [Address(RVA = "0x4E1CC6C", Offset = "0x4E1CC6C", VA = "0x4E1CC6C")]
    private void AddViewItemDatas(
      ExpeditionBossBattleWinResultPopup.ViewItemData data)
    {
    }

    [Token(Token = "0x6011616")]
    [Address(RVA = "0x4E1CDFC", Offset = "0x4E1CDFC", VA = "0x4E1CDFC", Slot = "6")]
    public override void OnBackClosed()
    {
    }

    [Token(Token = "0x6011617")]
    [Address(RVA = "0x4E1CE08", Offset = "0x4E1CE08", VA = "0x4E1CE08", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x6011618")]
    [Address(RVA = "0x4E1CE34", Offset = "0x4E1CE34", VA = "0x4E1CE34")]
    public void Back()
    {
    }

    [Token(Token = "0x6011619")]
    [Address(RVA = "0x4E1CE4C", Offset = "0x4E1CE4C", VA = "0x4E1CE4C")]
    public void SetCloseAction(Action closeAction)
    {
    }

    [Token(Token = "0x601161A")]
    [Address(RVA = "0x4E1CE54", Offset = "0x4E1CE54", VA = "0x4E1CE54")]
    private void OpenItemDetailPopup(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x601161B")]
    [Address(RVA = "0x4E1D044", Offset = "0x4E1D044", VA = "0x4E1D044")]
    private IEnumerator ItemDetailInit(RewardTypeEnum rewardType, int rewardId)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601161C")]
    [Address(RVA = "0x4E1D0C0", Offset = "0x4E1D0C0", VA = "0x4E1D0C0")]
    private void OpenItemDetail(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x601161D")]
    [Address(RVA = "0x4E1CEB4", Offset = "0x4E1CEB4", VA = "0x4E1CEB4")]
    private void OpenOtherDetailPopup(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x601161E")]
    [Address(RVA = "0x4E1D138", Offset = "0x4E1D138", VA = "0x4E1D138")]
    private void CloseDetailPopup()
    {
    }

    [Token(Token = "0x601161F")]
    [Address(RVA = "0x4E1D154", Offset = "0x4E1D154", VA = "0x4E1D154")]
    public ExpeditionBossBattleWinResultPopup()
    {
    }

    [Token(Token = "0x2002C61")]
    public class ViewItemData
    {
      [Token(Token = "0x400BD1D")]
      [FieldOffset(Offset = "0x10")]
      public RewardTypeEnum rewardType;
      [Token(Token = "0x400BD1E")]
      [FieldOffset(Offset = "0x14")]
      public int rewardId;
      [Token(Token = "0x400BD1F")]
      [FieldOffset(Offset = "0x18")]
      public int amount;

      [Token(Token = "0x6011620")]
      [Address(RVA = "0x4E1CC64", Offset = "0x4E1CC64", VA = "0x4E1CC64")]
      public ViewItemData()
      {
      }
    }
  }
}
