// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.ShowPopupSubQuestAutoMove
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.State.ModeState;
using FreeMap.UI.Popup;
using Il2CppDummyDll;
using Scenes.Story.SubQuest;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017EC")]
  public class ShowPopupSubQuestAutoMove : FreeMapProcess, IQuestUIEvent
  {
    [Token(Token = "0x40068F2")]
    [FieldOffset(Offset = "0x34")]
    private int subquestID;
    [Token(Token = "0x40068F3")]
    [FieldOffset(Offset = "0x38")]
    private ShowPopupSubQuest showPopupSubQuest;
    [Token(Token = "0x40068F4")]
    [FieldOffset(Offset = "0x40")]
    private IPlayerAreaOperationEvent playerOperation;

    [Token(Token = "0x1700156F")]
    private QuestPopupHandler PopupHandler
    {
      [Token(Token = "0x6008759"), Address(RVA = "0x43D6550", Offset = "0x43D6550", VA = "0x43D6550")] get
      {
        return (QuestPopupHandler) null;
      }
    }

    [Token(Token = "0x17001570")]
    private SubQuestDetailPopupToaster Toaster
    {
      [Token(Token = "0x600875A"), Address(RVA = "0x43D656C", Offset = "0x43D656C", VA = "0x43D656C")] get
      {
        return (SubQuestDetailPopupToaster) null;
      }
    }

    [Token(Token = "0x600875B")]
    [Address(RVA = "0x43D6588", Offset = "0x43D6588", VA = "0x43D6588")]
    public ShowPopupSubQuestAutoMove(
      FreeMapStateManager entity,
      IPlayerAreaOperationEvent playerOperation)
    {
    }

    [Token(Token = "0x600875C")]
    [Address(RVA = "0x43D6638", Offset = "0x43D6638", VA = "0x43D6638")]
    public void Initialize(int subquestID)
    {
    }

    [Token(Token = "0x600875D")]
    [Address(RVA = "0x43D67A4", Offset = "0x43D67A4", VA = "0x43D67A4", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x600875E")]
    [Address(RVA = "0x43D67C4", Offset = "0x43D67C4", VA = "0x43D67C4", Slot = "7")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnPositive()
    {
    }

    [Token(Token = "0x600875F")]
    [Address(RVA = "0x43D6954", Offset = "0x43D6954", VA = "0x43D6954", Slot = "13")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnPositiveSE()
    {
    }

    [Token(Token = "0x6008760")]
    [Address(RVA = "0x43D6958", Offset = "0x43D6958", VA = "0x43D6958", Slot = "8")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnNegative()
    {
    }

    [Token(Token = "0x6008761")]
    [Address(RVA = "0x43D6A6C", Offset = "0x43D6A6C", VA = "0x43D6A6C", Slot = "9")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnNeutral()
    {
    }

    [Token(Token = "0x6008762")]
    [Address(RVA = "0x43D6A84", Offset = "0x43D6A84", VA = "0x43D6A84", Slot = "11")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnPocketBook()
    {
    }

    [Token(Token = "0x6008763")]
    [Address(RVA = "0x43D6B2C", Offset = "0x43D6B2C", VA = "0x43D6B2C", Slot = "12")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnMap()
    {
    }

    [Token(Token = "0x6008764")]
    [Address(RVA = "0x43D6BC8", Offset = "0x43D6BC8", VA = "0x43D6BC8", Slot = "10")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnClose()
    {
    }
  }
}
