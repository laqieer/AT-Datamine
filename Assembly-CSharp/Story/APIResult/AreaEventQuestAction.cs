// Decompiled with JetBrains decompiler
// Type: Story.APIResult.AreaEventQuestAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;

#nullable disable
namespace Story.APIResult
{
  [Token(Token = "0x2000734")]
  public class AreaEventQuestAction : 
    Story.APIResult.APIResult<APIStoryAreaEventQuestActionRequest, APIStoryAreaEventQuestActionResponse>
  {
    [Token(Token = "0x600288D")]
    [Address(RVA = "0x3677520", Offset = "0x3677520", VA = "0x3677520", Slot = "4")]
    protected override void OnSuccess(
      APIStoryAreaEventQuestActionRequest request,
      APIStoryAreaEventQuestActionResponse response)
    {
    }

    [Token(Token = "0x600288E")]
    [Address(RVA = "0x367762C", Offset = "0x367762C", VA = "0x367762C")]
    public AreaEventQuestAction()
    {
    }
  }
}
