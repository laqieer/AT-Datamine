// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionAreaGroupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Data;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200123D")]
  [Serializable]
  public sealed class StoryFreeActionAreaGroupData : IMasterDataEntity
  {
    [Token(Token = "0x400574B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400574C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int AreaGroupLabel;
    [Token(Token = "0x400574D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int Area1;
    [Token(Token = "0x400574E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string Location1;
    [Token(Token = "0x400574F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string StartPoint1;
    [Token(Token = "0x4005750")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public float iconOffsetX1;
    [Token(Token = "0x4005751")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public float iconOffsetY1;
    [Token(Token = "0x4005752")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public float iconOffsetZ1;
    [Token(Token = "0x4005753")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int Area2;
    [Token(Token = "0x4005754")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public string Location2;
    [Token(Token = "0x4005755")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public string StartPoint2;
    [Token(Token = "0x4005756")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public float iconOffsetX2;
    [Token(Token = "0x4005757")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public float iconOffsetY2;
    [Token(Token = "0x4005758")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public float iconOffsetZ2;
    [Token(Token = "0x4005759")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public string ConnectName;

    [Token(Token = "0x17000F9B")]
    public int Key
    {
      [Token(Token = "0x60067B3"), Address(RVA = "0x4D31BC0", Offset = "0x4D31BC0", VA = "0x4D31BC0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60067B4")]
    [Address(RVA = "0x4D31BC8", Offset = "0x4D31BC8", VA = "0x4D31BC8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60067B5")]
    [Address(RVA = "0x4D321B4", Offset = "0x4D321B4", VA = "0x4D321B4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60067B6")]
    [Address(RVA = "0x4D3231C", Offset = "0x4D3231C", VA = "0x4D3231C")]
    public AreaConnectParam GetArea1ConnectParam() => new AreaConnectParam();

    [Token(Token = "0x60067B7")]
    [Address(RVA = "0x4D32368", Offset = "0x4D32368", VA = "0x4D32368")]
    public AreaConnectParam GetArea2ConnectParam() => new AreaConnectParam();

    [Token(Token = "0x60067B8")]
    [Address(RVA = "0x4D32348", Offset = "0x4D32348", VA = "0x4D32348")]
    private AreaConnectParam CreateConnectParam(
      int toAreaID,
      string startAnchor,
      int fromAreaID,
      string placementAnchor,
      float iconOffsetX,
      float iconOffsetY,
      float iconOffsetZ)
    {
      return new AreaConnectParam();
    }

    [Token(Token = "0x60067B9")]
    [Address(RVA = "0x4D32398", Offset = "0x4D32398", VA = "0x4D32398")]
    public StoryFreeActionAreaGroupData()
    {
    }
  }
}
