// Decompiled with JetBrains decompiler
// Type: FreeMap.FreeMapCommonElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.MovableMob;
using FreeMap.Instance;
using FreeMap.Instance.KeyController;
using FreeMap.Loader;
using FreeMap.Parameter;
using FreeMap.Parameter.UIParam;
using FreeMap.Sound;
using FreeMap.UI;
using FreeMap.UI.SwipeController;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
namespace FreeMap
{
  [Token(Token = "0x20015E2")]
  public class FreeMapCommonElement
  {
    [Token(Token = "0x17001304")]
    public FreeMapManager FreeMapManager
    {
      [Token(Token = "0x6007BA7"), Address(RVA = "0x22A371C", Offset = "0x22A371C", VA = "0x22A371C")] get
      {
        return (FreeMapManager) null;
      }
      [Token(Token = "0x6007BA8"), Address(RVA = "0x22A3724", Offset = "0x22A3724", VA = "0x22A3724")] set
      {
      }
    }

    [Token(Token = "0x17001305")]
    public FreeMapSceneManager SceneManager
    {
      [Token(Token = "0x6007BA9"), Address(RVA = "0x22A372C", Offset = "0x22A372C", VA = "0x22A372C")] get
      {
        return (FreeMapSceneManager) null;
      }
      [Token(Token = "0x6007BAA"), Address(RVA = "0x22A3734", Offset = "0x22A3734", VA = "0x22A3734")] set
      {
      }
    }

    [Token(Token = "0x17001306")]
    public FreeMapUIManageHandler MapUIManageHolder
    {
      [Token(Token = "0x6007BAB"), Address(RVA = "0x22A373C", Offset = "0x22A373C", VA = "0x22A373C")] get
      {
        return (FreeMapUIManageHandler) null;
      }
      [Token(Token = "0x6007BAC"), Address(RVA = "0x22A3744", Offset = "0x22A3744", VA = "0x22A3744")] set
      {
      }
    }

    [Token(Token = "0x17001307")]
    public FreeMapInstanceHolder InstanceHolder
    {
      [Token(Token = "0x6007BAD"), Address(RVA = "0x22A374C", Offset = "0x22A374C", VA = "0x22A374C")] get
      {
        return (FreeMapInstanceHolder) null;
      }
      [Token(Token = "0x6007BAE"), Address(RVA = "0x22A3754", Offset = "0x22A3754", VA = "0x22A3754")] set
      {
      }
    }

    [Token(Token = "0x17001308")]
    public FreeMapTransformHolderList TransformHolderList
    {
      [Token(Token = "0x6007BAF"), Address(RVA = "0x22A375C", Offset = "0x22A375C", VA = "0x22A375C")] get
      {
        return (FreeMapTransformHolderList) null;
      }
      [Token(Token = "0x6007BB0"), Address(RVA = "0x22A3764", Offset = "0x22A3764", VA = "0x22A3764")] set
      {
      }
    }

    [Token(Token = "0x17001309")]
    public AudioListenerConrtol AudioListener
    {
      [Token(Token = "0x6007BB1"), Address(RVA = "0x22A376C", Offset = "0x22A376C", VA = "0x22A376C")] get
      {
        return (AudioListenerConrtol) null;
      }
      [Token(Token = "0x6007BB2"), Address(RVA = "0x22A3774", Offset = "0x22A3774", VA = "0x22A3774")] set
      {
      }
    }

    [Token(Token = "0x1700130A")]
    public FreeMapIconEventHandler IconEventHandler
    {
      [Token(Token = "0x6007BB3"), Address(RVA = "0x22A377C", Offset = "0x22A377C", VA = "0x22A377C")] get
      {
        return (FreeMapIconEventHandler) null;
      }
      [Token(Token = "0x6007BB4"), Address(RVA = "0x22A3784", Offset = "0x22A3784", VA = "0x22A3784")] set
      {
      }
    }

    [Token(Token = "0x1700130B")]
    public FreeMapSoundResourceManager SoundResourceManager
    {
      [Token(Token = "0x6007BB5"), Address(RVA = "0x22A378C", Offset = "0x22A378C", VA = "0x22A378C")] set
      {
      }
      [Token(Token = "0x6007BB6"), Address(RVA = "0x22A3794", Offset = "0x22A3794", VA = "0x22A3794")] get
      {
        return (FreeMapSoundResourceManager) null;
      }
    }

    [Token(Token = "0x1700130C")]
    public FreeMapResourceLoader ResourceLoader
    {
      [Token(Token = "0x6007BB7"), Address(RVA = "0x22A379C", Offset = "0x22A379C", VA = "0x22A379C")] set
      {
      }
      [Token(Token = "0x6007BB8"), Address(RVA = "0x22A37A4", Offset = "0x22A37A4", VA = "0x22A37A4")] get
      {
        return (FreeMapResourceLoader) null;
      }
    }

