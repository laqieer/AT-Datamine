// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.LimitedEventQuest.LimitedEventQuestTopBanner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.LimitedEventQuest
{
  [Token(Token = "0x2003648")]
  public class LimitedEventQuestTopBanner : MonoBehaviour
  {
    [Token(Token = "0x400EC32")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RawImage banner;
    [Token(Token = "0x400EC33")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RawImage title;
    [Token(Token = "0x400EC34")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image staminaItem;
    [Token(Token = "0x400EC35")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UI.Utilities.SerializeUI.TextContainer endAtText;
    [Token(Token = "0x400EC36")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI staminaNow;
    [Token(Token = "0x400EC37")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI staminaMax;
    [Token(Token = "0x400EC38")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject newMark;
    [Token(Token = "0x400EC39")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject staminaObjectRoot;
    [Token(Token = "0x400EC3A")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton eventQuestButton;
    [Token(Token = "0x400EC3B")]
    [FieldOffset(Offset = "0x60")]
    private UnityAction<int> selectEvent;
    [Token(Token = "0x400EC3C")]
    [FieldOffset(Offset = "0x68")]
    private int eventId;
    [Token(Token = "0x400EC3D")]
    [FieldOffset(Offset = "0x70")]
    private Coroutine bannerCoroutine;
    [Token(Token = "0x400EC3E")]
    [FieldOffset(Offset = "0x78")]
    private Coroutine titleCoroutine;
    [Token(Token = "0x400EC3F")]
    [FieldOffset(Offset = "0x80")]
    private Texture2D titleTexture;

    [Token(Token = "0x17004702")]
    public Texture2D TitleTexture
    {
      [Token(Token = "0x60155E7"), Address(RVA = "0x18D67F0", Offset = "0x18D67F0", VA = "0x18D67F0")] get
      {
        return (Texture2D) null;
      }
    }

    [Token(Token = "0x17004703")]
    public bool IsLoadCompletedTitleTexture
    {
      [Token(Token = "0x60155E8"), Address(RVA = "0x18D67F8", Offset = "0x18D67F8", VA = "0x18D67F8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60155E9")]
    [Address(RVA = "0x18D6808", Offset = "0x18D6808", VA = "0x18D6808")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60155EA")]
    [Address(RVA = "0x18D6904", Offset = "0x18D6904", VA = "0x18D6904")]
    public void SetUp(
      MonoBehaviour parentBehavior,
      Scenes.OutGame.LimitedEventQuest.LimitedEventQuest.TopBannerData bannerData,
      UnityAction<int> selectEvent)
    {
    }

    [Token(Token = "0x60155EB")]
    [Address(RVA = "0x18D6CAC", Offset = "0x18D6CAC", VA = "0x18D6CAC")]
    public void Release()
    {
    }

    [Token(Token = "0x60155EC")]
    [Address(RVA = "0x18D6CE8", Offset = "0x18D6CE8", VA = "0x18D6CE8")]
    private void SelectBannerEvent()
    {
    }

    [Token(Token = "0x60155ED")]
    [Address(RVA = "0x18D6D08", Offset = "0x18D6D08", VA = "0x18D6D08")]
    public void NewBadgeOff()
    {
    }

    [Token(Token = "0x17004704")]
    public int EventId
    {
      [Token(Token = "0x60155EE"), Address(RVA = "0x18D6D28", Offset = "0x18D6D28", VA = "0x18D6D28")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60155EF")]
    [Address(RVA = "0x18D6D30", Offset = "0x18D6D30", VA = "0x18D6D30")]
    public LimitedEventQuestTopBanner()
    {
    }
  }
}
