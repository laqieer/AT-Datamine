// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardSelectModeView
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

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x200333E")]
  public class AbilityBoardSelectModeView : MonoBehaviour
  {
    [Token(Token = "0x400DDD0")]
    [FieldOffset(Offset = "0x18")]
    [Header("必要素材")]
    [SerializeField]
    private ItemIcon abilityBoardItemIcon;
    [Token(Token = "0x400DDD1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Header("Xボタン")]
    private CommonButton closeButton;
    [Token(Token = "0x400DDD2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Header("解放ボタン")]
    private CommonButton unlockButton;
    [Token(Token = "0x400DDD7")]
    [FieldOffset(Offset = "0x50")]
    private AbilityBoardSelectModeView.InvalidShowToasterType invalidShowToasterType;
    [Token(Token = "0x400DDD8")]
    [FieldOffset(Offset = "0x58")]
    private Dictionary<ItemIcon, ItemData> itemIconDic;
    [Token(Token = "0x400DDD9")]
    [FieldOffset(Offset = "0x60")]
    private Dictionary<int, ItemData> cacheItemDatas;
    [Token(Token = "0x400DDDA")]
    [FieldOffset(Offset = "0x68")]
    private Dictionary<int, int> cacheNeedItemAmount;
    [Token(Token = "0x400DDDB")]
    [FieldOffset(Offset = "0x70")]
    private Style style;
    [Token(Token = "0x400DDDC")]
    [FieldOffset(Offset = "0x78")]
    private AbilityBoardStyleSettingData styleSettingData;
    [Token(Token = "0x400DDDD")]
    [FieldOffset(Offset = "0x80")]
    private HashSet<int> nodeIds;
    [Token(Token = "0x400DDDE")]
    [FieldOffset(Offset = "0x88")]
    private List<PlayerUnitAbilityBoardType> unlockNodeData;
    [Token(Token = "0x400DDDF")]
    [FieldOffset(Offset = "0x90")]
    private List<AbilityBoardReleaseNodeData> releaseNodeDatas;
    [Token(Token = "0x400DDE0")]
    [FieldOffset(Offset = "0x98")]
    private PlayerProfile playerProfile;
    [Token(Token = "0x400DDE1")]
    [FieldOffset(Offset = "0xA0")]
    private AbilityBoardBulkReleasePopupCreator bulkReleasePopupCreator;
    [Token(Token = "0x400DDE2")]
    [FieldOffset(Offset = "0xA8")]
    private int boardId;
    [Token(Token = "0x400DDE3")]
    [FieldOffset(Offset = "0xAC")]
    private int boardListId;
    [Token(Token = "0x400DDE4")]
    [FieldOffset(Offset = "0xB0")]
    private bool unlockButtonInteractable;
    [Token(Token = "0x400DDE5")]
    [FieldOffset(Offset = "0xB1")]
    private bool viewControlAllowed;

    [Token(Token = "0x1700436B")]
    public Action<List<AbilityBoardReleaseNodeData>> OnNodeUnlockAction
    {
      [Token(Token = "0x6014222"), Address(RVA = "0x20CE25C", Offset = "0x20CE25C", VA = "0x20CE25C")] get
      {
        return (Action<List<AbilityBoardReleaseNodeData>>) null;
      }
      [Token(Token = "0x6014223"), Address(RVA = "0x20CE264", Offset = "0x20CE264", VA = "0x20CE264")] set
      {
      }
    }

    [Token(Token = "0x1700436C")]
    public Action CloseCallback
    {
      [Token(Token = "0x6014224"), Address(RVA = "0x20CE26C", Offset = "0x20CE26C", VA = "0x20CE26C")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6014225"), Address(RVA = "0x20CE274", Offset = "0x20CE274", VA = "0x20CE274")] set
      {
      }
    }

    [Token(Token = "0x1700436D")]
    public IItemDetailController itemDetailController
    {
      [Token(Token = "0x6014226"), Address(RVA = "0x20CE27C", Offset = "0x20CE27C", VA = "0x20CE27C")] get
      {
        return (IItemDetailController) null;
      }
      [Token(Token = "0x6014227"), Address(RVA = "0x20CE284", Offset = "0x20CE284", VA = "0x20CE284")] set
      {
      }
    }

    [Token(Token = "0x1700436E")]
    public IAbilityBoardIconLoader iconLoader
    {
      [Token(Token = "0x6014228"), Address(RVA = "0x20CE28C", Offset = "0x20CE28C", VA = "0x20CE28C")] get
      {
        return (IAbilityBoardIconLoader) null;
      }
      [Token(Token = "0x6014229"), Address(RVA = "0x20CE294", Offset = "0x20CE294", VA = "0x20CE294")] set
      {
      }
    }

    [Token(Token = "0x601422A")]
    [Address(RVA = "0x20CE29C", Offset = "0x20CE29C", VA = "0x20CE29C")]
    public void AllowViewControl()
    {
    }

    [Token(Token = "0x601422B")]
    [Address(RVA = "0x20CE2A8", Offset = "0x20CE2A8", VA = "0x20CE2A8")]
    public void NotAllowViewControl()
    {
    }

    [Token(Token = "0x601422C")]
    [Address(RVA = "0x20CE2B0", Offset = "0x20CE2B0", VA = "0x20CE2B0")]
    public void SetData(
      Style style,
      AbilityBoardStyleSettingData styleSettingData,
      int boardListId,
      int boardId,
      HashSet<int> nodeIds,
      List<PlayerUnitAbilityBoardType> playerUnitAbilityBoardTypes)
    {
    }

    [Token(Token = "0x601422D")]
    [Address(RVA = "0x20CF230", Offset = "0x20CF230", VA = "0x20CF230")]
    private void OnNodeReleaseButton()
    {
    }

    [Token(Token = "0x601422E")]
    [Address(RVA = "0x20CF620", Offset = "0x20CF620", VA = "0x20CF620")]
    private void OnClickItemIcon(ItemIcon itemIcon)
    {
    }

    [Token(Token = "0x601422F")]
    [Address(RVA = "0x20CF730", Offset = "0x20CF730", VA = "0x20CF730")]
    public void OnCloseAllNodeReleasePopup()
    {
    }

    [Token(Token = "0x6014230")]
    [Address(RVA = "0x20CE754", Offset = "0x20CE754", VA = "0x20CE754")]
    private void CheckCanReleaseNode()
    {
    }

    [Token(Token = "0x6014231")]
    [Address(RVA = "0x20CE93C", Offset = "0x20CE93C", VA = "0x20CE93C")]
    private void UpdateItemUi()
    {
    }

    [Token(Token = "0x6014232")]
    [Address(RVA = "0x20CE3F0", Offset = "0x20CE3F0", VA = "0x20CE3F0")]
    private void InitButton()
    {
    }

    [Token(Token = "0x6014233")]
    [Address(RVA = "0x20CF4E8", Offset = "0x20CF4E8", VA = "0x20CF4E8")]
    private void CreatePopup()
    {
    }

    [Token(Token = "0x6014234")]
    [Address(RVA = "0x20CF338", Offset = "0x20CF338", VA = "0x20CF338")]
    private void ShowToaster()
    {
    }

    [Token(Token = "0x6014235")]
    [Address(RVA = "0x20CE540", Offset = "0x20CE540", VA = "0x20CE540")]
    private void ClearItemDic()
    {
    }

    [Token(Token = "0x6014236")]
    [Address(RVA = "0x20CF750", Offset = "0x20CF750", VA = "0x20CF750")]
    public AbilityBoardSelectModeView()
    {
    }

    [Token(Token = "0x200333F")]
    private enum InvalidShowToasterType
    {
      [Token(Token = "0x400DDE7")] None,
      [Token(Token = "0x400DDE8")] Lock,
      [Token(Token = "0x400DDE9")] StraddleBoard,
      [Token(Token = "0x400DDEA")] IncludeCustom,
      [Token(Token = "0x400DDEB")] ItemLack,
    }
  }
}
