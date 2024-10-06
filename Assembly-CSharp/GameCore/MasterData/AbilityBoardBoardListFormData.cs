// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardBoardListFormData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001325")]
  [Serializable]
  public sealed class AbilityBoardBoardListFormData : IMasterDataEntity
  {
    [Token(Token = "0x4005A70")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005A71")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string resource;

    [Token(Token = "0x17001059")]
    public int Key
    {
      [Token(Token = "0x6006C12"), Address(RVA = "0x48E816C", Offset = "0x48E816C", VA = "0x48E816C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006C13")]
    [Address(RVA = "0x48E8174", Offset = "0x48E8174", VA = "0x48E8174", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006C14")]
    [Address(RVA = "0x48E8280", Offset = "0x48E8280", VA = "0x48E8280", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006C15")]
    [Address(RVA = "0x48E8308", Offset = "0x48E8308", VA = "0x48E8308")]
    public AbilityBoardBoardListFormData()
    {
    }
  }
}
