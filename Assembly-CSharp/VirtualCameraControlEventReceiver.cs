// Decompiled with JetBrains decompiler
// Type: VirtualCameraControlEventReceiver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cinemachine;
using DuelMarker;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001BE")]
public class VirtualCameraControlEventReceiver : VirtualCameraControlEventReceiverBase
{
  [Token(Token = "0x4000AA7")]
  [FieldOffset(Offset = "0x20")]
  public DuelManager duelManager;

  [Token(Token = "0x6000B79")]
  [Address(RVA = "0x4BC98BC", Offset = "0x4BC98BC", VA = "0x4BC98BC", Slot = "5")]
  public override CinemachineVirtualCamera GetVirtualCamera() => (CinemachineVirtualCamera) null;

  [Token(Token = "0x6000B7A")]
  [Address(RVA = "0x4BC98E0", Offset = "0x4BC98E0", VA = "0x4BC98E0", Slot = "6")]
  public override Transform GetLookAtTarget(VirtualCameraControlMarker marker) => (Transform) null;

  [Token(Token = "0x6000B7B")]
  [Address(RVA = "0x4BC98FC", Offset = "0x4BC98FC", VA = "0x4BC98FC")]
  public VirtualCameraControlEventReceiver()
  {
  }
}
