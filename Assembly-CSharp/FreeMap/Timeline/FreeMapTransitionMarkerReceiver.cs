// Decompiled with JetBrains decompiler
// Type: FreeMap.Timeline.FreeMapTransitionMarkerReceiver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

#nullable disable
namespace FreeMap.Timeline
{
  [Token(Token = "0x2001782")]
  [Serializable]
  public class FreeMapTransitionMarkerReceiver : MonoBehaviour, INotificationReceiver
  {
    [Token(Token = "0x14000113")]
    public event UnityAction OnReceived
    {
      [Token(Token = "0x600853C"), Address(RVA = "0x406B05C", Offset = "0x406B05C", VA = "0x406B05C")] add
      {
      }
      [Token(Token = "0x600853D"), Address(RVA = "0x406B0F8", Offset = "0x406B0F8", VA = "0x406B0F8")] remove
      {
      }
    }

    [Token(Token = "0x600853E")]
    [Address(RVA = "0x406B194", Offset = "0x406B194", VA = "0x406B194", Slot = "4")]
    public void OnNotify(Playable origin, INotification notification, object context)
    {
    }

    [Token(Token = "0x600853F")]
    [Address(RVA = "0x406B278", Offset = "0x406B278", VA = "0x406B278")]
    public FreeMapTransitionMarkerReceiver()
    {
    }
  }
}
