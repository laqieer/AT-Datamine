// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EventQuest.EventStaminaItemPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.MasterData;
using GameCore.Popup;
using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.EventQuest
{
  [Token(Token = "0x2003667")]
  [AddComponentMenu("Scenes/OutGame/EventQuest/StaminaItemPopup")]
  public class EventStaminaItemPopup : PopupBase
  {
    [Token(Token = "0x400ECB9")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Image staminaItem;
    [Token(Token = "0x400ECBA")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text staminaInfoText;
    [Token(Token = "0x400ECBB")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Transform contentTrans;
    [Token(Token = "0x400ECBC")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400ECBD")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private ItemIcon icon;
    [Token(Token = "0x400ECBE")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text textName;
    [Token(Token = "0x400ECBF")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Text textDescription;
    [Token(Token = "0x400ECC0")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Text textReplenishmentTime;
    [Token(Token = "0x400ECC1")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Text replenishmentQuantity;
    [Token(Token = "0x400ECC2")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private Text replenishmentQuantityLimit;
    [Token(Token = "0x400ECC3")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private Text noticeText;
    [Token(Token = "0x400ECC4")]
    [FieldOffset(Offset = "0xE0")]
    private readonly string NIL_TIME;
    [Token(Token = "0x400ECC5")]
    [FieldOffset(Offset = "0xE8")]
    private readonly string NIL_VALUE;
    [Token(Token = "0x400ECC6")]
    [FieldOffset(Offset = "0xF0")]
    private string lastReplenishmentTime;
    [Token(Token = "0x400ECC7")]
    [FieldOffset(Offset = "0xF8")]
    private readonly TimeSpan minTime;
    [Token(Token = "0x400ECC8")]
    [FieldOffset(Offset = "0x100")]
    private DateTime? replenishmentTime;

    [Token(Token = "0x60156B5")]
    [Address(RVA = "0x18DEBFC", Offset = "0x18DEBFC", VA = "0x18DEBFC")]
    public static EventStaminaItemPopup Show(
      LimitedEventData data,
      Sprite icon,
      string text,
      Transform buttonTrans = null,
      in Vector2 contentOffset = default (Vector2))
    {
      return (EventStaminaItemPopup) null;
    }

    [Token(Token = "0x60156B6")]
    [Address(RVA = "0x18DF04C", Offset = "0x18DF04C", VA = "0x18DF04C")]
    public static EventStaminaItemPopup Show(
      GuildRaidData data,
      Sprite icon,
      string text,
      Transform buttonTrans = null,
      in Vector2 contentOffset = default (Vector2))
    {
      return (EventStaminaItemPopup) null;
    }

    [Token(Token = "0x60156B7")]
    [Address(RVA = "0x18DF28C", Offset = "0x18DF28C", VA = "0x18DF28C")]
    public static void ShowAsync(
      AssetCachedSpawner spawner,
      LimitedEventData data,
      Sprite icon,
      string text,
      Transform buttonTrans = null,
      Vector2 contentOffset = default (Vector2))
    {
    }

    [Token(Token = "0x60156B8")]
    [Address(RVA = "0x18DF3D4", Offset = "0x18DF3D4", VA = "0x18DF3D4")]
    public static AssetSpawnOperation<GameObject> ShowAsync(
      AssetCachedSpawner spawner,
      GuildRaidData data,
      Sprite icon,
      string text,
      Transform buttonTrans = null,
      Vector2 contentOffset = default (Vector2))
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x17004729")]
    private string TextReplenishmentTime
    {
      [Token(Token = "0x60156B9"), Address(RVA = "0x18DF510", Offset = "0x18DF510", VA = "0x18DF510")] set
      {
      }
    }

    [Token(Token = "0x60156BA")]
    [Address(RVA = "0x18DF560", Offset = "0x18DF560", VA = "0x18DF560")]
    public void Initialize(LimitedEventData data)
    {
    }

    [Token(Token = "0x60156BB")]
    [Address(RVA = "0x18DFB24", Offset = "0x18DFB24", VA = "0x18DFB24")]
    public void Initialize(GuildRaidData data)
    {
    }

    [Token(Token = "0x60156BC")]
    [Address(RVA = "0x18DFF78", Offset = "0x18DFF78", VA = "0x18DFF78")]
    private void Update()
    {
    }

    [Token(Token = "0x60156BD")]
    [Address(RVA = "0x18DF9D8", Offset = "0x18DF9D8", VA = "0x18DF9D8")]
    private void SetReplenishmentRemainingTime()
    {
    }

    [Token(Token = "0x60156BE")]
    [Address(RVA = "0x18DFF7C", Offset = "0x18DFF7C", VA = "0x18DFF7C", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x60156BF")]
    [Address(RVA = "0x18DEEBC", Offset = "0x18DEEBC", VA = "0x18DEEBC")]
    public void SetPosition(Transform buttonTrans)
    {
    }

    [Token(Token = "0x60156C0")]
    [Address(RVA = "0x18DFF88", Offset = "0x18DFF88", VA = "0x18DFF88")]
    public void SetPosition(in Vector2 pos)
    {
    }

    [Token(Token = "0x60156C1")]
    [Address(RVA = "0x18DEFB8", Offset = "0x18DEFB8", VA = "0x18DEFB8")]
    public void ShiftContentTo(in Vector2 offset)
    {
    }

    [Token(Token = "0x60156C2")]
    [Address(RVA = "0x18E0024", Offset = "0x18E0024", VA = "0x18E0024")]
    public EventStaminaItemPopup()
    {
    }

    [Token(Token = "0x2003668")]
    private class LoadedPrefabGetter : LoadedSingleAssetGetter<EventStaminaItemPopup>
    {
      [Token(Token = "0x60156C3")]
      [Address(RVA = "0x18DEE3C", Offset = "0x18DEE3C", VA = "0x18DEE3C")]
      public LoadedPrefabGetter()
      {
      }
    }
  }
}
