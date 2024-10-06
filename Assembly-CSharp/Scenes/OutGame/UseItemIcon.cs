// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UseItemIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using TeamOrganization;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003268")]
  public class UseItemIcon : MonoBehaviour
  {
    [Token(Token = "0x400D7B8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400D7B9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image alertIcon;

    [Token(Token = "0x6013A8B")]
    [Address(RVA = "0x4622DA0", Offset = "0x4622DA0", VA = "0x4622DA0")]
    public void Set(OrganizationItemSetSlot itemSetSlot)
    {
    }

    [Token(Token = "0x6013A8C")]
    [Address(RVA = "0x4622F28", Offset = "0x4622F28", VA = "0x4622F28")]
    public void Delete()
    {
    }

    [Token(Token = "0x6013A8D")]
    [Address(RVA = "0x4622F48", Offset = "0x4622F48", VA = "0x4622F48")]
    public UseItemIcon()
    {
    }
  }
}
