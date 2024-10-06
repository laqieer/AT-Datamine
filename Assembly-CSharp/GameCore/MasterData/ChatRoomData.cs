// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ChatRoomData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E7E")]
  [Serializable]
  public sealed class ChatRoomData : IMasterDataEntity
  {
    [Token(Token = "0x40045FC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40045FD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40045FE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int categoryId;
    [Token(Token = "0x40045FF")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int channelId;
    [Token(Token = "0x4004600")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int roomId;

    [Token(Token = "0x17000D1F")]
    public int Key
    {
      [Token(Token = "0x6005851"), Address(RVA = "0x3E47EE8", Offset = "0x3E47EE8", VA = "0x3E47EE8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005852")]
    [Address(RVA = "0x3E47EF0", Offset = "0x3E47EF0", VA = "0x3E47EF0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005853")]
    [Address(RVA = "0x3E4811C", Offset = "0x3E4811C", VA = "0x3E4811C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005854")]
    [Address(RVA = "0x3E481D4", Offset = "0x3E481D4", VA = "0x3E481D4")]
    public ChatRoomData()
    {
    }
  }
}
