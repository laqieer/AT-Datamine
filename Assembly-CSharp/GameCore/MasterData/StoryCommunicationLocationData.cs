// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationLocationData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011FA")]
  [Serializable]
  public sealed class StoryCommunicationLocationData : IMasterDataEntity
  {
    [Token(Token = "0x4005622")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005623")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005624")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int conditionAbility;
    [Token(Token = "0x4005625")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int adv;
    [Token(Token = "0x4005626")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int conditionTimeSlot;
    [Token(Token = "0x4005627")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int conditionWeather;

    [Token(Token = "0x17000F78")]
    public int Key
    {
      [Token(Token = "0x600669B"), Address(RVA = "0x4D26FD4", Offset = "0x4D26FD4", VA = "0x4D26FD4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600669C")]
    [Address(RVA = "0x4D26FDC", Offset = "0x4D26FDC", VA = "0x4D26FDC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600669D")]
    [Address(RVA = "0x4D27268", Offset = "0x4D27268", VA = "0x4D27268", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000F79")]
    public string AreaNameText
    {
      [Token(Token = "0x600669E"), Address(RVA = "0x4D27330", Offset = "0x4D27330", VA = "0x4D27330")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600669F")]
    [Address(RVA = "0x4D2740C", Offset = "0x4D2740C", VA = "0x4D2740C")]
    public StoryCommunicationLocationData()
    {
    }
  }
}
