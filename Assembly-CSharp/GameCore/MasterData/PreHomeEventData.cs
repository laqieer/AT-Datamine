// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.PreHomeEventData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010E5")]
  [Serializable]
  public sealed class PreHomeEventData : IMasterDataEntity
  {
    [Token(Token = "0x40052AA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40052AB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int executionRecordIdentiferId;
    [Token(Token = "0x40052AC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int contentId;
    [Token(Token = "0x40052AD")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int executionOrderPriorityValue;
    [Token(Token = "0x40052AE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int mainStorySequenceId;
    [Token(Token = "0x40052AF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public DateTime startAt;
    [Token(Token = "0x40052B0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public DateTime endAt;

    [Token(Token = "0x17000E82")]
    public int Key
    {
      [Token(Token = "0x600617F"), Address(RVA = "0x28E0F74", Offset = "0x28E0F74", VA = "0x28E0F74", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006180")]
    [Address(RVA = "0x28E0F7C", Offset = "0x28E0F7C", VA = "0x28E0F7C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006181")]
    [Address(RVA = "0x28E1268", Offset = "0x28E1268", VA = "0x28E1268", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006182")]
    [Address(RVA = "0x28E1394", Offset = "0x28E1394", VA = "0x28E1394")]
    public PreHomeEventData()
    {
    }
  }
}
