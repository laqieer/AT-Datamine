// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionChestTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001251")]
  [Serializable]
  public sealed class StoryFreeActionChestTypeData : IMasterDataEntity
  {
    [Token(Token = "0x40057A4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40057A5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40057A6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int propID;
    [Token(Token = "0x40057A7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string openSE;
    [Token(Token = "0x40057A8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int expendableItemID;
    [Token(Token = "0x40057A9")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int mapShowAbility;

    [Token(Token = "0x17000FB7")]
    public int Key
    {
      [Token(Token = "0x600682B"), Address(RVA = "0x4D3620C", Offset = "0x4D3620C", VA = "0x4D3620C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600682C")]
    [Address(RVA = "0x4D36214", Offset = "0x4D36214", VA = "0x4D36214", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600682D")]
    [Address(RVA = "0x4D364A0", Offset = "0x4D364A0", VA = "0x4D364A0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600682E")]
    [Address(RVA = "0x4D3656C", Offset = "0x4D3656C", VA = "0x4D3656C")]
    public StoryFreeActionChestTypeData()
    {
    }
  }
}
