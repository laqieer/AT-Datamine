// Decompiled with JetBrains decompiler
// Type: staq.Camera.PostProcessSwitcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D84")]
  public class PostProcessSwitcher : MonoBehaviour
  {
    [Token(Token = "0x4010E2C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Tag("PostProcessをかけるカメラの Tag を指定します")]
    private string targetCameraTag;
    [Token(Token = "0x4010E2D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool IsForceEnable;
    [Token(Token = "0x4010E2E")]
    [FieldOffset(Offset = "0x28")]
    private CameraStackManager cameraStackManager;
    [Token(Token = "0x4010E2F")]
    [FieldOffset(Offset = "0x30")]
    private AppQualitySettings appQualitySettings;

    [Token(Token = "0x6018C03")]
    [Address(RVA = "0x2649B44", Offset = "0x2649B44", VA = "0x2649B44")]
    private void Awake()
    {
    }

    [Token(Token = "0x6018C04")]
    [Address(RVA = "0x2649BE0", Offset = "0x2649BE0", VA = "0x2649BE0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6018C05")]
    [Address(RVA = "0x2649CA8", Offset = "0x2649CA8", VA = "0x2649CA8")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6018C06")]
    [Address(RVA = "0x2649C14", Offset = "0x2649C14", VA = "0x2649C14")]
    private bool IsActive() => new bool();

    [Token(Token = "0x6018C07")]
    [Address(RVA = "0x2649CC4", Offset = "0x2649CC4", VA = "0x2649CC4")]
    public PostProcessSwitcher()
    {
    }
  }
}
