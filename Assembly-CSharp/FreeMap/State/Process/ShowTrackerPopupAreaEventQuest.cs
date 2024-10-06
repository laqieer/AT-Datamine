// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.ShowTrackerPopupAreaEventQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.State.ModeState;
using FreeMap.UI.Popup;
using Il2CppDummyDll;
using StaqData.AreaEvent;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017ED")]
  public class ShowTrackerPopupAreaEventQuest : FreeMapProcess, IQuestUIEvent
  {
    [Token(Token = "0x40068F5")]
    [FieldOffset(Offset = "0x38")]
    private QuestUIStateHandler questUIStateHandler;
    [Token(Token = "0x40068F6")]
    [FieldOffset(Offset = "0x40")]
    private AreaEventQuestDataSetter dataSetter;
    [Token(Token = "0x40068F7")]
    [FieldOffset(Offset = "0x48")]
    private QuestPopupHandler popupHandler;
    [Token(Token = "0x40068F8")]
    [FieldOffset(Offset = "0x50")]
    private IPlayerAreaOperationEvent playerOperation;
    [Token(Token = "0x40068F9")]
    [FieldOffset(Offset = "0x58")]
    private int areaEventQuestID;

    [Token(Token = "0x6008765")]
    [Address(RVA = "0x43D6BE0", Offset = "0x43D6BE0", VA = "0x43D6BE0")]
    public ShowTrackerPopupAreaEventQuest(
      FreeMapStateManager entity,
      IPlayerAreaOperationEvent playerOperation)
    {
    }

    [Token(Token = "0x6008766")]
    [Address(RVA = "0x43D6C60", Offset = "0x43D6C60", VA = "0x43D6C60")]
    public void Initialize(int areaEventQuestID)
    {
    }

    [Token(Token = "0x6008767")]
    [Address(RVA = "0x43D6D30", Offset = "0x43D6D30", VA = "0x43D6D30", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x6008768")]
    [Address(RVA = "0x43D6E18", Offset = "0x43D6E18", VA = "0x43D6E18")]
    private void OnPopupInitialized()
    {
    }

    [Token(Token = "0x6008769")]
    [Address(RVA = "0x43D6E34", Offset = "0x43D6E34", VA = "0x43D6E34", Slot = "7")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnPositive()
    {
    }

    [Token(Token = "0x600876A")]
    [Address(RVA = "0x43D708C", Offset = "0x43D708C", VA = "0x43D708C", Slot = "13")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnPositiveSE()
    {
    }

    [Token(Token = "0x600876B")]
    [Address(RVA = "0x43D6F04", Offset = "0x43D6F04", VA = "0x43D6F04")]
    private void GotoTarget(AreaEventQuestData areaEventQuest)
    {
    }

    [Token(Token = "0x600876C")]
    [Address(RVA = "0x43D7090", Offset = "0x43D7090", VA = "0x43D7090", Slot = "8")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnNegative()
    {
    }

    [Token(Token = "0x600876D")]
    [Address(RVA = "0x43D70F0", Offset = "0x43D70F0", VA = "0x43D70F0", Slot = "9")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnNeutral()
    {
    }

    [Token(Token = "0x600876E")]
    [Address(RVA = "0x43D70F4", Offset = "0x43D70F4", VA = "0x43D70F4", Slot = "11")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnPocketBook()
    {
    }

    [Token(Token = "0x600876F")]
    [Address(RVA = "0x43D71B0", Offset = "0x43D71B0", VA = "0x43D71B0", Slot = "12")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnMap()
    {
    }

    [Token(Token = "0x6008770")]
    [Address(RVA = "0x43D7260", Offset = "0x43D7260", VA = "0x43D7260", Slot = "10")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnClose()
    {
    }

    [Token(Token = "0x6008771")]
    [Address(RVA = "0x43D7094", Offset = "0x43D7094", VA = "0x43D7094")]
    private void Close()
    {
    }
  }
}
