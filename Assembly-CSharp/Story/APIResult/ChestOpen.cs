// Decompiled with JetBrains decompiler
// Type: Story.APIResult.ChestOpen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;

#nullable disable
namespace Story.APIResult
{
  [Token(Token = "0x2000737")]
  public class ChestOpen : 
    Story.APIResult.APIResult<APIStoryFreeactionChestOpenRequest, APIStoryFreeactionChestOpenResponse>
  {
    [Token(Token = "0x6002893")]
    [Address(RVA = "0x3677884", Offset = "0x3677884", VA = "0x3677884", Slot = "4")]
    protected override void OnSuccess(
      APIStoryFreeactionChestOpenRequest request,
      APIStoryFreeactionChestOpenResponse response)
    {
    }

    [Token(Token = "0x6002894")]
    [Address(RVA = "0x3677914", Offset = "0x3677914", VA = "0x3677914")]
    public ChestOpen()
    {
    }
  }
}
