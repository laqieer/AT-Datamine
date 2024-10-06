// Decompiled with JetBrains decompiler
// Type: StaqData.Ending
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020B2")]
  public class Ending
  {
    [Token(Token = "0x600C5E4")]
    [Address(RVA = "0x1A088F4", Offset = "0x1A088F4", VA = "0x1A088F4")]
    public static bool RouteIsEnd(SpecifiedStory story, int routeID) => new bool();

    [Token(Token = "0x600C5E5")]
    [Address(RVA = "0x1A08EF8", Offset = "0x1A08EF8", VA = "0x1A08EF8")]
    public static bool SequenceIsEnd(SpecifiedStory story, int sequenceID) => new bool();

    [Token(Token = "0x600C5E6")]
    [Address(RVA = "0x1A08A88", Offset = "0x1A08A88", VA = "0x1A08A88")]
    public static StoryMainQuestSequenceData GetSequence(int routeID)
    {
      return (StoryMainQuestSequenceData) null;
    }

    [Token(Token = "0x600C5E7")]
    [Address(RVA = "0x1A09070", Offset = "0x1A09070", VA = "0x1A09070")]
    public Ending()
    {
    }
  }
}
