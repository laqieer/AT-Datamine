// Decompiled with JetBrains decompiler
// Type: Story.APIResult.SubQuestAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;

#nullable disable
namespace Story.APIResult
{
  [Token(Token = "0x2000740")]
  public class SubQuestAction : 
    Story.APIResult.APIResult<APIStorySubquestActionRequest, APIStorySubquestActionResponse>
  {
    [Token(Token = "0x60028A5")]
    [Address(RVA = "0x3678328", Offset = "0x3678328", VA = "0x3678328", Slot = "4")]
    protected override void OnSuccess(
      APIStorySubquestActionRequest request,
      APIStorySubquestActionResponse response)
    {
    }

    [Token(Token = "0x60028A6")]
    [Address(RVA = "0x36783B8", Offset = "0x36783B8", VA = "0x36783B8")]
    public SubQuestAction()
    {
    }
  }
}
