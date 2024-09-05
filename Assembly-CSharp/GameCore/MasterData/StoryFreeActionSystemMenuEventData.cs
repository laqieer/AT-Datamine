// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionSystemMenuEventData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001282")]
  [Serializable]
  public sealed class StoryFreeActionSystemMenuEventData : IMasterDataEntity
  {
    [Token(Token = "0x400586F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005870")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupLabel;
    [Token(Token = "0x4005871")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int objectName;
    [Token(Token = "0x4005872")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int advName;
    [Token(Token = "0x4005873")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int iconID;
    [Token(Token = "0x4005874")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int cameraMovePosition;
    [Token(Token = "0x4005875")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int playerMovePosition;
    [Token(Token = "0x4005876")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public EventNpcActEnum beginNpcAct;
    [Token(Token = "0x4005877")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public float iconPositionX;
    [Token(Token = "0x4005878")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public float iconPositionY;
    [Token(Token = "0x4005879")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public float iconPositionZ;

    [Token(Token = "0x17000FEC")]
    public int Key
    {
      [Token(Token = "0x6006935"), Address(RVA = "0x48CDBE8", Offset = "0x48CDBE8", VA = "0x48CDBE8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006936")]
    [Address(RVA = "0x48CDBF0", Offset = "0x48CDBF0", VA = "0x48CDBF0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006937")]
    [Address(RVA = "0x48CE05C", Offset = "0x48CE05C", VA = "0x48CE05C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006938")]
    [Address(RVA = "0x48CE170", Offset = "0x48CE170", VA = "0x48CE170")]
    public StoryFreeActionSystemMenuEventData()
    {
    }
  }
}
