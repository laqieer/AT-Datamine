// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.Utility.AbilityBoardUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard.Utility
{
  [Token(Token = "0x2003349")]
  public static class AbilityBoardUtility
  {
    [Token(Token = "0x601426B")]
    [Address(RVA = "0x1E05824", Offset = "0x1E05824", VA = "0x1E05824")]
    public static AbilityBoardBehaviour.NodeType GetNodeType(int nodeId)
    {
      return new AbilityBoardBehaviour.NodeType();
    }

    [Token(Token = "0x601426C")]
    [Address(RVA = "0x1E05A34", Offset = "0x1E05A34", VA = "0x1E05A34")]
    public static bool GetNodeUnlock(int nodeId, List<PlayerUnitAbilityBoardType> unlockNodeData)
    {
      return new bool();
    }

    [Token(Token = "0x601426D")]
    [Address(RVA = "0x1E05BA0", Offset = "0x1E05BA0", VA = "0x1E05BA0")]
    public static bool GetBeforeNodeUnlock(
      int nodeId,
      int boardId,
      List<PlayerUnitAbilityBoardType> unlockNodeData)
    {
      return new bool();
    }

    [Token(Token = "0x601426E")]
    [Address(RVA = "0x1E061A0", Offset = "0x1E061A0", VA = "0x1E061A0")]
    public static bool GetBeforeBoardUnlock(
      int nodeID,
      int boardId,
      int boardListId,
      List<PlayerUnitAbilityBoardType> unlockNodeData)
    {
      return new bool();
    }

    [Token(Token = "0x601426F")]
    [Address(RVA = "0x1E06E4C", Offset = "0x1E06E4C", VA = "0x1E06E4C")]
    public static int GetBoardIdByNodeIdAndListId(int nodeId, int boardListId) => new int();

    [Token(Token = "0x6014270")]
    [Address(RVA = "0x1E074FC", Offset = "0x1E074FC", VA = "0x1E074FC")]
    public static AbilityBoardListIcon.IconState GetBoadState(
      int boardId,
      List<PlayerUnitAbilityBoardType> unlockNodeData)
    {
      return new AbilityBoardListIcon.IconState();
    }

    [Token(Token = "0x6014271")]
    [Address(RVA = "0x1E07A38", Offset = "0x1E07A38", VA = "0x1E07A38")]
    public static bool GetBoardIsUnlock(
      int boardListId,
      int boardId,
      List<PlayerUnitAbilityBoardType> unlockNodeData)
    {
      return new bool();
    }

    [Token(Token = "0x6014272")]
    [Address(RVA = "0x1E08480", Offset = "0x1E08480", VA = "0x1E08480")]
    public static bool GetNodeCanRelease(int nodeId, int boardId, Style style) => new bool();

    [Token(Token = "0x6014273")]
    [Address(RVA = "0x1E08850", Offset = "0x1E08850", VA = "0x1E08850")]
    public static List<int> GetAllNodesCurrentBoard(int boardId) => (List<int>) null;

    [Token(Token = "0x6014274")]
    [Address(RVA = "0x1E08C44", Offset = "0x1E08C44", VA = "0x1E08C44")]
    public static List<ItemData> GetItemData(Style style, int consumeGroupTypeId)
    {
      return (List<ItemData>) null;
    }

    [Token(Token = "0x6014275")]
    [Address(RVA = "0x1E0B748", Offset = "0x1E0B748", VA = "0x1E0B748")]
    public static AbilityBoardIcon.IconState GetNodeIconStateType(
      Style style,
      int nodeId,
      int boardId,
      int boardListId,
      List<PlayerUnitAbilityBoardType> unlockNodeData)
    {
      return new AbilityBoardIcon.IconState();
    }

    [Token(Token = "0x6014276")]
    [Address(RVA = "0x1E0C368", Offset = "0x1E0C368", VA = "0x1E0C368")]
    public static int GetNodeIconId(int nodeId, Style style) => new int();

    [Token(Token = "0x6014277")]
    [Address(RVA = "0x1E0CB6C", Offset = "0x1E0CB6C", VA = "0x1E0CB6C")]
    public static int GetNodeIconId(AbilityBoardRewardAllocationData allocationData, Style style)
    {
      return new int();
    }

    [Token(Token = "0x6014278")]
    [Address(RVA = "0x1E0CE70", Offset = "0x1E0CE70", VA = "0x1E0CE70")]
    public static string GetNodeNameText(int nodeId, Style style) => (string) null;

    [Token(Token = "0x6014279")]
    [Address(RVA = "0x1E0D6E8", Offset = "0x1E0D6E8", VA = "0x1E0D6E8")]
    public static string GetNodeNameText(
      AbilityboardRewardTypeEnum rewardTypeEnum,
      int amount,
      Style style)
    {
      return (string) null;
    }

    [Token(Token = "0x601427A")]
    [Address(RVA = "0x1E0DB40", Offset = "0x1E0DB40", VA = "0x1E0DB40")]
    public static string GetNodeText(string name, int before, int amount, NodeRoughType type)
    {
      return (string) null;
    }

    [Token(Token = "0x601427B")]
    [Address(RVA = "0x1E0DCA0", Offset = "0x1E0DCA0", VA = "0x1E0DCA0")]
    public static string GetParamText(
      string name,
      int before,
      int amount,
      NodeRoughType type,
      bool isBulk = false)
    {
      return (string) null;
    }

    [Token(Token = "0x601427C")]
    [Address(RVA = "0x1E0BBC8", Offset = "0x1E0BBC8", VA = "0x1E0BBC8")]
    public static List<int> GetNodeIdList(int nodeId, int boardId) => (List<int>) null;

    [Token(Token = "0x601427D")]
    [Address(RVA = "0x1E0C24C", Offset = "0x1E0C24C", VA = "0x1E0C24C")]
    public static bool CheckCustomNode(int nodeId) => new bool();

    [Token(Token = "0x601427E")]
    [Address(RVA = "0x1E0E2C4", Offset = "0x1E0E2C4", VA = "0x1E0E2C4")]
    public static bool GetNodeUnlock(
      int nodeId,
      List<PlayerUnitAbilityBoardCustomANodeType> unlockNodeData)
    {
      return new bool();
    }

    [Token(Token = "0x601427F")]
    [Address(RVA = "0x1E0E430", Offset = "0x1E0E430", VA = "0x1E0E430")]
    public static List<string> GetRewardText(
      int customANodeId1,
      int customAFrameId1,
      int customANodeId2,
      int customAFrameId2,
      int customANodeId3,
      int customAFrameId3,
      AbilityBoardStyleSettingData styleSettingData,
      int customId)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x6014280")]
    [Address(RVA = "0x1E0E93C", Offset = "0x1E0E93C", VA = "0x1E0E93C")]
    private static string GetSlotBonusReward(
      int customANodeId,
      int bonusValue,
      AbilityBoardStyleSettingData styleSettingData)
    {
      return (string) null;
    }

    [Token(Token = "0x6014281")]
    [Address(RVA = "0x1E0E80C", Offset = "0x1E0E80C", VA = "0x1E0E80C")]
    private static string GetSlotReward(
      int customANodeId,
      int customAFrameId,
      AbilityBoardStyleSettingData styleSettingData)
    {
      return (string) null;
    }

    [Token(Token = "0x6014282")]
    [Address(RVA = "0x1E0E9FC", Offset = "0x1E0E9FC", VA = "0x1E0E9FC")]
    private static string GetSlotRewardText(
      AbilityboardRewardTypeEnum rewardType,
      int value,
      AbilityBoardStyleSettingData styleSettingData)
    {
      return (string) null;
    }

    [Token(Token = "0x6014283")]
    [Address(RVA = "0x1E0EAA0", Offset = "0x1E0EAA0", VA = "0x1E0EAA0")]
    public static string GetCustomARewardTypeText(
      AbilityboardRewardTypeEnum abilityboardRewardType,
      AbilityBoardStyleSettingData styleSettingData)
    {
      return (string) null;
    }

    [Token(Token = "0x6014284")]
    [Address(RVA = "0x1E0EE00", Offset = "0x1E0EE00", VA = "0x1E0EE00")]
    public static string GetCustomARewardTypeText(ParameterTypeEnum parameterType) => (string) null;
  }
}
