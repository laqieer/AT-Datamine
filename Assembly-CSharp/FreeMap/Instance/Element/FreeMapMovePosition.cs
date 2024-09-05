// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Element.FreeMapMovePosition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance.Element
{
  [Token(Token = "0x2001905")]
  public class FreeMapMovePosition : MonoBehaviour
  {
    [Token(Token = "0x4006C28")]
    [FieldOffset(Offset = "0x18")]
    private FreeMapMovePosition.Area validAreaLocal;
    [Token(Token = "0x4006C29")]
    [FieldOffset(Offset = "0x28")]
    private FreeMapMovePosition.Area invalidAreaLocal;
    [Token(Token = "0x4006C2A")]
    [FieldOffset(Offset = "0x38")]
    private Vector3 addEulerAngle;

    [Token(Token = "0x6008E31")]
    [Address(RVA = "0x4AFE818", Offset = "0x4AFE818", VA = "0x4AFE818")]
    public void SetParameter(StoryFreeActionPlayerMovePositionData data)
    {
    }

    [Token(Token = "0x6008E32")]
    [Address(RVA = "0x4AFE8D8", Offset = "0x4AFE8D8", VA = "0x4AFE8D8")]
    public void SetParameter(
      Vector3 eulerAngle,
      Vector3 validPosition,
      float validRadius,
      Vector3 invalidPosition = default (Vector3),
      float invalidRadius = 0.0f)
    {
    }

    [Token(Token = "0x6008E33")]
    [Address(RVA = "0x4AFE97C", Offset = "0x4AFE97C", VA = "0x4AFE97C")]
    public FreeMapMovePosition.Area GetMovePoint(Vector3 locationPos)
    {
      return new FreeMapMovePosition.Area();
    }

    [Token(Token = "0x6008E34")]
    [Address(RVA = "0x4AFF34C", Offset = "0x4AFF34C", VA = "0x4AFF34C")]
    public void GetForward(out Vector3 position, out Vector3 eulerAngle)
    {
    }

    [Token(Token = "0x6008E35")]
    [Address(RVA = "0x4AFF4F0", Offset = "0x4AFF4F0", VA = "0x4AFF4F0")]
    public void GetFront(out Vector3 position, out Vector3 eulerAngle)
    {
    }

    [Token(Token = "0x6008E36")]
    [Address(RVA = "0x4AFF420", Offset = "0x4AFF420", VA = "0x4AFF420")]
    public void GetWarpData(out Vector3 position, out Vector3 eulerAngle)
    {
    }

    [Token(Token = "0x6008E37")]
    [Address(RVA = "0x4AFED38", Offset = "0x4AFED38", VA = "0x4AFED38")]
    private static bool InRange(FreeMapMovePosition.Area area, Vector3 location) => new bool();

    [Token(Token = "0x6008E38")]
    [Address(RVA = "0x4AFEDF4", Offset = "0x4AFEDF4", VA = "0x4AFEDF4")]
    private static Vector3 GetNearest(FreeMapMovePosition.Area area, Vector3 location)
    {
      return new Vector3();
    }

    [Token(Token = "0x6008E39")]
    [Address(RVA = "0x4AFF0B8", Offset = "0x4AFF0B8", VA = "0x4AFF0B8")]
    private static bool TryGetIntersections(
      FreeMapMovePosition.Area C1,
      FreeMapMovePosition.Area C2,
      out Vector3 a,
      out Vector3 b)
    {
      return new bool();
    }

    [Token(Token = "0x6008E3A")]
    [Address(RVA = "0x4AFEC30", Offset = "0x4AFEC30", VA = "0x4AFEC30")]
    private FreeMapMovePosition.Area ToWorldPosition(FreeMapMovePosition.Area source)
    {
      return new FreeMapMovePosition.Area();
    }

    [Token(Token = "0x6008E3B")]
    [Address(RVA = "0x4AFF5D8", Offset = "0x4AFF5D8", VA = "0x4AFF5D8")]
    public FreeMapMovePosition()
    {
    }

    [Token(Token = "0x2001906")]
    public struct Area
    {
      [Token(Token = "0x4006C2B")]
      [FieldOffset(Offset = "0x0")]
      public Vector3 position;
      [Token(Token = "0x4006C2C")]
      [FieldOffset(Offset = "0xC")]
      public float radius;
    }
  }
}
