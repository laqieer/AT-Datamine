// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.ItemSetCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;
using TeamOrganization;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003AEA")]
  public class ItemSetCell : MonoBehaviour
  {
    [Token(Token = "0x401037A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemSetThumb[] itemSetThumbs;

    [Token(Token = "0x60172E0")]
    [Address(RVA = "0x3012854", Offset = "0x3012854", VA = "0x3012854")]
    public void InitItemSetCell(
      PartyListBelowScreen partyListBelowScreen,
      IReadOnlyList<Expendable> expendables)
    {
    }

    [Token(Token = "0x60172E1")]
    [Address(RVA = "0x30129F0", Offset = "0x30129F0", VA = "0x30129F0")]
    public ItemSetCell()
    {
    }
  }
}
