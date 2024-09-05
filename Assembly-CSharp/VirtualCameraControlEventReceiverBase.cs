// Decompiled with JetBrains decompiler
// Type: VirtualCameraControlEventReceiverBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cinemachine;
using DuelMarker;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
[Token(Token = "0x20001BF")]
public abstract class VirtualCameraControlEventReceiverBase : MonoBehaviour, INotificationReceiver
{
  [Token(Token = "0x4000AA8")]
  [FieldOffset(Offset = "0x18")]
  public bool isEnabled;

  [Token(Token = "0x6000B7C")]
  public abstract CinemachineVirtualCamera GetVirtualCamera();

  [Token(Token = "0x6000B7D")]
  public abstract Transform GetLookAtTarget(VirtualCameraControlMarker marker);

  [Token(Token = "0x6000B7E")]
  [Address(RVA = "0x4BC991C", Offset = "0x4BC991C", VA = "0x4BC991C", Slot = "4")]
  public void OnNotify(Playable origin, INotification notification, object context)
  {
  }

  [Token(Token = "0x6000B7F")]
  [Address(RVA = "0x4BC9CA0", Offset = "0x4BC9CA0", VA = "0x4BC9CA0")]
  public IEnumerator ResetVCTransformCoroutine(
    CinemachineVirtualCamera virtualCamera,
    float resetDamping)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000B80")]
  [Address(RVA = "0x4BC990C", Offset = "0x4BC990C", VA = "0x4BC990C")]
  protected VirtualCameraControlEventReceiverBase()
  {
  }
}
