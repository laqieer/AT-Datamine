// Decompiled with JetBrains decompiler
// Type: Story.APIResult.BreakableObjectCrush
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;

#nullable disable
namespace Story.APIResult
{
  [Token(Token = "0x2000736")]
  public class BreakableObjectCrush : 
    Story.APIResult.APIResult<APIStoryFreeactionBreakableCrushRequest, APIStoryFreeactionBreakableCrushResponse>
  {
    [Token(Token = "0x6002891")]
    [Address(RVA = "0x36777AC", Offset = "0x36777AC", VA = "0x36777AC", Slot = "4")]
    protected override void OnSuccess(
      APIStoryFreeactionBreakableCrushRequest request,
      APIStoryFreeactionBreakableCrushResponse response)
    {
    }

    [Token(Token = "0x6002892")]
    [Address(RVA = "0x367783C", Offset = "0x367783C", VA = "0x367783C")]
    public BreakableObjectCrush()
    {
    }
  }
}
