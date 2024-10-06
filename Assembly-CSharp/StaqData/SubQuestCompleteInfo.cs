// Decompiled with JetBrains decompiler
// Type: StaqData.SubQuestCompleteInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020EE")]
  public class SubQuestCompleteInfo
  {
    [Token(Token = "0x17002B03")]
    public StorySubquestTaskData TaskMasterData
    {
      [Token(Token = "0x600C794"), Address(RVA = "0x1CDFE70", Offset = "0x1CDFE70", VA = "0x1CDFE70")] get
      {
        return (StorySubquestTaskData) null;
      }
      [Token(Token = "0x600C795"), Address(RVA = "0x1CDFE78", Offset = "0x1CDFE78", VA = "0x1CDFE78")] private set
      {
      }
    }

    [Token(Token = "0x600C796")]
    [Address(RVA = "0x1CDF994", Offset = "0x1CDF994", VA = "0x1CDF994")]
    public SubQuestCompleteInfo(StorySubquestTaskData taskTableData)
    {
    }

    [Token(Token = "0x600C797")]
    [Address(RVA = "0x1CDE12C", Offset = "0x1CDE12C", VA = "0x1CDE12C")]
    public bool IsCompletable(int flagStatus, int flagID) => new bool();
  }
}
