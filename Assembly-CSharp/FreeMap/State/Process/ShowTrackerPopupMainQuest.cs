// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.ShowTrackerPopupMainQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.State.ModeState;
using FreeMap.UI.Popup;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017EE")]
  public class ShowTrackerPopupMainQuest : FreeMapProcess, IQuestUIEvent
  {
    [Token(Token = "0x40068FA")]
    [FieldOffset(Offset = "0x34")]
    private int sequenceID;
    [Token(Token = "0x40068FB")]
    [FieldOffset(Offset = "0x38")]
    private QuestUIStateHandler questUIStateHandler;
    [Token(Token = "0x40068FC")]
    [FieldOffset(Offset = "0x40")]
    private MainQuestDataSetter dataSetter;
    [Token(Token = "0x40068FD")]
    [FieldOffset(Offset = "0x48")]
    private QuestPopupHandler popupHandler;
    [Token(Token = "0x40068FE")]
    [FieldOffset(Offset = "0x50")]
    private IPlayerAreaOperationEvent playerOperation;

    [Token(Token = "0x6008772")]
    [Address(RVA = "0x43D7264", Offset = "0x43D7264", VA = "0x43D7264")]
    public ShowTrackerPopupMainQuest(
      FreeMapStateManager entity,
      IPlayerAreaOperationEvent playerOperation)
    {
    }

    [Token(Token = "0x6008773")]
    [Address(RVA = "0x43D72E4", Offset = "0x43D72E4", VA = "0x43D72E4")]
    public void Initialize(int sequenceID)
    {
    }

    [Token(Token = "0x6008774")]
    [Address(RVA = "0x43D7364", Offset = "0x43D7364", VA = "0x43D7364", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x6008775")]
    [Address(RVA = "0x43D745C", Offset = "0x43D745C", VA = "0x43D745C")]
    private void OnPopupInitialized()
    {
    }

    [Token(Token = "0x6008776")]
    [Address(RVA = "0x43D7478", Offset = "0x43D7478", VA = "0x43D7478", Slot = "7")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnPositive()
    {
    }

    [Token(Token = "0x6008777")]
    [Address(RVA = "0x43D74E8", Offset = "0x43D74E8", VA = "0x43D74E8", Slot = "13")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnPositiveSE()
    {
    }

    [Token(Token = "0x6008778")]
    [Address(RVA = "0x43D74EC", Offset = "0x43D74EC", VA = "0x43D74EC", Slot = "8")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnNegative()
    {
    }

    [Token(Token = "0x6008779")]
    [Address(RVA = "0x43D74F0", Offset = "0x43D74F0", VA = "0x43D74F0", Slot = "10")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnClose()
    {
    }

    [Token(Token = "0x600877A")]
    [Address(RVA = "0x43D74F4", Offset = "0x43D74F4", VA = "0x43D74F4", Slot = "9")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnNeutral()
    {
    }

    [Token(Token = "0x600877B")]
    [Address(RVA = "0x43D74F8", Offset = "0x43D74F8", VA = "0x43D74F8", Slot = "11")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnPocketBook()
    {
    }

    [Token(Token = "0x600877C")]
    [Address(RVA = "0x43D75B4", Offset = "0x43D75B4", VA = "0x43D75B4", Slot = "12")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnMap()
    {
    }

    [Token(Token = "0x600877D")]
    [Address(RVA = "0x43D747C", Offset = "0x43D747C", VA = "0x43D747C")]
    private void Close()
    {
    }
  }
}
