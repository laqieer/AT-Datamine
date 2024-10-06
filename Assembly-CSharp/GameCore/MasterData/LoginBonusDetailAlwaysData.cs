// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LoginBonusDetailAlwaysData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001090")]
  [Serializable]
  public sealed class LoginBonusDetailAlwaysData : IMasterDataEntity
  {
    [Token(Token = "0x40051CD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40051CE")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int loginbonusId;
    [Token(Token = "0x40051CF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string prefabName;

    [Token(Token = "0x17000E4F")]
    public int Key
    {
      [Token(Token = "0x6005FFA"), Address(RVA = "0x28D37C0", Offset = "0x28D37C0", VA = "0x28D37C0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005FFB")]
    [Address(RVA = "0x28D37C8", Offset = "0x28D37C8", VA = "0x28D37C8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005FFC")]
    [Address(RVA = "0x28D3934", Offset = "0x28D3934", VA = "0x28D3934", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005FFD")]
    [Address(RVA = "0x28D39CC", Offset = "0x28D39CC", VA = "0x28D39CC")]
    public LoginBonusDetailAlwaysData()
    {
    }
  }
}
