// Decompiled with JetBrains decompiler
// Type: Story.APIResult.StoryInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;

#nullable disable
namespace Story.APIResult
{
  [Token(Token = "0x200073A")]
  public class StoryInfo : Story.APIResult.APIResult<APIStoryRequest, APIStoryResponse>
  {
    [Token(Token = "0x6002899")]
    [Address(RVA = "0x3677B70", Offset = "0x3677B70", VA = "0x3677B70", Slot = "4")]
    protected override void OnSuccess(APIStoryRequest request, APIStoryResponse response)
    {
    }

    [Token(Token = "0x600289A")]
    [Address(RVA = "0x3677DCC", Offset = "0x3677DCC", VA = "0x3677DCC")]
    public StoryInfo()
    {
    }
  }
}
