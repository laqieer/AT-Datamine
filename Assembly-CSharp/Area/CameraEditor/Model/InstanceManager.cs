// Decompiled with JetBrains decompiler
// Type: Area.CameraEditor.Model.InstanceManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap;
using FreeMap.CameraField;
using FreeMap.Instance;
using FreeMap.Instance.Element;
using FreeMap.Loader;
using FreeMap.Parameter;
using FreeMap.Scriptable;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Area.CameraEditor.Model
{
  [Token(Token = "0x200285D")]
  public class InstanceManager
  {
    [Token(Token = "0x400ABFF")]
    [FieldOffset(Offset = "0x48")]
    private AreaCameraEditor parent;

    [Token(Token = "0x170037F5")]
    private FreeMapSceneHolder MapLoader
    {
      [Token(Token = "0x600FE42"), Address(RVA = "0x40ED9EC", Offset = "0x40ED9EC", VA = "0x40ED9EC")] get
      {
        return (FreeMapSceneHolder) null;
      }
      [Token(Token = "0x600FE43"), Address(RVA = "0x40ED9F4", Offset = "0x40ED9F4", VA = "0x40ED9F4")] set
      {
      }
    }

    [Token(Token = "0x170037F6")]
    private FreeMapSceneHolder CameraFieldLoader
    {
      [Token(Token = "0x600FE44"), Address(RVA = "0x40ED9FC", Offset = "0x40ED9FC", VA = "0x40ED9FC")] get
      {
        return (FreeMapSceneHolder) null;
      }
      [Token(Token = "0x600FE45"), Address(RVA = "0x40EDA04", Offset = "0x40EDA04", VA = "0x40EDA04")] set
      {
      }
    }

    [Token(Token = "0x170037F7")]
    public FreeMapCameraFieldManager CameraFieldManager
    {
      [Token(Token = "0x600FE46"), Address(RVA = "0x40EDA0C", Offset = "0x40EDA0C", VA = "0x40EDA0C")] private set
      {
      }
      [Token(Token = "0x600FE47"), Address(RVA = "0x40EDA14", Offset = "0x40EDA14", VA = "0x40EDA14")] get
      {
        return (FreeMapCameraFieldManager) null;
      }
    }

    [Token(Token = "0x170037F8")]
    public Camera MapCamera
    {
      [Token(Token = "0x600FE48"), Address(RVA = "0x40EDA1C", Offset = "0x40EDA1C", VA = "0x40EDA1C")] private set
      {
      }
      [Token(Token = "0x600FE49"), Address(RVA = "0x40EDA24", Offset = "0x40EDA24", VA = "0x40EDA24")] get
      {
        return (Camera) null;
      }
    }

    [Token(Token = "0x170037F9")]
    public FreeMapMovePosition MovePosition
    {
      [Token(Token = "0x600FE4A"), Address(RVA = "0x40EDA2C", Offset = "0x40EDA2C", VA = "0x40EDA2C")] private set
      {
      }
      [Token(Token = "0x600FE4B"), Address(RVA = "0x40EDA34", Offset = "0x40EDA34", VA = "0x40EDA34")] get
      {
        return (FreeMapMovePosition) null;
      }
    }

    [Token(Token = "0x170037FA")]
    public FreeMapOverrideCameraTransform CameraTransform
    {
      [Token(Token = "0x600FE4C"), Address(RVA = "0x40EDA3C", Offset = "0x40EDA3C", VA = "0x40EDA3C")] private set
      {
      }
      [Token(Token = "0x600FE4D"), Address(RVA = "0x40EDA44", Offset = "0x40EDA44", VA = "0x40EDA44")] get
      {
        return (FreeMapOverrideCameraTransform) null;
      }
    }

    [Token(Token = "0x170037FB")]
    public FreeMapInstance TargetInstance
    {
      [Token(Token = "0x600FE4E"), Address(RVA = "0x40EDA4C", Offset = "0x40EDA4C", VA = "0x40EDA4C")] private set
      {
      }
      [Token(Token = "0x600FE4F"), Address(RVA = "0x40EDA54", Offset = "0x40EDA54", VA = "0x40EDA54")] get
      {
        return (FreeMapInstance) null;
      }
    }

    [Token(Token = "0x170037FC")]
    private FreeMapCommonElement Element
    {
      [Token(Token = "0x600FE50"), Address(RVA = "0x40EDA5C", Offset = "0x40EDA5C", VA = "0x40EDA5C")] get
      {
        return (FreeMapCommonElement) null;
      }
    }

    [Token(Token = "0x170037FD")]
    private Func<IEnumerator, Coroutine> StartCoroutine
    {
      [Token(Token = "0x600FE51"), Address(RVA = "0x40EDA78", Offset = "0x40EDA78", VA = "0x40EDA78")] get
      {
        return (Func<IEnumerator, Coroutine>) null;
      }
    }

    [Token(Token = "0x600FE52")]
    [Address(RVA = "0x40EDAF8", Offset = "0x40EDAF8", VA = "0x40EDAF8")]
    public InstanceManager(AreaCameraEditor parent)
    {
    }

    [Token(Token = "0x600FE53")]
    [Address(RVA = "0x40EDB90", Offset = "0x40EDB90", VA = "0x40EDB90")]
    public void Update()
    {
    }

    [Token(Token = "0x600FE54")]
    [Address(RVA = "0x40EDBE0", Offset = "0x40EDBE0", VA = "0x40EDBE0")]
    public void Release()
    {
    }

    [Token(Token = "0x600FE55")]
    [Address(RVA = "0x40EDC44", Offset = "0x40EDC44", VA = "0x40EDC44")]
    public void SetPosition(int playerMovePos, int cameraPosID, FreeMapInstance target)
    {
    }

    [Token(Token = "0x600FE56")]
    [Address(RVA = "0x40EDCC0", Offset = "0x40EDCC0", VA = "0x40EDCC0")]
    private IEnumerator SetPositionInternal(
      int playerMovePos,
      int cameraPosID,
      FreeMapInstance target)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600FE57")]
    [Address(RVA = "0x40EDD74", Offset = "0x40EDD74", VA = "0x40EDD74")]
    public IEnumerable<FreeMapInstance> GetLayoutInstances() => (IEnumerable<FreeMapInstance>) null;

    [Token(Token = "0x600FE58")]
    [Address(RVA = "0x40EDE98", Offset = "0x40EDE98", VA = "0x40EDE98")]
    public void Create(int settingID, int areaSettingID)
    {
    }

    [Token(Token = "0x600FE59")]
    [Address(RVA = "0x40EDF00", Offset = "0x40EDF00", VA = "0x40EDF00")]
    private IEnumerator CreateInternal(int settingID, int areaSettingID) => (IEnumerator) null;

    [Token(Token = "0x600FE5A")]
    [Address(RVA = "0x40EDFA4", Offset = "0x40EDFA4", VA = "0x40EDFA4")]
    private IEnumerator CreateBackGroundAsync(FreeMapScenesParam sceneParam) => (IEnumerator) null;

    [Token(Token = "0x600FE5B")]
    [Address(RVA = "0x40EE040", Offset = "0x40EE040", VA = "0x40EE040")]
    private void CameraSetting(FreeMapPlacementObject placementObject)
    {
    }

    [Token(Token = "0x600FE5C")]
    [Address(RVA = "0x40EE1D0", Offset = "0x40EE1D0", VA = "0x40EE1D0")]
    private IEnumerator CreateLayoutAsync(
      FreeMapScenesParam sceneParam,
      FreeMapPlacementObject placementObject,
      int layoutLabel,
      int areaID)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600FE5D")]
    [Address(RVA = "0x40EE288", Offset = "0x40EE288", VA = "0x40EE288")]
    private IEnumerator CreatePlayerAsync(
      FreeMapScenesParam sceneParam,
      FreeMapPlacementObject placementObject,
      int characterSwitchPatternID)
    {
      return (IEnumerator) null;
    }
  }
}
