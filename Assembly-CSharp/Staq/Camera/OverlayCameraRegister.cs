// Decompiled with JetBrains decompiler
// Type: staq.Camera.OverlayCameraRegister
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D83")]
  public class OverlayCameraRegister : MonoBehaviour, ICameraStackData
  {
    [Token(Token = "0x4010E27")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CameraStackOrderData cameraStackOrder;
    [Token(Token = "0x4010E28")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int priority;
    [Token(Token = "0x4010E29")]
    [FieldOffset(Offset = "0x28")]
    private UnityEngine.Camera targetCamera;
    [Token(Token = "0x4010E2A")]
    [FieldOffset(Offset = "0x30")]
    private bool renderPostProcessing;
    [Token(Token = "0x4010E2B")]
    [FieldOffset(Offset = "0x34")]
    private int enablePostProcessingRequestCount;

    [Token(Token = "0x170050B9")]
    public int Priority
    {
      [Token(Token = "0x6018BF4"), Address(RVA = "0x26497CC", Offset = "0x26497CC", VA = "0x26497CC", Slot = "4")] get
      {
        return new int();
      }
      [Token(Token = "0x6018BF5"), Address(RVA = "0x26497D4", Offset = "0x26497D4", VA = "0x26497D4")] set
      {
      }
    }

    [Token(Token = "0x170050BA")]
    private UnityEngine.Camera staq\u002ECamera\u002EICameraStackData\u002ETargetCamera
    {
      [Token(Token = "0x6018BF6"), Address(RVA = "0x26497DC", Offset = "0x26497DC", VA = "0x26497DC", Slot = "5")] get
      {
        return (UnityEngine.Camera) null;
      }
    }

    [Token(Token = "0x170050BB")]
    private int staq\u002ECamera\u002EICameraStackData\u002EOrder
    {
      [Token(Token = "0x6018BF7"), Address(RVA = "0x26497E4", Offset = "0x26497E4", VA = "0x26497E4", Slot = "6")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170050BC")]
    private string staq\u002ECamera\u002EICameraStackData\u002EOrderName
    {
      [Token(Token = "0x6018BF8"), Address(RVA = "0x2649800", Offset = "0x2649800", VA = "0x2649800", Slot = "7")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170050BD")]
    private string staq\u002ECamera\u002EICameraStackData\u002ECameraTag
    {
      [Token(Token = "0x6018BF9"), Address(RVA = "0x264981C", Offset = "0x264981C", VA = "0x264981C", Slot = "8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170050BE")]
    public bool IsRenderPostProcessing
    {
      [Token(Token = "0x6018BFA"), Address(RVA = "0x2649824", Offset = "0x2649824", VA = "0x2649824", Slot = "9")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170050BF")]
    public int EnablePostProcessingRequestCount
    {
      [Token(Token = "0x6018BFB"), Address(RVA = "0x264982C", Offset = "0x264982C", VA = "0x264982C", Slot = "10")] get
      {
        return new int();
      }
      [Token(Token = "0x6018BFC"), Address(RVA = "0x2649834", Offset = "0x2649834", VA = "0x2649834", Slot = "11")] set
      {
      }
    }

    [Token(Token = "0x6018BFD")]
    [Address(RVA = "0x264983C", Offset = "0x264983C", VA = "0x264983C")]
    private void Awake()
    {
    }

    [Token(Token = "0x6018BFE")]
    [Address(RVA = "0x2649914", Offset = "0x2649914", VA = "0x2649914")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6018BFF")]
    [Address(RVA = "0x2649840", Offset = "0x2649840", VA = "0x2649840")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6018C00")]
    [Address(RVA = "0x2649968", Offset = "0x2649968", VA = "0x2649968")]
    public void ResetCameraStackOrder(CameraStackOderType cameraStackOderType)
    {
    }

    [Token(Token = "0x6018C01")]
    [Address(RVA = "0x26499DC", Offset = "0x26499DC", VA = "0x26499DC")]
    public static void AttachIfDoesNotExist(
      UnityEngine.Camera camera,
      CameraStackOderType cameraStackOderType,
      string tag = null)
    {
    }

    [Token(Token = "0x6018C02")]
    [Address(RVA = "0x2649ACC", Offset = "0x2649ACC", VA = "0x2649ACC")]
    public OverlayCameraRegister()
    {
    }
  }
}
