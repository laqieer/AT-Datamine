// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelectMap.MapCameraManage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cinemachine;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.QuestSelectMap
{
  [Token(Token = "0x20033B2")]
  public class MapCameraManage
  {
    [Token(Token = "0x400E099")]
    [FieldOffset(Offset = "0x10")]
    private CinemachineBrain cb;
    [Token(Token = "0x400E09A")]
    [FieldOffset(Offset = "0x18")]
    private GameObject prevVo;
    [Token(Token = "0x400E09B")]
    [FieldOffset(Offset = "0x20")]
    private CinemachineVirtualCamera prevVs;
    [Token(Token = "0x400E09C")]
    [FieldOffset(Offset = "0x28")]
    private GameObject nowVo;
    [Token(Token = "0x400E09D")]
    [FieldOffset(Offset = "0x30")]
    private CinemachineVirtualCamera nowVs;
    [Token(Token = "0x400E09E")]
    [FieldOffset(Offset = "0x38")]
    private MapGroundData mapData;
    [Token(Token = "0x400E09F")]
    [FieldOffset(Offset = "0x40")]
    private ILocationDataProvider.LocationData? nowData;
    [Token(Token = "0x400E0A1")]
    [FieldOffset(Offset = "0x68")]
    private Camera mapModelRenderingCamera;
    [Token(Token = "0x400E0A2")]
    [FieldOffset(Offset = "0x70")]
    private Vector3 cameraOffSetPos;
    [Token(Token = "0x400E0A3")]
    [FieldOffset(Offset = "0x7C")]
    private Vector3 cameraInitOffSetPos;
    [Token(Token = "0x400E0A4")]
    [FieldOffset(Offset = "0x88")]
    private Vector3 cameraRot;
    [Token(Token = "0x400E0A5")]
    [FieldOffset(Offset = "0x94")]
    private float cameraFov;
    [Token(Token = "0x400E0A6")]
    [FieldOffset(Offset = "0x98")]
    private CinemachineBlenderSettings cameraStartBlend;
    [Token(Token = "0x400E0A7")]
    [FieldOffset(Offset = "0xA0")]
    private CinemachineBlenderSettings cameraTransitionBlend;
    [Token(Token = "0x400E0A8")]
    [FieldOffset(Offset = "0xA8")]
    private GameObject virtualCameraPrefab;
    [Token(Token = "0x400E0A9")]
    [FieldOffset(Offset = "0xB0")]
    private GameObject parentGo;

    [Token(Token = "0x14000209")]
    private event Action onUpateEvent
    {
      [Token(Token = "0x6014539"), Address(RVA = "0x206CD54", Offset = "0x206CD54", VA = "0x206CD54")] add
      {
      }
      [Token(Token = "0x601453A"), Address(RVA = "0x206CDF0", Offset = "0x206CDF0", VA = "0x206CDF0")] remove
      {
      }
    }

    [Token(Token = "0x601453B")]
    [Address(RVA = "0x206CE8C", Offset = "0x206CE8C", VA = "0x206CE8C")]
    public MapCameraManage(
      GameObject parentGo,
      GameObject virtualCameraPrefab,
      Camera mapModelRenderingCamera,
      Vector3 cameraOffSetPos,
      Vector3 cameraInitOffSetPos,
      Vector3 cameraRot,
      float cameraFov,
      CinemachineBlenderSettings cameraStartBlend,
      CinemachineBlenderSettings cameraTransitionBlend,
      MapGroundData mapData)
    {
    }

    [Token(Token = "0x601453C")]
    [Address(RVA = "0x206CF44", Offset = "0x206CF44", VA = "0x206CF44")]
    public IEnumerator Initialize(ILocationDataProvider.LocationData? nowData)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601453D")]
    [Address(RVA = "0x206CFEC", Offset = "0x206CFEC", VA = "0x206CFEC")]
    public void Destory()
    {
    }

    [Token(Token = "0x601453E")]
    [Address(RVA = "0x206D0B8", Offset = "0x206D0B8", VA = "0x206D0B8")]
    private void OnCameraUpdate(CinemachineBrain brain)
    {
    }

    [Token(Token = "0x601453F")]
    [Address(RVA = "0x206D150", Offset = "0x206D150", VA = "0x206D150")]
    public void RegisterUpdate(Action action)
    {
    }

    [Token(Token = "0x6014540")]
    [Address(RVA = "0x206D154", Offset = "0x206D154", VA = "0x206D154")]
    public void UnRegisterUpdate(Action action)
    {
    }

    [Token(Token = "0x6014541")]
    [Address(RVA = "0x206D158", Offset = "0x206D158", VA = "0x206D158")]
    public void MapStart()
    {
    }

    [Token(Token = "0x6014542")]
    [Address(RVA = "0x206D34C", Offset = "0x206D34C", VA = "0x206D34C")]
    private void ReplaceNewCameraTransition()
    {
    }

    [Token(Token = "0x6014543")]
    [Address(RVA = "0x206D484", Offset = "0x206D484", VA = "0x206D484")]
    public void Update()
    {
    }

    [Token(Token = "0x6014544")]
    [Address(RVA = "0x206D488", Offset = "0x206D488", VA = "0x206D488")]
    public void RequestLocationChange(ILocationDataProvider.LocationData? locData)
    {
    }

    [Token(Token = "0x6014545")]
    [Address(RVA = "0x206D214", Offset = "0x206D214", VA = "0x206D214")]
    private void SetCamraTrans(
      Transform cameraTransRef,
      ILocationDataProvider.LocationData? locData,
      Vector3 offSetPos)
    {
    }

    [Token(Token = "0x6014546")]
    [Address(RVA = "0x206D4FC", Offset = "0x206D4FC", VA = "0x206D4FC")]
    private CinemachineVirtualCamera CreateCamera(string objname)
    {
      return (CinemachineVirtualCamera) null;
    }
  }
}
