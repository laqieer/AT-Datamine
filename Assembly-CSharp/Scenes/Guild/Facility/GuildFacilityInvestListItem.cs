// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Facility.GuildFacilityInvestListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using StaqData;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Guild.Facility
{
  [Token(Token = "0x2002BFA")]
  public class GuildFacilityInvestListItem : MonoBehaviour
  {
    [Token(Token = "0x400BB2F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemIcon iconResourceItem;
    [Token(Token = "0x400BB30")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text textResourceName;
    [Token(Token = "0x400BB31")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text textResourceQuantity;
    [Token(Token = "0x400BB32")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text textRewardItem;
    [Token(Token = "0x400BB33")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text textRewardExp;
    [Token(Token = "0x400BB34")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button button;
    [Token(Token = "0x400BB35")]
    [FieldOffset(Offset = "0x48")]
    private GuildFacilityInvestListItem.UIParameter uiParameter;
    [Token(Token = "0x400BB36")]
    [FieldOffset(Offset = "0x50")]
    private GuildFacilityInvestBelowScreen screen;

    [Token(Token = "0x60112CC")]
    [Address(RVA = "0x4A12E68", Offset = "0x4A12E68", VA = "0x4A12E68")]
    public void Setup(
      GuildFacilityInvestListItem.UIParameter param,
      GuildFacilityInvestBelowScreen screen,
      bool canInvest)
    {
    }

    [Token(Token = "0x60112CD")]
    [Address(RVA = "0x4A130D0", Offset = "0x4A130D0", VA = "0x4A130D0")]
    public GuildFacilityInvestListItem.UIParameter GetParam()
    {
      return (GuildFacilityInvestListItem.UIParameter) null;
    }

    [Token(Token = "0x60112CE")]
    [Address(RVA = "0x4A130D8", Offset = "0x4A130D8", VA = "0x4A130D8")]
    public void OnInvest()
    {
    }

    [Token(Token = "0x60112CF")]
    [Address(RVA = "0x4A130F8", Offset = "0x4A130F8", VA = "0x4A130F8")]
    public GuildFacilityInvestListItem()
    {
    }

    [Token(Token = "0x2002BFB")]
    public class UIParameter
    {
      [Token(Token = "0x17003B2C")]
      public int investResourceID
      {
        [Token(Token = "0x60112D0"), Address(RVA = "0x4A13100", Offset = "0x4A13100", VA = "0x4A13100")] get
        {
          return new int();
        }
        [Token(Token = "0x60112D1"), Address(RVA = "0x4A13108", Offset = "0x4A13108", VA = "0x4A13108")] set
        {
        }
      }

      [Token(Token = "0x17003B2D")]
      public int rewardExp
      {
        [Token(Token = "0x60112D2"), Address(RVA = "0x4A13110", Offset = "0x4A13110", VA = "0x4A13110")] get
        {
          return new int();
        }
        [Token(Token = "0x60112D3"), Address(RVA = "0x4A13118", Offset = "0x4A13118", VA = "0x4A13118")] set
        {
        }
      }

      [Token(Token = "0x17003B2E")]
      public ItemUtility.Parameter investRewardParameter
      {
        [Token(Token = "0x60112D4"), Address(RVA = "0x4A13120", Offset = "0x4A13120", VA = "0x4A13120")] get
        {
          return new ItemUtility.Parameter();
        }
        [Token(Token = "0x60112D5"), Address(RVA = "0x4A13130", Offset = "0x4A13130", VA = "0x4A13130")] set
        {
        }
      }

      [Token(Token = "0x17003B2F")]
      public int investRewardQuantity
      {
        [Token(Token = "0x60112D6"), Address(RVA = "0x4A13148", Offset = "0x4A13148", VA = "0x4A13148")] get
        {
          return new int();
        }
        [Token(Token = "0x60112D7"), Address(RVA = "0x4A13150", Offset = "0x4A13150", VA = "0x4A13150")] set
        {
        }
      }

      [Token(Token = "0x17003B30")]
      public ItemUtility.Parameter investResourceParameter
      {
        [Token(Token = "0x60112D8"), Address(RVA = "0x4A13158", Offset = "0x4A13158", VA = "0x4A13158")] get
        {
          return new ItemUtility.Parameter();
        }
        [Token(Token = "0x60112D9"), Address(RVA = "0x4A13168", Offset = "0x4A13168", VA = "0x4A13168")] set
        {
        }
      }

      [Token(Token = "0x17003B31")]
      public int investResourceQuantity
      {
        [Token(Token = "0x60112DA"), Address(RVA = "0x4A13180", Offset = "0x4A13180", VA = "0x4A13180")] get
        {
          return new int();
        }
        [Token(Token = "0x60112DB"), Address(RVA = "0x4A13188", Offset = "0x4A13188", VA = "0x4A13188")] set
        {
        }
      }

      [Token(Token = "0x17003B32")]
      public int quantity
      {
        [Token(Token = "0x60112DC"), Address(RVA = "0x4A13190", Offset = "0x4A13190", VA = "0x4A13190")] get
        {
          return new int();
        }
        [Token(Token = "0x60112DD"), Address(RVA = "0x4A13198", Offset = "0x4A13198", VA = "0x4A13198")] set
        {
        }
      }

      [Token(Token = "0x60112DE")]
      [Address(RVA = "0x4A11758", Offset = "0x4A11758", VA = "0x4A11758")]
      public UIParameter()
      {
      }
    }
  }
}
