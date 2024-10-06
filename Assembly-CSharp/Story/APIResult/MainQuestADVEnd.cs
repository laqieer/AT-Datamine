// Decompiled with JetBrains decompiler
// Type: Story.APIResult.MainQuestADVEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;

#nullable disable
namespace Story.APIResult
{
  [Token(Token = "0x200073B")]
  public class MainQuestADVEnd : Story.APIResult.APIResult<APIStoryMainquestAdvRequest, APIStoryMainquestAdvResponse>
  {
    [Token(Token = "0x600289B")]
    [Address(RVA = "0x3677E14", Offset = "0x3677E14", VA = "0x3677E14", Slot = "4")]
    protected override void OnSuccess(
      APIStoryMainquestAdvRequest request,
      APIStoryMainquestAdvResponse response)
    {
    }

    [Token(Token = "0x600289C")]
    [Address(RVA = "0x3677F18", Offset = "0x3677F18", VA = "0x3677F18")]
    public MainQuestADVEnd()
    {
    }
  }
}
