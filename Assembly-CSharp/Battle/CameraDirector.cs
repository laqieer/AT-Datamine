// Decompiled with JetBrains decompiler
// Type: Battle.CameraDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.ViewCamera;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
namespace Battle
{
  [Token(Token = "0x200226B")]
  public class CameraDirector : MonoBehaviour, ISubDirector<IDirector>, IStepUpdate
  {
    [Token(Token = "0x400910C")]
    protected const float DefaultMinDistance = 20f;
    [Token(Token = "0x400910D")]
    protected const float DefaultMaxDistance = 50f;
    [Token(Token = "0x400910E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Camera mainUICamera;
    [Token(Token = "0x4009110")]
    [FieldOffset(Offset = "0x28")]
    private IDirector mainDirector;
    [Token(Token = "0x4009111")]
    [FieldOffset(Offset = "0x30")]
    [Tooltip("カメラ設定")]
    [SerializeField]
    protected List<CameraDirector.MapViewCameraSetting> mapViewCameraSettings;
    [Token(Token = "0x4009113")]
    [FieldOffset(Offset = "0x40")]
    protected InputControllCamera2D mapViewCameraControll;
    [Token(Token = "0x4009116")]
    [FieldOffset(Offset = "0x50")]
    private CameraDirector.IOnSwitchCameraSettingHandler onSwitchCameraSettingHandler;
    [Token(Token = "0x4009117")]
    [FieldOffset(Offset = "0x58")]
    protected DoFController dofController;
    [Token(Token = "0x4009118")]
    [FieldOffset(Offset = "0x60")]
    public Action<float> OnUpdateDistanceDelegate;

    [Token(Token = "0x17002D69")]
    public Camera MainUiCamera
    {
      [Token(Token = "0x600D147"), Address(RVA = "0x19562BC", Offset = "0x19562BC", VA = "0x19562BC")] get
      {
        return (Camera) null;
      }
    }

    [Token(Token = "0x17002D6A")]
    public bool MainUICameraEnabled
    {
      [Token(Token = "0x600D148"), Address(RVA = "0x19562C4", Offset = "0x19562C4", VA = "0x19562C4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D149"), Address(RVA = "0x19562E0", Offset = "0x19562E0", VA = "0x19562E0")] set
      {
      }
    }

    [Token(Token = "0x17002D6B")]
    public IMapViewCamera MapViewCamera
    {
      [Token(Token = "0x600D14A"), Address(RVA = "0x1956300", Offset = "0x1956300", VA = "0x1956300")] get
      {
        return (IMapViewCamera) null;
      }
      [Token(Token = "0x600D14B"), Address(RVA = "0x1956308", Offset = "0x1956308", VA = "0x1956308")] protected set
      {
      }
    }

    [Token(Token = "0x17002D6C")]
    public IReadOnlyList<CameraDirector.MapViewCameraSetting> MapViewCameraSettings
    {
      [Token(Token = "0x600D14C"), Address(RVA = "0x1956310", Offset = "0x1956310", VA = "0x1956310")] get
      {
        return (IReadOnlyList<CameraDirector.MapViewCameraSetting>) null;
      }
    }

    [Token(Token = "0x17002D6D")]
    public int CurrentMapViewCameraSettingIndex
    {
      [Token(Token = "0x600D14D"), Address(RVA = "0x1956318", Offset = "0x1956318", VA = "0x1956318")] get
      {
        return new int();
      }
      [Token(Token = "0x600D14E"), Address(RVA = "0x1956320", Offset = "0x1956320", VA = "0x1956320")] protected set
      {
      }
    }

    [Token(Token = "0x17002D6E")]
    public InputControllCamera2D MapViewCameraControll
    {
      [Token(Token = "0x600D14F"), Address(RVA = "0x1956328", Offset = "0x1956328", VA = "0x1956328")] get
      {
        return (InputControllCamera2D) null;
      }
    }

    [Token(Token = "0x17002D6F")]
    public bool Initialized
    {
      [Token(Token = "0x600D150"), Address(RVA = "0x1956330", Offset = "0x1956330", VA = "0x1956330", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D151"), Address(RVA = "0x1956338", Offset = "0x1956338", VA = "0x1956338")] private set
      {
      }
    }

    [Token(Token = "0x17002D70")]
    public bool RequireSideCover
    {
      [Token(Token = "0x600D152"), Address(RVA = "0x1956344", Offset = "0x1956344", VA = "0x1956344")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D153"), Address(RVA = "0x195634C", Offset = "0x195634C", VA = "0x195634C")] protected set
      {
      }
    }

    [Token(Token = "0x600D154")]
    [Address(RVA = "0x1956358", Offset = "0x1956358", VA = "0x1956358", Slot = "5")]
    public void Initialize(IDirector mainDirector)
    {
    }

    [Token(Token = "0x600D155")]
    [Address(RVA = "0x1956394", Offset = "0x1956394", VA = "0x1956394", Slot = "9")]
    public virtual void RegisterMapViewCamera(
      ISystemFlags sys,
      IMapViewCamera viewCamera,
      Vector3 minViewMovePos,
      Vector3 maxViewMovePos,
      Vector3 initialPosition,
      params CameraDirector.MapViewCameraSetting[] settings)
    {
    }

    [Token(Token = "0x600D156")]
    [Address(RVA = "0x1956BBC", Offset = "0x1956BBC", VA = "0x1956BBC")]
    public void UnRegisterMapViewCamera()
    {
    }

    [Token(Token = "0x600D157")]
    [Address(RVA = "0x1956D10", Offset = "0x1956D10", VA = "0x1956D10", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600D158")]
    [Address(RVA = "0x1956D14", Offset = "0x1956D14", VA = "0x1956D14", Slot = "7")]
    public void Release()
    {
    }

    [Token(Token = "0x600D159")]
    [Address(RVA = "0x1956E00", Offset = "0x1956E00", VA = "0x1956E00", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600D15A")]
    [Address(RVA = "0x1956EC4", Offset = "0x1956EC4", VA = "0x1956EC4")]
    public void SetNextMapViewCameraSetting(float duration = 0.0f)
    {
    }

    [Token(Token = "0x600D15B")]
    [Address(RVA = "0x1956F44", Offset = "0x1956F44", VA = "0x1956F44")]
    public void SetSpecifiedMapViewCameraSetting(int index, float duration = 0.0f)
    {
    }

    [Token(Token = "0x600D15C")]
    [Address(RVA = "0x1957400", Offset = "0x1957400", VA = "0x1957400")]
    public bool SearchAndSetDoFController(Scene mapScene) => new bool();

    [Token(Token = "0x600D15D")]
    [Address(RVA = "0x195751C", Offset = "0x195751C", VA = "0x195751C")]
    public Vector3 MainUIScreenToWorldPoint(Vector3 point) => new Vector3();

    [Token(Token = "0x600D15E")]
    [Address(RVA = "0x1957538", Offset = "0x1957538", VA = "0x1957538")]
    public Vector3 WorldToMainUIScreenPoint(Vector3 point) => new Vector3();

    [Token(Token = "0x600D15F")]
    [Address(RVA = "0x1957554", Offset = "0x1957554", VA = "0x1957554")]
    public void SetSwitchCameraSettingHandler(
      CameraDirector.IOnSwitchCameraSettingHandler handler)
    {
    }

    [Token(Token = "0x600D160")]
    [Address(RVA = "0x195755C", Offset = "0x195755C", VA = "0x195755C", Slot = "10")]
    protected virtual void OnUpdateDistanceMapViewCamera(float distance)
    {
    }

    [Token(Token = "0x600D161")]
    [Address(RVA = "0x195769C", Offset = "0x195769C", VA = "0x195769C")]
    public CameraDirector()
    {
    }

    [Token(Token = "0x200226C")]
    public interface IOnSwitchCameraSettingHandler
    {
      [Token(Token = "0x600D162")]
      void OnSwitchCameraSetting();
    }

    [Token(Token = "0x200226D")]
    [Serializable]
    public struct MapViewCameraSetting
    {
      [Token(Token = "0x4009119")]
      [FieldOffset(Offset = "0x0")]
      [Tooltip("カメラID")]
      public int Id;
      [Token(Token = "0x400911A")]
      [FieldOffset(Offset = "0x4")]
      [Tooltip("カメラ距離制限")]
      public float MaxDistance;
      [Token(Token = "0x400911B")]
      [FieldOffset(Offset = "0x8")]
      [Tooltip("カメラ距離制限")]
      public float MinDistance;
      [Token(Token = "0x400911C")]
      [FieldOffset(Offset = "0xC")]
      [Tooltip("初期カメラ距離")]
      public float InitialDistance;
      [Token(Token = "0x400911D")]
      [FieldOffset(Offset = "0x10")]
      [Tooltip("ユーザーが設定したカメラ距離")]
      public float UserDistance;
      [Token(Token = "0x400911E")]
      [FieldOffset(Offset = "0x14")]
      [Tooltip("カメラ角度")]
      public Vector3 RotationAngles;
      [Token(Token = "0x400911F")]
      [FieldOffset(Offset = "0x20")]
      [Tooltip("カメラ高さオフセット")]
      public float HeightOffset;
      [Token(Token = "0x4009120")]
      [FieldOffset(Offset = "0x24")]
      [Tooltip("マップ端の覆いの表示ON/OFF")]
      public bool RequireSideCover;

      [Token(Token = "0x600D163")]
      [Address(RVA = "0x1957748", Offset = "0x1957748", VA = "0x1957748")]
      public MapViewCameraSetting(
        int id,
        float minDistance,
        float maxDistance,
        float initialDistance,
        float userDistance,
        Vector3 rotationAngles,
        float heightOffset,
        bool requireSideCover)
      {
      }
    }
  }
}
