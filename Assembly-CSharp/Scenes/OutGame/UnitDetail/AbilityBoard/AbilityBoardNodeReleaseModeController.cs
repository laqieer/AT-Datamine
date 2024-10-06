// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardNodeReleaseModeController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using StaqData;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x2003331")]
  public class AbilityBoardNodeReleaseModeController
  {
    [Token(Token = "0x400DD79")]
    [FieldOffset(Offset = "0x10")]
    private AbilityBoardView view;
    [Token(Token = "0x400DD7A")]
    [FieldOffset(Offset = "0x18")]
    private AbilityBoardBehaviour boardBehaviour;
    [Token(Token = "0x400DD7B")]
    [FieldOffset(Offset = "0x20")]
    private AbilityBoardCacheNodeData cacheNodeData;
    [Token(Token = "0x400DD7C")]
    [FieldOffset(Offset = "0x28")]
    private AbilityBoardNodeReleaseModeController.NodeReleaseMode mode;
    [Token(Token = "0x400DD7D")]
    [FieldOffset(Offset = "0x2C")]
    private AbilityBoardNodeReleaseModeController.ToasterShowType toasterShowType;
    [Token(Token = "0x400DD7E")]
    [FieldOffset(Offset = "0x30")]
    private HashSet<int> cacheNodeIdsfullyReleased;
    [Token(Token = "0x400DD7F")]
    [FieldOffset(Offset = "0x38")]
    private HashSet<int> cacheNodeIdsSelectReleased;
    [Token(Token = "0x400DD80")]
    [FieldOffset(Offset = "0x40")]
    private List<PlayerUnitAbilityBoardType> unlockData;
    [Token(Token = "0x400DD81")]
    [FieldOffset(Offset = "0x48")]
    private Style style;
    [Token(Token = "0x400DD82")]
    [FieldOffset(Offset = "0x50")]
    private IAbilityBoardIconLoader iconLoader;
    [Token(Token = "0x400DD83")]
    [FieldOffset(Offset = "0x58")]
    private IItemDetailController itemDetailController;
    [Token(Token = "0x400DD84")]
    [FieldOffset(Offset = "0x60")]
    private Action<List<AbilityBoardReleaseNodeData>> onNodeUnlockAction;
    [Token(Token = "0x400DD85")]
    [FieldOffset(Offset = "0x68")]
    private int boardId;
    [Token(Token = "0x400DD86")]
    [FieldOffset(Offset = "0x6C")]
    private bool canAllNodesRelease;
    [Token(Token = "0x400DD87")]
    [FieldOffset(Offset = "0x70")]
    private AbilityBoardBulkReleasePopupCreator bulkReleasePopupCreator;

    [Token(Token = "0x17004360")]
    public HashSet<int> CacheNodeIdsSelectReleased
    {
      [Token(Token = "0x60141D5"), Address(RVA = "0x20C9698", Offset = "0x20C9698", VA = "0x20C9698")] get
      {
        return (HashSet<int>) null;
      }
    }

    [Token(Token = "0x17004361")]
    public bool IsDefaultMode
    {
      [Token(Token = "0x60141D6"), Address(RVA = "0x20C96A0", Offset = "0x20C96A0", VA = "0x20C96A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004362")]
    public bool IsBulkMode
    {
      [Token(Token = "0x60141D7"), Address(RVA = "0x20C96B0", Offset = "0x20C96B0", VA = "0x20C96B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004363")]
    public int AllReleaseNodeIdFirst
    {
      [Token(Token = "0x60141D8"), Address(RVA = "0x20C96C0", Offset = "0x20C96C0", VA = "0x20C96C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60141D9")]
    [Address(RVA = "0x20C9734", Offset = "0x20C9734", VA = "0x20C9734")]
    public AbilityBoardNodeReleaseModeController(
      AbilityBoardBehaviour boardBehaviour,
      AbilityBoardView view)
    {
    }

    [Token(Token = "0x60141DA")]
    [Address(RVA = "0x20C9824", Offset = "0x20C9824", VA = "0x20C9824")]
    public void Setup(
      IAbilityBoardIconLoader iconLoader,
      IItemDetailController itemDetailController,
      Action<List<AbilityBoardReleaseNodeData>> onNodeUnlockAction)
    {
    }

    [Token(Token = "0x60141DB")]
    [Address(RVA = "0x20C9830", Offset = "0x20C9830", VA = "0x20C9830")]
    public void UpdateCacheNodeData(
      int boardId,
      int boardListId,
      Style style,
      List<PlayerUnitAbilityBoardType> unlockNodeData)
    {
    }

    [Token(Token = "0x60141DC")]
    [Address(RVA = "0x20C99E8", Offset = "0x20C99E8", VA = "0x20C99E8")]
    private void Clear()
    {
    }

    [Token(Token = "0x60141DD")]
    [Address(RVA = "0x20CA158", Offset = "0x20CA158", VA = "0x20CA158")]
    public void ShowToaster()
    {
    }

    [Token(Token = "0x60141DE")]
    [Address(RVA = "0x20CA210", Offset = "0x20CA210", VA = "0x20CA210")]
    public bool OnAllNodeReleaseButton() => new bool();

    [Token(Token = "0x60141DF")]
    [Address(RVA = "0x20CA450", Offset = "0x20CA450", VA = "0x20CA450")]
    public void OnCloseAllNodeReleasePopup()
    {
    }

    [Token(Token = "0x60141E0")]
    [Address(RVA = "0x20BD4E0", Offset = "0x20BD4E0", VA = "0x20BD4E0")]
    public void SetDisableAllRelease()
    {
    }

    [Token(Token = "0x60141E1")]
    [Address(RVA = "0x20CA234", Offset = "0x20CA234", VA = "0x20CA234")]
    private void CreatePopup()
    {
    }

    [Token(Token = "0x60141E2")]
    [Address(RVA = "0x20CA790", Offset = "0x20CA790", VA = "0x20CA790")]
    private void OnClose()
    {
    }

    [Token(Token = "0x60141E3")]
    [Address(RVA = "0x20CA7F4", Offset = "0x20CA7F4", VA = "0x20CA7F4")]
    public bool ChangeNodeReleaseModeToSelectRelease() => new bool();

    [Token(Token = "0x60141E4")]
    [Address(RVA = "0x20CA878", Offset = "0x20CA878", VA = "0x20CA878")]
    public void ChangeNodeReleaseModeToDefault()
    {
    }

    [Token(Token = "0x60141E5")]
    [Address(RVA = "0x20CA930", Offset = "0x20CA930", VA = "0x20CA930")]
    public bool OnPushNode(int pushNodeId) => new bool();

    [Token(Token = "0x60141E6")]
    [Address(RVA = "0x20CB02C", Offset = "0x20CB02C", VA = "0x20CB02C")]
    public void SetSelectNodeList(List<int> nodeIdlist)
    {
    }

    [Token(Token = "0x60141E7")]
    [Address(RVA = "0x20CAE40", Offset = "0x20CAE40", VA = "0x20CAE40")]
    private void SelectNode(CacheNode cacheNode)
    {
    }

    [Token(Token = "0x60141E8")]
    [Address(RVA = "0x20CAB1C", Offset = "0x20CAB1C", VA = "0x20CAB1C")]
    private void DeselectNode(CacheNode cacheNode)
    {
    }

    [Token(Token = "0x2003332")]
    public enum NodeReleaseMode
    {
      [Token(Token = "0x400DD89")] DefaultMode,
      [Token(Token = "0x400DD8A")] SelectMode,
      [Token(Token = "0x400DD8B")] BulkMode,
    }

    [Token(Token = "0x2003333")]
    private enum ToasterShowType
    {
      [Token(Token = "0x400DD8D")] None,
      [Token(Token = "0x400DD8E")] AlreadyBoardRelease,
      [Token(Token = "0x400DD8F")] InvalidAllNodeReleaseOther,
    }
  }
}
