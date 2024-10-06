// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.LimitedEventQuest.ILimitedEventQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.LimitedEventQuest
{
  [Token(Token = "0x200362A")]
  public interface ILimitedEventQuest
  {
    [Token(Token = "0x170046ED")]
    IReadOnlyList<Scenes.OutGame.LimitedEventQuest.LimitedEventQuest.TopBannerData> TopBannerList { [Token(Token = "0x601554A")] get; }

    [Token(Token = "0x170046EE")]
    IReadOnlyDictionary<int, Scenes.OutGame.LimitedEventQuest.LimitedEventQuest.TopBannerData> TopBanners { [Token(Token = "0x601554B")] get; }

    [Token(Token = "0x170046EF")]
    IReadOnlyList<Scenes.OutGame.LimitedEventQuest.LimitedEventQuest.BattleStageData> EventStageThumbnailList { [Token(Token = "0x601554C")] get; }

    [Token(Token = "0x601554D")]
    void Dispose();

    [Token(Token = "0x601554E")]
    void Release();

    [Token(Token = "0x601554F")]
    void CreateTopBannerDataList();

    [Token(Token = "0x6015550")]
    void CreateEventStageThumbnailDataList(int eventId);

    [Token(Token = "0x6015551")]
    void ReleaseEventStageThumbnailDataList();

    [Token(Token = "0x6015552")]
    (int, int)? GetOpenLeftTime(DateTime? checkTime);

    [Token(Token = "0x6015553")]
    void CreateEventStageDataList(int eventId);

    [Token(Token = "0x6015554")]
    void ReleaseEventStageDataList();
  }
}
