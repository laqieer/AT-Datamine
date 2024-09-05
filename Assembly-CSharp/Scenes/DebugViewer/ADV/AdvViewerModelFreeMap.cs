// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerModelFreeMap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Adv;
using FreeMap.Instance;
using FreeMap.Instance.Element;
using FreeMap.Loader;
using FreeMap.UI.Element;
using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.DebugViewer.AreaMap;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.ADV
{
  [Token(Token = "0x2003005")]
  public class AdvViewerModelFreeMap : IAdvViewerModel, IDebugViewerModel
  {
    [Token(Token = "0x400CCD5")]
    [FieldOffset(Offset = "0x10")]
    private Func<IEnumerator, Coroutine> StartCoroutine;
    [Token(Token = "0x400CCD6")]
    [FieldOffset(Offset = "0x18")]
    private DebugAreaMapLoader loader;
    [Token(Token = "0x400CCDB")]
    [FieldOffset(Offset = "0x40")]
    private Dictionary<int, int> placementObejctDicts;
    [Token(Token = "0x400CCDC")]
    [FieldOffset(Offset = "0x48")]
    private int currentSequenceId;

    [Token(Token = "0x17003F5B")]
    public FreeMapMovePosition PlayerMovePoint
    {
      [Token(Token = "0x6012C54"), Address(RVA = "0x3FB00F8", Offset = "0x3FB00F8", VA = "0x3FB00F8")] private set
      {
      }
      [Token(Token = "0x6012C55"), Address(RVA = "0x3FB0100", Offset = "0x3FB0100", VA = "0x3FB0100")] get
      {
        return (FreeMapMovePosition) null;
      }
    }

    [Token(Token = "0x17003F5C")]
    public MapAdvControlAdapter AdvControlAdapter
    {
      [Token(Token = "0x6012C56"), Address(RVA = "0x3FB0108", Offset = "0x3FB0108", VA = "0x3FB0108")] private set
      {
      }
      [Token(Token = "0x6012C57"), Address(RVA = "0x3FB0110", Offset = "0x3FB0110", VA = "0x3FB0110")] get
      {
        return (MapAdvControlAdapter) null;
      }
    }

    [Token(Token = "0x17003F5D")]
    public FreeMapBackGroundTemporarySceneLoader BackGroundSceneReloadHandler
    {
      [Token(Token = "0x6012C58"), Address(RVA = "0x3FB0118", Offset = "0x3FB0118", VA = "0x3FB0118")] private set
      {
      }
      [Token(Token = "0x6012C59"), Address(RVA = "0x3FB0120", Offset = "0x3FB0120", VA = "0x3FB0120")] get
      {
        return (FreeMapBackGroundTemporarySceneLoader) null;
      }
    }

    [Token(Token = "0x17003F5E")]
    public FreeMapIconEventControlElement ControlElement
    {
      [Token(Token = "0x6012C5A"), Address(RVA = "0x3FB0128", Offset = "0x3FB0128", VA = "0x3FB0128")] get
      {
        return (FreeMapIconEventControlElement) null;
      }
    }

    [Token(Token = "0x6012C5B")]
    [Address(RVA = "0x3FB0130", Offset = "0x3FB0130", VA = "0x3FB0130")]
    public bool DebugCheckCondition(
      int checkSequenceID,
      int inactiveConditionId,
      int activeConditionId)
    {
      return new bool();
    }

    [Token(Token = "0x6012C5C")]
    [Address(RVA = "0x3FB039C", Offset = "0x3FB039C", VA = "0x3FB039C")]
    public bool DebugCheck(
      int layoutId,
      int placementObjectId,
      int checkSequenceID,
      int inactiveConditionId,
      int activeConditionId)
    {
      return new bool();
    }

    [Token(Token = "0x6012C5D")]
    [Address(RVA = "0x3FB0188", Offset = "0x3FB0188", VA = "0x3FB0188")]
    protected bool IsMatchConditionEvent(int checkSequenceID, int conditionID) => new bool();

    [Token(Token = "0x6012C5E")]
    [Address(RVA = "0x3FB04A8", Offset = "0x3FB04A8", VA = "0x3FB04A8")]
    public AdvViewerModelFreeMap(
      Func<IEnumerator, Coroutine> StartCoroutine,
      DebugAreaMapLoader loader)
    {
    }

    [Token(Token = "0x6012C5F")]
    [Address(RVA = "0x3FB07A0", Offset = "0x3FB07A0", VA = "0x3FB07A0")]
    public void Create(int settingId, int areaSettingId, int sequenceId, Action OnCreate)
    {
    }

    [Token(Token = "0x6012C60")]
    [Address(RVA = "0x3FB08A0", Offset = "0x3FB08A0", VA = "0x3FB08A0")]
    private void Create(
      int settingId,
      int areaSettingId,
      string startAnchor,
      int sequenceId,
      Action OnCreate)
    {
    }

    [Token(Token = "0x6012C61")]
    [Address(RVA = "0x3FB09D4", Offset = "0x3FB09D4", VA = "0x3FB09D4")]
    public void Release()
    {
    }

    [Token(Token = "0x6012C62")]
    [Address(RVA = "0x3FB09F0", Offset = "0x3FB09F0", VA = "0x3FB09F0")]
    public GameObject GetObjectModel(string objectAccessName) => (GameObject) null;

    [Token(Token = "0x6012C63")]
    [Address(RVA = "0x3FB0A1C", Offset = "0x3FB0A1C", VA = "0x3FB0A1C")]
    public GameObject GetPlayerModel() => (GameObject) null;

    [Token(Token = "0x6012C64")]
    [Address(RVA = "0x3FB0A48", Offset = "0x3FB0A48", VA = "0x3FB0A48")]
    public void SetPlayerPosition(string anchorName, Vector3 offset, float rotate)
    {
    }

    [Token(Token = "0x6012C65")]
    [Address(RVA = "0x3FB0A64", Offset = "0x3FB0A64", VA = "0x3FB0A64")]
    public void SetPlayerPosition(int playerMoveKey, int cameraViewKey, string objectAccessName)
    {
    }

    [Token(Token = "0x6012C66")]
    [Address(RVA = "0x3FB0C50", Offset = "0x3FB0C50", VA = "0x3FB0C50")]
    public void AddInstance(StoryFreeActionLayoutData layout, Action<FreeMapInstance> onCreate)
    {
    }

    [Token(Token = "0x6012C67")]
    [Address(RVA = "0x3FB0C7C", Offset = "0x3FB0C7C", VA = "0x3FB0C7C")]
    public void AddInstanceIfNotFound(
      StoryFreeActionObjectData objectData,
      Action<FreeMapInstance> onCreate)
    {
    }

    [Token(Token = "0x6012C68")]
    [Address(RVA = "0x3FB0E28", Offset = "0x3FB0E28", VA = "0x3FB0E28", Slot = "4")]
    public void Update()
    {
    }

    [Token(Token = "0x6012C69")]
    [Address(RVA = "0x3FB0E2C", Offset = "0x3FB0E2C", VA = "0x3FB0E2C", Slot = "5")]
    public void Destroy()
    {
    }
  }
}
