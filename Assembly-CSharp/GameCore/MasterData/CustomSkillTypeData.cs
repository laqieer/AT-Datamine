// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CustomSkillTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EDE")]
  [Serializable]
  public sealed class CustomSkillTypeData : IMasterDataEntity
  {
    [Token(Token = "0x40048E1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40048E2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000D45")]
    public int Key
    {
      [Token(Token = "0x600594D"), Address(RVA = "0x3C3154C", Offset = "0x3C3154C", VA = "0x3C3154C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600594E")]
    [Address(RVA = "0x3C31554", Offset = "0x3C31554", VA = "0x3C31554", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600594F")]
    [Address(RVA = "0x3C31660", Offset = "0x3C31660", VA = "0x3C31660", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005950")]
    [Address(RVA = "0x3C316E8", Offset = "0x3C316E8", VA = "0x3C316E8")]
    public CustomSkillTypeData()
    {
    }
  }
}
