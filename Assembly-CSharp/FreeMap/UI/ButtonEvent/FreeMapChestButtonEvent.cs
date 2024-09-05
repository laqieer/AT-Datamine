// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.FreeMapChestButtonEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Parameter.UIParam;
using FreeMap.Reward;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.UI.ButtonEvent
{
  [Token(Token = "0x20016D5")]
  public class FreeMapChestButtonEvent : FreeMapRewardButtonEvent<FreeMapChestUIParam>
  {
    [Token(Token = "0x4006614")]
    [FieldOffset(Offset = "0x50")]
    private KeySelectPopup popup;
    [Token(Token = "0x4006616")]
    [FieldOffset(Offset = "0x60")]
    private FreeMapInstanceHolder refInstanceHolder;

    [Token(Token = "0x1700140B")]
    private List<StaqData.RewardData> RewardData
    {
      [Token(Token = "0x600810D"), Address(RVA = "0x41F8C30", Offset = "0x41F8C30", VA = "0x41F8C30")] get
      {
        return (List<StaqData.RewardData>) null;
      }
    }

    [Token(Token = "0x600810E")]
    [Address(RVA = "0x41F8C38", Offset = "0x41F8C38", VA = "0x41F8C38")]
    public FreeMapChestButtonEvent(FreeMapChestUIParam param, FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x600810F")]
    [Address(RVA = "0x41F8CE0", Offset = "0x41F8CE0", VA = "0x41F8CE0", Slot = "13")]
    protected override void BuildTask(FreeMapCommonElement element)
    {
    }

    [Token(Token = "0x6008110")]
    [Address(RVA = "0x41F8D4C", Offset = "0x41F8D4C", VA = "0x41F8D4C", Slot = "17")]
    protected override IEnumerator PlayIconEvent(FreeMapPlayerInstance activePlayer)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008111")]
    [Address(RVA = "0x41F8DE8", Offset = "0x41F8DE8", VA = "0x41F8DE8")]
    private IEnumerator PlayCanNotOpenEvent() => (IEnumerator) null;

    [Token(Token = "0x6008112")]
    [Address(RVA = "0x41F8E70", Offset = "0x41F8E70", VA = "0x41F8E70")]
    private IEnumerator PlayCanOpenEvent(FreeMapPlayerInstance activePlayer) => (IEnumerator) null;

    [Token(Token = "0x6008113")]
    [Address(RVA = "0x41F8F0C", Offset = "0x41F8F0C", VA = "0x41F8F0C")]
    private IEnumerator ExecuteOpenEvent(FreeMapPlayerInstance activePlayer) => (IEnumerator) null;

    [Token(Token = "0x6008114")]
    [Address(RVA = "0x41F8FA8", Offset = "0x41F8FA8", VA = "0x41F8FA8")]
    private IEnumerator OpenAPICoroutine() => (IEnumerator) null;

    [Token(Token = "0x6008115")]
    [Address(RVA = "0x41F9038", Offset = "0x41F9038", VA = "0x41F9038")]
    private void OpenInstance()
    {
    }
  }
}
