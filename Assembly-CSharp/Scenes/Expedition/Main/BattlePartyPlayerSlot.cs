// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Main.BattlePartyPlayerSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Tween;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.Main
{
  [Token(Token = "0x2002C97")]
  public class BattlePartyPlayerSlot : MonoBehaviour
  {
    [Token(Token = "0x400BE34")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400BE35")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<GameObject> slotStatuses;
    [Token(Token = "0x400BE36")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image imageCharacter;
    [Token(Token = "0x400BE37")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI levelText;
    [Token(Token = "0x400BE38")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject levelUpObj;
    [Token(Token = "0x400BE39")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI levelUpText;
    [Token(Token = "0x400BE3A")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject downObject;
    [Token(Token = "0x400BE3B")]
    [FieldOffset(Offset = "0x50")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400BE3C")]
    [FieldOffset(Offset = "0x58")]
    private Style style;
    [Token(Token = "0x400BE3D")]
    private const string StatusAssetName = "ExpeditionStatusPopup";
    [Token(Token = "0x400BE3E")]
    [FieldOffset(Offset = "0x60")]
    private Action OnClickCharacterAction;
    [Token(Token = "0x400BE3F")]
    [FieldOffset(Offset = "0x68")]
    private bool isPartyLock;
    [Token(Token = "0x400BE41")]
    [FieldOffset(Offset = "0x6C")]
    private int infoId;

    [Token(Token = "0x17003C1C")]
    public string StyleId
    {
      [Token(Token = "0x6011729"), Address(RVA = "0x49377C0", Offset = "0x49377C0", VA = "0x49377C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17003C1D")]
    public bool isStyleEmpty
    {
      [Token(Token = "0x601172A"), Address(RVA = "0x493783C", Offset = "0x493783C", VA = "0x493783C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003C1E")]
    public bool isPlayDeathAnim
    {
      [Token(Token = "0x601172B"), Address(RVA = "0x493784C", Offset = "0x493784C", VA = "0x493784C")] get
      {
        return new bool();
      }
      [Token(Token = "0x601172C"), Address(RVA = "0x4937854", Offset = "0x4937854", VA = "0x4937854")] private set
      {
      }
    }

    [Token(Token = "0x17003C1F")]
    public int InfoId
    {
      [Token(Token = "0x601172D"), Address(RVA = "0x4937860", Offset = "0x4937860", VA = "0x4937860")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x601172E")]
    [Address(RVA = "0x4937868", Offset = "0x4937868", VA = "0x4937868")]
    public void Initialize(
      AssetCachedSpawner spawner,
      PartySlotStatus status,
      Style style = null,
      int storedExperience = 0,
      bool isPartyLock = false,
      int infoId = 0)
    {
    }

    [Token(Token = "0x601172F")]
    [Address(RVA = "0x4937B70", Offset = "0x4937B70", VA = "0x4937B70")]
    public void SetCallback(Action onCharacter)
    {
    }

    [Token(Token = "0x6011730")]
    [Address(RVA = "0x4937B78", Offset = "0x4937B78", VA = "0x4937B78")]
    public void OnClickCharacter()
    {
    }

    [Token(Token = "0x6011731")]
    [Address(RVA = "0x4937B9C", Offset = "0x4937B9C", VA = "0x4937B9C")]
    public void OnClickUnset()
    {
    }

    [Token(Token = "0x6011732")]
    [Address(RVA = "0x4937BC0", Offset = "0x4937BC0", VA = "0x4937BC0")]
    public void OnClickLocked()
    {
    }

    [Token(Token = "0x6011733")]
    [Address(RVA = "0x4937954", Offset = "0x4937954", VA = "0x4937954")]
    private void ShowStatusThumbnail(PartySlotStatus status)
    {
    }

    [Token(Token = "0x6011734")]
    [Address(RVA = "0x49379C4", Offset = "0x49379C4", VA = "0x49379C4")]
    private void ShowStyleThumbnail(Style style, int storedExperience)
    {
    }

    [Token(Token = "0x6011735")]
    [Address(RVA = "0x4937CE4", Offset = "0x4937CE4", VA = "0x4937CE4")]
    public void UpdateLevelUp(int storedExperience)
    {
    }

    [Token(Token = "0x6011736")]
    [Address(RVA = "0x4937BE4", Offset = "0x4937BE4", VA = "0x4937BE4")]
    private void HideAllStatusThumbnail()
    {
    }

    [Token(Token = "0x6011737")]
    [Address(RVA = "0x4937D60", Offset = "0x4937D60", VA = "0x4937D60")]
    private void ChangeStatusThumbnail(PartySlotStatus status)
    {
    }

    [Token(Token = "0x6011738")]
    [Address(RVA = "0x4937DD0", Offset = "0x4937DD0", VA = "0x4937DD0")]
    private void ChangeSubScene(string assetBundleName, string subSceneName)
    {
    }

    [Token(Token = "0x6011739")]
    [Address(RVA = "0x4937E64", Offset = "0x4937E64", VA = "0x4937E64")]
    public void UpdateDeathUnit()
    {
    }

    [Token(Token = "0x601173A")]
    [Address(RVA = "0x4937EF4", Offset = "0x4937EF4", VA = "0x4937EF4")]
    public BattlePartyPlayerSlot()
    {
    }
  }
}
