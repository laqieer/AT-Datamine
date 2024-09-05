// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardConsumeItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001337")]
  [Serializable]
  public sealed class AbilityBoardConsumeItemData : IMasterDataEntity
  {
    [Token(Token = "0x4005A9A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005A9B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005A9C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int allocationType;

    [Token(Token = "0x17001060")]
    public int Key
    {
      [Token(Token = "0x6006C67"), Address(RVA = "0x46F32FC", Offset = "0x46F32FC", VA = "0x46F32FC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006C68")]
    [Address(RVA = "0x46F3304", Offset = "0x46F3304", VA = "0x46F3304", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006C69")]
    [Address(RVA = "0x46F3470", Offset = "0x46F3470", VA = "0x46F3470", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006C6A")]
    [Address(RVA = "0x46F3508", Offset = "0x46F3508", VA = "0x46F3508")]
    public AbilityBoardConsumeItemData()
    {
    }
  }
}
