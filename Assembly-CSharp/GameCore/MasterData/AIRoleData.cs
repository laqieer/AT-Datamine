// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AIRoleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DD0")]
  [Serializable]
  public sealed class AIRoleData : IMasterDataEntity
  {
    [Token(Token = "0x400420D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400420E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000C09")]
    public int Key
    {
      [Token(Token = "0x6005456"), Address(RVA = "0x3AA4644", Offset = "0x3AA4644", VA = "0x3AA4644", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005457")]
    [Address(RVA = "0x3AA464C", Offset = "0x3AA464C", VA = "0x3AA464C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005458")]
    [Address(RVA = "0x3AA4758", Offset = "0x3AA4758", VA = "0x3AA4758", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005459")]
    [Address(RVA = "0x3AA47E0", Offset = "0x3AA47E0", VA = "0x3AA47E0")]
    public AIRoleData()
    {
    }
  }
}
