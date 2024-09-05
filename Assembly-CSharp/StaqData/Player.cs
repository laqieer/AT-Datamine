// Decompiled with JetBrains decompiler
// Type: StaqData.Player
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002047")]
  public class Player : IPlayerTitleInfo
  {
    [Token(Token = "0x400895E")]
    [FieldOffset(Offset = "0xA0")]
    public bool IsAgeRegistered;
    [Token(Token = "0x4008960")]
    [FieldOffset(Offset = "0xA8")]
    private readonly string PLAYER_ASSET_BUNDLE_LABEL;
    [Token(Token = "0x4008961")]
    [FieldOffset(Offset = "0xB0")]
    private readonly string PLAYER_LEVEL_UP_ASSET;

    [Token(Token = "0x170028B1")]
    public UniqueID Id
    {
      [Token(Token = "0x600C1B3"), Address(RVA = "0x193DF80", Offset = "0x193DF80", VA = "0x193DF80")] private set
      {
      }
      [Token(Token = "0x600C1B4"), Address(RVA = "0x193DF88", Offset = "0x193DF88", VA = "0x193DF88")] get
      {
        return new UniqueID();
      }
    }

    [Token(Token = "0x170028B2")]
    public long ShortId
    {
      [Token(Token = "0x600C1B5"), Address(RVA = "0x193DF90", Offset = "0x193DF90", VA = "0x193DF90")] private set
      {
      }
      [Token(Token = "0x600C1B6"), Address(RVA = "0x193DF98", Offset = "0x193DF98", VA = "0x193DF98")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x170028B3")]
    public string Name
    {
      [Token(Token = "0x600C1B7"), Address(RVA = "0x193DFA0", Offset = "0x193DFA0", VA = "0x193DFA0")] private set
      {
      }
      [Token(Token = "0x600C1B8"), Address(RVA = "0x193DFA8", Offset = "0x193DFA8", VA = "0x193DFA8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170028B4")]
    public string Comment
    {
      [Token(Token = "0x600C1B9"), Address(RVA = "0x193DFB0", Offset = "0x193DFB0", VA = "0x193DFB0")] private set
      {
      }
      [Token(Token = "0x600C1BA"), Address(RVA = "0x193DFB8", Offset = "0x193DFB8", VA = "0x193DFB8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170028B5")]
    public string CreatedAt
    {
      [Token(Token = "0x600C1BB"), Address(RVA = "0x193DFC0", Offset = "0x193DFC0", VA = "0x193DFC0")] private set
      {
      }
      [Token(Token = "0x600C1BC"), Address(RVA = "0x193DFC8", Offset = "0x193DFC8", VA = "0x193DFC8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170028B6")]
    public string UpdatedAt
    {
      [Token(Token = "0x600C1BD"), Address(RVA = "0x193DFD0", Offset = "0x193DFD0", VA = "0x193DFD0")] private set
      {
      }
      [Token(Token = "0x600C1BE"), Address(RVA = "0x193DFD8", Offset = "0x193DFD8", VA = "0x193DFD8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170028B7")]
    public int FreeCommonCoin
    {
      [Token(Token = "0x600C1BF"), Address(RVA = "0x193DFE0", Offset = "0x193DFE0", VA = "0x193DFE0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170028B8")]
    public int AllCoin
    {
      [Token(Token = "0x600C1C0"), Address(RVA = "0x193DFEC", Offset = "0x193DFEC", VA = "0x193DFEC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170028B9")]
    public int CommonCoin
    {
      [Token(Token = "0x600C1C1"), Address(RVA = "0x193E000", Offset = "0x193E000", VA = "0x193E000")] private set
      {
      }
      [Token(Token = "0x600C1C2"), Address(RVA = "0x193E008", Offset = "0x193E008", VA = "0x193E008")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170028BA")]
    public int FreeCoin
    {
      [Token(Token = "0x600C1C3"), Address(RVA = "0x193E010", Offset = "0x193E010", VA = "0x193E010")] private set
      {
      }
      [Token(Token = "0x600C1C4"), Address(RVA = "0x193E018", Offset = "0x193E018", VA = "0x193E018")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170028BB")]
    public int PaidCoin
    {
      [Token(Token = "0x600C1C5"), Address(RVA = "0x193E020", Offset = "0x193E020", VA = "0x193E020")] private set
      {
      }
      [Token(Token = "0x600C1C6"), Address(RVA = "0x193E028", Offset = "0x193E028", VA = "0x193E028")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170028BC")]
    public int Experience
    {
      [Token(Token = "0x600C1C7"), Address(RVA = "0x193E030", Offset = "0x193E030", VA = "0x193E030")] private set
      {
      }
      [Token(Token = "0x600C1C8"), Address(RVA = "0x193E038", Offset = "0x193E038", VA = "0x193E038")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170028BD")]
    public int LastModifiedAp
    {
      [Token(Token = "0x600C1C9"), Address(RVA = "0x193E040", Offset = "0x193E040", VA = "0x193E040")] private set
      {
      }
      [Token(Token = "0x600C1CA"), Address(RVA = "0x193E048", Offset = "0x193E048", VA = "0x193E048")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170028BE")]
    public DateTime? ApModifiedAt
    {
      [Token(Token = "0x600C1CB"), Address(RVA = "0x193E050", Offset = "0x193E050", VA = "0x193E050")] get
      {
        return new DateTime?();
      }
      [Token(Token = "0x600C1CC"), Address(RVA = "0x193E05C", Offset = "0x193E05C", VA = "0x193E05C")] private set
      {
      }
    }

    [Token(Token = "0x170028BF")]
    public int ApDayRecoveryCountItem
    {
      [Token(Token = "0x600C1CD"), Address(RVA = "0x193E064", Offset = "0x193E064", VA = "0x193E064")] get
      {
        return new int();
      }
      [Token(Token = "0x600C1CE"), Address(RVA = "0x193E06C", Offset = "0x193E06C", VA = "0x193E06C")] private set
      {
      }
    }

    [Token(Token = "0x170028C0")]
    public int ApDayRecoveryCountCoin
    {
      [Token(Token = "0x600C1CF"), Address(RVA = "0x193E074", Offset = "0x193E074", VA = "0x193E074")] get
      {
        return new int();
      }
      [Token(Token = "0x600C1D0"), Address(RVA = "0x193E07C", Offset = "0x193E07C", VA = "0x193E07C")] private set
      {
      }
    }

    [Token(Token = "0x170028C1")]
    public DateTime NameChangeCoolTimeEndAt
    {
      [Token(Token = "0x600C1D1"), Address(RVA = "0x193E084", Offset = "0x193E084", VA = "0x193E084")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600C1D2"), Address(RVA = "0x193E08C", Offset = "0x193E08C", VA = "0x193E08C")] private set
      {
      }
    }

    [Token(Token = "0x170028C2")]
    public int PreTitleId
    {
      [Token(Token = "0x600C1D3"), Address(RVA = "0x193E094", Offset = "0x193E094", VA = "0x193E094")] private set
      {
      }
      [Token(Token = "0x600C1D4"), Address(RVA = "0x193E09C", Offset = "0x193E09C", VA = "0x193E09C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170028C3")]
    public int PostTitleId
    {
      [Token(Token = "0x600C1D5"), Address(RVA = "0x193E0A4", Offset = "0x193E0A4", VA = "0x193E0A4")] private set
      {
      }
      [Token(Token = "0x600C1D6"), Address(RVA = "0x193E0AC", Offset = "0x193E0AC", VA = "0x193E0AC", Slot = "5")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170028C4")]
    public int TitleFrameId
    {
      [Token(Token = "0x600C1D7"), Address(RVA = "0x193E0B4", Offset = "0x193E0B4", VA = "0x193E0B4")] private set
      {
      }
      [Token(Token = "0x600C1D8"), Address(RVA = "0x193E0BC", Offset = "0x193E0BC", VA = "0x193E0BC", Slot = "6")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170028C5")]
    public int EmblemId
    {
      [Token(Token = "0x600C1D9"), Address(RVA = "0x193E0C4", Offset = "0x193E0C4", VA = "0x193E0C4")] private set
      {
      }
      [Token(Token = "0x600C1DA"), Address(RVA = "0x193E0CC", Offset = "0x193E0CC", VA = "0x193E0CC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170028C6")]
    public int AvatarId
    {
      [Token(Token = "0x600C1DB"), Address(RVA = "0x193E0D4", Offset = "0x193E0D4", VA = "0x193E0D4")] private set
      {
      }
      [Token(Token = "0x600C1DC"), Address(RVA = "0x193E0DC", Offset = "0x193E0DC", VA = "0x193E0DC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170028C7")]
    public long TotalBattlePower
    {
      [Token(Token = "0x600C1DD"), Address(RVA = "0x193E0E4", Offset = "0x193E0E4", VA = "0x193E0E4")] private set
      {
      }
      [Token(Token = "0x600C1DE"), Address(RVA = "0x193E0EC", Offset = "0x193E0EC", VA = "0x193E0EC")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x170028C8")]
    public DateTime LastSignedInAt
    {
      [Token(Token = "0x600C1DF"), Address(RVA = "0x193E0F4", Offset = "0x193E0F4", VA = "0x193E0F4")] private set
      {
      }
      [Token(Token = "0x600C1E0"), Address(RVA = "0x193E0FC", Offset = "0x193E0FC", VA = "0x193E0FC")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x170028C9")]
    public int SymbolUnitId
    {
      [Token(Token = "0x600C1E1"), Address(RVA = "0x193E104", Offset = "0x193E104", VA = "0x193E104")] get
      {
        return new int();
      }
      [Token(Token = "0x600C1E2"), Address(RVA = "0x193E10C", Offset = "0x193E10C", VA = "0x193E10C")] private set
      {
      }
    }

    [Token(Token = "0x170028CA")]
    public int Level
    {
      [Token(Token = "0x600C1E3"), Address(RVA = "0x193E114", Offset = "0x193E114", VA = "0x193E114")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170028CB")]
    public int NextLevelExp
    {
      [Token(Token = "0x600C1E4"), Address(RVA = "0x193E52C", Offset = "0x193E52C", VA = "0x193E52C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170028CC")]
    public float NextLevelExpRate
    {
      [Token(Token = "0x600C1E5"), Address(RVA = "0x193E620", Offset = "0x193E620", VA = "0x193E620")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x600C1E6")]
    [Address(RVA = "0x193E718", Offset = "0x193E718", VA = "0x193E718")]
    public Player()
    {
    }

    [Token(Token = "0x600C1E7")]
    [Address(RVA = "0x193E78C", Offset = "0x193E78C", VA = "0x193E78C")]
    public void Apply(PlayerType entity)
    {
    }

    [Token(Token = "0x600C1E8")]
    [Address(RVA = "0x193E954", Offset = "0x193E954", VA = "0x193E954")]
    public void ApplyAp(PlayerApType entity)
    {
    }

    [Token(Token = "0x600C1E9")]
    [Address(RVA = "0x193E9F8", Offset = "0x193E9F8", VA = "0x193E9F8")]
    public void ApplyCoin(PlayerCoinType entity)
    {
    }

    [Token(Token = "0x600C1EA")]
    [Address(RVA = "0x193EA10", Offset = "0x193EA10", VA = "0x193EA10")]
    public void ApplyProfileChange(PlayerProfileChangeType entity)
    {
    }

    [Token(Token = "0x600C1EB")]
    [Address(RVA = "0x193E948", Offset = "0x193E948", VA = "0x193E948")]
    public void UpdataCoin(int commonCoin, int freeCoin, int paidCoin)
    {
    }

    [Token(Token = "0x600C1EC")]
    [Address(RVA = "0x193EA80", Offset = "0x193EA80", VA = "0x193EA80")]
    public void SetName(string name)
    {
    }

    [Token(Token = "0x600C1ED")]
    [Address(RVA = "0x193EA88", Offset = "0x193EA88", VA = "0x193EA88")]
    public void SetEmblem(int emblemId)
    {
    }

    [Token(Token = "0x600C1EE")]
    [Address(RVA = "0x193EA90", Offset = "0x193EA90", VA = "0x193EA90")]
    public void SetEditData(string name, int avatarId)
    {
    }

    [Token(Token = "0x600C1EF")]
    [Address(RVA = "0x193EA9C", Offset = "0x193EA9C", VA = "0x193EA9C")]
    public void SetComment(string comment)
    {
    }

    [Token(Token = "0x600C1F0")]
    [Address(RVA = "0x193E924", Offset = "0x193E924", VA = "0x193E924")]
    private void Reset()
    {
    }

    [Token(Token = "0x600C1F1")]
    [Address(RVA = "0x193E134", Offset = "0x193E134", VA = "0x193E134")]
    private PlayerExpData GetNowLevelData(bool isLast = false) => (PlayerExpData) null;

    [Token(Token = "0x600C1F2")]
    [Address(RVA = "0x193E584", Offset = "0x193E584", VA = "0x193E584")]
    private PlayerExpData GetMaxLevelData() => (PlayerExpData) null;

    [Token(Token = "0x600C1F3")]
    [Address(RVA = "0x193EAA4", Offset = "0x193EAA4", VA = "0x193EAA4")]
    public int GetAp() => new int();

    [Token(Token = "0x600C1F4")]
    [Address(RVA = "0x193EDF0", Offset = "0x193EDF0", VA = "0x193EDF0")]
    public float GetNextApRecoveryTime() => new float();

    [Token(Token = "0x600C1F5")]
    [Address(RVA = "0x193F0D0", Offset = "0x193F0D0", VA = "0x193F0D0")]
    public int GetApFullRecoveryTime() => new int();

    [Token(Token = "0x600C1F6")]
    [Address(RVA = "0x193F230", Offset = "0x193F230", VA = "0x193F230")]
    public IEnumerator ShowPlayLevelUpEffect(GameObject parent, Action callback)
    {
      return (IEnumerator) null;
    }
  }
}
