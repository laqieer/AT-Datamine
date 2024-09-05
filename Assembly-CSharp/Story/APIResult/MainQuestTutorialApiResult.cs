// Decompiled with JetBrains decompiler
// Type: Story.APIResult.MainQuestTutorialApiResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;

#nullable disable
namespace Story.APIResult
{
  [Token(Token = "0x200073E")]
  public class MainQuestTutorialApiResult : 
    Story.APIResult.APIResult<APIStoryMainquestTutorialRequest, APIStoryMainquestTutorialResponse>
  {
    [Token(Token = "0x60028A1")]
    [Address(RVA = "0x367817C", Offset = "0x367817C", VA = "0x367817C", Slot = "4")]
    protected override void OnSuccess(
      APIStoryMainquestTutorialRequest request,
      APIStoryMainquestTutorialResponse response)
    {
    }

    [Token(Token = "0x60028A2")]
    [Address(RVA = "0x3678220", Offset = "0x3678220", VA = "0x3678220")]
    public MainQuestTutorialApiResult()
    {
    }
  }
}
