// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.DifficultyData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001113")]
  [Serializable]
  public sealed class DifficultyData : IMasterDataEntity
  {
    [Token(Token = "0x4005336")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005337")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000EAA")]
    public int Key
    {
      [Token(Token = "0x6006253"), Address(RVA = "0x4ADE514", Offset = "0x4ADE514", VA = "0x4ADE514", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006254")]
    [Address(RVA = "0x4ADE51C", Offset = "0x4ADE51C", VA = "0x4ADE51C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006255")]
    [Address(RVA = "0x4ADE628", Offset = "0x4ADE628", VA = "0x4ADE628", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006256")]
    [Address(RVA = "0x4ADE6B0", Offset = "0x4ADE6B0", VA = "0x4ADE6B0")]
    public DifficultyData()
    {
    }
  }
}
