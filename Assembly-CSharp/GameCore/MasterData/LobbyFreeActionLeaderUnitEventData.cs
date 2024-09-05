// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LobbyFreeActionLeaderUnitEventData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001082")]
  [Serializable]
  public sealed class LobbyFreeActionLeaderUnitEventData : IMasterDataEntity
  {
    [Token(Token = "0x4005195")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005196")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int lobbyEventGroupLabel;
    [Token(Token = "0x4005197")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int conditionID;
    [Token(Token = "0x4005198")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int styleID;
    [Token(Token = "0x4005199")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int playPriority;
    [Token(Token = "0x400519A")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int playPattern;
    [Token(Token = "0x400519B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int lobbyEventType;
    [Token(Token = "0x400519C")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int advID;
    [Token(Token = "0x400519D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int cameraViewPositionID;
    [Token(Token = "0x400519E")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int playerMovePositionID;
    [Token(Token = "0x400519F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public float iconPositionX;
    [Token(Token = "0x40051A0")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public float iconPositionY;
    [Token(Token = "0x40051A1")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public float iconPositionZ;

    [Token(Token = "0x17000E43")]
    public int Key
    {
      [Token(Token = "0x6005FBC"), Address(RVA = "0x28D1284", Offset = "0x28D1284", VA = "0x28D1284", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005FBD")]
    [Address(RVA = "0x28D128C", Offset = "0x28D128C", VA = "0x28D128C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005FBE")]
    [Address(RVA = "0x28D17B8", Offset = "0x28D17B8", VA = "0x28D17B8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005FBF")]
    [Address(RVA = "0x28D18EC", Offset = "0x28D18EC", VA = "0x28D18EC")]
    public LobbyFreeActionLeaderUnitEventData()
    {
    }
  }
}
