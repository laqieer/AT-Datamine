// Decompiled with JetBrains decompiler
// Type: TeamOrganization.ItemListThumbIconElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000777")]
  public class ItemListThumbIconElement : MonoBehaviour
  {
    [Token(Token = "0x4002213")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemSetThumb[] thumbList;
    [Token(Token = "0x4002214")]
    [FieldOffset(Offset = "0x20")]
    private ItemSetEditItemListPopup itemSetEditItemListPopup;

    [Token(Token = "0x60029A5")]
    [Address(RVA = "0x34F7AD0", Offset = "0x34F7AD0", VA = "0x34F7AD0")]
    public void Initialize(int idx, ItemSetEditItemListPopup.eItemListKind kind)
    {
    }

    [Token(Token = "0x60029A6")]
    [Address(RVA = "0x34F7EB8", Offset = "0x34F7EB8", VA = "0x34F7EB8")]
    public void SetThumbButtonOperationPossible(bool flg)
    {
    }

    [Token(Token = "0x60029A7")]
    [Address(RVA = "0x34F7F28", Offset = "0x34F7F28", VA = "0x34F7F28")]
    private void Update()
    {
    }

    [Token(Token = "0x60029A8")]
    [Address(RVA = "0x34F81DC", Offset = "0x34F81DC", VA = "0x34F81DC")]
    public ItemListThumbIconElement()
    {
    }
  }
}
