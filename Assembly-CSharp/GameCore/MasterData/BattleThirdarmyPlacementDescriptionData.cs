// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleThirdarmyPlacementDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E6F")]
  [Serializable]
  public sealed class BattleThirdarmyPlacementDescriptionData : IMasterDataEntity, IUnitPlacementData
  {
    [Token(Token = "0x40045C5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40045C6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int placement;
    [Token(Token = "0x40045C7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int troops;
    [Token(Token = "0x40045C8")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int unitNo;
    [Token(Token = "0x40045C9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int thirdarmy;
    [Token(Token = "0x40045CA")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public bool skipDefeat;
    [Token(Token = "0x40045CB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int x;
    [Token(Token = "0x40045CC")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int y;
    [Token(Token = "0x40045CD")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int fromX;
    [Token(Token = "0x40045CE")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int fromY;
    [Token(Token = "0x40045CF")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int waitTurnCount;
    [Token(Token = "0x40045D0")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int barrier;
    [Token(Token = "0x40045D1")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int barrierHp;
    [Token(Token = "0x40045D2")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int barrierRecovery;
    [Token(Token = "0x40045D3")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int baseSupportRank;
    [Token(Token = "0x40045D4")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int supportUnit1;
    [Token(Token = "0x40045D5")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int supportRank1;
    [Token(Token = "0x40045D6")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int supportUnit2;
    [Token(Token = "0x40045D7")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int supportRank2;
    [Token(Token = "0x40045D8")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public int supportUnit3;
    [Token(Token = "0x40045D9")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public int supportRank3;
    [Token(Token = "0x40045DA")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    public int drop;
    [Token(Token = "0x40045DB")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public int exp;

    [Token(Token = "0x17000D05")]
    public int Key
    {
      [Token(Token = "0x60057FD"), Address(RVA = "0x3E4530C", Offset = "0x3E4530C", VA = "0x3E4530C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60057FE")]
    [Address(RVA = "0x3E45314", Offset = "0x3E45314", VA = "0x3E45314", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60057FF")]
    [Address(RVA = "0x3E45C04", Offset = "0x3E45C04", VA = "0x3E45C04", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000D06")]
    public int Id
    {
      [Token(Token = "0x6005800"), Address(RVA = "0x3E45DD8", Offset = "0x3E45DD8", VA = "0x3E45DD8", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D07")]
    public int UnitNo
    {
      [Token(Token = "0x6005801"), Address(RVA = "0x3E45DE0", Offset = "0x3E45DE0", VA = "0x3E45DE0", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D08")]
    public int NpcMasterDataId
    {
      [Token(Token = "0x6005802"), Address(RVA = "0x3E45DE8", Offset = "0x3E45DE8", VA = "0x3E45DE8", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D09")]
    public int Troops
    {
      [Token(Token = "0x6005803"), Address(RVA = "0x3E45DF0", Offset = "0x3E45DF0", VA = "0x3E45DF0", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D0A")]
    public int X
    {
      [Token(Token = "0x6005804"), Address(RVA = "0x3E45DF8", Offset = "0x3E45DF8", VA = "0x3E45DF8", Slot = "14")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D0B")]
    public int Y
    {
      [Token(Token = "0x6005805"), Address(RVA = "0x3E45E00", Offset = "0x3E45E00", VA = "0x3E45E00", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D0C")]
    public int SortieFromX
    {
      [Token(Token = "0x6005806"), Address(RVA = "0x3E45E08", Offset = "0x3E45E08", VA = "0x3E45E08", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D0D")]
    public int SortieFromY
    {
      [Token(Token = "0x6005807"), Address(RVA = "0x3E45E10", Offset = "0x3E45E10", VA = "0x3E45E10", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D0E")]
    public int WaitTurnCount
    {
      [Token(Token = "0x6005808"), Address(RVA = "0x3E45E18", Offset = "0x3E45E18", VA = "0x3E45E18", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D0F")]
    public int BaseExp
    {
      [Token(Token = "0x6005809"), Address(RVA = "0x3E45E20", Offset = "0x3E45E20", VA = "0x3E45E20", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D10")]
    public int Damage
    {
      [Token(Token = "0x600580A"), Address(RVA = "0x3E45E28", Offset = "0x3E45E28", VA = "0x3E45E28", Slot = "18")] set
      {
      }
      [Token(Token = "0x600580B"), Address(RVA = "0x3E45E30", Offset = "0x3E45E30", VA = "0x3E45E30", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D11")]
    public int Barrier
    {
      [Token(Token = "0x600580C"), Address(RVA = "0x3E45E38", Offset = "0x3E45E38", VA = "0x3E45E38", Slot = "19")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D12")]
    public int BarrierHp
    {
      [Token(Token = "0x600580D"), Address(RVA = "0x3E45E40", Offset = "0x3E45E40", VA = "0x3E45E40", Slot = "20")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D13")]
    public bool Modifiable
    {
      [Token(Token = "0x600580E"), Address(RVA = "0x3E45E48", Offset = "0x3E45E48", VA = "0x3E45E48", Slot = "21")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000D14")]
    public int BaseSupportRank
    {
      [Token(Token = "0x600580F"), Address(RVA = "0x3E45E50", Offset = "0x3E45E50", VA = "0x3E45E50", Slot = "22")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005810")]
    [Address(RVA = "0x3E45E58", Offset = "0x3E45E58", VA = "0x3E45E58", Slot = "23")]
    public Dictionary<int, int> GetSupportInfo() => (Dictionary<int, int>) null;

    [Token(Token = "0x17000D15")]
    public QuestCorrection Correction
    {
      [Token(Token = "0x6005811"), Address(RVA = "0x3E45F28", Offset = "0x3E45F28", VA = "0x3E45F28", Slot = "25")] set
      {
      }
      [Token(Token = "0x6005812"), Address(RVA = "0x3E45F30", Offset = "0x3E45F30", VA = "0x3E45F30", Slot = "24")] get
      {
        return (QuestCorrection) null;
      }
    }

    [Token(Token = "0x17000D16")]
    public bool IsBoss
    {
      [Token(Token = "0x6005813"), Address(RVA = "0x3E45F38", Offset = "0x3E45F38", VA = "0x3E45F38", Slot = "26")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6005814")]
    [Address(RVA = "0x3E45F40", Offset = "0x3E45F40", VA = "0x3E45F40")]
    public BattleThirdarmyPlacementDescriptionData()
    {
    }
  }
}
