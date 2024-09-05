// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LobbySettingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200108B")]
  [Serializable]
  public sealed class LobbySettingData : IMasterDataEntity
  {
    [Token(Token = "0x40051BB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40051BC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40051BD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int areaSettingLabel;
    [Token(Token = "0x40051BE")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int layoutLabel;
    [Token(Token = "0x40051BF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int layoutSubLabel;
    [Token(Token = "0x40051C0")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int lobbyEventGroupLabel;
    [Token(Token = "0x40051C1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int lobbySubEventGroupLabel;
    [Token(Token = "0x40051C2")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int leaderUnitLayoutLabel;
    [Token(Token = "0x40051C3")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int leaderUnitEventLabel;

    [Token(Token = "0x17000E4D")]
    public int Key
    {
      [Token(Token = "0x6005FEA"), Address(RVA = "0x28D2E78", Offset = "0x28D2E78", VA = "0x28D2E78", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005FEB")]
    [Address(RVA = "0x28D2E80", Offset = "0x28D2E80", VA = "0x28D2E80", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005FEC")]
    [Address(RVA = "0x28D322C", Offset = "0x28D322C", VA = "0x28D322C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005FED")]
    [Address(RVA = "0x28D3324", Offset = "0x28D3324", VA = "0x28D3324")]
    public LobbySettingData()
    {
    }
  }
}
