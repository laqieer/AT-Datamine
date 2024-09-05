// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LobbyFreeActionEventData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200107B")]
  [Serializable]
  public sealed class LobbyFreeActionEventData : IMasterDataEntity
  {
    [Token(Token = "0x4005175")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005176")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int lobbyEventGroupLabel;
    [Token(Token = "0x4005177")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int conditionID;
    [Token(Token = "0x4005178")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int targetObjectID;
    [Token(Token = "0x4005179")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int lobbyEventType;
    [Token(Token = "0x400517A")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int advID;
    [Token(Token = "0x400517B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int iconID;
    [Token(Token = "0x400517C")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int cameraViewPositionID;
    [Token(Token = "0x400517D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int playerMovePositionID;
    [Token(Token = "0x400517E")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public float iconPositionX;
    [Token(Token = "0x400517F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public float iconPositionY;
    [Token(Token = "0x4005180")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public float iconPositionZ;

    [Token(Token = "0x17000E3A")]
    public int Key
    {
      [Token(Token = "0x6005F95"), Address(RVA = "0x28CF7A4", Offset = "0x28CF7A4", VA = "0x28CF7A4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005F96")]
    [Address(RVA = "0x28CF7AC", Offset = "0x28CF7AC", VA = "0x28CF7AC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005F97")]
    [Address(RVA = "0x28CFC78", Offset = "0x28CFC78", VA = "0x28CFC78", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005F98")]
    [Address(RVA = "0x28CFD9C", Offset = "0x28CFD9C", VA = "0x28CFD9C")]
    public LobbyFreeActionEventData()
    {
    }
  }
}
