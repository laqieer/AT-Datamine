// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.ConsumableMaterialList.ConsumableMaterialItemThumbnail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.ConsumableMaterialList
{
  [Token(Token = "0x2003BE2")]
  public class ConsumableMaterialItemThumbnail : MonoBehaviour
  {
    [Token(Token = "0x401096E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemIcon _itemIcon;
    [Token(Token = "0x401096F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ConsumableMaterialItemThumbnail.Category[] _categories;

    [Token(Token = "0x60178AF")]
    [Address(RVA = "0x2378404", Offset = "0x2378404", VA = "0x2378404")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x60178B0")]
    [Address(RVA = "0x237842C", Offset = "0x237842C", VA = "0x237842C")]
    public void SetItemIcon(
      ItemParam itemParam,
      Action<ItemTypeEnum, int> onClick,
      AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x60178B1")]
    [Address(RVA = "0x23785E8", Offset = "0x23785E8", VA = "0x23785E8")]
    public void SetCategory(string[] usages)
    {
    }

    [Token(Token = "0x60178B2")]
    [Address(RVA = "0x2378704", Offset = "0x2378704", VA = "0x2378704")]
    public ConsumableMaterialItemThumbnail()
    {
    }

    [Token(Token = "0x2003BE3")]
    [Serializable]
    private struct Category
    {
      [Token(Token = "0x4010970")]
      [FieldOffset(Offset = "0x0")]
      public GameObject Root;
      [Token(Token = "0x4010971")]
      [FieldOffset(Offset = "0x8")]
      public Text Text;
    }
  }
}
