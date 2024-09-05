// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.CustomSkillEnhanceController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20031D0")]
  public class CustomSkillEnhanceController : MonoBehaviour
  {
    [Token(Token = "0x400D450")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SkillEnhanceController enhanceController;
    [Token(Token = "0x400D451")]
    [FieldOffset(Offset = "0x20")]
    private string skillUID;
    [Token(Token = "0x400D452")]
    [FieldOffset(Offset = "0x28")]
    private Action<int, int> onChange;
    [Token(Token = "0x400D453")]
    [FieldOffset(Offset = "0x30")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x170040E5")]
    public Action OnClickCloseAction
    {
      [Token(Token = "0x601370D"), Address(RVA = "0x4E0B0BC", Offset = "0x4E0B0BC", VA = "0x4E0B0BC")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x601370E"), Address(RVA = "0x4E0B0D8", Offset = "0x4E0B0D8", VA = "0x4E0B0D8")] set
      {
      }
    }

    [Token(Token = "0x170040E6")]
    public ItemDetailPopupProvider ItemDetailPopupProvider
    {
      [Token(Token = "0x601370F"), Address(RVA = "0x4E0B0F4", Offset = "0x4E0B0F4", VA = "0x4E0B0F4")] get
      {
        return (ItemDetailPopupProvider) null;
      }
      [Token(Token = "0x6013710"), Address(RVA = "0x4E0B110", Offset = "0x4E0B110", VA = "0x4E0B110")] set
      {
      }
    }

    [Token(Token = "0x170040E7")]
    public bool enhancedMaxLv
    {
      [Token(Token = "0x6013711"), Address(RVA = "0x4E0B12C", Offset = "0x4E0B12C", VA = "0x4E0B12C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6013712")]
    [Address(RVA = "0x4E0B148", Offset = "0x4E0B148", VA = "0x4E0B148")]
    public bool Setup(
      AssetCachedSpawner assetCachedSpawner,
      int skillID,
      RarityTypeEnum rarityType,
      string skillUID,
      int skillLevel,
      int skillEnergy,
      Action<int, int> onChange,
      Action onLevelInfo)
    {
      return new bool();
    }

    [Token(Token = "0x6013713")]
    [Address(RVA = "0x4E0B2D4", Offset = "0x4E0B2D4", VA = "0x4E0B2D4")]
    private void onClickEnhance(int count)
    {
    }

    [Token(Token = "0x6013714")]
    [Address(RVA = "0x4E0B488", Offset = "0x4E0B488", VA = "0x4E0B488")]
    private void onClickInvalidEnhance(int count)
    {
    }

    [Token(Token = "0x6013715")]
    [Address(RVA = "0x4E0B410", Offset = "0x4E0B410", VA = "0x4E0B410")]
    private IEnumerator ConnectEnhanceAPI(int tryCount) => (IEnumerator) null;

    [Token(Token = "0x6013716")]
    [Address(RVA = "0x4E0B38C", Offset = "0x4E0B38C", VA = "0x4E0B38C")]
    public void SetToaster(string txt)
    {
    }

    [Token(Token = "0x6013717")]
    [Address(RVA = "0x4E0B5D8", Offset = "0x4E0B5D8", VA = "0x4E0B5D8")]
    public CustomSkillEnhanceController()
    {
    }
  }
}
