// Decompiled with JetBrains decompiler
// Type: Story.SubQuestBattleResultTask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Popup;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Story
{
  [Token(Token = "0x200058B")]
  public class SubQuestBattleResultTask : IContentTask, IQuestUIEvent
  {
    [Token(Token = "0x4001C2E")]
    [FieldOffset(Offset = "0x10")]
    private int sequenceID;
    [Token(Token = "0x4001C2F")]
    [FieldOffset(Offset = "0x18")]
    private StorySubquestTaskData task;
    [Token(Token = "0x4001C30")]
    [FieldOffset(Offset = "0x20")]
    private bool ended;
    [Token(Token = "0x4001C31")]
    [FieldOffset(Offset = "0x28")]
    private QuestPopupHandler popupHandler;

    [Token(Token = "0x6001FFF")]
    [Address(RVA = "0x2A05A4C", Offset = "0x2A05A4C", VA = "0x2A05A4C")]
    public SubQuestBattleResultTask(int sequenceID, StorySubquestTaskData task)
    {
    }

    [Token(Token = "0x6002000")]
    [Address(RVA = "0x2A05A7C", Offset = "0x2A05A7C", VA = "0x2A05A7C", Slot = "6")]
    public bool IsBusy() => new bool();

    [Token(Token = "0x6002001")]
    [Address(RVA = "0x2A05A8C", Offset = "0x2A05A8C", VA = "0x2A05A8C", Slot = "4")]
    public IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x6002002")]
    [Address(RVA = "0x2A05B1C", Offset = "0x2A05B1C", VA = "0x2A05B1C", Slot = "5")]
    private void Story\u002EIContentTask\u002EUpdate()
    {
    }

    [Token(Token = "0x6002003")]
    [Address(RVA = "0x2A05B20", Offset = "0x2A05B20", VA = "0x2A05B20")]
    private IEnumerator PlayAdv(int subquestTaskID, int advID) => (IEnumerator) null;

    [Token(Token = "0x6002004")]
    [Address(RVA = "0x2A05BC4", Offset = "0x2A05BC4", VA = "0x2A05BC4")]
    private void ResultEnd()
    {
    }

    [Token(Token = "0x6002005")]
    [Address(RVA = "0x2A05BD0", Offset = "0x2A05BD0", VA = "0x2A05BD0")]
    private IEnumerator PlayNoAdv(int subquestID) => (IEnumerator) null;

    [Token(Token = "0x6002006")]
    [Address(RVA = "0x2A05C70", Offset = "0x2A05C70", VA = "0x2A05C70")]
    private IEnumerator PlayDialog(int subquestID) => (IEnumerator) null;

    [Token(Token = "0x6002007")]
    [Address(RVA = "0x2A05D10", Offset = "0x2A05D10", VA = "0x2A05D10")]
    private IEnumerator PlayRewardPopup(int subquestID) => (IEnumerator) null;

    [Token(Token = "0x6002008")]
    [Address(RVA = "0x2A05DA0", Offset = "0x2A05DA0", VA = "0x2A05DA0", Slot = "7")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnPositive()
    {
    }

    [Token(Token = "0x6002009")]
    [Address(RVA = "0x2A05DCC", Offset = "0x2A05DCC", VA = "0x2A05DCC", Slot = "13")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnPositiveSE()
    {
    }

    [Token(Token = "0x600200A")]
    [Address(RVA = "0x2A05DD0", Offset = "0x2A05DD0", VA = "0x2A05DD0", Slot = "8")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnNegative()
    {
    }

    [Token(Token = "0x600200B")]
    [Address(RVA = "0x2A05DD4", Offset = "0x2A05DD4", VA = "0x2A05DD4", Slot = "9")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnNeutral()
    {
    }

    [Token(Token = "0x600200C")]
    [Address(RVA = "0x2A05DD8", Offset = "0x2A05DD8", VA = "0x2A05DD8", Slot = "10")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnClose()
    {
    }

    [Token(Token = "0x600200D")]
    [Address(RVA = "0x2A05DDC", Offset = "0x2A05DDC", VA = "0x2A05DDC", Slot = "11")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnPocketBook()
    {
    }

    [Token(Token = "0x600200E")]
    [Address(RVA = "0x2A05DE0", Offset = "0x2A05DE0", VA = "0x2A05DE0", Slot = "12")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnMap()
    {
    }

    [Token(Token = "0x600200F")]
    [Address(RVA = "0x2A05DA4", Offset = "0x2A05DA4", VA = "0x2A05DA4")]
    private void Close()
    {
    }
  }
}
