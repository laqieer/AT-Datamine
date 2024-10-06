// Decompiled with JetBrains decompiler
// Type: Battle.ViewCamera.DoFController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

#nullable disable
namespace Battle.ViewCamera
{
  [Token(Token = "0x2002615")]
  [RequireComponent(typeof (PostProcessVolume))]
  public class DoFController : MonoBehaviour
  {
    [Token(Token = "0x400A36D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private float focusDistanceOffset;
    [Token(Token = "0x400A36E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private AnimationCurve apertureCurve;
    [Token(Token = "0x400A36F")]
    [FieldOffset(Offset = "0x28")]
    private DepthOfField depthOfField;

    [Token(Token = "0x600EB13")]
    [Address(RVA = "0x4B99440", Offset = "0x4B99440", VA = "0x4B99440")]
    public void RegisterMapViewCamera(IMapViewCamera camera)
    {
    }

    [Token(Token = "0x600EB14")]
    [Address(RVA = "0x4B996C4", Offset = "0x4B996C4", VA = "0x4B996C4")]
    public void UnRegisterMapViewCamera(IMapViewCamera camera)
    {
    }

    [Token(Token = "0x600EB15")]
    [Address(RVA = "0x4B9967C", Offset = "0x4B9967C", VA = "0x4B9967C")]
    private void OnUpdateDistance(float distance)
    {
    }

    [Token(Token = "0x600EB16")]
    [Address(RVA = "0x4B997C4", Offset = "0x4B997C4", VA = "0x4B997C4")]
    public DoFController()
    {
    }
  }
}
