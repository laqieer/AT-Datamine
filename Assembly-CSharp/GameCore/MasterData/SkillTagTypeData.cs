// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SkillTagTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F1C")]
  [Serializable]
  public sealed class SkillTagTypeData : IMasterDataEntity
  {
    [Token(Token = "0x4004B40")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004B41")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004B42")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string displayName;

    [Token(Token = "0x17000D4F")]
    public int Key
    {
      [Token(Token = "0x6005997"), Address(RVA = "0x3C33054", Offset = "0x3C33054", VA = "0x3C33054", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005998")]
    [Address(RVA = "0x3C3305C", Offset = "0x3C3305C", VA = "0x3C3305C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005999")]
    [Address(RVA = "0x3C331C8", Offset = "0x3C331C8", VA = "0x3C331C8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000D50")]
    public string DisplayName
    {
      [Token(Token = "0x600599A"), Address(RVA = "0x3C33264", Offset = "0x3C33264", VA = "0x3C33264")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600599B")]
    [Address(RVA = "0x3C33340", Offset = "0x3C33340", VA = "0x3C33340")]
    public SkillTagTypeData()
    {
    }
  }
}
