// Decompiled with JetBrains decompiler
// Type: Story.APIResult.FacilityExecution
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;

#nullable disable
namespace Story.APIResult
{
  [Token(Token = "0x2000738")]
  public class FacilityExecution : 
    Story.APIResult.APIResult<APIStoryFacilityExecutionRequest, APIStoryFacilityExecutionResponse>
  {
    [Token(Token = "0x6002895")]
    [Address(RVA = "0x367795C", Offset = "0x367795C", VA = "0x367795C", Slot = "4")]
    protected override void OnSuccess(
      APIStoryFacilityExecutionRequest request,
      APIStoryFacilityExecutionResponse response)
    {
    }

    [Token(Token = "0x6002896")]
    [Address(RVA = "0x3677A68", Offset = "0x3677A68", VA = "0x3677A68")]
    public FacilityExecution()
    {
    }
  }
}
