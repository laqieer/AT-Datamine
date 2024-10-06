// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.FreeQuest.IScenarioEventFreeQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.ScenarioQuest.FreeQuest
{
  [Token(Token = "0x200296C")]
  public interface IScenarioEventFreeQuest
  {
    [Token(Token = "0x170038F9")]
    IReadOnlyList<ScenarioEventFreeQuest.BattleStageData> EventStageThumbnailList { [Token(Token = "0x6010490")] get; }

    [Token(Token = "0x6010491")]
    void Dispose();

    [Token(Token = "0x6010492")]
    void Release();

    [Token(Token = "0x6010493")]
    void CreateEventStageThumbnailDataList();

    [Token(Token = "0x6010494")]
    void ReleaseEventStageThumbnailDataList();

    [Token(Token = "0x6010495")]
    (int, int)? GetOpenLeftTime(DateTime? checkTime);

    [Token(Token = "0x6010496")]
    void CreateEventStageDataList();

    [Token(Token = "0x6010497")]
    void ReleaseEventStageDataList();
  }
}
