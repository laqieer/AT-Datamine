// Decompiled with JetBrains decompiler
// Type: TeamOrganization.EquipSetTypeIconView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.Icon;
using Scenes.OutGame.Info.Common.UI;
using StaqData;
using System.Collections;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007D5")]
  public class EquipSetTypeIconView : MonoBehaviour
  {
    [Token(Token = "0x4002489")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TypeIcon[] typeIcons;
    [Token(Token = "0x400248A")]
    [FieldOffset(Offset = "0x20")]
    private int typeIconIndex;
    [Token(Token = "0x400248B")]
    [FieldOffset(Offset = "0x28")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400248C")]
    [FieldOffset(Offset = "0x30")]
    private IAssetProvider styleCategoryPopupProvider;
    [Token(Token = "0x400248D")]
    [FieldOffset(Offset = "0x38")]
    private Style dispStyle;

    [Token(Token = "0x6002C43")]
    [Address(RVA = "0x387BCE0", Offset = "0x387BCE0", VA = "0x387BCE0")]
    public void UpdateTypeIcon(
      OrganizationPartySlot partySlot,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002C44")]
    [Address(RVA = "0x387C288", Offset = "0x387C288", VA = "0x387C288")]
    private void ClearTypeIcon()
    {
    }

    [Token(Token = "0x6002C45")]
    [Address(RVA = "0x387C458", Offset = "0x387C458", VA = "0x387C458")]
    private TypeIcon GetEmptyTypeIcon() => (TypeIcon) null;

    [Token(Token = "0x6002C46")]
    [Address(RVA = "0x387C300", Offset = "0x387C300", VA = "0x387C300")]
    private void SetTypeIconSprite(Sprite sprite, bool isClass)
    {
    }

    [Token(Token = "0x6002C47")]
    [Address(RVA = "0x387C4A8", Offset = "0x387C4A8", VA = "0x387C4A8")]
    private IEnumerator OpenStyleCategoryPopup() => (IEnumerator) null;

    [Token(Token = "0x6002C48")]
    [Address(RVA = "0x387C538", Offset = "0x387C538", VA = "0x387C538")]
    public EquipSetTypeIconView()
    {
    }
  }
}
