// Decompiled with JetBrains decompiler
// Type: Story.APIResult.FreeActionSkip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;

#nullable disable
namespace Story.APIResult
{
  [Token(Token = "0x2000739")]
  public class FreeActionSkip : 
    Story.APIResult.APIResult<APIStoryFreeactionSkipRequest, APIStoryFreeactionSkipResponse>
  {
    [Token(Token = "0x6002897")]
    [Address(RVA = "0x3677AB0", Offset = "0x3677AB0", VA = "0x3677AB0", Slot = "4")]
    protected override void OnSuccess(
      APIStoryFreeactionSkipRequest request,
      APIStoryFreeactionSkipResponse response)
    {
    }

    [Token(Token = "0x6002898")]
    [Address(RVA = "0x3677B28", Offset = "0x3677B28", VA = "0x3677B28")]
    public FreeActionSkip()
    {
    }
  }
}
