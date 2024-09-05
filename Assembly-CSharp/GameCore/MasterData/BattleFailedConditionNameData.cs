// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleFailedConditionNameData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E13")]
  [Serializable]
  public sealed class BattleFailedConditionNameData : IMasterDataEntity
  {
    [Token(Token = "0x4004318")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;

    [Token(Token = "0x17000C4F")]
    public int Key
    {
      [Token(Token = "0x60055C7"), Address(RVA = "0x3E2E464", Offset = "0x3E2E464", VA = "0x3E2E464", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60055C8")]
    [Address(RVA = "0x3E2E46C", Offset = "0x3E2E46C", VA = "0x3E2E46C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60055C9")]
    [Address(RVA = "0x3E2E518", Offset = "0x3E2E518", VA = "0x3E2E518", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000C50")]
    public string Name
    {
      [Token(Token = "0x60055CA"), Address(RVA = "0x3E2E584", Offset = "0x3E2E584", VA = "0x3E2E584")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60055CB")]
    [Address(RVA = "0x3E2E660", Offset = "0x3E2E660", VA = "0x3E2E660")]
    public BattleFailedConditionNameData()
    {
    }
  }
}
