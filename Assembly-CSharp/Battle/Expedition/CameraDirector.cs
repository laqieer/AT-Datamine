// Decompiled with JetBrains decompiler
// Type: Battle.Expedition.CameraDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.ViewCamera;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.Expedition
{
  [Token(Token = "0x20025D0")]
  public class CameraDirector : Battle.CameraDirector
  {
    [Token(Token = "0x600E96F")]
    [Address(RVA = "0x4C49E08", Offset = "0x4C49E08", VA = "0x4C49E08", Slot = "9")]
    public override void RegisterMapViewCamera(
      ISystemFlags sys,
      IMapViewCamera viewCamera,
      Vector3 minViewMovePos,
      Vector3 maxViewMovePos,
      Vector3 initialPosition,
      params Battle.CameraDirector.MapViewCameraSetting[] settings)
    {
    }

    [Token(Token = "0x600E970")]
    [Address(RVA = "0x4C4A640", Offset = "0x4C4A640", VA = "0x4C4A640", Slot = "10")]
    protected override void OnUpdateDistanceMapViewCamera(float distance)
    {
    }

    [Token(Token = "0x600E971")]
    [Address(RVA = "0x4C4A7F8", Offset = "0x4C4A7F8", VA = "0x4C4A7F8")]
    public CameraDirector()
    {
    }
  }
}
