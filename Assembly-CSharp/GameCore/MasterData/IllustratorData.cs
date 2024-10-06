// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IllustratorData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001396")]
  [Serializable]
  public sealed class IllustratorData : IMasterDataEntity
  {
    [Token(Token = "0x4005B6E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B6F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17001091")]
    public int Key
    {
      [Token(Token = "0x6006E14"), Address(RVA = "0x4701C50", Offset = "0x4701C50", VA = "0x4701C50", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006E15")]
    [Address(RVA = "0x4701C58", Offset = "0x4701C58", VA = "0x4701C58", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006E16")]
    [Address(RVA = "0x4701D64", Offset = "0x4701D64", VA = "0x4701D64", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006E17")]
    [Address(RVA = "0x4701DEC", Offset = "0x4701DEC", VA = "0x4701DEC")]
    public IllustratorData()
    {
    }
  }
}
