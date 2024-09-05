// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleSkillSettingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013BD")]
  [Serializable]
  public sealed class StyleSkillSettingData : IMasterDataEntity
  {
    [Token(Token = "0x4005BCD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005BCE")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int styleId;
    [Token(Token = "0x4005BCF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int skillId;
    [Token(Token = "0x4005BD0")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public StyleSkillTypeEnum styleSkillType;
    [Token(Token = "0x4005BD1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public bool initialSkill;

    [Token(Token = "0x1700109D")]
    public int Key
    {
      [Token(Token = "0x6006ED6"), Address(RVA = "0x470A49C", Offset = "0x470A49C", VA = "0x470A49C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006ED7")]
    [Address(RVA = "0x470A4A4", Offset = "0x470A4A4", VA = "0x470A4A4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006ED8")]
    [Address(RVA = "0x470A6D4", Offset = "0x470A6D4", VA = "0x470A6D4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006ED9")]
    [Address(RVA = "0x470A370", Offset = "0x470A370", VA = "0x470A370")]
    public StyleSkillSettingData()
    {
    }
  }
}
