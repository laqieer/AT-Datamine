// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.FreeMapIconEventTimeElapse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using Network.API;
using Story.APIResult;
using System.Collections;

#nullable disable
namespace FreeMap.UI.ButtonEvent
{
  [Token(Token = "0x2001706")]
  public class FreeMapIconEventTimeElapse : FreeMapIconButtonEventBase<FreeMapTimeElapseUIParam>
  {
    [Token(Token = "0x40066C0")]
    [FieldOffset(Offset = "0x50")]
    private APIStoryFreeactionSkip skipAPI;
    [Token(Token = "0x40066C1")]
    [FieldOffset(Offset = "0x58")]
    private FreeActionSkip skipAPIresultCommon;

    [Token(Token = "0x6008250")]
    [Address(RVA = "0x41FF3F8", Offset = "0x41FF3F8", VA = "0x41FF3F8")]
    public FreeMapIconEventTimeElapse(
      FreeMapTimeElapseUIParam param,
      FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x6008251")]
    [Address(RVA = "0x41FF4D4", Offset = "0x41FF4D4", VA = "0x41FF4D4", Slot = "18")]
    protected override IEnumerator PlayIconEvent() => (IEnumerator) null;

    [Token(Token = "0x6008252")]
    [Address(RVA = "0x41FF564", Offset = "0x41FF564", VA = "0x41FF564")]
    private IEnumerator SkipAPICoroutine() => (IEnumerator) null;

    [Token(Token = "0x6008253")]
    [Address(RVA = "0x41FF5F4", Offset = "0x41FF5F4", VA = "0x41FF5F4")]
    private void OnSucceededSkipAPI(APIStoryFreeactionSkipResponse response)
    {
    }
  }
}
