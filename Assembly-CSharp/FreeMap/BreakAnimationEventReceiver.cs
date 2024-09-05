// Decompiled with JetBrains decompiler
// Type: FreeMap.BreakAnimationEventReceiver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap
{
  [Token(Token = "0x20015D7")]
  public class BreakAnimationEventReceiver : MonoBehaviour
  {
    [Token(Token = "0x14000105")]
    public event BreakAnimationEventReceiver.BreakTimingCallback BreakTimingEvent
    {
      [Token(Token = "0x6007B86"), Address(RVA = "0x22A24D0", Offset = "0x22A24D0", VA = "0x22A24D0")] add
      {
      }
      [Token(Token = "0x6007B87"), Address(RVA = "0x22A256C", Offset = "0x22A256C", VA = "0x22A256C")] remove
      {
      }
    }

    [Token(Token = "0x6007B88")]
    [Address(RVA = "0x22A2608", Offset = "0x22A2608", VA = "0x22A2608")]
    private void BreakTiming()
    {
    }

    [Token(Token = "0x6007B89")]
    [Address(RVA = "0x22A2624", Offset = "0x22A2624", VA = "0x22A2624")]
    public BreakAnimationEventReceiver()
    {
    }

    [Token(Token = "0x20015D8")]
    public delegate void BreakTimingCallback();
  }
}
