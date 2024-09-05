// Decompiled with JetBrains decompiler
// Type: Story.APIResult.AreaEventQuestReceipt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;

#nullable disable
namespace Story.APIResult
{
  [Token(Token = "0x2000735")]
  public class AreaEventQuestReceipt : 
    Story.APIResult.APIResult<APIStoryAreaEventQuestReceiptRequest, APIStoryAreaEventQuestReceiptResponse>
  {
    [Token(Token = "0x600288F")]
    [Address(RVA = "0x3677674", Offset = "0x3677674", VA = "0x3677674", Slot = "4")]
    protected override void OnSuccess(
      APIStoryAreaEventQuestReceiptRequest request,
      APIStoryAreaEventQuestReceiptResponse response)
    {
    }

    [Token(Token = "0x6002890")]
    [Address(RVA = "0x3677764", Offset = "0x3677764", VA = "0x3677764")]
    public AreaEventQuestReceipt()
    {
    }
  }
}
