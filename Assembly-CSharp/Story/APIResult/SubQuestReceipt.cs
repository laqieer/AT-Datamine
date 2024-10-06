// Decompiled with JetBrains decompiler
// Type: Story.APIResult.SubQuestReceipt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;

#nullable disable
namespace Story.APIResult
{
  [Token(Token = "0x2000742")]
  public class SubQuestReceipt : 
    Story.APIResult.APIResult<APIStorySubquestReceiptRequest, APIStorySubquestReceiptResponse>
  {
    [Token(Token = "0x60028A9")]
    [Address(RVA = "0x36784C4", Offset = "0x36784C4", VA = "0x36784C4", Slot = "4")]
    protected override void OnSuccess(
      APIStorySubquestReceiptRequest request,
      APIStorySubquestReceiptResponse response)
    {
    }

    [Token(Token = "0x60028AA")]
    [Address(RVA = "0x3678540", Offset = "0x3678540", VA = "0x3678540")]
    public SubQuestReceipt()
    {
    }
  }
}
