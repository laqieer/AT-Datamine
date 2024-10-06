// Decompiled with JetBrains decompiler
// Type: Story.ScenarioQuestStoryAdvDirection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Adv;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000562")]
  public class ScenarioQuestStoryAdvDirection : IAdvDirection, IDirection
  {
    [Token(Token = "0x4001BDA")]
    [FieldOffset(Offset = "0x10")]
    private MainStoryAdvDirection mainstoryAdvDirection;

    [Token(Token = "0x6001F0C")]
    [Address(RVA = "0x2A018EC", Offset = "0x2A018EC", VA = "0x2A018EC")]
    public ScenarioQuestStoryAdvDirection(int advID, bool showHeader)
    {
    }

    [Token(Token = "0x6001F0D")]
    [Address(RVA = "0x2A01974", Offset = "0x2A01974", VA = "0x2A01974", Slot = "4")]
    public AdvDemoInfoData GetDemoInfo() => (AdvDemoInfoData) null;

    [Token(Token = "0x6001F0E")]
    [Address(RVA = "0x2A0198C", Offset = "0x2A0198C", VA = "0x2A0198C", Slot = "5")]
    public AdvStage CreateAdvStage() => (AdvStage) null;

    [Token(Token = "0x17000442")]
    public bool ShowHeader
    {
      [Token(Token = "0x6001F0F"), Address(RVA = "0x2A019A4", Offset = "0x2A019A4", VA = "0x2A019A4", Slot = "6")] get
      {
        return new bool();
      }
    }
  }
}
