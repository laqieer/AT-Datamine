// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SkillCategoryTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F18")]
  [Serializable]
  public sealed class SkillCategoryTypeData : IMasterDataEntity
  {
    [Token(Token = "0x4004B2E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004B2F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000D4D")]
    public int Key
    {
      [Token(Token = "0x600598E"), Address(RVA = "0x3C32CCC", Offset = "0x3C32CCC", VA = "0x3C32CCC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600598F")]
    [Address(RVA = "0x3C32CD4", Offset = "0x3C32CD4", VA = "0x3C32CD4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005990")]
    [Address(RVA = "0x3C32DE0", Offset = "0x3C32DE0", VA = "0x3C32DE0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000D4E")]
    public string Name
    {
      [Token(Token = "0x6005991"), Address(RVA = "0x3C32E68", Offset = "0x3C32E68", VA = "0x3C32E68")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005992")]
    [Address(RVA = "0x3C32F44", Offset = "0x3C32F44", VA = "0x3C32F44")]
    public SkillCategoryTypeData()
    {
    }
  }
}
