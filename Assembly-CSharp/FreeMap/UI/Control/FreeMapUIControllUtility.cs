// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Control.FreeMapUIControllUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Control
{
  [Token(Token = "0x20016AA")]
  public static class FreeMapUIControllUtility
  {
    [Token(Token = "0x40065A9")]
    [FieldOffset(Offset = "0x0")]
    private static readonly int NearFrustumPlaneNumber;
    [Token(Token = "0x40065AA")]
    [FieldOffset(Offset = "0x8")]
    private static Plane[] planeBuffer;

    [Token(Token = "0x6008049")]
    [Address(RVA = "0x41F0660", Offset = "0x41F0660", VA = "0x41F0660")]
    public static Plane GetCameraFrustumNearPlane(Camera cam) => new Plane();

    [Token(Token = "0x600804A")]
    [Address(RVA = "0x41F2278", Offset = "0x41F2278", VA = "0x41F2278")]
    static FreeMapUIControllUtility()
    {
    }
  }
}
