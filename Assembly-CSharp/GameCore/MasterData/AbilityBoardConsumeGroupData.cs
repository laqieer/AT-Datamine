// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardConsumeGroupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001335")]
  [Serializable]
  public sealed class AbilityBoardConsumeGroupData : IMasterDataEntity
  {
    [Token(Token = "0x4005A96")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005A97")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupId;
    [Token(Token = "0x4005A98")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int consumeItem;
    [Token(Token = "0x4005A99")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int num;

    [Token(Token = "0x1700105F")]
    public int Key
    {
      [Token(Token = "0x6006C5F"), Address(RVA = "0x46F2F74", Offset = "0x46F2F74", VA = "0x46F2F74", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006C60")]
    [Address(RVA = "0x46F2F7C", Offset = "0x46F2F7C", VA = "0x46F2F7C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006C61")]
    [Address(RVA = "0x46F3148", Offset = "0x46F3148", VA = "0x46F3148", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006C62")]
    [Address(RVA = "0x46F31EC", Offset = "0x46F31EC", VA = "0x46F31EC")]
    public AbilityBoardConsumeGroupData()
    {
    }
  }
}
