// Decompiled with JetBrains decompiler
// Type: ShotEventReceiver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using DuelMarker;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
[Token(Token = "0x20001B9")]
public class ShotEventReceiver : MonoBehaviour, INotificationReceiver
{
  [Token(Token = "0x4000A9C")]
  [FieldOffset(Offset = "0x18")]
  public DuelManager duelManager;

  [Token(Token = "0x6000B65")]
  [Address(RVA = "0x4BC8EB4", Offset = "0x4BC8EB4", VA = "0x4BC8EB4", Slot = "4")]
  public void OnNotify(Playable origin, INotification notification, object context)
  {
  }

  [Token(Token = "0x6000B66")]
  [Address(RVA = "0x4BC8F8C", Offset = "0x4BC8F8C", VA = "0x4BC8F8C")]
  private IEnumerator ThrowCoroutine(Shot_Base marker) => (IEnumerator) null;

  [Token(Token = "0x6000B67")]
  [Address(RVA = "0x4BC9028", Offset = "0x4BC9028", VA = "0x4BC9028")]
  public ShotEventReceiver()
  {
  }
}
