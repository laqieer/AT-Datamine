// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapInstanceUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018EB")]
  public static class FreeMapInstanceUtility
  {
    [Token(Token = "0x4006BE9")]
    private const string LocatorAreaName = "Loc_Area";

    [Token(Token = "0x6008D94")]
    [Address(RVA = "0x4AFAC54", Offset = "0x4AFAC54", VA = "0x4AFAC54")]
    public static void ChangeLayerDeep(GameObject go, int layer)
    {
    }

    [Token(Token = "0x6008D95")]
    [Address(RVA = "0x4AFAFB4", Offset = "0x4AFAFB4", VA = "0x4AFAFB4")]
    private static void CreateParentHierarchy(Transform to, Transform from, Queue<Transform> list)
    {
    }

    [Token(Token = "0x6008D96")]
    [Address(RVA = "0x4AFB08C", Offset = "0x4AFB08C", VA = "0x4AFB08C")]
    public static Matrix4x4 GetLocatorAreaTransMatrixIfNeed(Transform target) => new Matrix4x4();

    [Token(Token = "0x6008D97")]
    [Address(RVA = "0x4AFB100", Offset = "0x4AFB100", VA = "0x4AFB100")]
    private static Matrix4x4 GetLocatorOffsetMatrixIfNeed(Transform target, string locName)
    {
      return new Matrix4x4();
    }

    [Token(Token = "0x6008D98")]
    [Address(RVA = "0x4AFB3E8", Offset = "0x4AFB3E8", VA = "0x4AFB3E8")]
    public static void SetParentInInstance(FreeMapInstance instance, GameObject cacheObject)
    {
    }

    [Token(Token = "0x6008D99")]
    [Address(RVA = "0x4AFB544", Offset = "0x4AFB544", VA = "0x4AFB544")]
    public static Animator GetAnimatorComponent(GameObject cacheObject) => (Animator) null;
  }
}
