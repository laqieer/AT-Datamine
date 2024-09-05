// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.FreeMapStoryShopButtonEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using FreeMap.UI.ButtonEvent.Task;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace FreeMap.UI.ButtonEvent
{
  [Token(Token = "0x200170F")]
  public class FreeMapStoryShopButtonEvent : FreeMapIconButtonEventBase<FreeMapStoryShopEventUIParam>
  {
    [Token(Token = "0x40066D9")]
    [FieldOffset(Offset = "0x50")]
    private FreeMapCommonElement commonElement;

    [Token(Token = "0x600827A")]
    [Address(RVA = "0x420016C", Offset = "0x420016C", VA = "0x420016C")]
    public FreeMapStoryShopButtonEvent(
      FreeMapStoryShopEventUIParam param,
      FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x600827B")]
    [Address(RVA = "0x42001D4", Offset = "0x42001D4", VA = "0x42001D4", Slot = "14")]
    protected override void SetupBeginTask(
      FreeMapCommonElement element,
      FreeMapButtonEventTaskList withCameraWork,
      FreeMapButtonEventTaskList afterCameraWork)
    {
    }

    [Token(Token = "0x600827C")]
    [Address(RVA = "0x4200564", Offset = "0x4200564", VA = "0x4200564", Slot = "15")]
    protected override void SetupEndTask(
      FreeMapCommonElement element,
      FreeMapButtonEventTaskList withCameraWork,
      FreeMapButtonEventTaskList afterCameraWork)
    {
    }

    [Token(Token = "0x600827D")]
    [Address(RVA = "0x4200834", Offset = "0x4200834", VA = "0x4200834", Slot = "18")]
    protected override IEnumerator PlayIconEvent() => (IEnumerator) null;
  }
}
