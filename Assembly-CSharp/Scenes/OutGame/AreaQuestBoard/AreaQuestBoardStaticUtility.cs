// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.AreaQuestBoardStaticUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard
{
  [Token(Token = "0x20038AE")]
  public static class AreaQuestBoardStaticUtility
  {
    [Token(Token = "0x400F7EB")]
    [FieldOffset(Offset = "0x0")]
    public static readonly string SUBSCENE_AB_NAME;
    [Token(Token = "0x400F7EC")]
    [FieldOffset(Offset = "0x8")]
    public static readonly string SUBSCENE_ASSET_NAME;

    [Token(Token = "0x6016483")]
    [Address(RVA = "0x2071B4C", Offset = "0x2071B4C", VA = "0x2071B4C")]
    private static bool TryOneParamFromMaster(
      AreaGroupTypeEnum targettype,
      out int areaGroupId,
      out int areaId,
      out int firstAreaNodeId)
    {
      return new bool();
    }

    [Token(Token = "0x6016484")]
    [Address(RVA = "0x2071EA8", Offset = "0x2071EA8", VA = "0x2071EA8")]
    public static AreaQuestBoardSubScene.SceneParam CreateStoryMainParam()
    {
      return (AreaQuestBoardSubScene.SceneParam) null;
    }

    [Token(Token = "0x6016485")]
    [Address(RVA = "0x2071FBC", Offset = "0x2071FBC", VA = "0x2071FBC")]
    public static AreaQuestBoardSubScene.SceneParam CreateStoryMain2Param()
    {
      return (AreaQuestBoardSubScene.SceneParam) null;
    }

    [Token(Token = "0x6016486")]
    [Address(RVA = "0x207205C", Offset = "0x207205C", VA = "0x207205C")]
    public static AreaQuestBoardSubScene.SceneParam CreateReturn2Param()
    {
      return (AreaQuestBoardSubScene.SceneParam) null;
    }

    [Token(Token = "0x6016487")]
    [Address(RVA = "0x20720FC", Offset = "0x20720FC", VA = "0x20720FC")]
    public static AreaQuestAreaData GetAreaMasterData(int areaId) => (AreaQuestAreaData) null;

    [Token(Token = "0x6016488")]
    [Address(RVA = "0x20722A4", Offset = "0x20722A4", VA = "0x20722A4")]
    public static List<AreaQuestAreaNodeData> GetNodeMasterDataList(int areaId)
    {
      return (List<AreaQuestAreaNodeData>) null;
    }

    [Token(Token = "0x6016489")]
    [Address(RVA = "0x2072468", Offset = "0x2072468", VA = "0x2072468")]
    public static AreaQuestAreaNodeData GetNodeMasterData(int nodeId)
    {
      return (AreaQuestAreaNodeData) null;
    }

    [Token(Token = "0x601648A")]
    [Address(RVA = "0x2072610", Offset = "0x2072610", VA = "0x2072610")]
    public static List<int> GetNextNodeIdsByNodeId(int nodeId) => (List<int>) null;

    [Token(Token = "0x601648B")]
    [Address(RVA = "0x2072674", Offset = "0x2072674", VA = "0x2072674")]
    public static List<int> GetNextUnclearedAndPlayableNodeIdsByNodeId(int nodeId)
    {
      return (List<int>) null;
    }

    [Token(Token = "0x601648C")]
    [Address(RVA = "0x20727C0", Offset = "0x20727C0", VA = "0x20727C0")]
    public static bool GetNodeQuestID(
      out int questId,
      int nodeId,
      QuestDifficultyTypeEnum difficulty)
    {
      return new bool();
    }

    [Token(Token = "0x601648D")]
    [Address(RVA = "0x2072B38", Offset = "0x2072B38", VA = "0x2072B38")]
    static AreaQuestBoardStaticUtility()
    {
    }
  }
}
