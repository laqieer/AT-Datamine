// Decompiled with JetBrains decompiler
// Type: Battle.UniteStratagem.Timeline.Marker.USVCControlEventReceiver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cinemachine;
using DuelMarker;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace Battle.UniteStratagem.Timeline.Marker
{
  [Token(Token = "0x20022B9")]
  [RequireComponent(typeof (PlayableDirector), typeof (SignalReceiver))]
  public sealed class USVCControlEventReceiver : VirtualCameraControlEventReceiverBase
  {
    [Token(Token = "0x4009266")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CinemachineBrain targetCinemachineBrain;
    [Token(Token = "0x4009267")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Transform lookAtTargetSearchRoot;

    [Token(Token = "0x600D3D3")]
    [Address(RVA = "0x19DAE20", Offset = "0x19DAE20", VA = "0x19DAE20", Slot = "6")]
    public override Transform GetLookAtTarget(VirtualCameraControlMarker marker)
    {
      return (Transform) null;
    }

    [Token(Token = "0x600D3D4")]
    [Address(RVA = "0x19DAE48", Offset = "0x19DAE48", VA = "0x19DAE48")]
    private Transform FindLookAtObjectRoot(string lookAtObjectName) => (Transform) null;

    [Token(Token = "0x600D3D5")]
    [Address(RVA = "0x19DAF18", Offset = "0x19DAF18", VA = "0x19DAF18")]
    private Transform FindLookAtTarget(Transform root, string targetName) => (Transform) null;

    [Token(Token = "0x600D3D6")]
    [Address(RVA = "0x19DAFA8", Offset = "0x19DAFA8", VA = "0x19DAFA8", Slot = "5")]
    public override CinemachineVirtualCamera GetVirtualCamera() => (CinemachineVirtualCamera) null;

    [Token(Token = "0x600D3D7")]
    [Address(RVA = "0x19DB030", Offset = "0x19DB030", VA = "0x19DB030")]
    public USVCControlEventReceiver()
    {
    }
  }
}
