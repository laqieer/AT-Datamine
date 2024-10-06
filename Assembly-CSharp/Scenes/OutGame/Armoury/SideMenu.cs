// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.SideMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Armoury
{
  [Token(Token = "0x200381F")]
  public class SideMenu : MonoBehaviour
  {
    [Token(Token = "0x400F4E0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button[] menuButton;
    [Token(Token = "0x400F4E1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup menuButtonTween;
    [Token(Token = "0x400F4E2")]
    [FieldOffset(Offset = "0x28")]
    private ArmouryScreenType cursor;
    [Token(Token = "0x400F4E3")]
    [FieldOffset(Offset = "0x2C")]
    private int belowScreenValue;
    [Token(Token = "0x400F4E4")]
    [FieldOffset(Offset = "0x30")]
    private ArmouryScreenType _next;

    [Token(Token = "0x60160F7")]
    [Address(RVA = "0x20ED3E8", Offset = "0x20ED3E8", VA = "0x20ED3E8")]
    public void Initialize(ArmouryScreenType type, Action<ArmouryScreenType> onClickAction)
    {
    }

    [Token(Token = "0x60160F8")]
    [Address(RVA = "0x20ED4A8", Offset = "0x20ED4A8", VA = "0x20ED4A8")]
    public void UpdateSideMenu()
    {
    }

    [Token(Token = "0x60160F9")]
    [Address(RVA = "0x20ED430", Offset = "0x20ED430", VA = "0x20ED430")]
    public IEnumerator ChangeSideMenu(ArmouryScreenType type) => (IEnumerator) null;

    [Token(Token = "0x60160FA")]
    [Address(RVA = "0x20EF2F8", Offset = "0x20EF2F8", VA = "0x20EF2F8")]
    private void InitializeSideMenuButton(Action<ArmouryScreenType> onClickAction)
    {
    }

    [Token(Token = "0x60160FB")]
    [Address(RVA = "0x20EF818", Offset = "0x20EF818", VA = "0x20EF818")]
    private void SelectSideMenu(ArmouryScreenType type)
    {
    }

    [Token(Token = "0x60160FC")]
    [Address(RVA = "0x20EFA40", Offset = "0x20EFA40", VA = "0x20EFA40")]
    private IEnumerator OnClickSideMenu(
      Action<ArmouryScreenType> onClickAction,
      ArmouryScreenType type)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60160FD")]
    [Address(RVA = "0x20EF840", Offset = "0x20EF840", VA = "0x20EF840")]
    private void UpdateBadge()
    {
    }

    [Token(Token = "0x60160FE")]
    [Address(RVA = "0x20EFAE8", Offset = "0x20EFAE8", VA = "0x20EFAE8")]
    private IEnumerator SideMenuSelectOut(ArmouryScreenType type) => (IEnumerator) null;

    [Token(Token = "0x60160FF")]
    [Address(RVA = "0x20EFB88", Offset = "0x20EFB88", VA = "0x20EFB88")]
    public SideMenu()
    {
    }

    [Token(Token = "0x2003820")]
    public class SideMenuTweenName
    {
      [Token(Token = "0x400F4E5")]
      public const string CharaIn = "SideMenu_1_Chara_In";
      [Token(Token = "0x400F4E6")]
      public const string CharaOut = "SideMenu_1_Chara_Out";
      [Token(Token = "0x400F4E7")]
      public const string StyleIn = "SideMenu_2_In";
      [Token(Token = "0x400F4E8")]
      public const string StyleOut = "SideMenu_2_Out";
      [Token(Token = "0x400F4E9")]
      public const string WeaponIn = "SideMenu_3_In";
      [Token(Token = "0x400F4EA")]
      public const string WeaponOut = "SideMenu_3_Out";
      [Token(Token = "0x400F4EB")]
      public const string AccessoryIn = "SideMenu_4_In";
      [Token(Token = "0x400F4EC")]
      public const string AccessoryOut = "SideMenu_4_Out";
      [Token(Token = "0x400F4ED")]
      public const string MindEquipmentIn = "SideMenu_5_In";
      [Token(Token = "0x400F4EE")]
      public const string MindEquipmentOut = "SideMenu_5_Out";
      [Token(Token = "0x400F4EF")]
      public const string TrustIn = "SideMenu_6_In";
      [Token(Token = "0x400F4F0")]
      public const string TrustOut = "SideMenu_6_Out";
      [Token(Token = "0x400F4F1")]
      public const string CustomSkillIn = "SideMenu_7_In";
      [Token(Token = "0x400F4F2")]
      public const string CustomSkillOut = "SideMenu_7_Out";
      [Token(Token = "0x400F4F3")]
      public const string ItemIn = "SideMenu_8_In";
      [Token(Token = "0x400F4F4")]
      public const string ItemOut = "SideMenu_8_Out";

      [Token(Token = "0x6016100")]
      [Address(RVA = "0x20EFB9C", Offset = "0x20EFB9C", VA = "0x20EFB9C")]
      public static string GetTweenInName(ArmouryScreenType type) => (string) null;

      [Token(Token = "0x6016101")]
      [Address(RVA = "0x20EFCB4", Offset = "0x20EFCB4", VA = "0x20EFCB4")]
      public static string GetTweenOutName(ArmouryScreenType type) => (string) null;

      [Token(Token = "0x6016102")]
      [Address(RVA = "0x20EFDCC", Offset = "0x20EFDCC", VA = "0x20EFDCC")]
      public SideMenuTweenName()
      {
      }
    }
  }
}
