// Decompiled with JetBrains decompiler
// Type: ShotEventReceiverForTest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using DuelMarker;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
[Token(Token = "0x20001BB")]
public class ShotEventReceiverForTest : MonoBehaviour, INotificationReceiver
{
  [Token(Token = "0x4000AA1")]
  [FieldOffset(Offset = "0x18")]
  public GameObject flyingObjectsRoot;

  [Token(Token = "0x6000B6E")]
  [Address(RVA = "0x4BC9130", Offset = "0x4BC9130", VA = "0x4BC9130", Slot = "4")]
  public void OnNotify(Playable origin, INotification notification, object context)
  {
  }

  [Token(Token = "0x6000B6F")]
  [Address(RVA = "0x4BC929C", Offset = "0x4BC929C", VA = "0x4BC929C")]
  private IEnumerator ThrowCoroutine(Shot_Base marker) => (IEnumerator) null;

  [Token(Token = "0x6000B70")]
  [Address(RVA = "0x4BC9338", Offset = "0x4BC9338", VA = "0x4BC9338")]
  public ShotEventReceiverForTest()
  {
  }
}
