// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardBulkDataCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x200330C")]
  public class AbilityBoardBulkDataCreator
  {
    [Token(Token = "0x400DC82")]
    [FieldOffset(Offset = "0x10")]
    private Style style;
    [Token(Token = "0x400DC83")]
    [FieldOffset(Offset = "0x18")]
    private PlayerProfile playerProfile;
    [Token(Token = "0x400DC84")]
    [FieldOffset(Offset = "0x20")]
    private AbilityBoardStyleSettingData styleSettingData;
    [Token(Token = "0x400DC85")]
    [FieldOffset(Offset = "0x28")]
    private List<AbilityBoardReleaseNodeData> releaseNodeDatas;

    [Token(Token = "0x60140F9")]
    [Address(RVA = "0x2353EA0", Offset = "0x2353EA0", VA = "0x2353EA0")]
    public AbilityBoardBulkDataCreator(
      Style style,
      PlayerProfile playerProfile,
      AbilityBoardStyleSettingData styleSettingData)
    {
    }

    [Token(Token = "0x60140FA")]
    [Address(RVA = "0x2353F44", Offset = "0x2353F44", VA = "0x2353F44")]
    public List<AbilityBoardReleaseNodeData> CreateReleaseData(
      List<int> nodeIds,
      List<PlayerUnitAbilityBoardType> unlockNodeData)
    {
      return (List<AbilityBoardReleaseNodeData>) null;
    }

    [Token(Token = "0x60140FB")]
    [Address(RVA = "0x23542A0", Offset = "0x23542A0", VA = "0x23542A0")]
    public List<AbilityBoardReleaseNodeData> CreateReleaseData(HashSet<int> nodeIds)
    {
      return (List<AbilityBoardReleaseNodeData>) null;
    }

    [Token(Token = "0x60140FC")]
    [Address(RVA = "0x23541BC", Offset = "0x23541BC", VA = "0x23541BC")]
    private void SetBulkReleaseData(int nodeID, AbilityBoardReleaseNodeData data)
    {
    }

    [Token(Token = "0x60140FD")]
    [Address(RVA = "0x23544F0", Offset = "0x23544F0", VA = "0x23544F0")]
    public void SetRewardData(int nodeId, AbilityBoardReleaseNodeData data)
    {
    }

    [Token(Token = "0x60140FE")]
    [Address(RVA = "0x2354D78", Offset = "0x2354D78", VA = "0x2354D78")]
    private void SetReleaseNodeData(
      AbilityBoardReleaseNodeData data,
      AbilityboardRewardTypeEnum type,
      int typeId)
    {
    }

    [Token(Token = "0x60140FF")]
    [Address(RVA = "0x235529C", Offset = "0x235529C", VA = "0x235529C")]
    private string GetSkillNameText(StyleSkillTypeEnum styleSkillType) => (string) null;

    [Token(Token = "0x6014100")]
    [Address(RVA = "0x23553B4", Offset = "0x23553B4", VA = "0x23553B4")]
    private int GetSkillLevel(StyleSkillTypeEnum styleSkillType) => new int();

    [Token(Token = "0x6014101")]
    [Address(RVA = "0x23555C0", Offset = "0x23555C0", VA = "0x23555C0")]
    private int GetCharacterSkillLevel() => new int();
  }
}
