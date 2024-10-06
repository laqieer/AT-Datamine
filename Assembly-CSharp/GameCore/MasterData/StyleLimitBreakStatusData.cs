// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleLimitBreakStatusData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013C7")]
  [Serializable]
  public sealed class StyleLimitBreakStatusData : IMasterDataEntity
  {
    [Token(Token = "0x4005C72")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005C73")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int rarityStar;
    [Token(Token = "0x4005C74")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int vitalityValue;
    [Token(Token = "0x4005C75")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int strengthValue;
    [Token(Token = "0x4005C76")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int intelligenceValue;
    [Token(Token = "0x4005C77")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int defenceValue;
    [Token(Token = "0x4005C78")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int mindValue;
    [Token(Token = "0x4005C79")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int agilityValue;
    [Token(Token = "0x4005C7A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int dexterityValue;
    [Token(Token = "0x4005C7B")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int luckyValue;

    [Token(Token = "0x170010B8")]
    public int Key
    {
      [Token(Token = "0x6006F20"), Address(RVA = "0x4710F50", Offset = "0x4710F50", VA = "0x4710F50", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006F21")]
    [Address(RVA = "0x4710F58", Offset = "0x4710F58", VA = "0x4710F58", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006F22")]
    [Address(RVA = "0x4711364", Offset = "0x4711364", VA = "0x4711364", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006F23")]
    [Address(RVA = "0x4711468", Offset = "0x4711468", VA = "0x4711468")]
    public StyleLimitBreakStatusData()
    {
    }
  }
}
