// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubquestResetItemSetData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200130A")]
  [Serializable]
  public sealed class StorySubquestResetItemSetData : IMasterDataEntity
  {
    [Token(Token = "0x4005A0E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005A0F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int subQuestTaskID;
    [Token(Token = "0x4005A10")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int paymentType;
    [Token(Token = "0x4005A11")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int paymentID;

    [Token(Token = "0x1700103C")]
    public int Key
    {
      [Token(Token = "0x6006B7F"), Address(RVA = "0x48E2D08", Offset = "0x48E2D08", VA = "0x48E2D08", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006B80")]
    [Address(RVA = "0x48E2D10", Offset = "0x48E2D10", VA = "0x48E2D10", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006B81")]
    [Address(RVA = "0x48E2EDC", Offset = "0x48E2EDC", VA = "0x48E2EDC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006B82")]
    [Address(RVA = "0x48E2F80", Offset = "0x48E2F80", VA = "0x48E2F80")]
    public StorySubquestResetItemSetData()
    {
    }
  }
}
