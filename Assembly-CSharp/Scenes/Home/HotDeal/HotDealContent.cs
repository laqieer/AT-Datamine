// Decompiled with JetBrains decompiler
// Type: Scenes.Home.HotDeal.HotDealContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Home.HotDeal
{
  [Token(Token = "0x2002B11")]
  internal class HotDealContent : MonoBehaviour
  {
    [Token(Token = "0x400B737")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mainArticleImage;
    [Token(Token = "0x400B738")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton paidCoinButton;
    [Token(Token = "0x400B739")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject bonusArticleImage;
    [Token(Token = "0x400B73A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton freeCoinButton;
    [Token(Token = "0x400B73B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private RectTransform parent;
    [Token(Token = "0x400B73C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject bonusTag;
    [Token(Token = "0x400B73D")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text amountText;

    [Token(Token = "0x6010D41")]
    [Address(RVA = "0x1C35198", Offset = "0x1C35198", VA = "0x1C35198")]
    public void SetPaidCoin(HotDealController controller, int amount)
    {
    }

    [Token(Token = "0x6010D42")]
    [Address(RVA = "0x1C352F4", Offset = "0x1C352F4", VA = "0x1C352F4")]
    public void SetFreeCoin(HotDealController controller, int amount)
    {
    }

    [Token(Token = "0x6010D43")]
    [Address(RVA = "0x1C35450", Offset = "0x1C35450", VA = "0x1C35450")]
    public void SetItem(HotDealController controller, Reward item)
    {
    }

    [Token(Token = "0x6010D44")]
    [Address(RVA = "0x1C35618", Offset = "0x1C35618", VA = "0x1C35618")]
    public void ClearThumb()
    {
    }

    [Token(Token = "0x6010D45")]
    [Address(RVA = "0x1C35918", Offset = "0x1C35918", VA = "0x1C35918")]
    public HotDealContent()
    {
    }
  }
}
