// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvOptionOneData
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
  [Token(Token = "0x2000DBA")]
  [Serializable]
  public sealed class AdvOptionOneData : IMasterDataEntity
  {
    [Token(Token = "0x40041B1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40041B2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int OptionID;
    [Token(Token = "0x40041B3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string TextID;
    [Token(Token = "0x40041B4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int ProcessID;
    [Token(Token = "0x40041B5")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public AdvVariableTypeEnum VariableKind;
    [Token(Token = "0x40041B6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int VariableID;
    [Token(Token = "0x40041B7")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public AdvArithmeticTypeEnum ArithmeticType;
    [Token(Token = "0x40041B8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int Argument;
    [Token(Token = "0x40041B9")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int LockID;
    [Token(Token = "0x40041BA")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int expandedLockID;
    [Token(Token = "0x40041BB")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int NextOptionID;
    [Token(Token = "0x40041BC")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public bool Fixed;

    [Token(Token = "0x17000BFD")]
    public int Key
    {
      [Token(Token = "0x60053F8"), Address(RVA = "0x3A9FA68", Offset = "0x3A9FA68", VA = "0x3A9FA68", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60053F9")]
    [Address(RVA = "0x3A9FA70", Offset = "0x3A9FA70", VA = "0x3A9FA70", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60053FA")]
    [Address(RVA = "0x3AA0010", Offset = "0x3AA0010", VA = "0x3AA0010", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60053FB")]
    [Address(RVA = "0x3AA0138", Offset = "0x3AA0138", VA = "0x3AA0138")]
    public string GetText(IAdvTextAccess access) => (string) null;

    [Token(Token = "0x60053FC")]
    [Address(RVA = "0x3AA01E0", Offset = "0x3AA01E0", VA = "0x3AA01E0")]
    public AdvOptionOneData()
    {
    }
  }
}
