// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationLocationCharacterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011F8")]
  [Serializable]
  public sealed class StoryCommunicationLocationCharacterData : IMasterDataEntity
  {
    [Token(Token = "0x400561C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400561D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int communicationID;
    [Token(Token = "0x400561E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int locationID;
    [Token(Token = "0x400561F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public bool isFavorite;
    [Token(Token = "0x4005620")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int favoriteADV;

    [Token(Token = "0x17000F77")]
    public int Key
    {
      [Token(Token = "0x6006693"), Address(RVA = "0x4D26BD8", Offset = "0x4D26BD8", VA = "0x4D26BD8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006694")]
    [Address(RVA = "0x4D26BE0", Offset = "0x4D26BE0", VA = "0x4D26BE0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006695")]
    [Address(RVA = "0x4D26E10", Offset = "0x4D26E10", VA = "0x4D26E10", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006696")]
    [Address(RVA = "0x4D26EC4", Offset = "0x4D26EC4", VA = "0x4D26EC4")]
    public StoryCommunicationLocationCharacterData()
    {
    }
  }
}
