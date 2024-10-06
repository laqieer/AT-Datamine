// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.EventMission.EventMissionCellData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.ScenarioQuest.EventMission
{
  [Token(Token = "0x2002984")]
  public class EventMissionCellData
  {
    [Token(Token = "0x400B0CF")]
    [FieldOffset(Offset = "0x10")]
    public EventMissionCellData.EventMissionCellDataType Type;
    [Token(Token = "0x400B0D0")]
    [FieldOffset(Offset = "0x18")]
    public MissionDataList MissionData;

    [Token(Token = "0x601050A")]
    [Address(RVA = "0x475D35C", Offset = "0x475D35C", VA = "0x475D35C")]
    public EventMissionCellData(
      EventMissionCellData.EventMissionCellDataType type,
      MissionDataList missionData)
    {
    }

    [Token(Token = "0x2002985")]
    public enum EventMissionCellDataType
    {
      [Token(Token = "0x400B0D2")] Open,
      [Token(Token = "0x400B0D3")] Lock,
    }
  }
}
