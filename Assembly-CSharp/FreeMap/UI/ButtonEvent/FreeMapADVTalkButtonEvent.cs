// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.FreeMapADVTalkButtonEvent
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
  [Token(Token = "0x20016CC")]
  public class FreeMapADVTalkButtonEvent : FreeMapIconButtonEventBase<FreeMapADVEventUIParam>
  {
    [Token(Token = "0x40065F3")]
    [FieldOffset(Offset = "0x50")]
    private FreeMapIconEventAdvStage adv;
    [Token(Token = "0x40065F4")]
    [FieldOffset(Offset = "0x58")]
    private ChangeReadIcon changeToRead;
    [Token(Token = "0x40065F5")]
    [FieldOffset(Offset = "0x60")]
    private int textCounter;

    [Token(Token = "0x60080DC")]
    [Address(RVA = "0x41F6D04", Offset = "0x41F6D04", VA = "0x41F6D04")]
    public FreeMapADVTalkButtonEvent(
      FreeMapADVEventUIParam advParam,
      FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x60080DD")]
    [Address(RVA = "0x41F6D64", Offset = "0x41F6D64", VA = "0x41F6D64", Slot = "19")]
    protected override void LoadIconEvent(FreeMapPlayerInstance activePlayer)
    {
    }

    [Token(Token = "0x60080DE")]
    [Address(RVA = "0x41F6FE0", Offset = "0x41F6FE0", VA = "0x41F6FE0", Slot = "20")]
    protected override bool IsLoadedIconEvent() => new bool();

    [Token(Token = "0x60080DF")]
    [Address(RVA = "0x41F7000", Offset = "0x41F7000", VA = "0x41F7000", Slot = "18")]
    protected override IEnumerator PlayIconEvent() => (IEnumerator) null;

    [Token(Token = "0x60080E0")]
    [Address(RVA = "0x41F7090", Offset = "0x41F7090", VA = "0x41F7090", Slot = "15")]
    protected override void SetupEndTask(
      FreeMapCommonElement element,
      FreeMapButtonEventTaskList withCameraWork,
      FreeMapButtonEventTaskList afterCameraWork)
    {
    }
  }
}
