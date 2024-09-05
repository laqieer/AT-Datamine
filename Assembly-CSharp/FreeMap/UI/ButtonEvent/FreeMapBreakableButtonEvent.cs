// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.FreeMapBreakableButtonEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.UI.ButtonEvent
{
  [Token(Token = "0x20016D1")]
  public class FreeMapBreakableButtonEvent : FreeMapRewardButtonEvent<FreeMapBreakableUIParam>
  {
    [Token(Token = "0x4006605")]
    [FieldOffset(Offset = "0x58")]
    private FreeMapInstanceHolder refInstanceHolder;

    [Token(Token = "0x60080F9")]
    [Address(RVA = "0x41F8094", Offset = "0x41F8094", VA = "0x41F8094")]
    public FreeMapBreakableButtonEvent(
      FreeMapBreakableUIParam param,
      FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x17001406")]
    private List<StaqData.RewardData> RewardData
    {
      [Token(Token = "0x60080FA"), Address(RVA = "0x41F813C", Offset = "0x41F813C", VA = "0x41F813C")] get
      {
        return (List<StaqData.RewardData>) null;
      }
    }

    [Token(Token = "0x60080FB")]
    [Address(RVA = "0x41F8144", Offset = "0x41F8144", VA = "0x41F8144", Slot = "13")]
    protected override void BuildTask(FreeMapCommonElement element)
    {
    }

    [Token(Token = "0x60080FC")]
    [Address(RVA = "0x41F81B0", Offset = "0x41F81B0", VA = "0x41F81B0", Slot = "17")]
    protected override IEnumerator PlayIconEvent(FreeMapPlayerInstance activePlayer)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60080FD")]
    [Address(RVA = "0x41F824C", Offset = "0x41F824C", VA = "0x41F824C")]
    private void BreakObjectAnimeEvent(FreeMapPlayerInstance activePlayer)
    {
    }

    [Token(Token = "0x60080FE")]
    [Address(RVA = "0x41F844C", Offset = "0x41F844C", VA = "0x41F844C")]
    private IEnumerator OpenAPICoroutine() => (IEnumerator) null;
  }
}
