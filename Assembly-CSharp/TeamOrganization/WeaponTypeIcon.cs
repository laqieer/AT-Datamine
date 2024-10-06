// Decompiled with JetBrains decompiler
// Type: TeamOrganization.WeaponTypeIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000810")]
  public class WeaponTypeIcon : MonoBehaviour
  {
    [Token(Token = "0x400262C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image iconImage;

    [Token(Token = "0x6002E3F")]
    [Address(RVA = "0x3A92590", Offset = "0x3A92590", VA = "0x3A92590", Slot = "4")]
    public virtual void SetIcon(Sprite sprite)
    {
    }

    [Token(Token = "0x6002E40")]
    [Address(RVA = "0x3A92624", Offset = "0x3A92624", VA = "0x3A92624")]
    public WeaponTypeIcon()
    {
    }
  }
}
