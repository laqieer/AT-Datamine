// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleGuestPlacementDescriptionData
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
  [Token(Token = "0x2000E4E")]
  [Serializable]
  public sealed class BattleGuestPlacementDescriptionData : IMasterDataEntity, IUnitPlacementData
  {
    [Token(Token = "0x40044F1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40044F2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int placement;
    [Token(Token = "0x40044F3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int troops;
    [Token(Token = "0x40044F4")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int unitNo;
    [Token(Token = "0x40044F5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int guest;
    [Token(Token = "0x40044F6")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int x;
    [Token(Token = "0x40044F7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int y;
    [Token(Token = "0x40044F8")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int fromX;
    [Token(Token = "0x40044F9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int fromY;
    [Token(Token = "0x40044FA")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int waitTurnCount;
    [Token(Token = "0x40044FB")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int baseSupportRank;
    [Token(Token = "0x40044FC")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int supportUnit1;
    [Token(Token = "0x40044FD")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int supportRank1;
    [Token(Token = "0x40044FE")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int supportUnit2;
    [Token(Token = "0x40044FF")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int supportRank2;
    [Token(Token = "0x4004500")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int supportUnit3;
    [Token(Token = "0x4004501")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int supportRank3;

    [Token(Token = "0x17000CA1")]
    public int Key
    {
      [Token(Token = "0x6005700"), Address(RVA = "0x3E3B4A4", Offset = "0x3E3B4A4", VA = "0x3E3B4A4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005701")]
    [Address(RVA = "0x3E3B4AC", Offset = "0x3E3B4AC", VA = "0x3E3B4AC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005702")]
    [Address(RVA = "0x3E3BB58", Offset = "0x3E3BB58", VA = "0x3E3BB58", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000CA2")]
    public int Id
    {
      [Token(Token = "0x6005703"), Address(RVA = "0x3E3BCCC", Offset = "0x3E3BCCC", VA = "0x3E3BCCC", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CA3")]
    public int UnitNo
    {
      [Token(Token = "0x6005704"), Address(RVA = "0x3E3BCD4", Offset = "0x3E3BCD4", VA = "0x3E3BCD4", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CA4")]
    public int NpcMasterDataId
    {
      [Token(Token = "0x6005705"), Address(RVA = "0x3E3BCDC", Offset = "0x3E3BCDC", VA = "0x3E3BCDC", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CA5")]
    public int Troops
    {
      [Token(Token = "0x6005706"), Address(RVA = "0x3E3BCE4", Offset = "0x3E3BCE4", VA = "0x3E3BCE4", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CA6")]
    public int X
    {
      [Token(Token = "0x6005707"), Address(RVA = "0x3E3BCEC", Offset = "0x3E3BCEC", VA = "0x3E3BCEC", Slot = "14")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CA7")]
    public int Y
    {
      [Token(Token = "0x6005708"), Address(RVA = "0x3E3BCF4", Offset = "0x3E3BCF4", VA = "0x3E3BCF4", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CA8")]
    public int SortieFromX
    {
      [Token(Token = "0x6005709"), Address(RVA = "0x3E3BCFC", Offset = "0x3E3BCFC", VA = "0x3E3BCFC", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CA9")]
    public int SortieFromY
    {
      [Token(Token = "0x600570A"), Address(RVA = "0x3E3BD04", Offset = "0x3E3BD04", VA = "0x3E3BD04", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CAA")]
    public int WaitTurnCount
    {
      [Token(Token = "0x600570B"), Address(RVA = "0x3E3BD0C", Offset = "0x3E3BD0C", VA = "0x3E3BD0C", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CAB")]
    public int BaseExp
    {
      [Token(Token = "0x600570C"), Address(RVA = "0x3E3BD14", Offset = "0x3E3BD14", VA = "0x3E3BD14", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CAC")]
    public int Damage
    {
      [Token(Token = "0x600570D"), Address(RVA = "0x3E3BD1C", Offset = "0x3E3BD1C", VA = "0x3E3BD1C", Slot = "18")] set
      {
      }
      [Token(Token = "0x600570E"), Address(RVA = "0x3E3BD24", Offset = "0x3E3BD24", VA = "0x3E3BD24", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CAD")]
    public int Barrier
    {
      [Token(Token = "0x600570F"), Address(RVA = "0x3E3BD2C", Offset = "0x3E3BD2C", VA = "0x3E3BD2C", Slot = "19")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CAE")]
    public int BarrierHp
    {
      [Token(Token = "0x6005710"), Address(RVA = "0x3E3BD34", Offset = "0x3E3BD34", VA = "0x3E3BD34", Slot = "20")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CAF")]
    public bool Modifiable
    {
      [Token(Token = "0x6005711"), Address(RVA = "0x3E3BD3C", Offset = "0x3E3BD3C", VA = "0x3E3BD3C", Slot = "21")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CB0")]
    public int BaseSupportRank
    {
      [Token(Token = "0x6005712"), Address(RVA = "0x3E3BD44", Offset = "0x3E3BD44", VA = "0x3E3BD44", Slot = "22")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005713")]
    [Address(RVA = "0x3E3BD4C", Offset = "0x3E3BD4C", VA = "0x3E3BD4C", Slot = "23")]
    public Dictionary<int, int> GetSupportInfo() => (Dictionary<int, int>) null;

    [Token(Token = "0x17000CB1")]
    public QuestCorrection Correction
    {
      [Token(Token = "0x6005714"), Address(RVA = "0x3E3BE1C", Offset = "0x3E3BE1C", VA = "0x3E3BE1C", Slot = "25")] set
      {
      }
      [Token(Token = "0x6005715"), Address(RVA = "0x3E3BE24", Offset = "0x3E3BE24", VA = "0x3E3BE24", Slot = "24")] get
      {
        return (QuestCorrection) null;
      }
    }

    [Token(Token = "0x17000CB2")]
    public bool IsBoss
    {
      [Token(Token = "0x6005716"), Address(RVA = "0x3E3BE2C", Offset = "0x3E3BE2C", VA = "0x3E3BE2C", Slot = "26")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6005717")]
    [Address(RVA = "0x3E3BE34", Offset = "0x3E3BE34", VA = "0x3E3BE34")]
    public BattleGuestPlacementDescriptionData()
    {
    }
  }
}
