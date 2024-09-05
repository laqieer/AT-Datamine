// Decompiled with JetBrains decompiler
// Type: Story.APIResult.MainQuestCommunication
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;

#nullable disable
namespace Story.APIResult
{
  [Token(Token = "0x200073C")]
  public class MainQuestCommunication : 
    Story.APIResult.APIResult<APIStoryMainquestCommunicationRequest, APIStoryMainquestCommunicationResponse>
  {
    [Token(Token = "0x600289D")]
    [Address(RVA = "0x3677F60", Offset = "0x3677F60", VA = "0x3677F60", Slot = "4")]
    protected override void OnSuccess(
      APIStoryMainquestCommunicationRequest request,
      APIStoryMainquestCommunicationResponse response)
    {
    }

    [Token(Token = "0x600289E")]
    [Address(RVA = "0x367807C", Offset = "0x367807C", VA = "0x367807C")]
    public MainQuestCommunication()
    {
    }
  }
}
