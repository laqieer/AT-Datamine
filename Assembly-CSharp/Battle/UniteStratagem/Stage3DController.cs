// Decompiled with JetBrains decompiler
// Type: Battle.UniteStratagem.Stage3DController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.UniteStratagem
{
  [Token(Token = "0x20022AB")]
  public class Stage3DController : MonoBehaviour
  {
    [Token(Token = "0x4009214")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Stage3DAnimationController animationController;
    [Token(Token = "0x4009215")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string cameraHeightReferenceBoneName;
    [Token(Token = "0x4009216")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Transform characterLocator;
    [Token(Token = "0x4009217")]
    [FieldOffset(Offset = "0x30")]
    private GameObject character;
    [Token(Token = "0x4009218")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Transform targetCameraRoot;
    [Token(Token = "0x4009219")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Vector3 defaultTargetCameraRootLocalPosition;
    [Token(Token = "0x400921A")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Vector3 defaultTargetCameraRootLocalAngles;
    [Token(Token = "0x400921B")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Camera targetCamera;
    [Token(Token = "0x400921C")]
    [FieldOffset(Offset = "0x60")]
    [HideInInspector]
    [SerializeField]
    private int renderTargetLayer;

    [Token(Token = "0x17002DD2")]
    public bool IsPlaying
    {
      [Token(Token = "0x600D36D"), Address(RVA = "0x19D6A6C", Offset = "0x19D6A6C", VA = "0x19D6A6C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D36E")]
    [Address(RVA = "0x19D6A9C", Offset = "0x19D6A9C", VA = "0x19D6A9C")]
    public void Prepare(RenderTexture texture, GameObject character)
    {
    }

    [Token(Token = "0x600D36F")]
    [Address(RVA = "0x19D6BF4", Offset = "0x19D6BF4", VA = "0x19D6BF4")]
    public void Release()
    {
    }

    [Token(Token = "0x600D370")]
    [Address(RVA = "0x19D6C70", Offset = "0x19D6C70", VA = "0x19D6C70")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600D371")]
    [Address(RVA = "0x19D6C74", Offset = "0x19D6C74", VA = "0x19D6C74")]
    public void Play()
    {
    }

    [Token(Token = "0x600D372")]
    [Address(RVA = "0x19D6CA4", Offset = "0x19D6CA4", VA = "0x19D6CA4")]
    private void AdjustCameraHeightToReferenceObjectHeight()
    {
    }

    [Token(Token = "0x600D373")]
    [Address(RVA = "0x19D6E64", Offset = "0x19D6E64", VA = "0x19D6E64")]
    public void Stop()
    {
    }

    [Token(Token = "0x600D374")]
    [Address(RVA = "0x19D6E80", Offset = "0x19D6E80", VA = "0x19D6E80")]
    public Stage3DController()
    {
    }
  }
}
