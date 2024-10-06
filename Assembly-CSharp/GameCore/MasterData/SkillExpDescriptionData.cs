// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SkillExpDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011BB")]
  [Serializable]
  public sealed class SkillExpDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4005557")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005558")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupId;
    [Token(Token = "0x4005559")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int level;
    [Token(Token = "0x400555A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int from;
    [Token(Token = "0x400555B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int to;

    [Token(Token = "0x17000F52")]
    public int Key
    {
      [Token(Token = "0x6006588"), Address(RVA = "0x4D1C62C", Offset = "0x4D1C62C", VA = "0x4D1C62C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006589")]
    [Address(RVA = "0x4D1C634", Offset = "0x4D1C634", VA = "0x4D1C634", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600658A")]
    [Address(RVA = "0x4D1C860", Offset = "0x4D1C860", VA = "0x4D1C860", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600658B")]
    [Address(RVA = "0x4D1C914", Offset = "0x4D1C914", VA = "0x4D1C914")]
    public SkillExpDescriptionData()
    {
    }
  }
}
