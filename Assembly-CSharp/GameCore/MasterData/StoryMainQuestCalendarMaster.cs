// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestCalendarMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200129A")]
  [Serializable]
  public sealed class StoryMainQuestCalendarMaster : BaseMaster<StoryMainQuestCalendarData>
  {
    [Token(Token = "0x60069A7")]
    [Address(RVA = "0x48D1FA8", Offset = "0x48D1FA8", VA = "0x48D1FA8")]
    public IReadOnlyDictionary<int, StoryMainQuestCalendarData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryMainQuestCalendarData>) null;
    }

    [Token(Token = "0x60069A8")]
    [Address(RVA = "0x48D1FB0", Offset = "0x48D1FB0", VA = "0x48D1FB0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60069A9")]
    [Address(RVA = "0x48D2010", Offset = "0x48D2010", VA = "0x48D2010", Slot = "5")]
    protected override StoryMainQuestCalendarData LoadEntity(IMasterDataReader reader)
    {
      return (StoryMainQuestCalendarData) null;
    }

    [Token(Token = "0x60069AA")]
    [Address(RVA = "0x48D2068", Offset = "0x48D2068", VA = "0x48D2068")]
    public static bool CheckCalendar(int begin, int end, int current) => new bool();

    [Token(Token = "0x60069AB")]
    [Address(RVA = "0x48D2204", Offset = "0x48D2204", VA = "0x48D2204")]
    public StoryMainQuestCalendarData[] GetMonthlyData(int yearId, int month)
    {
      return (StoryMainQuestCalendarData[]) null;
    }

    [Token(Token = "0x60069AC")]
    [Address(RVA = "0x48D23FC", Offset = "0x48D23FC", VA = "0x48D23FC")]
    public int GetLastMonthByTargetYearID(int yearId) => new int();

    [Token(Token = "0x60069AD")]
    [Address(RVA = "0x48D26C8", Offset = "0x48D26C8", VA = "0x48D26C8")]
    public int GetFirstMonthByTargetYearID(int yearId) => new int();

    [Token(Token = "0x60069AE")]
    [Address(RVA = "0x48D2994", Offset = "0x48D2994", VA = "0x48D2994")]
    public StoryMainQuestCalendarMaster()
    {
    }
  }
}
