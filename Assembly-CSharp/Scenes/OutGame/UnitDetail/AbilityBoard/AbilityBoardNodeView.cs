// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardNodeView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.Param;
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x2003336")]
  public class AbilityBoardNodeView : MonoBehaviour
  {
    [Token(Token = "0x400DD95")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400DD96")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text nodeNameText;
    [Token(Token = "0x400DD97")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private AbilityBoardIcon abilityBoardIcon;
    [Token(Token = "0x400DD98")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text rewardText;
    [Token(Token = "0x400DD99")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text statusUpText;
    [Token(Token = "0x400DD9A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton unlockButton;
    [Token(Token = "0x400DD9B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text unlockButtonText;
    [Token(Token = "0x400DD9C")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private ItemIcon abilityBoardItemIcon;
    [Token(Token = "0x400DD9D")]
    [FieldOffset(Offset = "0x58")]
    private Dictionary<ItemIcon, ItemData> itemIconDic;
    [Token(Token = "0x400DD9E")]
    [FieldOffset(Offset = "0x60")]
    private Style style;
    [Token(Token = "0x400DD9F")]
    [FieldOffset(Offset = "0x68")]
    private AbilityBoardStyleSettingData styleSettingData;
    [Token(Token = "0x400DDA0")]
    [FieldOffset(Offset = "0x70")]
    private AbilityBoardNodeData nodeData;
    [Token(Token = "0x400DDA1")]
    [FieldOffset(Offset = "0x78")]
    private List<PlayerUnitAbilityBoardType> unlockNodeData;
    [Token(Token = "0x400DDA2")]
    [FieldOffset(Offset = "0x80")]
    private List<AbilityBoardReleaseNodeData> releaseNodeDatas;
    [Token(Token = "0x400DDA3")]
    [FieldOffset(Offset = "0x88")]
    private List<int> nodeIdList;
    [Token(Token = "0x400DDA4")]
    [FieldOffset(Offset = "0x90")]
    private AbilityBoardBulkReleasePopup bulkReleasePopup;
    [Token(Token = "0x400DDA5")]
    [FieldOffset(Offset = "0x98")]
    private int boardId;
    [Token(Token = "0x400DDA6")]
    [FieldOffset(Offset = "0x9C")]
    private int boardListId;
    [Token(Token = "0x400DDA7")]
    [FieldOffset(Offset = "0xA0")]
    private bool isBulkRelease;
    [Token(Token = "0x400DDA8")]
    [FieldOffset(Offset = "0xA1")]
    private bool isItemLack;
    [Token(Token = "0x400DDA9")]
    [FieldOffset(Offset = "0xA2")]
    private bool isIncludeCustom;
    [Token(Token = "0x400DDAA")]
    [FieldOffset(Offset = "0xA3")]
    private bool isStraddleBoard;
    [Token(Token = "0x400DDAB")]
    [FieldOffset(Offset = "0xA4")]
    private bool isLock;
    [Token(Token = "0x400DDAC")]
    [FieldOffset(Offset = "0xA8")]
    public IAbilityBoardIconLoader iconLoader;
    [Token(Token = "0x400DDAD")]
    [FieldOffset(Offset = "0xB0")]
    public Action<List<AbilityBoardReleaseNodeData>> OnNodeUnlockAction;
    [Token(Token = "0x400DDAE")]
    [FieldOffset(Offset = "0xB8")]
    public Action CloseCallback;
    [Token(Token = "0x400DDAF")]
    [FieldOffset(Offset = "0xC0")]
    public IItemDetailController itemDetailController;
    [Token(Token = "0x400DDB0")]
    [FieldOffset(Offset = "0xC8")]
    private PlayerProfile playerProfile;
    [Token(Token = "0x400DDB1")]
    [FieldOffset(Offset = "0xD0")]
    private StyleMasterBonus styleMasterBonus;
    [Token(Token = "0x400DDB2")]
    [FieldOffset(Offset = "0xD8")]
    private bool viewControlAllowed;

    [Token(Token = "0x60141F0")]
    [Address(RVA = "0x20CB300", Offset = "0x20CB300", VA = "0x20CB300")]
    public void AllowViewControl()
    {
    }

    [Token(Token = "0x60141F1")]
    [Address(RVA = "0x20CB30C", Offset = "0x20CB30C", VA = "0x20CB30C")]
    public void NotAllowViewControl()
    {
    }

    [Token(Token = "0x60141F2")]
    [Address(RVA = "0x20CB314", Offset = "0x20CB314", VA = "0x20CB314")]
    public void SetData(
      Style style,
      AbilityBoardStyleSettingData styleSettingData,
      int boardListId,
      int boardId,
      int nodeId,
      List<PlayerUnitAbilityBoardType> playerUnitAbilityBoardTypes)
    {
    }

    [Token(Token = "0x60141F3")]
    [Address(RVA = "0x20CC0E4", Offset = "0x20CC0E4", VA = "0x20CC0E4")]
    private void OnNodeOpenButton()
    {
    }

    [Token(Token = "0x60141F4")]
    [Address(RVA = "0x20CC410", Offset = "0x20CC410", VA = "0x20CC410")]
    private void OpenBulkReleasePopup()
    {
    }

    [Token(Token = "0x60141F5")]
    [Address(RVA = "0x20CC43C", Offset = "0x20CC43C", VA = "0x20CC43C")]
    private void CreateBulkReleaseData()
    {
    }

    [Token(Token = "0x60141F6")]
    [Address(RVA = "0x20CC4D0", Offset = "0x20CC4D0", VA = "0x20CC4D0")]
    private void CallAbilityBoardBulkRelease()
    {
    }

    [Token(Token = "0x60141F7")]
    [Address(RVA = "0x20CC734", Offset = "0x20CC734", VA = "0x20CC734")]
    private void OnClickItemIcon(ItemIcon itemIcon)
    {
    }

    [Token(Token = "0x60141F8")]
    [Address(RVA = "0x20CC844", Offset = "0x20CC844", VA = "0x20CC844")]
    public void OnSceneChangedInItemDetail()
    {
    }

    [Token(Token = "0x60141F9")]
    [Address(RVA = "0x20CC8CC", Offset = "0x20CC8CC", VA = "0x20CC8CC")]
    public AbilityBoardNodeView()
    {
    }
  }
}
