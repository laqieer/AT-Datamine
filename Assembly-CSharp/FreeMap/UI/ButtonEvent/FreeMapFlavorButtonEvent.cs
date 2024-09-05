// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.FreeMapFlavorButtonEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Parameter.UIParam;
using FreeMap.UI.ButtonEvent.Task;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace FreeMap.UI.ButtonEvent
{
  [Token(Token = "0x20016EA")]
  public class FreeMapFlavorButtonEvent : FreeMapIconButtonEventBase<FreeMapFlavorUIParam>
  {
    [Token(Token = "0x4006658")]
    [FieldOffset(Offset = "0x50")]
    private FreeMapIconEventAdvStage adv;
    [Token(Token = "0x4006659")]
    [FieldOffset(Offset = "0x58")]
    private ChangeReadIcon changeToRead;
    [Token(Token = "0x400665A")]
    [FieldOffset(Offset = "0x60")]
    private int textCounter;

    [Token(Token = "0x6008188")]
    [Address(RVA = "0x41FC378", Offset = "0x41FC378", VA = "0x41FC378")]
    public FreeMapFlavorButtonEvent(FreeMapFlavorUIParam param, FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x6008189")]
    [Address(RVA = "0x41FC3D8", Offset = "0x41FC3D8", VA = "0x41FC3D8", Slot = "19")]
    protected override void LoadIconEvent(FreeMapPlayerInstance activePlayer)
    {
    }

    [Token(Token = "0x600818A")]
    [Address(RVA = "0x41FC5A0", Offset = "0x41FC5A0", VA = "0x41FC5A0", Slot = "20")]
    protected override bool IsLoadedIconEvent() => new bool();

    [Token(Token = "0x600818B")]
    [Address(RVA = "0x41FC5C0", Offset = "0x41FC5C0", VA = "0x41FC5C0", Slot = "18")]
    protected override IEnumerator PlayIconEvent() => (IEnumerator) null;

    [Token(Token = "0x600818C")]
    [Address(RVA = "0x41FC650", Offset = "0x41FC650", VA = "0x41FC650", Slot = "15")]
    protected override void SetupEndTask(
      FreeMapCommonElement element,
      FreeMapButtonEventTaskList withCameraWork,
      FreeMapButtonEventTaskList afterCameraWork)
    {
    }
  }
}
