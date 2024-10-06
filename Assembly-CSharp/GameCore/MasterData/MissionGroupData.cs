// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MissionGroupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200109C")]
  [Serializable]
  public sealed class MissionGroupData : IMasterDataEntity
  {
    [Token(Token = "0x40051EC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40051ED")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40051EE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int panelMission;
    [Token(Token = "0x40051EF")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int bannerId;
    [Token(Token = "0x40051F0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int pageIndex;

    [Token(Token = "0x17000E56")]
    public int Key
    {
      [Token(Token = "0x6006031"), Address(RVA = "0x28D51A8", Offset = "0x28D51A8", VA = "0x28D51A8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006032")]
    [Address(RVA = "0x28D51B0", Offset = "0x28D51B0", VA = "0x28D51B0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006033")]
    [Address(RVA = "0x28D53DC", Offset = "0x28D53DC", VA = "0x28D53DC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006034")]
    [Address(RVA = "0x28D5494", Offset = "0x28D5494", VA = "0x28D5494")]
    public MissionGroupData()
    {
    }
  }
}
