// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubquestCycleTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001304")]
  [Serializable]
  public sealed class StorySubquestCycleTypeData : IMasterDataEntity
  {
    [Token(Token = "0x4005A01")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005A02")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x1700103A")]
    public int Key
    {
      [Token(Token = "0x6006B6C"), Address(RVA = "0x48E24C4", Offset = "0x48E24C4", VA = "0x48E24C4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006B6D")]
    [Address(RVA = "0x48E24CC", Offset = "0x48E24CC", VA = "0x48E24CC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006B6E")]
    [Address(RVA = "0x48E25D8", Offset = "0x48E25D8", VA = "0x48E25D8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006B6F")]
    [Address(RVA = "0x48E2660", Offset = "0x48E2660", VA = "0x48E2660")]
    public StorySubquestCycleTypeData()
    {
    }
  }
}
