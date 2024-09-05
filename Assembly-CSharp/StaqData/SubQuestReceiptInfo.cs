// Decompiled with JetBrains decompiler
// Type: StaqData.SubQuestReceiptInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020ED")]
  public class SubQuestReceiptInfo
  {
    [Token(Token = "0x17002B02")]
    public StorySubquestTaskData TaskMasterData
    {
      [Token(Token = "0x600C791"), Address(RVA = "0x1CDFDD8", Offset = "0x1CDFDD8", VA = "0x1CDFDD8")] get
      {
        return (StorySubquestTaskData) null;
      }
    }

    [Token(Token = "0x600C792")]
    [Address(RVA = "0x1CDF244", Offset = "0x1CDF244", VA = "0x1CDF244")]
    public SubQuestReceiptInfo(StorySubquestTaskData taskTableData)
    {
    }

    [Token(Token = "0x600C793")]
    [Address(RVA = "0x1CDFDE0", Offset = "0x1CDFDE0", VA = "0x1CDFDE0")]
    public StoryFreeActionLayoutData GetLayoutData() => (StoryFreeActionLayoutData) null;
  }
}
