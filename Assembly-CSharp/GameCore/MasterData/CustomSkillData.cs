// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CustomSkillData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011AA")]
  [Serializable]
  public sealed class CustomSkillData : IMasterDataEntity
  {
    [Token(Token = "0x40054FD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40054FE")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int skillId;
    [Token(Token = "0x40054FF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int customSkillTypeId;
    [Token(Token = "0x4005500")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rarityId;
    [Token(Token = "0x4005501")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int costPattern;

    [Token(Token = "0x17000F49")]
    public int Key
    {
      [Token(Token = "0x6006537"), Address(RVA = "0x4AF69AC", Offset = "0x4AF69AC", VA = "0x4AF69AC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006538")]
    [Address(RVA = "0x4AF69B4", Offset = "0x4AF69B4", VA = "0x4AF69B4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006539")]
    [Address(RVA = "0x4AF6BE0", Offset = "0x4AF6BE0", VA = "0x4AF6BE0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600653A")]
    [Address(RVA = "0x4AF6C94", Offset = "0x4AF6C94", VA = "0x4AF6C94")]
    public CustomSkillData()
    {
    }
  }
}
