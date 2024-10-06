// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationAttachData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011F0")]
  [Serializable]
  public sealed class StoryCommunicationAttachData : IMasterDataEntity
  {
    [Token(Token = "0x4005607")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005608")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupLabel;
    [Token(Token = "0x4005609")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int objectName;
    [Token(Token = "0x400560A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int communicationID;
    [Token(Token = "0x400560B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int cameraMovePosition;
    [Token(Token = "0x400560C")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int playerMovePosition;
    [Token(Token = "0x400560D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public EventNpcActEnum beginNpcAct;
    [Token(Token = "0x400560E")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public float iconPositionX;
    [Token(Token = "0x400560F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public float iconPositionY;
    [Token(Token = "0x4005610")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public float iconPositionZ;

    [Token(Token = "0x17000F74")]
    public int Key
    {
      [Token(Token = "0x6006673"), Address(RVA = "0x4D259EC", Offset = "0x4D259EC", VA = "0x4D259EC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006674")]
    [Address(RVA = "0x4D259F4", Offset = "0x4D259F4", VA = "0x4D259F4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006675")]
    [Address(RVA = "0x4D25E00", Offset = "0x4D25E00", VA = "0x4D25E00", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006676")]
    [Address(RVA = "0x4D25F04", Offset = "0x4D25F04", VA = "0x4D25F04")]
    public StoryCommunicationAttachData()
    {
    }
  }
}
