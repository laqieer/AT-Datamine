// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Top.GuildTopTabToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.Guild.Top
{
  [Token(Token = "0x2002BAC")]
  public class GuildTopTabToggle : MonoBehaviour
  {
    [Token(Token = "0x400B9E3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject onPanel;
    [Token(Token = "0x400B9E4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject offPanel;
    [Token(Token = "0x400B9E5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject target;
    [Token(Token = "0x400B9E6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject updateIcon;

    [Token(Token = "0x60110ED")]
    [Address(RVA = "0x1C7B004", Offset = "0x1C7B004", VA = "0x1C7B004")]
    public void SetToggle(bool sw)
    {
    }

    [Token(Token = "0x60110EE")]
    [Address(RVA = "0x1C78624", Offset = "0x1C78624", VA = "0x1C78624")]
    public void SetUpdateIcon(bool sw)
    {
    }

    [Token(Token = "0x60110EF")]
    [Address(RVA = "0x1C7B060", Offset = "0x1C7B060", VA = "0x1C7B060")]
    public GuildTopTabToggle()
    {
    }
  }
}
