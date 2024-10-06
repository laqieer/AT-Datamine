// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.PlayerTitleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010C5")]
  [Serializable]
  public sealed class PlayerTitleData : IMasterDataEntity, ITitleMasterData
  {
    [Token(Token = "0x4005255")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005256")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int titleType;
    [Token(Token = "0x4005257")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int size;
    [Token(Token = "0x4005258")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string colorCode;
    [Token(Token = "0x4005259")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int spriteId;

    [Token(Token = "0x17000E6E")]
    public int Key
    {
      [Token(Token = "0x60060EE"), Address(RVA = "0x28DB9FC", Offset = "0x28DB9FC", VA = "0x28DB9FC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60060EF")]
    [Address(RVA = "0x28DBA04", Offset = "0x28DBA04", VA = "0x28DBA04", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60060F0")]
    [Address(RVA = "0x28DBC30", Offset = "0x28DBC30", VA = "0x28DBC30", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E6F")]
    private int GameCore\u002EMasterData\u002EITitleMasterData\u002ETitleId
    {
      [Token(Token = "0x60060F1"), Address(RVA = "0x28DBCE8", Offset = "0x28DBCE8", VA = "0x28DBCE8", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E70")]
    private TitleTypeEnum GameCore\u002EMasterData\u002EITitleMasterData\u002ETitleType
    {
      [Token(Token = "0x60060F2"), Address(RVA = "0x28DBCF0", Offset = "0x28DBCF0", VA = "0x28DBCF0", Slot = "8")] get
      {
        return new TitleTypeEnum();
      }
    }

    [Token(Token = "0x17000E71")]
    private string GameCore\u002EMasterData\u002EITitleMasterData\u002EText
    {
      [Token(Token = "0x60060F3"), Address(RVA = "0x28DBCF8", Offset = "0x28DBCF8", VA = "0x28DBCF8", Slot = "9")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E72")]
    private int? GameCore\u002EMasterData\u002EITitleMasterData\u002ESpriteId
    {
      [Token(Token = "0x60060F4"), Address(RVA = "0x28DBDD8", Offset = "0x28DBDD8", VA = "0x28DBDD8", Slot = "10")] get
      {
        return new int?();
      }
    }

    [Token(Token = "0x17000E73")]
    private int? GameCore\u002EMasterData\u002EITitleMasterData\u002ESize
    {
      [Token(Token = "0x60060F5"), Address(RVA = "0x28DBE3C", Offset = "0x28DBE3C", VA = "0x28DBE3C", Slot = "11")] get
      {
        return new int?();
      }
    }

    [Token(Token = "0x17000E74")]
    private string GameCore\u002EMasterData\u002EITitleMasterData\u002EColorCode
    {
      [Token(Token = "0x60060F6"), Address(RVA = "0x28DBEA0", Offset = "0x28DBEA0", VA = "0x28DBEA0", Slot = "12")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E75")]
    private string GameCore\u002EMasterData\u002EITitleMasterData\u002EUnlockDescription
    {
      [Token(Token = "0x60060F7"), Address(RVA = "0x28DBEA8", Offset = "0x28DBEA8", VA = "0x28DBEA8", Slot = "13")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E76")]
    public string Name
    {
      [Token(Token = "0x60060F8"), Address(RVA = "0x28DBCFC", Offset = "0x28DBCFC", VA = "0x28DBCFC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E77")]
    public string UnlockDescription
    {
      [Token(Token = "0x60060F9"), Address(RVA = "0x28DBEAC", Offset = "0x28DBEAC", VA = "0x28DBEAC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60060FA")]
    [Address(RVA = "0x28DBF88", Offset = "0x28DBF88", VA = "0x28DBF88")]
    public PlayerTitleData()
    {
    }
  }
}
