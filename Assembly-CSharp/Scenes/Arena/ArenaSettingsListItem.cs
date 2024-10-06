// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaSettingsListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x200312D")]
  public class ArenaSettingsListItem : MonoBehaviour
  {
    [Token(Token = "0x400D170")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ArenaSettings.Type type;
    [Token(Token = "0x400D171")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<ArenaSettingsListItemButton> buttons;

    [Token(Token = "0x17004047")]
    public ArenaSettings.Type Type
    {
      [Token(Token = "0x601331A"), Address(RVA = "0x45E63AC", Offset = "0x45E63AC", VA = "0x45E63AC")] get
      {
        return new ArenaSettings.Type();
      }
    }

    [Token(Token = "0x17004048")]
    public int Value
    {
      [Token(Token = "0x601331B"), Address(RVA = "0x45E63B4", Offset = "0x45E63B4", VA = "0x45E63B4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x601331C")]
    [Address(RVA = "0x45E64BC", Offset = "0x45E64BC", VA = "0x45E64BC")]
    public void Initialize(int firstVal)
    {
    }

    [Token(Token = "0x601331D")]
    [Address(RVA = "0x45E65A4", Offset = "0x45E65A4", VA = "0x45E65A4")]
    private void OnClickAny()
    {
    }

    [Token(Token = "0x601331E")]
    [Address(RVA = "0x45E66A4", Offset = "0x45E66A4", VA = "0x45E66A4")]
    public ArenaSettingsListItem()
    {
    }
  }
}
