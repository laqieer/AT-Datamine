// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LoginBonusRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001094")]
  [Serializable]
  public sealed class LoginBonusRewardData : IMasterDataEntity
  {
    [Token(Token = "0x40051D6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40051D7")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int loginbonusId;
    [Token(Token = "0x40051D8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int number;

    [Token(Token = "0x17000E52")]
    public int Key
    {
      [Token(Token = "0x600600B"), Address(RVA = "0x28D3FB0", Offset = "0x28D3FB0", VA = "0x28D3FB0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600600C")]
    [Address(RVA = "0x28D3FB8", Offset = "0x28D3FB8", VA = "0x28D3FB8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600600D")]
    [Address(RVA = "0x28D4124", Offset = "0x28D4124", VA = "0x28D4124", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600600E")]
    [Address(RVA = "0x28D41B8", Offset = "0x28D41B8", VA = "0x28D41B8")]
    public LoginBonusRewardData()
    {
    }
  }
}
