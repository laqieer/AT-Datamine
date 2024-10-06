// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.PlayerAvatarData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010BD")]
  [Serializable]
  public sealed class PlayerAvatarData : IMasterDataEntity
  {
    [Token(Token = "0x400523E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400523F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int playerStyleId;
    [Token(Token = "0x4005240")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string animationControllerName;
    [Token(Token = "0x4005241")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string animationControllerPath;
    [Token(Token = "0x4005242")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string defaultMotion;
    [Token(Token = "0x4005243")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string facialPackName;
    [Token(Token = "0x4005244")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public string facialPackPath;
    [Token(Token = "0x4005245")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int playerFreeActionPlayerId;

    [Token(Token = "0x17000E69")]
    public int Key
    {
      [Token(Token = "0x60060C6"), Address(RVA = "0x28DA4F8", Offset = "0x28DA4F8", VA = "0x28DA4F8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60060C7")]
    [Address(RVA = "0x28DA500", Offset = "0x28DA500", VA = "0x28DA500", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60060C8")]
    [Address(RVA = "0x28DA84C", Offset = "0x28DA84C", VA = "0x28DA84C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E6A")]
    public string Name
    {
      [Token(Token = "0x60060C9"), Address(RVA = "0x28DA944", Offset = "0x28DA944", VA = "0x28DA944")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60060CA")]
    [Address(RVA = "0x28DAA20", Offset = "0x28DAA20", VA = "0x28DAA20")]
    public PlayerAvatarData()
    {
    }
  }
}
