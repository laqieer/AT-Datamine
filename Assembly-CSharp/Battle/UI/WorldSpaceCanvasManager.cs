// Decompiled with JetBrains decompiler
// Type: Battle.UI.WorldSpaceCanvasManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.ViewCamera;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Collections.Generic;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200243C")]
  public class WorldSpaceCanvasManager : MonoBehaviour, IDisposable
  {
    [Token(Token = "0x4009B1C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UDictionary<WorldSpaceCanvasManager.CanvasType, Canvas> worldSpaceUICanvases;
    [Token(Token = "0x4009B1D")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<string, Transform> rootObjects;
    [Token(Token = "0x4009B1E")]
    [FieldOffset(Offset = "0x28")]
    private TransformConfig rootOffsetConfig;
    [Token(Token = "0x4009B1F")]
    [FieldOffset(Offset = "0x30")]
    private float initCamraRotationAngles;
    [Token(Token = "0x4009B20")]
    [FieldOffset(Offset = "0x34")]
    private bool disposed;

    [Token(Token = "0x600DE02")]
    [Address(RVA = "0x1E2D048", Offset = "0x1E2D048", VA = "0x1E2D048")]
    public void Initialize(BattleConfigAsset config)
    {
    }

    [Token(Token = "0x600DE03")]
    [Address(RVA = "0x1E2D088", Offset = "0x1E2D088", VA = "0x1E2D088", Slot = "4")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600DE04")]
    [Address(RVA = "0x1E2D0F0", Offset = "0x1E2D0F0", VA = "0x1E2D0F0")]
    public void SetUpCameraEvent(IMapViewCamera camera)
    {
    }

    [Token(Token = "0x600DE05")]
    [Address(RVA = "0x1E2D1E8", Offset = "0x1E2D1E8", VA = "0x1E2D1E8")]
    public void Show()
    {
    }

    [Token(Token = "0x600DE06")]
    [Address(RVA = "0x1E2D358", Offset = "0x1E2D358", VA = "0x1E2D358")]
    public void Hide()
    {
    }

    [Token(Token = "0x600DE07")]
    [Address(RVA = "0x1E2D4C8", Offset = "0x1E2D4C8", VA = "0x1E2D4C8")]
    public Transform Get(string name) => (Transform) null;

    [Token(Token = "0x600DE08")]
    [Address(RVA = "0x1E2D540", Offset = "0x1E2D540", VA = "0x1E2D540")]
    public Transform CreateRootObject(string name, WorldSpaceCanvasManager.CanvasType type)
    {
      return (Transform) null;
    }

    [Token(Token = "0x600DE09")]
    [Address(RVA = "0x1E2D7D8", Offset = "0x1E2D7D8", VA = "0x1E2D7D8")]
    public Transform AttachUI(
      string name,
      WorldSpaceCanvasManager.CanvasType type,
      Transform targetObject)
    {
      return (Transform) null;
    }

    [Token(Token = "0x600DE0A")]
    [Address(RVA = "0x1E2D888", Offset = "0x1E2D888", VA = "0x1E2D888")]
    public void DetachUI(string name, Transform nextParent)
    {
    }

    [Token(Token = "0x600DE0B")]
    [Address(RVA = "0x1E2D968", Offset = "0x1E2D968", VA = "0x1E2D968")]
    private IEnumerator BookingDeleteRootObject(string name) => (IEnumerator) null;

    [Token(Token = "0x600DE0C")]
    [Address(RVA = "0x1E2DA04", Offset = "0x1E2DA04", VA = "0x1E2DA04")]
    public void DeleteUI(string name)
    {
    }

    [Token(Token = "0x600DE0D")]
    [Address(RVA = "0x1E2DAE4", Offset = "0x1E2DAE4", VA = "0x1E2DAE4")]
    public void AllDeleteUI()
    {
    }

    [Token(Token = "0x600DE0E")]
    [Address(RVA = "0x1E2D734", Offset = "0x1E2D734", VA = "0x1E2D734")]
    public void LookToCamera(string name, float cameraAngle)
    {
    }

    [Token(Token = "0x600DE0F")]
    [Address(RVA = "0x1E2DCA8", Offset = "0x1E2DCA8", VA = "0x1E2DCA8")]
    public void LookToCamera(float cameraAngle)
    {
    }

    [Token(Token = "0x600DE10")]
    [Address(RVA = "0x1E2DE24", Offset = "0x1E2DE24", VA = "0x1E2DE24")]
    public void UpdateLocalPosition(string name, Vector3 position)
    {
    }

    [Token(Token = "0x600DE11")]
    [Address(RVA = "0x1E2DED8", Offset = "0x1E2DED8", VA = "0x1E2DED8")]
    public void UpdateLocalPosition(Vector3 position)
    {
    }

    [Token(Token = "0x600DE12")]
    [Address(RVA = "0x1E2E040", Offset = "0x1E2E040", VA = "0x1E2E040")]
    public void UpdateLocalPosition(string name, float x, float y, float z)
    {
    }

    [Token(Token = "0x600DE13")]
    [Address(RVA = "0x1E2E0F4", Offset = "0x1E2E0F4", VA = "0x1E2E0F4")]
    public void UpdateLocalPosition(float x, float y, float z)
    {
    }

    [Token(Token = "0x600DE14")]
    [Address(RVA = "0x1E2E25C", Offset = "0x1E2E25C", VA = "0x1E2E25C")]
    public void UpdateLocalRotation(string name, Quaternion rotation)
    {
    }

    [Token(Token = "0x600DE15")]
    [Address(RVA = "0x1E2E30C", Offset = "0x1E2E30C", VA = "0x1E2E30C")]
    public void UpdateLocalRotation(Quaternion rotation)
    {
    }

    [Token(Token = "0x600DE16")]
    [Address(RVA = "0x1E2D7C4", Offset = "0x1E2D7C4", VA = "0x1E2D7C4")]
    private bool TryGetRootOffsetConfig(out TransformConfig rootOffsetConfig) => new bool();

    [Token(Token = "0x600DE17")]
    [Address(RVA = "0x1E2E4A8", Offset = "0x1E2E4A8", VA = "0x1E2E4A8")]
    public WorldSpaceCanvasManager()
    {
    }

    [Token(Token = "0x200243D")]
    public enum CanvasType
    {
      [Token(Token = "0x4009B22")] Status,
      [Token(Token = "0x4009B23")] Fierce,
      [Token(Token = "0x4009B24")] TargetIcon,
      [Token(Token = "0x4009B25")] MostFront,
    }
  }
}
