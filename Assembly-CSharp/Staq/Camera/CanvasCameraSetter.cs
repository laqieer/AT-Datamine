// Decompiled with JetBrains decompiler
// Type: staq.Camera.CanvasCameraSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D82")]
  [RequireComponent(typeof (Canvas))]
  public class CanvasCameraSetter : MonoBehaviour, ICameraIntanceGetter
  {
    [Token(Token = "0x4010E22")]
    [FieldOffset(Offset = "0x18")]
    [Tag("Canvas にセットするカメラの Tag を指定します")]
    [SerializeField]
    private string targetCameraTag;
    [Token(Token = "0x4010E23")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CanvasSettingData canvasSettingData;
    [Token(Token = "0x4010E24")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int offsetPlaneDistance;
    [Token(Token = "0x4010E25")]
    [FieldOffset(Offset = "0x30")]
    private Canvas canvas;
    [Token(Token = "0x4010E26")]
    [FieldOffset(Offset = "0x38")]
    private int overridePlaneDistance;

    [Token(Token = "0x170050B8")]
    private int OverridePlaneDistance
    {
      [Token(Token = "0x6018BEA"), Address(RVA = "0x26492F8", Offset = "0x26492F8", VA = "0x26492F8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018BEB")]
    [Address(RVA = "0x2649300", Offset = "0x2649300", VA = "0x2649300")]
    private void Awake()
    {
    }

    [Token(Token = "0x6018BEC")]
    [Address(RVA = "0x26494D0", Offset = "0x26494D0", VA = "0x26494D0")]
    public void ForceChangeCamera(string targetCameraTag)
    {
    }

    [Token(Token = "0x6018BED")]
    [Address(RVA = "0x26494D8", Offset = "0x26494D8", VA = "0x26494D8")]
    public void ForceChangeOffsetPlaneDistance(int offsetPlaneDistance)
    {
    }

    [Token(Token = "0x6018BEE")]
    [Address(RVA = "0x2649378", Offset = "0x2649378", VA = "0x2649378")]
    private void InitializeCanvas()
    {
    }

    [Token(Token = "0x6018BEF")]
    [Address(RVA = "0x2649520", Offset = "0x2649520", VA = "0x2649520", Slot = "4")]
    private void staq\u002ECamera\u002EICameraIntanceGetter\u002EReceiveCameraInstance(UnityEngine.Camera camera)
    {
    }

    [Token(Token = "0x6018BF0")]
    [Address(RVA = "0x26495E4", Offset = "0x26495E4", VA = "0x26495E4")]
    public static void SetLayer(GameObject go, string layerName)
    {
    }

    [Token(Token = "0x6018BF1")]
    [Address(RVA = "0x2649510", Offset = "0x2649510", VA = "0x2649510")]
    public bool IsUntagged() => new bool();

    [Token(Token = "0x6018BF2")]
    [Address(RVA = "0x2649518", Offset = "0x2649518", VA = "0x2649518")]
    public bool IsMainCamera() => new bool();

    [Token(Token = "0x6018BF3")]
    [Address(RVA = "0x2649740", Offset = "0x2649740", VA = "0x2649740")]
    public CanvasCameraSetter()
    {
    }
  }
}