    [Token(Token = "0x1700130D")]
    public FreeMapResourceCacheManager ResourceCacheManager
    {
      [Token(Token = "0x6007BB9"), Address(RVA = "0x22A37AC", Offset = "0x22A37AC", VA = "0x22A37AC")] get
      {
        return (FreeMapResourceCacheManager) null;
      }
      [Token(Token = "0x6007BBA"), Address(RVA = "0x22A37B4", Offset = "0x22A37B4", VA = "0x22A37B4")] set
      {
      }
    }

    [Token(Token = "0x1700130E")]
    public SwipeControllerLogic SwipeController
    {
      [Token(Token = "0x6007BBB"), Address(RVA = "0x22A37BC", Offset = "0x22A37BC", VA = "0x22A37BC")] set
      {
      }
      [Token(Token = "0x6007BBC"), Address(RVA = "0x22A37C4", Offset = "0x22A37C4", VA = "0x22A37C4")] get
      {
        return (SwipeControllerLogic) null;
      }
    }

    [Token(Token = "0x1700130F")]
    public FreeMapPlayerKeyControllerLogic KeyController
    {
      [Token(Token = "0x6007BBD"), Address(RVA = "0x22A37CC", Offset = "0x22A37CC", VA = "0x22A37CC")] get
      {
        return (FreeMapPlayerKeyControllerLogic) null;
      }
      [Token(Token = "0x6007BBE"), Address(RVA = "0x22A37D4", Offset = "0x22A37D4", VA = "0x22A37D4")] set
      {
      }
    }

    [Token(Token = "0x17001310")]
    public Scene MapManagerScene
    {
      [Token(Token = "0x6007BBF"), Address(RVA = "0x22A37DC", Offset = "0x22A37DC", VA = "0x22A37DC")] get
      {
        return new Scene();
      }
    }

    [Token(Token = "0x6007BC0")]
    [Address(RVA = "0x22A3818", Offset = "0x22A3818", VA = "0x22A3818")]
    public FreeMapCommonElement()
    {
    }

    [Token(Token = "0x6007BC1")]
    [Address(RVA = "0x22A3820", Offset = "0x22A3820", VA = "0x22A3820")]
    public FreeMapCommonElement(GameObject owner, RectTransform iconCanvasRectTransform)
    {
    }

    [Token(Token = "0x6007BC2")]
    [Address(RVA = "0x22A3D4C", Offset = "0x22A3D4C", VA = "0x22A3D4C")]
    public void Initialize(MonoBehaviour monoBehaviour, Transform instanceRoot)
    {
    }

    [Token(Token = "0x6007BC3")]
    [Address(RVA = "0x22A3D9C", Offset = "0x22A3D9C", VA = "0x22A3D9C")]
    public void SetAudioListener(Scene spawnScene)
    {
    }

    [Token(Token = "0x6007BC4")]
    [Address(RVA = "0x22A3E0C", Offset = "0x22A3E0C", VA = "0x22A3E0C")]
    public void StartAreaMap(
      FreeMapScenesParam sceneParam,
      Action mapStartedCallback,
      FreeMapUIParamBase executeUIParam,
      MovableMobManager movableMobManager,
      UnityAction<string> onTransitionByArea = null,
      UnityAction onInteractEnableUI = null,
      UnityAction onInteractDisableUI = null,
      IReadOnlyList<string> activeTransAreaAnchors = null)
    {
    }

    [Token(Token = "0x6007BC5")]
    [Address(RVA = "0x22A4238", Offset = "0x22A4238", VA = "0x22A4238")]
    public void ApplySettingPlayerMapMoveParamInMapData(FreeMapPlayerInstance playerIns)
    {
    }

    [Token(Token = "0x6007BC6")]
    [Address(RVA = "0x22A4310", Offset = "0x22A4310", VA = "0x22A4310")]
    public GameObject GetAreaGlobalVolumeObject() => (GameObject) null;

    [Token(Token = "0x6007BC7")]
    [Address(RVA = "0x22A43BC", Offset = "0x22A43BC", VA = "0x22A43BC")]
    public void Update(float deltaTime)
    {
    }

    [Token(Token = "0x6007BC8")]
    [Address(RVA = "0x22A43D8", Offset = "0x22A43D8", VA = "0x22A43D8")]
    public void Release()
    {
    }

    [Token(Token = "0x6007BC9")]
    [Address(RVA = "0x22A4770", Offset = "0x22A4770", VA = "0x22A4770")]
    public void Destroy()
    {
    }
  }
}
