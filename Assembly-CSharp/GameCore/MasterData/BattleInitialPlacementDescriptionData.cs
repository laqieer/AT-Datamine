// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleInitialPlacementDescriptionData
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
  [Token(Token = "0x2000E52")]
  [Serializable]
  public sealed class BattleInitialPlacementDescriptionData : IMasterDataEntity, IUnitPlacementData
  {
    [Token(Token = "0x400450B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400450C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int placementID;
    [Token(Token = "0x400450D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int x;
    [Token(Token = "0x400450E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int y;
    [Token(Token = "0x400450F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int slotID;
    [Token(Token = "0x4004510")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public bool modifiable;
    [Token(Token = "0x4004511")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int guestNpcId;
    [Token(Token = "0x4004512")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int guestSupportRank;

    [Token(Token = "0x17000CB8")]
    public int Key
    {
      [Token(Token = "0x600572C"), Address(RVA = "0x3E3C844", Offset = "0x3E3C844", VA = "0x3E3C844", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600572D")]
    [Address(RVA = "0x3E3C84C", Offset = "0x3E3C84C", VA = "0x3E3C84C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600572E")]
    [Address(RVA = "0x3E3CB9C", Offset = "0x3E3CB9C", VA = "0x3E3CB9C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000CB9")]
    public int Id
    {
      [Token(Token = "0x600572F"), Address(RVA = "0x3E3CC80", Offset = "0x3E3CC80", VA = "0x3E3CC80", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CBA")]
    public int Troops
    {
      [Token(Token = "0x6005730"), Address(RVA = "0x3E3CC88", Offset = "0x3E3CC88", VA = "0x3E3CC88", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CBB")]
    public int UnitNo
    {
      [Token(Token = "0x6005731"), Address(RVA = "0x3E3CC90", Offset = "0x3E3CC90", VA = "0x3E3CC90", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CBC")]
    public int X
    {
      [Token(Token = "0x6005732"), Address(RVA = "0x3E3CC98", Offset = "0x3E3CC98", VA = "0x3E3CC98", Slot = "14")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CBD")]
    public int Y
    {
      [Token(Token = "0x6005733"), Address(RVA = "0x3E3CCA0", Offset = "0x3E3CCA0", VA = "0x3E3CCA0", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CBE")]
    public int SortieFromX
    {
      [Token(Token = "0x6005734"), Address(RVA = "0x3E3CCA8", Offset = "0x3E3CCA8", VA = "0x3E3CCA8", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CBF")]
    public int SortieFromY
    {
      [Token(Token = "0x6005735"), Address(RVA = "0x3E3CCB0", Offset = "0x3E3CCB0", VA = "0x3E3CCB0", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CC0")]
    public int WaitTurnCount
    {
      [Token(Token = "0x6005736"), Address(RVA = "0x3E3CCB8", Offset = "0x3E3CCB8", VA = "0x3E3CCB8", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CC1")]
    public int BaseExp
    {
      [Token(Token = "0x6005737"), Address(RVA = "0x3E3CCC0", Offset = "0x3E3CCC0", VA = "0x3E3CCC0", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CC2")]
    public int Damage
    {
      [Token(Token = "0x6005738"), Address(RVA = "0x3E3CCC8", Offset = "0x3E3CCC8", VA = "0x3E3CCC8", Slot = "18")] set
      {
      }
      [Token(Token = "0x6005739"), Address(RVA = "0x3E3CCD0", Offset = "0x3E3CCD0", VA = "0x3E3CCD0", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CC3")]
    public int NpcMasterDataId
    {
      [Token(Token = "0x600573A"), Address(RVA = "0x3E3CCD8", Offset = "0x3E3CCD8", VA = "0x3E3CCD8", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CC4")]
    public int Barrier
    {
      [Token(Token = "0x600573B"), Address(RVA = "0x3E3CCE0", Offset = "0x3E3CCE0", VA = "0x3E3CCE0", Slot = "19")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CC5")]
    public int BarrierHp
    {
      [Token(Token = "0x600573C"), Address(RVA = "0x3E3CCE8", Offset = "0x3E3CCE8", VA = "0x3E3CCE8", Slot = "20")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CC6")]
    public bool Modifiable
    {
      [Token(Token = "0x600573D"), Address(RVA = "0x3E3CCF0", Offset = "0x3E3CCF0", VA = "0x3E3CCF0", Slot = "21")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CC7")]
    public int BaseSupportRank
    {
      [Token(Token = "0x600573E"), Address(RVA = "0x3E3CCF8", Offset = "0x3E3CCF8", VA = "0x3E3CCF8", Slot = "22")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600573F")]
    [Address(RVA = "0x3E3CD00", Offset = "0x3E3CD00", VA = "0x3E3CD00", Slot = "23")]
    public Dictionary<int, int> GetSupportInfo() => (Dictionary<int, int>) null;

    [Token(Token = "0x17000CC8")]
    public QuestCorrection Correction
    {
      [Token(Token = "0x6005740"), Address(RVA = "0x3E3CD08", Offset = "0x3E3CD08", VA = "0x3E3CD08", Slot = "25")] set
      {
      }
      [Token(Token = "0x6005741"), Address(RVA = "0x3E3CD10", Offset = "0x3E3CD10", VA = "0x3E3CD10", Slot = "24")] get
      {
        return (QuestCorrection) null;
      }
    }

    [Token(Token = "0x17000CC9")]
    public bool IsBoss
    {
      [Token(Token = "0x6005742"), Address(RVA = "0x3E3CD18", Offset = "0x3E3CD18", VA = "0x3E3CD18", Slot = "26")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6005743")]
    [Address(RVA = "0x3E3CD20", Offset = "0x3E3CD20", VA = "0x3E3CD20")]
    public BattleInitialPlacementDescriptionData()
    {
    }
  }
}
