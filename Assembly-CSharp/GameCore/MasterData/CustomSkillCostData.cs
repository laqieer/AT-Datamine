// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CustomSkillCostData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011A8")]
  [Serializable]
  public sealed class CustomSkillCostData : IMasterDataEntity
  {
    [Token(Token = "0x40054F9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40054FA")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int pattern;
    [Token(Token = "0x40054FB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int level;
    [Token(Token = "0x40054FC")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int cost;

    [Token(Token = "0x17000F48")]
    public int Key
    {
      [Token(Token = "0x600652F"), Address(RVA = "0x4AF6624", Offset = "0x4AF6624", VA = "0x4AF6624", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006530")]
    [Address(RVA = "0x4AF662C", Offset = "0x4AF662C", VA = "0x4AF662C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006531")]
    [Address(RVA = "0x4AF67F8", Offset = "0x4AF67F8", VA = "0x4AF67F8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006532")]
    [Address(RVA = "0x4AF689C", Offset = "0x4AF689C", VA = "0x4AF689C")]
    public CustomSkillCostData()
    {
    }
  }
}
