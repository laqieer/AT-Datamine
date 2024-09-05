// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvLockOneData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DB6")]
  [Serializable]
  public sealed class AdvLockOneData : IMasterDataEntity
  {
    [Token(Token = "0x40041A5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40041A6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int LockID;
    [Token(Token = "0x40041A7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int Order;
    [Token(Token = "0x40041A8")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public AdvVariableTypeEnum VariableKind;
    [Token(Token = "0x40041A9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int VariableID;
    [Token(Token = "0x40041AA")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public AdvComparisonTypeEnum ComparisonType;
    [Token(Token = "0x40041AB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int Argument;
    [Token(Token = "0x40041AC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string TextID;

    [Token(Token = "0x17000BFB")]
    public int Key
    {
      [Token(Token = "0x60053E0"), Address(RVA = "0x3A9E6A8", Offset = "0x3A9E6A8", VA = "0x3A9E6A8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60053E1")]
    [Address(RVA = "0x3A9E6B0", Offset = "0x3A9E6B0", VA = "0x3A9E6B0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60053E2")]
    [Address(RVA = "0x3A9EACC", Offset = "0x3A9EACC", VA = "0x3A9EACC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60053E3")]
    [Address(RVA = "0x3A9EBB4", Offset = "0x3A9EBB4", VA = "0x3A9EBB4")]
    public string GetConditionText() => (string) null;

    [Token(Token = "0x60053E4")]
    [Address(RVA = "0x3A9EEA8", Offset = "0x3A9EEA8", VA = "0x3A9EEA8")]
    public string GetComparisonText() => (string) null;

    [Token(Token = "0x60053E5")]
    [Address(RVA = "0x3A9EF6C", Offset = "0x3A9EF6C", VA = "0x3A9EF6C")]
    public string GetText(IAdvTextAccess access) => (string) null;

    [Token(Token = "0x60053E6")]
    [Address(RVA = "0x3A9F014", Offset = "0x3A9F014", VA = "0x3A9F014")]
    public AdvLockOneData()
    {
    }
  }
}
