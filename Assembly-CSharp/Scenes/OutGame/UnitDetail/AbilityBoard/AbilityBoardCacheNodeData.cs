// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardCacheNodeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x2003313")]
  public class AbilityBoardCacheNodeData
  {
    [Token(Token = "0x400DCAC")]
    [FieldOffset(Offset = "0x10")]
    private AbilityBoardNodeReleaseModeController controller;
    [Token(Token = "0x400DCAD")]
    [FieldOffset(Offset = "0x18")]
    private List<CacheNode> cacheNodes;
    [Token(Token = "0x400DCAE")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, int> cacheItemAmount;

    [Token(Token = "0x6014129")]
    [Address(RVA = "0x20BCDA4", Offset = "0x20BCDA4", VA = "0x20BCDA4")]
    public AbilityBoardCacheNodeData(AbilityBoardNodeReleaseModeController controller)
    {
    }

    [Token(Token = "0x601412A")]
    [Address(RVA = "0x20BCE78", Offset = "0x20BCE78", VA = "0x20BCE78")]
    public void Setup(
      List<int> allNodeIds,
      int boardId,
      Style style,
      List<PlayerUnitAbilityBoardType> unlockNodeData)
    {
    }

    [Token(Token = "0x601412B")]
    [Address(RVA = "0x20BD4F0", Offset = "0x20BD4F0", VA = "0x20BD4F0")]
    public void Update()
    {
    }

    [Token(Token = "0x601412C")]
    [Address(RVA = "0x20BDCDC", Offset = "0x20BDCDC", VA = "0x20BDCDC")]
    public bool CanAllNodeRelase() => new bool();

    [Token(Token = "0x601412D")]
    [Address(RVA = "0x20BE048", Offset = "0x20BE048", VA = "0x20BE048")]
    public void Select(HashSet<int> selectNodeIds)
    {
    }

    [Token(Token = "0x601412E")]
    [Address(RVA = "0x20BE610", Offset = "0x20BE610", VA = "0x20BE610")]
    public void Deselect(HashSet<int> deselectNodeIds)
    {
    }

    [Token(Token = "0x601412F")]
    [Address(RVA = "0x20BD378", Offset = "0x20BD378", VA = "0x20BD378")]
    public void Clear()
    {
    }

    [Token(Token = "0x6014130")]
    [Address(RVA = "0x20BEA70", Offset = "0x20BEA70", VA = "0x20BEA70")]
    public HashSet<int> GetCanReleaseAllNodeIds() => (HashSet<int>) null;

    [Token(Token = "0x6014131")]
    [Address(RVA = "0x20BEC2C", Offset = "0x20BEC2C", VA = "0x20BEC2C")]
    public List<CacheNode> GetCacheNodeList(CacheNode node) => (List<CacheNode>) null;

    [Token(Token = "0x6014132")]
    [Address(RVA = "0x20BED20", Offset = "0x20BED20", VA = "0x20BED20")]
    public List<CacheNode> GetChildNodes(CacheNode node) => (List<CacheNode>) null;

    [Token(Token = "0x6014133")]
    [Address(RVA = "0x20BE4AC", Offset = "0x20BE4AC", VA = "0x20BE4AC")]
    public CacheNode GetCacheNode(int id) => (CacheNode) null;

    [Token(Token = "0x6014134")]
    [Address(RVA = "0x20BD41C", Offset = "0x20BD41C", VA = "0x20BD41C")]
    private List<ItemData> GetItemData(int id, Style style) => (List<ItemData>) null;

    [Token(Token = "0x6014135")]
    [Address(RVA = "0x20BD40C", Offset = "0x20BD40C", VA = "0x20BD40C")]
    private bool GetNodeIsUnlock(int id, List<PlayerUnitAbilityBoardType> unlockNodeData)
    {
      return new bool();
    }
  }
}
