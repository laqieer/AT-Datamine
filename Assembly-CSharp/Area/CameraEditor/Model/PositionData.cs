// Decompiled with JetBrains decompiler
// Type: Area.CameraEditor.Model.PositionData
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
  [Token(Token = "0x2002866")]
  [Serializable]
  public class PositionData
  {
    [Token(Token = "0x400AC2A")]
    [FieldOffset(Offset = "0x10")]
    private AreaCameraEditor parent;
    [Token(Token = "0x400AC2B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private StoryFreeActionPlayerMovePositionData current;
    [Token(Token = "0x400AC2C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<StoryFreeActionPlayerMovePositionData> dataList;

    [Token(Token = "0x17003808")]
    public StoryFreeActionPlayerMovePositionData Current
    {
      [Token(Token = "0x600FE85"), Address(RVA = "0x40EF9BC", Offset = "0x40EF9BC", VA = "0x40EF9BC")] get
      {
        return (StoryFreeActionPlayerMovePositionData) null;
      }
    }

    [Token(Token = "0x600FE86")]
    [Address(RVA = "0x40EF9C4", Offset = "0x40EF9C4", VA = "0x40EF9C4")]
    public PositionData(AreaCameraEditor parent)
    {
    }

    [Token(Token = "0x600FE87")]
    [Address(RVA = "0x40EF9EC", Offset = "0x40EF9EC", VA = "0x40EF9EC")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600FE88")]
    [Address(RVA = "0x40EFAA4", Offset = "0x40EFAA4", VA = "0x40EFAA4")]
    public void Update()
    {
    }

    [Token(Token = "0x600FE89")]
    [Address(RVA = "0x40EF850", Offset = "0x40EF850", VA = "0x40EF850")]
    public void SetCurrentDataByID(int movePosID)
    {
    }

    [Token(Token = "0x600FE8A")]
    [Address(RVA = "0x40EFBB8", Offset = "0x40EFBB8", VA = "0x40EFBB8")]
    public void SetCurrentDataByListIndex(int index)
    {
    }

    [Token(Token = "0x600FE8B")]
    [Address(RVA = "0x40EFC6C", Offset = "0x40EFC6C", VA = "0x40EFC6C")]
    public void UpdateListByCurrent(int index)
    {
    }

    [Token(Token = "0x600FE8C")]
    [Address(RVA = "0x40EFD2C", Offset = "0x40EFD2C", VA = "0x40EFD2C")]
    public void AddListFromCurrent()
    {
    }

    [Token(Token = "0x600FE8D")]
    [Address(RVA = "0x40EFE10", Offset = "0x40EFE10", VA = "0x40EFE10")]
    public void ListRemoveAt(int index)
    {
    }

    [Token(Token = "0x600FE8E")]
    [Address(RVA = "0x40EFE8C", Offset = "0x40EFE8C", VA = "0x40EFE8C")]
    public StoryFreeActionPlayerMovePositionData[] GetDataArray()
    {
      return (StoryFreeActionPlayerMovePositionData[]) null;
    }

    [Token(Token = "0x600FE8F")]
    [Address(RVA = "0x40EFAAC", Offset = "0x40EFAAC", VA = "0x40EFAAC")]
    public void UpdatePosition(StoryFreeActionPlayerMovePositionData data)
    {
    }
  }
}
