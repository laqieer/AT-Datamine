// Decompiled with JetBrains decompiler
// Type: Story.APIResult.SubQuestCancellation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;

#nullable disable
namespace Story.APIResult
{
  [Token(Token = "0x2000741")]
  public class SubQuestCancellation : 
    Story.APIResult.APIResult<APIStorySubquestCancellationRequest, APIStorySubquestCancellationResponse>
  {
    [Token(Token = "0x60028A7")]
    [Address(RVA = "0x3678400", Offset = "0x3678400", VA = "0x3678400", Slot = "4")]
    protected override void OnSuccess(
      APIStorySubquestCancellationRequest request,
      APIStorySubquestCancellationResponse response)
    {
    }

    [Token(Token = "0x60028A8")]
    [Address(RVA = "0x367847C", Offset = "0x367847C", VA = "0x367847C")]
    public SubQuestCancellation()
    {
    }
  }
}
