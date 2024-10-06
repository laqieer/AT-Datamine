// Decompiled with JetBrains decompiler
// Type: ADV2.PsBattleAdv.CameraDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.ViewCamera;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace ADV2.PsBattleAdv
{
  [Token(Token = "0x2003E6B")]
  public class CameraDirector : Battle.CameraDirector
  {
    [Token(Token = "0x60191DE")]
    [Address(RVA = "0x2CF340C", Offset = "0x2CF340C", VA = "0x2CF340C", Slot = "9")]
    public override void RegisterMapViewCamera(
      ISystemFlags sys,
      IMapViewCamera viewCamera,
      Vector3 minViewMovePos,
      Vector3 maxViewMovePos,
      Vector3 initialPosition,
      params Battle.CameraDirector.MapViewCameraSetting[] settings)
    {
    }

    [Token(Token = "0x60191DF")]
    [Address(RVA = "0x2CF3C44", Offset = "0x2CF3C44", VA = "0x2CF3C44", Slot = "10")]
    protected override void OnUpdateDistanceMapViewCamera(float distance)
    {
    }

    [Token(Token = "0x60191E0")]
    [Address(RVA = "0x2CF3DFC", Offset = "0x2CF3DFC", VA = "0x2CF3DFC")]
    public CameraDirector()
    {
    }
  }
}
