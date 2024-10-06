// Decompiled with JetBrains decompiler
// Type: Home.MenuBadge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData.Badge;
using UnityEngine;

#nullable disable
namespace Home
{
  [Token(Token = "0x2000B1B")]
  public class MenuBadge : MonoBehaviour
  {
    [Token(Token = "0x400329E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private MenuBadgeDataTypeEnum menuBadgeType;
    [Token(Token = "0x400329F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject badgeObject;

    [Token(Token = "0x6003F32")]
    [Address(RVA = "0x2C1AA80", Offset = "0x2C1AA80", VA = "0x2C1AA80")]
    private void Awake()
    {
    }

    [Token(Token = "0x6003F33")]
    [Address(RVA = "0x2C1AB44", Offset = "0x2C1AB44", VA = "0x2C1AB44")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6003F34")]
    [Address(RVA = "0x2C1AC08", Offset = "0x2C1AC08", VA = "0x2C1AC08")]
    private void OnBadgeEnableChanged(bool isEnable)
    {
    }

    [Token(Token = "0x6003F35")]
    [Address(RVA = "0x2C1AC28", Offset = "0x2C1AC28", VA = "0x2C1AC28")]
    public MenuBadge()
    {
    }
  }
}
