// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.TotalMissionRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010B5")]
  [Serializable]
  public sealed class TotalMissionRewardData : IMasterDataEntity
  {
    [Token(Token = "0x4005230")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005231")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000E64")]
    public int Key
    {
      [Token(Token = "0x60060A2"), Address(RVA = "0x28D9448", Offset = "0x28D9448", VA = "0x28D9448", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60060A3")]
    [Address(RVA = "0x28D9450", Offset = "0x28D9450", VA = "0x28D9450", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60060A4")]
    [Address(RVA = "0x28D955C", Offset = "0x28D955C", VA = "0x28D955C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60060A5")]
    [Address(RVA = "0x28D95E4", Offset = "0x28D95E4", VA = "0x28D95E4")]
    public TotalMissionRewardData()
    {
    }
  }
}
