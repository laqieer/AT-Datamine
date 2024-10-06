// Decompiled with JetBrains decompiler
// Type: Story.APIResult.ObliviaeExit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;

#nullable disable
namespace Story.APIResult
{
  [Token(Token = "0x200073F")]
  public class ObliviaeExit : Story.APIResult.APIResult<APIStoryObliviaeExitRequest, APIStoryObliviaeExitResponse>
  {
    [Token(Token = "0x60028A3")]
    [Address(RVA = "0x3678268", Offset = "0x3678268", VA = "0x3678268", Slot = "4")]
    protected override void OnSuccess(
      APIStoryObliviaeExitRequest request,
      APIStoryObliviaeExitResponse response)
    {
    }

    [Token(Token = "0x60028A4")]
    [Address(RVA = "0x36782E0", Offset = "0x36782E0", VA = "0x36782E0")]
    public ObliviaeExit()
    {
    }
  }
}
