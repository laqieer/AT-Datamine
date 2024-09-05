// Decompiled with JetBrains decompiler
// Type: FreeMap.FootMoveAnimtionEventReceiver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap
{
  [Token(Token = "0x20015D9")]
  public class FootMoveAnimtionEventReceiver : MonoBehaviour
  {
    [Token(Token = "0x14000106")]
    public event FootMoveAnimtionEventReceiver.FootMoveTimingCallback FootMoveTimingEvent
    {
      [Token(Token = "0x6007B8E"), Address(RVA = "0x22A2728", Offset = "0x22A2728", VA = "0x22A2728")] add
      {
      }
      [Token(Token = "0x6007B8F"), Address(RVA = "0x22A27C4", Offset = "0x22A27C4", VA = "0x22A27C4")] remove
      {
      }
    }

    [Token(Token = "0x6007B90")]
    [Address(RVA = "0x22A2860", Offset = "0x22A2860", VA = "0x22A2860")]
    private void FootMoveTiming(int type)
    {
    }

    [Token(Token = "0x6007B91")]
    [Address(RVA = "0x22A287C", Offset = "0x22A287C", VA = "0x22A287C")]
    public FootMoveAnimtionEventReceiver()
    {
    }

    [Token(Token = "0x20015DA")]
    public delegate void FootMoveTimingCallback(
      FootMoveAnimtionEventReceiver.FootMoveTimingType type);

    [Token(Token = "0x20015DB")]
    public enum FootMoveTimingType
    {
      [Token(Token = "0x40063BB")] WalkStamp = 1,
      [Token(Token = "0x40063BC")] RunStamp = 2,
    }
  }
}
