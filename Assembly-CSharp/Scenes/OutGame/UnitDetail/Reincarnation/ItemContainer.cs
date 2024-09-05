// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.Reincarnation.ItemContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.UnitDetail.Reincarnation
{
  [Token(Token = "0x20032DD")]
  public class ItemContainer : MonoBehaviour
  {
    [Token(Token = "0x400DB6F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400DB70")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject[] rarityIcons;

    [Token(Token = "0x6013FB4")]
    [Address(RVA = "0x23475F4", Offset = "0x23475F4", VA = "0x23475F4")]
    public void SetData(int itemId)
    {
    }

    [Token(Token = "0x6013FB5")]
    [Address(RVA = "0x234774C", Offset = "0x234774C", VA = "0x234774C")]
    public ItemContainer()
    {
    }
  }
}
