// Decompiled with JetBrains decompiler
// Type: Scenes.Information.InformationSideMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.Information
{
  [Token(Token = "0x2002ABD")]
  public class InformationSideMenu : GlobalMenuSideListBase
  {
    [Token(Token = "0x400B5EC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CanvasGroup[] badges;

    [Token(Token = "0x6010B5D")]
    [Address(RVA = "0x4BD56EC", Offset = "0x4BD56EC", VA = "0x4BD56EC", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x6010B5E")]
    [Address(RVA = "0x4BD5C60", Offset = "0x4BD5C60", VA = "0x4BD5C60")]
    public void ShowBadge(int index, bool isEnabled)
    {
    }

    [Token(Token = "0x6010B5F")]
    [Address(RVA = "0x4BD5CB8", Offset = "0x4BD5CB8", VA = "0x4BD5CB8")]
    public InformationSideMenu()
    {
    }
  }
}
