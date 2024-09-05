// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryBattleMissionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E6D")]
  [Serializable]
  public sealed class StoryBattleMissionData : IMasterDataEntity, IMissionData
  {
    [Token(Token = "0x40045B8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40045B9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int missionSet;
    [Token(Token = "0x40045BA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int rewardGroupId;
    [Token(Token = "0x40045BB")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public BattleMissionTypeEnum missionType1;
    [Token(Token = "0x40045BC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int value1;
    [Token(Token = "0x40045BD")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int value2;
    [Token(Token = "0x40045BE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public BattleMissionTypeEnum missionType2;
    [Token(Token = "0x40045BF")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int value3;
    [Token(Token = "0x40045C0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int value4;
    [Token(Token = "0x40045C1")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public BattleMissionTypeEnum missionType3;
    [Token(Token = "0x40045C2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int value5;
    [Token(Token = "0x40045C3")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int value6;

    [Token(Token = "0x17000CF6")]
    public int Key
    {
      [Token(Token = "0x60057E5"), Address(RVA = "0x3E44780", Offset = "0x3E44780", VA = "0x3E44780", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60057E6")]
    [Address(RVA = "0x3E44788", Offset = "0x3E44788", VA = "0x3E44788", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60057E7")]
    [Address(RVA = "0x3E44C54", Offset = "0x3E44C54", VA = "0x3E44C54", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000CF7")]
    private int Battle\u002EData\u002EIMissionData\u002EID
    {
      [Token(Token = "0x60057E8"), Address(RVA = "0x3E44D78", Offset = "0x3E44D78", VA = "0x3E44D78", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CF8")]
    private int Battle\u002EData\u002EIMissionData\u002ErewardGroupId
    {
      [Token(Token = "0x60057E9"), Address(RVA = "0x3E44D80", Offset = "0x3E44D80", VA = "0x3E44D80", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CF9")]
    private string Battle\u002EData\u002EIMissionData\u002Edescription
    {
      [Token(Token = "0x60057EA"), Address(RVA = "0x3E44D88", Offset = "0x3E44D88", VA = "0x3E44D88", Slot = "9")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CFA")]
    private BattleMissionTypeEnum Battle\u002EData\u002EIMissionData\u002EmissionType1
    {
      [Token(Token = "0x60057EB"), Address(RVA = "0x3E44E68", Offset = "0x3E44E68", VA = "0x3E44E68", Slot = "10")] get
      {
        return new BattleMissionTypeEnum();
      }
    }

    [Token(Token = "0x17000CFB")]
    private int Battle\u002EData\u002EIMissionData\u002Evalue1
    {
      [Token(Token = "0x60057EC"), Address(RVA = "0x3E44E70", Offset = "0x3E44E70", VA = "0x3E44E70", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CFC")]
    private int Battle\u002EData\u002EIMissionData\u002Evalue2
    {
      [Token(Token = "0x60057ED"), Address(RVA = "0x3E44E78", Offset = "0x3E44E78", VA = "0x3E44E78", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CFD")]
    private BattleMissionTypeEnum Battle\u002EData\u002EIMissionData\u002EmissionType2
    {
      [Token(Token = "0x60057EE"), Address(RVA = "0x3E44E80", Offset = "0x3E44E80", VA = "0x3E44E80", Slot = "13")] get
      {
        return new BattleMissionTypeEnum();
      }
    }

    [Token(Token = "0x17000CFE")]
    private int Battle\u002EData\u002EIMissionData\u002Evalue3
    {
      [Token(Token = "0x60057EF"), Address(RVA = "0x3E44E88", Offset = "0x3E44E88", VA = "0x3E44E88", Slot = "14")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CFF")]
    private int Battle\u002EData\u002EIMissionData\u002Evalue4
    {
      [Token(Token = "0x60057F0"), Address(RVA = "0x3E44E90", Offset = "0x3E44E90", VA = "0x3E44E90", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D00")]
    private BattleMissionTypeEnum Battle\u002EData\u002EIMissionData\u002EmissionType3
    {
      [Token(Token = "0x60057F1"), Address(RVA = "0x3E44E98", Offset = "0x3E44E98", VA = "0x3E44E98", Slot = "16")] get
      {
        return new BattleMissionTypeEnum();
      }
    }

    [Token(Token = "0x17000D01")]
    private int Battle\u002EData\u002EIMissionData\u002Evalue5
    {
      [Token(Token = "0x60057F2"), Address(RVA = "0x3E44EA0", Offset = "0x3E44EA0", VA = "0x3E44EA0", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D02")]
    private int Battle\u002EData\u002EIMissionData\u002Evalue6
    {
      [Token(Token = "0x60057F3"), Address(RVA = "0x3E44EA8", Offset = "0x3E44EA8", VA = "0x3E44EA8", Slot = "18")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D03")]
    public string Name
    {
      [Token(Token = "0x60057F4"), Address(RVA = "0x3E44EB0", Offset = "0x3E44EB0", VA = "0x3E44EB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D04")]
    public string Description
    {
      [Token(Token = "0x60057F5"), Address(RVA = "0x3E44D8C", Offset = "0x3E44D8C", VA = "0x3E44D8C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60057F6")]
    [Address(RVA = "0x3E44F8C", Offset = "0x3E44F8C", VA = "0x3E44F8C")]
    public StoryBattleMissionData()
    {
    }
  }
}
