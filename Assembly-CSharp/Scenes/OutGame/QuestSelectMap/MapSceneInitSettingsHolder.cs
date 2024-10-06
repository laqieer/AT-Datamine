// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelectMap.MapSceneInitSettingsHolder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.QuestSelectMap
{
  [Token(Token = "0x20033CA")]
  public class MapSceneInitSettingsHolder : MonoBehaviour
  {
    [Token(Token = "0x400E0F6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Vector3 cameraOffSetPos;
    [Token(Token = "0x400E0F7")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Vector3 cameraInitOffSetPos;
    [Token(Token = "0x400E0F8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Vector3 cameraRot;
    [Token(Token = "0x400E0F9")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private float cameraFov;
    [Token(Token = "0x400E0FA")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject locationPrefab;
    [Token(Token = "0x400E0FB")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject locationNameUIPrefab;
    [Token(Token = "0x400E0FC")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Camera screenUIRenderingCamera;
    [Token(Token = "0x400E0FD")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Camera mapModelRenderingCamera;
    [Token(Token = "0x400E0FE")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Camera stackBaseCheckCamera;
    [Token(Token = "0x400E0FF")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject virtualCameraPrefab;
    [Token(Token = "0x400E100")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Material haveDotCharaRenderMaterialData;
    [Token(Token = "0x400E101")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private CinemachineBlenderSettings cameraStartBlend;
    [Token(Token = "0x400E102")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private CinemachineBlenderSettings cameraTransitionBlend;
    [Token(Token = "0x400E103")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Canvas namePlateCanvas;
    [Token(Token = "0x400E104")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject mapCameraHierarchy;
    [Token(Token = "0x400E105")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject mapObjectRoot;
    [Token(Token = "0x400E106")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject mapGroundRoot;

    [Token(Token = "0x170043CC")]
    public Vector3 CameraOffSetPos
    {
      [Token(Token = "0x60145A4"), Address(RVA = "0x207005C", Offset = "0x207005C", VA = "0x207005C")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x170043CD")]
    public Vector3 CameraInitOffSetPos
    {
      [Token(Token = "0x60145A5"), Address(RVA = "0x2070068", Offset = "0x2070068", VA = "0x2070068")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x170043CE")]
    public Vector3 CameraRot
    {
      [Token(Token = "0x60145A6"), Address(RVA = "0x2070074", Offset = "0x2070074", VA = "0x2070074")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x170043CF")]
    public float CameraFov
    {
      [Token(Token = "0x60145A7"), Address(RVA = "0x2070080", Offset = "0x2070080", VA = "0x2070080")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170043D0")]
    public GameObject LocationPrefab
    {
      [Token(Token = "0x60145A8"), Address(RVA = "0x2070088", Offset = "0x2070088", VA = "0x2070088")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170043D1")]
    public GameObject LocationNameUIPrefab
    {
      [Token(Token = "0x60145A9"), Address(RVA = "0x2070090", Offset = "0x2070090", VA = "0x2070090")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170043D2")]
    public Camera ScreenUIRenderingCamera
    {
      [Token(Token = "0x60145AA"), Address(RVA = "0x2070098", Offset = "0x2070098", VA = "0x2070098")] get
      {
        return (Camera) null;
      }
    }

    [Token(Token = "0x170043D3")]
    public Camera MapModelRenderingCamera
    {
      [Token(Token = "0x60145AB"), Address(RVA = "0x20700A0", Offset = "0x20700A0", VA = "0x20700A0")] get
      {
        return (Camera) null;
      }
    }

    [Token(Token = "0x170043D4")]
    public Camera StackBaseCheckCamera
    {
      [Token(Token = "0x60145AC"), Address(RVA = "0x20700A8", Offset = "0x20700A8", VA = "0x20700A8")] get
      {
        return (Camera) null;
      }
    }

    [Token(Token = "0x170043D5")]
    public GameObject VirtualCameraPrefab
    {
      [Token(Token = "0x60145AD"), Address(RVA = "0x20700B0", Offset = "0x20700B0", VA = "0x20700B0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170043D6")]
    public Material HaveDotCharaRenderMaterialData
    {
      [Token(Token = "0x60145AE"), Address(RVA = "0x20700B8", Offset = "0x20700B8", VA = "0x20700B8")] get
      {
        return (Material) null;
      }
    }

    [Token(Token = "0x170043D7")]
    public CinemachineBlenderSettings CameraStartBlend
    {
      [Token(Token = "0x60145AF"), Address(RVA = "0x20700C0", Offset = "0x20700C0", VA = "0x20700C0")] get
      {
        return (CinemachineBlenderSettings) null;
      }
    }

    [Token(Token = "0x170043D8")]
    public CinemachineBlenderSettings CameraTransitionBlend
    {
      [Token(Token = "0x60145B0"), Address(RVA = "0x20700C8", Offset = "0x20700C8", VA = "0x20700C8")] get
      {
        return (CinemachineBlenderSettings) null;
      }
    }

    [Token(Token = "0x170043D9")]
    public Canvas NamePlateCanvas
    {
      [Token(Token = "0x60145B1"), Address(RVA = "0x20700D0", Offset = "0x20700D0", VA = "0x20700D0")] get
      {
        return (Canvas) null;
      }
    }

    [Token(Token = "0x170043DA")]
    public GameObject MapCameraHierarchy
    {
      [Token(Token = "0x60145B2"), Address(RVA = "0x20700D8", Offset = "0x20700D8", VA = "0x20700D8")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170043DB")]
    public GameObject MapObjectRoot
    {
      [Token(Token = "0x60145B3"), Address(RVA = "0x20700E0", Offset = "0x20700E0", VA = "0x20700E0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170043DC")]
    public GameObject MapGroundRoot
    {
      [Token(Token = "0x60145B4"), Address(RVA = "0x20700E8", Offset = "0x20700E8", VA = "0x20700E8")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x60145B5")]
    [Address(RVA = "0x20700F0", Offset = "0x20700F0", VA = "0x20700F0")]
    public MapSceneInitSettingsHolder()
    {
    }
  }
}
