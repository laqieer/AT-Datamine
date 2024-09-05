// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.HomeEventData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001025")]
  [Serializable]
  public sealed class HomeEventData : IMasterDataEntity
  {
    [Token(Token = "0x4005032")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005033")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int posterResource;
    [Token(Token = "0x4005034")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int buttonResource;
    [Token(Token = "0x4005035")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int button1;
    [Token(Token = "0x4005036")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int button2;
    [Token(Token = "0x4005037")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int button3;
    [Token(Token = "0x4005038")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public DateTime startAt;
    [Token(Token = "0x4005039")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public DateTime endAt;

    [Token(Token = "0x17000DD8")]
    public int Key
    {
      [Token(Token = "0x6005DF2"), Address(RVA = "0x2798780", Offset = "0x2798780", VA = "0x2798780", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005DF3")]
    [Address(RVA = "0x2798788", Offset = "0x2798788", VA = "0x2798788", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005DF4")]
    [Address(RVA = "0x2798AD4", Offset = "0x2798AD4", VA = "0x2798AD4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000DD9")]
    public string Name
    {
      [Token(Token = "0x6005DF5"), Address(RVA = "0x2798C10", Offset = "0x2798C10", VA = "0x2798C10")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DDA")]
    public bool HasButtonResource
    {
      [Token(Token = "0x6005DF6"), Address(RVA = "0x2798CEC", Offset = "0x2798CEC", VA = "0x2798CEC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6005DF7")]
    [Address(RVA = "0x2798CFC", Offset = "0x2798CFC", VA = "0x2798CFC")]
    public HomeEventData()
    {
    }
  }
}
