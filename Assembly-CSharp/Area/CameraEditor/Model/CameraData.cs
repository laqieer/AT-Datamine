// Decompiled with JetBrains decompiler
// Type: Area.CameraEditor.Model.CameraData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Area.CameraEditor.Model
{
  [Token(Token = "0x200285B")]
  [Serializable]
  public class CameraData
  {
    [Token(Token = "0x400ABF4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    protected StoryFreeActionCameraViewPositionData current;
    [Token(Token = "0x400ABF5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<StoryFreeActionCameraViewPositionData> dataList;
    [Token(Token = "0x400ABF6")]
    [FieldOffset(Offset = "0x20")]
    private AreaCameraEditor parent;

    [Token(Token = "0x170037F4")]
    public StoryFreeActionCameraViewPositionData Current
    {
      [Token(Token = "0x600FE35"), Address(RVA = "0x40ED490", Offset = "0x40ED490", VA = "0x40ED490")] get
      {
        return (StoryFreeActionCameraViewPositionData) null;
      }
    }

    [Token(Token = "0x600FE36")]
    [Address(RVA = "0x40ED498", Offset = "0x40ED498", VA = "0x40ED498")]
    public CameraData(AreaCameraEditor parent)
    {
    }

    [Token(Token = "0x600FE37")]
    [Address(RVA = "0x40ED4C0", Offset = "0x40ED4C0", VA = "0x40ED4C0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600FE38")]
    [Address(RVA = "0x40ED578", Offset = "0x40ED578", VA = "0x40ED578")]
    public void Update()
    {
    }

    [Token(Token = "0x600FE39")]
    [Address(RVA = "0x40ED580", Offset = "0x40ED580", VA = "0x40ED580")]
    public void SetCurrentDataByID(int cameraPosID)
    {
    }

    [Token(Token = "0x600FE3A")]
    [Address(RVA = "0x40ED6A4", Offset = "0x40ED6A4", VA = "0x40ED6A4")]
    public void SetCurrentDataByListIndex(int index)
    {
    }

    [Token(Token = "0x600FE3B")]
    [Address(RVA = "0x40ED758", Offset = "0x40ED758", VA = "0x40ED758")]
    public void UpdateListByCurrent(int index)
    {
    }

    [Token(Token = "0x600FE3C")]
    [Address(RVA = "0x40ED818", Offset = "0x40ED818", VA = "0x40ED818")]
    public void AddListFromCurrent()
    {
    }

    [Token(Token = "0x600FE3D")]
    [Address(RVA = "0x40ED8FC", Offset = "0x40ED8FC", VA = "0x40ED8FC")]
    public void ListRemoveAt(int index)
    {
    }

    [Token(Token = "0x600FE3E")]
    [Address(RVA = "0x40ED978", Offset = "0x40ED978", VA = "0x40ED978")]
    public StoryFreeActionCameraViewPositionData[] GetDataArray()
    {
      return (StoryFreeActionCameraViewPositionData[]) null;
    }

    [Token(Token = "0x600FE3F")]
    [Address(RVA = "0x40ED57C", Offset = "0x40ED57C", VA = "0x40ED57C")]
    public void UpdateCamera(StoryFreeActionCameraViewPositionData data)
    {
    }
  }
}
