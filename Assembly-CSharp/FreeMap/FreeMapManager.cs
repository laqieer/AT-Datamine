// Decompiled with JetBrains decompiler
// Type: FreeMap.FreeMapManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.FadeContent;
using Area.MovableMob;
using FreeMap.CameraField;
using FreeMap.Instance;
using FreeMap.Loader;
using FreeMap.Parameter.UIParam;
using FreeMap.Placement;
using FreeMap.Scriptable;
using FreeMap.Sound;
using FreeMap.UI;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
namespace FreeMap
{
  [Token(Token = "0x20015E3")]
  public class FreeMapManager : MonoBehaviour, IFreeMapRegistBackgroundCamera
  {
    [Token(Token = "0x40063D8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("確認用:配置データ")]
    private FreeMapPlacementObject placementObject;
    [Token(Token = "0x40063D9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Header("確認用:カメラフィールドデータ")]
    private FreeMapCameraFieldManager scriptCameraFieldManager;
    [Token(Token = "0x40063DB")]
    [FieldOffset(Offset = "0x30")]
    private FreeMapInstanceHolder instanceHolder;
    [Token(Token = "0x40063DC")]
    [FieldOffset(Offset = "0x38")]
    private List<FreeMapTransitionArea> freeMapTransitionAreaList;
    [Token(Token = "0x40063DD")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [Header("確認用:使用カメラ")]
    private Camera mapUseCamera;
    [Token(Token = "0x40063DE")]
    [FieldOffset(Offset = "0x48")]
    private Coroutine mapStartCoroutine;
    [Token(Token = "0x40063E0")]
    [FieldOffset(Offset = "0x58")]
    private FreeMapUIManageHandler uiManageHolder;
    [Token(Token = "0x40063E1")]
    [FieldOffset(Offset = "0x60")]
    [Header("確認用:フェードマネージャー")]
    [SerializeField]
    private AreaFadeContentManager areaFadeContentManager;
    [Token(Token = "0x40063E2")]
    [FieldOffset(Offset = "0x68")]
    private IFreeMapManagerAudioListenerAccess audioListenerAccess;
    [Token(Token = "0x40063E3")]
    [FieldOffset(Offset = "0x70")]
    private MovableMobManager movableMobManager;
    [Token(Token = "0x40063E4")]
    [FieldOffset(Offset = "0x78")]
    private Scene loadedScene;
    [Token(Token = "0x40063E5")]
    public const string MapLinkCameraName = "LinkCamera";

    [Token(Token = "0x17001311")]
    public FreeMapPlacementObject PlacementObject
    {
      [Token(Token = "0x6007BCA"), Address(RVA = "0x22A4888", Offset = "0x22A4888", VA = "0x22A4888")] get
      {
        return (FreeMapPlacementObject) null;
      }
    }

    [Token(Token = "0x17001312")]
    public FreeMapCameraFieldManager ScriptCameraFieldManager
    {
      [Token(Token = "0x6007BCB"), Address(RVA = "0x22A4890", Offset = "0x22A4890", VA = "0x22A4890")] get
      {
        return (FreeMapCameraFieldManager) null;
      }
    }

    [Token(Token = "0x17001313")]
    public Transform InstanceRoot
    {
      [Token(Token = "0x6007BCC"), Address(RVA = "0x22A4898", Offset = "0x22A4898", VA = "0x22A4898")] private set
      {
      }
      [Token(Token = "0x6007BCD"), Address(RVA = "0x22A48A0", Offset = "0x22A48A0", VA = "0x22A48A0")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17001314")]
    public Camera MapUseCamera
    {
      [Token(Token = "0x6007BCE"), Address(RVA = "0x22A48A8", Offset = "0x22A48A8", VA = "0x22A48A8")] get
      {
        return (Camera) null;
      }
    }

    [Token(Token = "0x17001315")]
    public bool IsLoadedScene
    {
      [Token(Token = "0x6007BCF"), Address(RVA = "0x22A48B0", Offset = "0x22A48B0", VA = "0x22A48B0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6007BD0"), Address(RVA = "0x22A48B8", Offset = "0x22A48B8", VA = "0x22A48B8")] private set
      {
      }
    }

    [Token(Token = "0x17001316")]
    public AreaFadeContentManager AreaFadeContentManager
    {
      [Token(Token = "0x6007BD1"), Address(RVA = "0x22A48C4", Offset = "0x22A48C4", VA = "0x22A48C4")] get
      {
        return (AreaFadeContentManager) null;
      }
    }

    [Token(Token = "0x6007BD2")]
    [Address(RVA = "0x22A3D94", Offset = "0x22A3D94", VA = "0x22A3D94")]
    public void Initialize(Transform instanceRoot)
    {
    }

    [Token(Token = "0x6007BD3")]
    [Address(RVA = "0x22A41DC", Offset = "0x22A41DC", VA = "0x22A41DC")]
    public void StartAreaMap(
      FreeMapCommonElement commonElement,
      FreeMapUIParamBase invokeParam = null,
      Action mapStartedcallback = null,
      MovableMobManager movableMobManager = null,
      UnityAction<string> onTransitionByArea = null,
      UnityAction onInteractEnableUI = null,
      UnityAction onInteractDisableUI = null,
      IReadOnlyList<string> activeTransAreaAnchors = null)
    {
    }

    [Token(Token = "0x6007BD4")]
    [Address(RVA = "0x22A4984", Offset = "0x22A4984", VA = "0x22A4984")]
    public void CancelAndReleaseMap()
    {
    }

    [Token(Token = "0x6007BD5")]
    [Address(RVA = "0x22A45B4", Offset = "0x22A45B4", VA = "0x22A45B4")]
    public void ReleaseAreaMap()
    {
    }

    [Token(Token = "0x6007BD6")]
    [Address(RVA = "0x22A49B0", Offset = "0x22A49B0", VA = "0x22A49B0")]
    public void ChangeActiveMap(bool isActive)
    {
    }

    [Token(Token = "0x6007BD7")]
    [Address(RVA = "0x22A4B0C", Offset = "0x22A4B0C", VA = "0x22A4B0C")]
    public void SetActiveFreeMapTransitionAreaUnit(bool isView)
    {
    }

    [Token(Token = "0x6007BD8")]
    [Address(RVA = "0x22A4C64", Offset = "0x22A4C64", VA = "0x22A4C64")]
    public void LinkPlayerCamera(
      FreeMapInstanceHolder instanceHolder,
      IFreeMapManagerAudioListenerAccess audioListenerAccess)
    {
    }

    [Token(Token = "0x6007BD9")]
    [Address(RVA = "0x22A4D58", Offset = "0x22A4D58", VA = "0x22A4D58")]
    public void SetNearCmaeraField(FreeMapPlayerInstance player)
    {
    }

    [Token(Token = "0x6007BDA")]
    [Address(RVA = "0x22A4DA8", Offset = "0x22A4DA8", VA = "0x22A4DA8")]
    public void SetupCameraLOD(bool isActive)
    {
    }

    [Token(Token = "0x6007BDB")]
    [Address(RVA = "0x22A48CC", Offset = "0x22A48CC", VA = "0x22A48CC")]
    private IEnumerator StartAreaCoroutine(
      FreeMapCommonElement commonElement,
      FreeMapUIParamBase invokeParam = null,
      Action mapStartedcallback = null,
      MovableMobManager movableMobManager = null,
      UnityAction<string> onTransitionByArea = null,
      UnityAction onInteractEnableUI = null,
      UnityAction onInteractDisableUI = null,
      IReadOnlyList<string> activeTransAreaAnchors = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007BDC")]
    [Address(RVA = "0x22A4E84", Offset = "0x22A4E84", VA = "0x22A4E84")]
    public void RegistAreaFadeContent(FreeMapSceneHolder mapLoader)
    {
    }

    [Token(Token = "0x6007BDD")]
    [Address(RVA = "0x22A4FE0", Offset = "0x22A4FE0", VA = "0x22A4FE0", Slot = "4")]
    public void RegistCamera(Camera camera)
    {
    }

    [Token(Token = "0x6007BDE")]
    [Address(RVA = "0x22A5024", Offset = "0x22A5024", VA = "0x22A5024", Slot = "5")]
    public void ExcludeCamera()
    {
    }

    [Token(Token = "0x6007BDF")]
    [Address(RVA = "0x22A506C", Offset = "0x22A506C", VA = "0x22A506C")]
    private void Update()
    {
    }

    [Token(Token = "0x6007BE0")]
    [Address(RVA = "0x22A5180", Offset = "0x22A5180", VA = "0x22A5180")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x6007BE1")]
    [Address(RVA = "0x22A51AC", Offset = "0x22A51AC", VA = "0x22A51AC")]
    private void UpdateAfterCameraComfirm()
    {
    }

    [Token(Token = "0x6007BE2")]
    [Address(RVA = "0x22A53C4", Offset = "0x22A53C4", VA = "0x22A53C4")]
    public FreeMapManager()
    {
    }
  }
}
