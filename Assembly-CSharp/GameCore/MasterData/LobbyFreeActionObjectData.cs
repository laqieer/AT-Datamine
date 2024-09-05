// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LobbyFreeActionObjectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001087")]
  [Serializable]
  public sealed class LobbyFreeActionObjectData : IMasterDataEntity, IFreeActionObjectData
  {
    [Token(Token = "0x40051B1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40051B2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40051B3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int characterSwitchPatternID;
    [Token(Token = "0x40051B4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string objectAccessName;
    [Token(Token = "0x40051B5")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int objectType;

    [Token(Token = "0x17000E45")]
    public int Key
    {
      [Token(Token = "0x6005FD3"), Address(RVA = "0x28D25A4", Offset = "0x28D25A4", VA = "0x28D25A4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005FD4")]
    [Address(RVA = "0x28D25AC", Offset = "0x28D25AC", VA = "0x28D25AC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005FD5")]
    [Address(RVA = "0x28D27D8", Offset = "0x28D27D8", VA = "0x28D27D8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E46")]
    public int DataID
    {
      [Token(Token = "0x6005FD6"), Address(RVA = "0x28D2894", Offset = "0x28D2894", VA = "0x28D2894", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E47")]
    public string ObjectName
    {
      [Token(Token = "0x6005FD7"), Address(RVA = "0x28D289C", Offset = "0x28D289C", VA = "0x28D289C", Slot = "8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E48")]
    public int CharacterSwitchPatternID
    {
      [Token(Token = "0x6005FD8"), Address(RVA = "0x28D28A4", Offset = "0x28D28A4", VA = "0x28D28A4", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E49")]
    public int PropID
    {
      [Token(Token = "0x6005FD9"), Address(RVA = "0x28D28AC", Offset = "0x28D28AC", VA = "0x28D28AC", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E4A")]
    public string ObjectAccessName
    {
      [Token(Token = "0x6005FDA"), Address(RVA = "0x28D28B4", Offset = "0x28D28B4", VA = "0x28D28B4", Slot = "10")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E4B")]
    public StoryFreeActionObjectTypeEnum ObjectType
    {
      [Token(Token = "0x6005FDB"), Address(RVA = "0x28D28BC", Offset = "0x28D28BC", VA = "0x28D28BC", Slot = "12")] get
      {
        return new StoryFreeActionObjectTypeEnum();
      }
    }

    [Token(Token = "0x6005FDC")]
    [Address(RVA = "0x28D28C4", Offset = "0x28D28C4", VA = "0x28D28C4")]
    public LobbyFreeActionObjectData()
    {
    }
  }
}
