// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.ConsumableMaterialList.ConsumableMaterialItemLine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.ConsumableMaterialList
{
  [Token(Token = "0x2003BE1")]
  public class ConsumableMaterialItemLine : MonoBehaviour
  {
    [Token(Token = "0x401096C")]
    public const int MAX_ITEM_THUMBNAIL = 3;
    [Token(Token = "0x401096D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ConsumableMaterialItemThumbnail[] _items;

    [Token(Token = "0x17004C75")]
    public int Count
    {
      [Token(Token = "0x60178AC"), Address(RVA = "0x23786D8", Offset = "0x23786D8", VA = "0x23786D8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60178AD")]
    [Address(RVA = "0x23783D4", Offset = "0x23783D4", VA = "0x23783D4")]
    public ConsumableMaterialItemThumbnail Get(int index) => (ConsumableMaterialItemThumbnail) null;

    [Token(Token = "0x60178AE")]
    [Address(RVA = "0x23786F4", Offset = "0x23786F4", VA = "0x23786F4")]
    public ConsumableMaterialItemLine()
    {
    }
  }
}
