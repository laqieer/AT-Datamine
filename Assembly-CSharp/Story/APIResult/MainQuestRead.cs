// Decompiled with JetBrains decompiler
// Type: Story.APIResult.MainQuestRead
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;

#nullable disable
namespace Story.APIResult
{
  [Token(Token = "0x200073D")]
  public class MainQuestRead : Story.APIResult.APIResult<APIStoryMainquestReadRequest, APIStoryMainquestReadResponse>
  {
    [Token(Token = "0x600289F")]
    [Address(RVA = "0x36780C4", Offset = "0x36780C4", VA = "0x36780C4", Slot = "4")]
    protected override void OnSuccess(
      APIStoryMainquestReadRequest request,
      APIStoryMainquestReadResponse response)
    {
    }

    [Token(Token = "0x60028A0")]
    [Address(RVA = "0x3678134", Offset = "0x3678134", VA = "0x3678134")]
    public MainQuestRead()
    {
    }
  }
}
