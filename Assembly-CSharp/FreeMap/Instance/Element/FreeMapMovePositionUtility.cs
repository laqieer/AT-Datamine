// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Element.FreeMapMovePositionUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.CameraField;
using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance.Element
{
  [Token(Token = "0x2001907")]
  public static class FreeMapMovePositionUtility
  {
    [Token(Token = "0x4006C2D")]
    public const string MovePositionGameObjectName = "MovePosition:";

    [Token(Token = "0x6008E3C")]
    [Address(RVA = "0x4AFF5E0", Offset = "0x4AFF5E0", VA = "0x4AFF5E0")]
    public static GameObject CreateObject(Transform parent) => (GameObject) null;

    [Token(Token = "0x6008E3D")]
    [Address(RVA = "0x4AFF6A4", Offset = "0x4AFF6A4", VA = "0x4AFF6A4")]
    public static FreeMapMovePosition CreateDefault(Transform parent) => (FreeMapMovePosition) null;

    [Token(Token = "0x6008E3E")]
    [Address(RVA = "0x4AFF800", Offset = "0x4AFF800", VA = "0x4AFF800")]
    public static FreeMapMovePosition Create(
      int playerMoveKey,
      int cameraViewKey,
      Transform parent)
    {
      return (FreeMapMovePosition) null;
    }

    [Token(Token = "0x6008E3F")]
    [Address(RVA = "0x4AFF8F8", Offset = "0x4AFF8F8", VA = "0x4AFF8F8")]
    public static FreeMapMovePosition AddMovePosition(
      GameObject target,
      StoryFreeActionPlayerMovePositionData data)
    {
      return (FreeMapMovePosition) null;
    }

    [Token(Token = "0x6008E40")]
    [Address(RVA = "0x4AFF724", Offset = "0x4AFF724", VA = "0x4AFF724")]
    public static FreeMapMovePosition AddMovePosition(
      GameObject target,
      Vector3 eulerAngle,
      Vector3 validPosition,
      float validRadius,
      Vector3 invalidPosition = default (Vector3),
      float invalidRadius = 0.0f)
    {
      return (FreeMapMovePosition) null;
    }

    [Token(Token = "0x6008E41")]
    [Address(RVA = "0x4AFFA00", Offset = "0x4AFFA00", VA = "0x4AFFA00")]
    public static FreeMapOverrideCameraTransform AddOverrideCamera(
      GameObject target,
      StoryFreeActionCameraViewPositionData cameraData)
    {
      return (FreeMapOverrideCameraTransform) null;
    }

    [Token(Token = "0x6008E42")]
    [Address(RVA = "0x4AFFAB8", Offset = "0x4AFFAB8", VA = "0x4AFFAB8")]
    public static FreeMapOverrideCameraTransform AddOverrideCamera(
      GameObject target,
      Vector3 cameraPosition,
      Vector3 cameraEulerAngles,
      float cameraFOV,
      bool absoluteFOV,
      CameraViewPositionReferenceEnum reference)
    {
      return (FreeMapOverrideCameraTransform) null;
    }
  }
}
