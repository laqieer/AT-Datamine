// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.LimitedEventQuest.StaminaItemPopUpButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.LimitedEventQuest
{
  [Token(Token = "0x2003627")]
  public class StaminaItemPopUpButton : MonoBehaviour
  {
    [Token(Token = "0x400EB72")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image staminaItem;
    [Token(Token = "0x400EB73")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text staminaInfoText;
    [Token(Token = "0x400EB74")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton popUpButton;
    [Token(Token = "0x400EB75")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RectTransform popUpParent;
    [Token(Token = "0x400EB76")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Vector2 contentOffset;
    [Token(Token = "0x400EB77")]
    [FieldOffset(Offset = "0x40")]
    private int eventId;
    [Token(Token = "0x400EB78")]
    [FieldOffset(Offset = "0x48")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400EB79")]
    [FieldOffset(Offset = "0x50")]
    private int consumeCostItemId;
    [Token(Token = "0x400EB7A")]
    [FieldOffset(Offset = "0x54")]
    private int staminaItemReplenishmentCount;

    [Token(Token = "0x601553D")]
    [Address(RVA = "0x4D98550", Offset = "0x4D98550", VA = "0x4D98550")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x601553E")]
    [Address(RVA = "0x4D986A0", Offset = "0x4D986A0", VA = "0x4D986A0")]
    public void Set(
      int eventId,
      Sprite staminaItemSprite,
      int staminaItemHolds,
      int staminaItemReplenishmentCount,
      RectTransform popUpParent = null,
      bool guildRaid = false)
    {
    }

    [Token(Token = "0x601553F")]
    [Address(RVA = "0x4D988F8", Offset = "0x4D988F8", VA = "0x4D988F8")]
    public void SetAsync(
      AssetCachedSpawner spawner,
      QuestInfo questInfo,
      RectTransform popUpParent = null)
    {
    }

    [Token(Token = "0x6015540")]
    [Address(RVA = "0x4D989B0", Offset = "0x4D989B0", VA = "0x4D989B0")]
    public void SetAsync(
      AssetCachedSpawner spawner,
      LimitedEventData data,
      RectTransform popUpParent = null)
    {
    }

    [Token(Token = "0x6015541")]
    [Address(RVA = "0x4D98AD8", Offset = "0x4D98AD8", VA = "0x4D98AD8")]
    public void SetAsync(AssetCachedSpawner spawner, GuildRaidData data, RectTransform popUpParent = null)
    {
    }

    [Token(Token = "0x6015542")]
    [Address(RVA = "0x4D98C00", Offset = "0x4D98C00", VA = "0x4D98C00")]
    private void ShowStaminaHeader()
    {
    }

    [Token(Token = "0x6015543")]
    [Address(RVA = "0x4D985D4", Offset = "0x4D985D4", VA = "0x4D985D4")]
    private void SetStaminaInfoText(int staminaItemHolds, int staminaItemReplenishmentCount)
    {
    }

    [Token(Token = "0x6015544")]
    [Address(RVA = "0x4D98D8C", Offset = "0x4D98D8C", VA = "0x4D98D8C")]
    private void ShowStaminaHeaderForGuildRaid()
    {
    }

    [Token(Token = "0x6015545")]
    [Address(RVA = "0x4D98F08", Offset = "0x4D98F08", VA = "0x4D98F08")]
    public StaminaItemPopUpButton()
    {
    }
  }
}
