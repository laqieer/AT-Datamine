// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleClearConditionNameData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E06")]
  [Serializable]
  public sealed class BattleClearConditionNameData : IMasterDataEntity
  {
    [Token(Token = "0x40042FB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;

    [Token(Token = "0x17000C47")]
    public int Key
    {
      [Token(Token = "0x6005589"), Address(RVA = "0x3AB1C90", Offset = "0x3AB1C90", VA = "0x3AB1C90", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600558A")]
    [Address(RVA = "0x3AB1C98", Offset = "0x3AB1C98", VA = "0x3AB1C98", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600558B")]
    [Address(RVA = "0x3AB1D44", Offset = "0x3AB1D44", VA = "0x3AB1D44", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000C48")]
    public string Name
    {
      [Token(Token = "0x600558C"), Address(RVA = "0x3AB1DB0", Offset = "0x3AB1DB0", VA = "0x3AB1DB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600558D")]
    [Address(RVA = "0x3AB1E8C", Offset = "0x3AB1E8C", VA = "0x3AB1E8C")]
    public BattleClearConditionNameData()
    {
    }
  }
}
