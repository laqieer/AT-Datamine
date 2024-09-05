// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionWeaponBaseData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F9E")]
  [Serializable]
  public sealed class ExpeditionWeaponBaseData : IMasterDataEntity
  {
    [Token(Token = "0x4004EC6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004EC7")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int weaponID;

    [Token(Token = "0x17000D8D")]
    public int Key
    {
      [Token(Token = "0x6005BBD"), Address(RVA = "0x2785D2C", Offset = "0x2785D2C", VA = "0x2785D2C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005BBE")]
    [Address(RVA = "0x2785D34", Offset = "0x2785D34", VA = "0x2785D34", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005BBF")]
    [Address(RVA = "0x2785E40", Offset = "0x2785E40", VA = "0x2785E40", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005BC0")]
    [Address(RVA = "0x2785EC4", Offset = "0x2785EC4", VA = "0x2785EC4")]
    public ExpeditionWeaponBaseData()
    {
    }
  }
}
