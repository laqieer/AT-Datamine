// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.PanelMissionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010AC")]
  [Serializable]
  public sealed class PanelMissionData : IMasterDataEntity
  {
    [Token(Token = "0x4005219")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400521A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000E60")]
    public int Key
    {
      [Token(Token = "0x6006076"), Address(RVA = "0x28D7844", Offset = "0x28D7844", VA = "0x28D7844", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006077")]
    [Address(RVA = "0x28D784C", Offset = "0x28D784C", VA = "0x28D784C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006078")]
    [Address(RVA = "0x28D7958", Offset = "0x28D7958", VA = "0x28D7958", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006079")]
    [Address(RVA = "0x28D79E0", Offset = "0x28D79E0", VA = "0x28D79E0")]
    public PanelMissionData()
    {
    }
  }
}
