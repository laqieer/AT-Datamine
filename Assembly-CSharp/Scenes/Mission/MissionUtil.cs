// Decompiled with JetBrains decompiler
// Type: Scenes.Mission.MissionUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.Mission
{
  [Token(Token = "0x2002AAC")]
  public static class MissionUtil
  {
    [Token(Token = "0x6010B0B")]
    [Address(RVA = "0x4BD2840", Offset = "0x4BD2840", VA = "0x4BD2840")]
    public static int? ScenarioEventMissionGroupId() => new int?();

    [Token(Token = "0x6010B0C")]
    [Address(RVA = "0x4BD28A4", Offset = "0x4BD28A4", VA = "0x4BD28A4")]
    public static int? ScenarioEventMissionGroupId(in DateTime dateTime) => new int?();

    [Token(Token = "0x6010B0D")]
    [Address(RVA = "0x4BD2934", Offset = "0x4BD2934", VA = "0x4BD2934")]
    public static int? ScenarioEventMissionGroupId(
      StoryScenarioQuestData scneraioEvent,
      in DateTime dateTime)
    {
      return new int?();
    }
  }
}
