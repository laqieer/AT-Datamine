// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.CrabWalkCtrl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using TeamOrganization;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x200328C")]
  public class CrabWalkCtrl
  {
    [Token(Token = "0x400D864")]
    private const string TweenGroupName = "WeaponChange";
    [Token(Token = "0x400D865")]
    [FieldOffset(Offset = "0x10")]
    private UITweenGroup _tweenGroup;
    [Token(Token = "0x400D866")]
    [FieldOffset(Offset = "0x18")]
    private UITweenContainer _tweenContainer;
    [Token(Token = "0x400D867")]
    [FieldOffset(Offset = "0x20")]
    private CrabWalkCtrl.State _state;

    [Token(Token = "0x17004174")]
    private static CrabWalkCtrl.Param StateInit
    {
      [Token(Token = "0x6013B64"), Address(RVA = "0x185CBC0", Offset = "0x185CBC0", VA = "0x185CBC0")] get
      {
        return new CrabWalkCtrl.Param();
      }
    }

    [Token(Token = "0x17004175")]
    private static CrabWalkCtrl.Param StateVision
    {
      [Token(Token = "0x6013B65"), Address(RVA = "0x185CC18", Offset = "0x185CC18", VA = "0x185CC18")] get
      {
        return new CrabWalkCtrl.Param();
      }
    }

    [Token(Token = "0x17004176")]
    private static CrabWalkCtrl.Param StateAccessories
    {
      [Token(Token = "0x6013B66"), Address(RVA = "0x185CC3C", Offset = "0x185CC3C", VA = "0x185CC3C")] get
      {
        return new CrabWalkCtrl.Param();
      }
    }

    [Token(Token = "0x17004177")]
    private static CrabWalkCtrl.Param StateStyle
    {
      [Token(Token = "0x6013B67"), Address(RVA = "0x185CC60", Offset = "0x185CC60", VA = "0x185CC60")] get
      {
        return new CrabWalkCtrl.Param();
      }
    }

    [Token(Token = "0x17004178")]
    private static CrabWalkCtrl.Param StateTrust
    {
      [Token(Token = "0x6013B68"), Address(RVA = "0x185CC84", Offset = "0x185CC84", VA = "0x185CC84")] get
      {
        return new CrabWalkCtrl.Param();
      }
    }

    [Token(Token = "0x17004179")]
    private static CrabWalkCtrl.Param StateWeapon
    {
      [Token(Token = "0x6013B69"), Address(RVA = "0x185CCA8", Offset = "0x185CCA8", VA = "0x185CCA8")] get
      {
        return new CrabWalkCtrl.Param();
      }
    }

    [Token(Token = "0x6013B6A")]
    [Address(RVA = "0x185CCCC", Offset = "0x185CCCC", VA = "0x185CCCC")]
    public CrabWalkCtrl(UITweenGroup tweenGroup)
    {
    }

    [Token(Token = "0x6013B6B")]
    [Address(RVA = "0x185CE58", Offset = "0x185CE58", VA = "0x185CE58")]
    public void Play(CrabWalkCtrl.State from, CrabWalkCtrl.State to)
    {
    }

    [Token(Token = "0x6013B6C")]
    [Address(RVA = "0x185D524", Offset = "0x185D524", VA = "0x185D524")]
    public void Play(CrabWalkCtrl.State to)
    {
    }

    [Token(Token = "0x6013B6D")]
    [Address(RVA = "0x185D534", Offset = "0x185D534", VA = "0x185D534")]
    public void PlayInit()
    {
    }

    [Token(Token = "0x6013B6E")]
    [Address(RVA = "0x185D540", Offset = "0x185D540", VA = "0x185D540")]
    public void PlayStlye()
    {
    }

    [Token(Token = "0x6013B6F")]
    [Address(RVA = "0x185D54C", Offset = "0x185D54C", VA = "0x185D54C")]
    public void Play(
      OrganizationEquipmentSlot.EquipmentSlotType slotType)
    {
    }

    [Token(Token = "0x6013B70")]
    [Address(RVA = "0x185D078", Offset = "0x185D078", VA = "0x185D078")]
    private void UpdateParam(in CrabWalkCtrl.Param from, in CrabWalkCtrl.Param to)
    {
    }

    [Token(Token = "0x6013B71")]
    [Address(RVA = "0x185CFE4", Offset = "0x185CFE4", VA = "0x185CFE4")]
    private static CrabWalkCtrl.Param GetParam(CrabWalkCtrl.State state)
    {
      return new CrabWalkCtrl.Param();
    }

    [Token(Token = "0x6013B72")]
    [Address(RVA = "0x185D570", Offset = "0x185D570", VA = "0x185D570")]
    private static CrabWalkCtrl.State ToState(
      OrganizationEquipmentSlot.EquipmentSlotType slotType)
    {
      return new CrabWalkCtrl.State();
    }

    [Token(Token = "0x200328D")]
    public enum State
    {
      [Token(Token = "0x400D869")] Init,
      [Token(Token = "0x400D86A")] Vision,
      [Token(Token = "0x400D86B")] Accessories,
      [Token(Token = "0x400D86C")] Style,
      [Token(Token = "0x400D86D")] Trust,
      [Token(Token = "0x400D86E")] Weapon,
    }

    [Token(Token = "0x200328E")]
    private readonly struct Param
    {
      [Token(Token = "0x400D86F")]
      [FieldOffset(Offset = "0x0")]
      public readonly Vector2 ScrollView_Party;
      [Token(Token = "0x400D870")]
      [FieldOffset(Offset = "0x8")]
      public readonly Vector2 Img_Icon_Lock;
      [Token(Token = "0x400D871")]
      [FieldOffset(Offset = "0x10")]
      public readonly Vector2 Img_Line_Upper;
      [Token(Token = "0x400D872")]
      [FieldOffset(Offset = "0x18")]
      public readonly Vector2 Img_Line_Under;
      [Token(Token = "0x400D873")]
      [FieldOffset(Offset = "0x20")]
      public readonly Vector2 Prev;
      [Token(Token = "0x400D874")]
      [FieldOffset(Offset = "0x28")]
      public readonly Vector2 Next;

      [Token(Token = "0x6013B73")]
      [Address(RVA = "0x185CBE4", Offset = "0x185CBE4", VA = "0x185CBE4")]
      public Param(
        in Vector2 scrollViewParty,
        in Vector2 imgIconLock,
        in Vector2 imgIconUppder,
        in Vector2 imgLineUnder,
        in Vector2 prev,
        in Vector2 next)
      {
      }
    }
  }
}
