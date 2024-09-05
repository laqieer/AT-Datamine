// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.ItemIconNameView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A44")]
  public class ItemIconNameView : MonoBehaviour
  {
    [Token(Token = "0x400FF3C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text itemName;
    [Token(Token = "0x400FF3D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400FF3E")]
    [FieldOffset(Offset = "0x28")]
    private List<string> loadedAssetBundleList;

    [Token(Token = "0x6016E5C")]
    [Address(RVA = "0x2C60060", Offset = "0x2C60060", VA = "0x2C60060")]
    public void SetItem(PaymentTypeEnum paymentType, int paymentId)
    {
    }

    [Token(Token = "0x6016E5D")]
    [Address(RVA = "0x2C60458", Offset = "0x2C60458", VA = "0x2C60458")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6016E5E")]
    [Address(RVA = "0x2C605F4", Offset = "0x2C605F4", VA = "0x2C605F4")]
    public ItemIconNameView()
    {
    }
  }
}
