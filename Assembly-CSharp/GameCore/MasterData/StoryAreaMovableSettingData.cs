// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAreaMovableSettingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.MovableMob.Data;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011CE")]
  [Serializable]
  public sealed class StoryAreaMovableSettingData : IMasterDataEntity
  {
    [Token(Token = "0x4005597")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005598")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int GroupName;
    [Token(Token = "0x4005599")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string SettingRouteName;
    [Token(Token = "0x400559A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int SpawnPattern;
    [Token(Token = "0x400559B")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public float MoveSpeed;
    [Token(Token = "0x400559C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public float PopSpeed;
    [Token(Token = "0x400559D")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public float PopMinSpeed;
    [Token(Token = "0x400559E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public float PopMaxSpeed;
    [Token(Token = "0x400559F")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int MaxPopCount;
    [Token(Token = "0x40055A0")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public float singleMobXPositionMin;
    [Token(Token = "0x40055A1")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public float singleMobXPositionMax;
    [Token(Token = "0x40055A2")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public float pairMobXDistanceMin;
    [Token(Token = "0x40055A3")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public float pairMobXDistanceMax;
    [Token(Token = "0x40055A4")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public float pairMobZDistanceMin;
    [Token(Token = "0x40055A5")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public float pairMobZDistanceMax;

    [Token(Token = "0x17000F60")]
    public int Key
    {
      [Token(Token = "0x60065E2"), Address(RVA = "0x4D1FD34", Offset = "0x4D1FD34", VA = "0x4D1FD34", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60065E3")]
    [Address(RVA = "0x4D1FD3C", Offset = "0x4D1FD3C", VA = "0x4D1FD3C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60065E4")]
    [Address(RVA = "0x4D20328", Offset = "0x4D20328", VA = "0x4D20328", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60065E5")]
    [Address(RVA = "0x4D20480", Offset = "0x4D20480", VA = "0x4D20480")]
    public MovablePartialRouteParameter.MobOffsetParameter MakeMobOffsetParameter()
    {
      return (MovablePartialRouteParameter.MobOffsetParameter) null;
    }

    [Token(Token = "0x60065E6")]
    [Address(RVA = "0x4D2057C", Offset = "0x4D2057C", VA = "0x4D2057C")]
    public StoryAreaMovableSettingData()
    {
    }
  }
}
