// Decompiled with JetBrains decompiler
// Type: FreeMap.CameraField.FreeMapCameraFieldManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cinemachine;
using FreeMap.CameraField.CameraController;
using FreeMap.Sound;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace FreeMap.CameraField
{
  [Token(Token = "0x2001952")]
  public class FreeMapCameraFieldManager : MonoBehaviour
  {
    [Token(Token = "0x4006CD2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private FreeMapCameraField[] cameraFields;
    [Token(Token = "0x4006CD3")]
    [FieldOffset(Offset = "0x20")]
    private List<FreeMapCameraField> activeFieldList;
    [Token(Token = "0x4006CD4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private FreeMapCameraField currentField;
    [Token(Token = "0x4006CD5")]
    [FieldOffset(Offset = "0x30")]
    private FreeMapCameraField beforeField;
    [Token(Token = "0x4006CD6")]
    [FieldOffset(Offset = "0x38")]
    private CinemachineBrain cameraBrain;
    [Token(Token = "0x4006CD7")]
    private const CinemachineBlendDefinition.Style BLEND_STYLE = CinemachineBlendDefinition.Style.EaseInOut;
    [Token(Token = "0x4006CD8")]
    private const float BLEND_SEC = 1f;
    [Token(Token = "0x4006CD9")]
    [FieldOffset(Offset = "0x40")]
    private UnityAction<CinemachineBrain> cameraUpdatedAction;
    [Token(Token = "0x4006CDA")]
    [FieldOffset(Offset = "0x48")]
    private IFreeMapManagerAudioListenerAccess audioListenerAccess;
    [Token(Token = "0x4006CDB")]
    [FieldOffset(Offset = "0x50")]
    private Camera usingCamera;
    [Token(Token = "0x4006CDC")]
    [FieldOffset(Offset = "0x58")]
    private Transform trackingTarget;
    [Token(Token = "0x4006CDD")]
    [FieldOffset(Offset = "0x60")]
    private FreeMapCameraControllerBase.RaycastHitHandler raycastHitHandler;

    [Token(Token = "0x17001735")]
    [SerializeField]
    public FreeMapCameraControllerBase NowCameraCart
    {
      [Token(Token = "0x6009057"), Address(RVA = "0x4B17EC0", Offset = "0x4B17EC0", VA = "0x4B17EC0")] get
      {
        return (FreeMapCameraControllerBase) null;
      }
    }

    [Token(Token = "0x6009058")]
    [Address(RVA = "0x4B17F3C", Offset = "0x4B17F3C", VA = "0x4B17F3C")]
    private FreeMapCameraField GetCurrentCameraField() => (FreeMapCameraField) null;

    [Token(Token = "0x6009059")]
    [Address(RVA = "0x4B17F44", Offset = "0x4B17F44", VA = "0x4B17F44")]
    private FreeMapCameraField GetCameraField(int index) => (FreeMapCameraField) null;

    [Token(Token = "0x600905A")]
    [Address(RVA = "0x4B18018", Offset = "0x4B18018", VA = "0x4B18018")]
    public void AddCameraField(FreeMapCameraField field)
    {
    }

    [Token(Token = "0x600905B")]
    [Address(RVA = "0x4B180C4", Offset = "0x4B180C4", VA = "0x4B180C4")]
    public bool RemoveField(FreeMapCameraField field) => new bool();

    [Token(Token = "0x600905C")]
    [Address(RVA = "0x4B18204", Offset = "0x4B18204", VA = "0x4B18204")]
    public void Initialize(
      Camera useCamera,
      Transform target,
      FreeMapCameraControllerBase.RaycastHitHandler handler,
      IFreeMapManagerAudioListenerAccess audioListenerAccess,
      UnityAction<CinemachineBrain> cameraUpdatedAction)
    {
    }

    [Token(Token = "0x600905D")]
    [Address(RVA = "0x4B18398", Offset = "0x4B18398", VA = "0x4B18398")]
    public void InitTrackingCamera()
    {
    }

    [Token(Token = "0x600905E")]
    [Address(RVA = "0x4B183BC", Offset = "0x4B183BC", VA = "0x4B183BC")]
    public void RegistCamera(Camera useCamera)
    {
    }

    [Token(Token = "0x600905F")]
    [Address(RVA = "0x4B184A8", Offset = "0x4B184A8", VA = "0x4B184A8")]
    public void UnRegisterCamera()
    {
    }

    [Token(Token = "0x6009060")]
    [Address(RVA = "0x4B18514", Offset = "0x4B18514", VA = "0x4B18514")]
    public void SetCurrentCameraField(Transform target)
    {
    }

    [Token(Token = "0x6009061")]
    [Address(RVA = "0x4B18894", Offset = "0x4B18894", VA = "0x4B18894")]
    public void FieldUpdate()
    {
    }

    [Token(Token = "0x6009062")]
    [Address(RVA = "0x4B18CBC", Offset = "0x4B18CBC", VA = "0x4B18CBC")]
    public void Warp()
    {
    }

    [Token(Token = "0x6009063")]
    [Address(RVA = "0x4B18D3C", Offset = "0x4B18D3C", VA = "0x4B18D3C")]
    public void DestroyManager()
    {
    }

    [Token(Token = "0x6009064")]
    [Address(RVA = "0x4B18DD0", Offset = "0x4B18DD0", VA = "0x4B18DD0")]
    public FreeMapCameraFieldManager()
    {
    }
  }
}
