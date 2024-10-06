// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.ScheduleList.UI.ScheduleListElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.ScheduleList.UI
{
  [Token(Token = "0x2002DFE")]
  public class ScheduleListElement : 
    MonoBehaviour,
    ScheduleListElement.IFullUI,
    ScheduleListElement.IMinimumUI
  {
    [Token(Token = "0x400C589")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400C58A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextAccessor title;
    [Token(Token = "0x400C58B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image chara;
    [Token(Token = "0x400C58C")]
    [FieldOffset(Offset = "0x30")]
    [Header("背景画像")]
    [SerializeField]
    private Image bg;
    [Token(Token = "0x400C58D")]
    [FieldOffset(Offset = "0x38")]
    [Header("背景スプライト")]
    [SerializeField]
    private BannerBG banners;
    [Token(Token = "0x400C58E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [Header("アイコン")]
    private BannerIcon bannerIcon;
    [Token(Token = "0x400C58F")]
    [FieldOffset(Offset = "0x48")]
    private StateMachine<ScheduleListElement> style;
    [Token(Token = "0x400C590")]
    [FieldOffset(Offset = "0x50")]
    private StateMachine<ScheduleListElement> grayout;

    [Token(Token = "0x14000164")]
    public event Action OnClick
    {
      [Token(Token = "0x6011F9C"), Address(RVA = "0x4375ED0", Offset = "0x4375ED0", VA = "0x4375ED0")] add
      {
      }
      [Token(Token = "0x6011F9D"), Address(RVA = "0x43774E4", Offset = "0x43774E4", VA = "0x43774E4")] remove
      {
      }
    }

    [Token(Token = "0x6011F9E")]
    [Address(RVA = "0x4377394", Offset = "0x4377394", VA = "0x4377394")]
    public void OnInitialize()
    {
    }

    [Token(Token = "0x6011F9F")]
    [Address(RVA = "0x4377580", Offset = "0x4377580", VA = "0x4377580")]
    public void OnRelease()
    {
    }

    [Token(Token = "0x17003D4B")]
    public Rect Rect
    {
      [Token(Token = "0x6011FA0"), Address(RVA = "0x4376FF0", Offset = "0x4376FF0", VA = "0x4376FF0")] get
      {
        return new Rect();
      }
    }

    [Token(Token = "0x6011FA1")]
    [Address(RVA = "0x43775A4", Offset = "0x43775A4", VA = "0x43775A4", Slot = "9")]
    public void SetTitle(string text)
    {
    }

    [Token(Token = "0x6011FA2")]
    [Address(RVA = "0x43775C0", Offset = "0x43775C0", VA = "0x43775C0", Slot = "6")]
    public void SetSprite(Sprite sprite)
    {
    }

    [Token(Token = "0x6011FA3")]
    [Address(RVA = "0x4377600", Offset = "0x4377600", VA = "0x4377600", Slot = "7")]
    public void SpriteOff()
    {
    }

    [Token(Token = "0x6011FA4")]
    [Address(RVA = "0x4377694", Offset = "0x4377694", VA = "0x4377694", Slot = "8")]
    public void DisplayIcon(
      ScheduleListElement.IFullUI.IconDisplayParameter param)
    {
    }

    [Token(Token = "0x6011FA5")]
    [Address(RVA = "0x437772C", Offset = "0x437772C", VA = "0x437772C", Slot = "10")]
    public void ChangeStyle(ScheduleListElement.Style style)
    {
    }

    [Token(Token = "0x6011FA6")]
    [Address(RVA = "0x4377838", Offset = "0x4377838", VA = "0x4377838")]
    public void Show(bool value)
    {
    }

    [Token(Token = "0x6011FA7")]
    [Address(RVA = "0x4377250", Offset = "0x4377250", VA = "0x4377250")]
    public void Show()
    {
    }

    [Token(Token = "0x6011FA8")]
    [Address(RVA = "0x4377308", Offset = "0x4377308", VA = "0x4377308")]
    public void Hide()
    {
    }

    [Token(Token = "0x6011FA9")]
    [Address(RVA = "0x4377B40", Offset = "0x4377B40", VA = "0x4377B40")]
    public void Grayout(bool isGray)
    {
    }

    [Token(Token = "0x6011FAA")]
    [Address(RVA = "0x4377848", Offset = "0x4377848", VA = "0x4377848")]
    private void Childs(bool active)
    {
    }

    [Token(Token = "0x6011FAB")]
    [Address(RVA = "0x4377C30", Offset = "0x4377C30", VA = "0x4377C30")]
    private void Update()
    {
    }

    [Token(Token = "0x6011FAC")]
    [Address(RVA = "0x4377CA8", Offset = "0x4377CA8", VA = "0x4377CA8")]
    public void UnityEventOnClick()
    {
    }

    [Token(Token = "0x6011FAD")]
    [Address(RVA = "0x4377CC4", Offset = "0x4377CC4", VA = "0x4377CC4")]
    private void OnValidate()
    {
    }

    [Token(Token = "0x6011FAE")]
    [Address(RVA = "0x4377DE4", Offset = "0x4377DE4", VA = "0x4377DE4")]
    public ScheduleListElement()
    {
    }

    [Token(Token = "0x2002DFF")]
    public interface IFullUI
    {
      [Token(Token = "0x6011FAF")]
      void SetTitle(string text);

      [Token(Token = "0x6011FB0")]
      void ChangeStyle(ScheduleListElement.Style style);

      [Token(Token = "0x6011FB1")]
      void SetSprite(Sprite sprite);

      [Token(Token = "0x6011FB2")]
      void SpriteOff();

      [Token(Token = "0x6011FB3")]
      void DisplayIcon(
        ScheduleListElement.IFullUI.IconDisplayParameter param);

      [Token(Token = "0x2002E00")]
      class IconDisplayParameter
      {
        [Token(Token = "0x400C592")]
        [FieldOffset(Offset = "0x10")]
        public bool DisplayCommunityRankUp;
        [Token(Token = "0x400C593")]
        [FieldOffset(Offset = "0x11")]
        public bool DisplaySubquestUnplayable;
        [Token(Token = "0x400C594")]
        [FieldOffset(Offset = "0x12")]
        public bool DisplaySubquestCleared;

        [Token(Token = "0x6011FB4")]
        [Address(RVA = "0x437657C", Offset = "0x437657C", VA = "0x437657C")]
        public IconDisplayParameter()
        {
        }
      }
    }

    [Token(Token = "0x2002E01")]
    public interface IMinimumUI
    {
      [Token(Token = "0x6011FB5")]
      void SetTitle(string text);

      [Token(Token = "0x6011FB6")]
      void ChangeStyle(ScheduleListElement.Style style);
    }

    [Token(Token = "0x2002E02")]
    private abstract class GrayOutState : StateMachineState<ScheduleListElement>
    {
      [Token(Token = "0x6011FB7")]
      [Address(RVA = "0x4377DEC", Offset = "0x4377DEC", VA = "0x4377DEC")]
      protected GrayOutState()
      {
      }

      [Token(Token = "0x2002E03")]
      protected enum Type
      {
        [Token(Token = "0x400C596")] Normal,
        [Token(Token = "0x400C597")] Gray,
      }
    }

    [Token(Token = "0x2002E04")]
    private class StateNormal : ScheduleListElement.GrayOutState
    {
      [Token(Token = "0x6011FB8")]
      [Address(RVA = "0x4377E34", Offset = "0x4377E34", VA = "0x4377E34", Slot = "5")]
      protected override void OnEnter(ScheduleListElement entity)
      {
      }

      [Token(Token = "0x6011FB9")]
      [Address(RVA = "0x4377E90", Offset = "0x4377E90", VA = "0x4377E90", Slot = "6")]
      public override void Execute(ScheduleListElement entity, float deltaTime)
      {
      }

      [Token(Token = "0x6011FBA")]
      [Address(RVA = "0x4377E94", Offset = "0x4377E94", VA = "0x4377E94", Slot = "7")]
      public override void Exit(ScheduleListElement entity)
      {
      }

      [Token(Token = "0x6011FBB")]
      [Address(RVA = "0x4377E98", Offset = "0x4377E98", VA = "0x4377E98", Slot = "8")]
      public override int GetStateType() => new int();

      [Token(Token = "0x6011FBC")]
      [Address(RVA = "0x4377C2C", Offset = "0x4377C2C", VA = "0x4377C2C")]
      public StateNormal()
      {
      }
    }

    [Token(Token = "0x2002E05")]
    private class StateGray : ScheduleListElement.GrayOutState
    {
      [Token(Token = "0x6011FBD")]
      [Address(RVA = "0x4377EA0", Offset = "0x4377EA0", VA = "0x4377EA0", Slot = "5")]
      protected override void OnEnter(ScheduleListElement entity)
      {
      }

      [Token(Token = "0x6011FBE")]
      [Address(RVA = "0x4377EFC", Offset = "0x4377EFC", VA = "0x4377EFC", Slot = "6")]
      public override void Execute(ScheduleListElement entity, float deltaTime)
      {
      }

      [Token(Token = "0x6011FBF")]
      [Address(RVA = "0x4377F00", Offset = "0x4377F00", VA = "0x4377F00", Slot = "7")]
      public override void Exit(ScheduleListElement entity)
      {
      }

      [Token(Token = "0x6011FC0")]
      [Address(RVA = "0x4377F04", Offset = "0x4377F04", VA = "0x4377F04", Slot = "8")]
      public override int GetStateType() => new int();

      [Token(Token = "0x6011FC1")]
      [Address(RVA = "0x4377C28", Offset = "0x4377C28", VA = "0x4377C28")]
      public StateGray()
      {
      }
    }

    [Token(Token = "0x2002E06")]
    public enum Style
    {
      [Token(Token = "0x400C599")] Facility,
      [Token(Token = "0x400C59A")] Communication,
      [Token(Token = "0x400C59B")] SubQuest,
      [Token(Token = "0x400C59C")] Obliviae,
    }

    [Token(Token = "0x2002E07")]
    private abstract class StyleState : StateMachineState<ScheduleListElement>
    {
      [Token(Token = "0x6011FC2")]
      [Address(RVA = "0x4377F0C", Offset = "0x4377F0C", VA = "0x4377F0C", Slot = "9")]
      public virtual void Show(ScheduleListElement entity)
      {
      }

      [Token(Token = "0x6011FC3")]
      [Address(RVA = "0x4377F10", Offset = "0x4377F10", VA = "0x4377F10")]
      protected StyleState()
      {
      }
    }

    [Token(Token = "0x2002E08")]
    private class StateFacility : ScheduleListElement.StyleState
    {
      [Token(Token = "0x6011FC4")]
      [Address(RVA = "0x4377F58", Offset = "0x4377F58", VA = "0x4377F58", Slot = "9")]
      public override void Show(ScheduleListElement entity)
      {
      }

      [Token(Token = "0x6011FC5")]
      [Address(RVA = "0x4377FD0", Offset = "0x4377FD0", VA = "0x4377FD0", Slot = "6")]
      public override void Execute(ScheduleListElement entity, float deltaTime)
      {
      }

      [Token(Token = "0x6011FC6")]
      [Address(RVA = "0x4377FD4", Offset = "0x4377FD4", VA = "0x4377FD4", Slot = "7")]
      public override void Exit(ScheduleListElement entity)
      {
      }

      [Token(Token = "0x6011FC7")]
      [Address(RVA = "0x4377FD8", Offset = "0x4377FD8", VA = "0x4377FD8", Slot = "8")]
      public override int GetStateType() => new int();

      [Token(Token = "0x6011FC8")]
      [Address(RVA = "0x4377828", Offset = "0x4377828", VA = "0x4377828")]
      public StateFacility()
      {
      }
    }

    [Token(Token = "0x2002E09")]
    private class StateCommunication : ScheduleListElement.StyleState
    {
      [Token(Token = "0x6011FC9")]
      [Address(RVA = "0x4377FE0", Offset = "0x4377FE0", VA = "0x4377FE0", Slot = "9")]
      public override void Show(ScheduleListElement entity)
      {
      }

      [Token(Token = "0x6011FCA")]
      [Address(RVA = "0x4378058", Offset = "0x4378058", VA = "0x4378058", Slot = "6")]
      public override void Execute(ScheduleListElement entity, float deltaTime)
      {
      }

      [Token(Token = "0x6011FCB")]
      [Address(RVA = "0x437805C", Offset = "0x437805C", VA = "0x437805C", Slot = "7")]
      public override void Exit(ScheduleListElement entity)
      {
      }

      [Token(Token = "0x6011FCC")]
      [Address(RVA = "0x4378060", Offset = "0x4378060", VA = "0x4378060", Slot = "8")]
      public override int GetStateType() => new int();

      [Token(Token = "0x6011FCD")]
      [Address(RVA = "0x437782C", Offset = "0x437782C", VA = "0x437782C")]
      public StateCommunication()
      {
      }
    }

    [Token(Token = "0x2002E0A")]
    private class StateSubQuest : ScheduleListElement.StyleState
    {
      [Token(Token = "0x6011FCE")]
      [Address(RVA = "0x4378068", Offset = "0x4378068", VA = "0x4378068", Slot = "9")]
      public override void Show(ScheduleListElement entity)
      {
      }

      [Token(Token = "0x6011FCF")]
      [Address(RVA = "0x43780E0", Offset = "0x43780E0", VA = "0x43780E0", Slot = "6")]
      public override void Execute(ScheduleListElement entity, float deltaTime)
      {
      }

      [Token(Token = "0x6011FD0")]
      [Address(RVA = "0x43780E4", Offset = "0x43780E4", VA = "0x43780E4", Slot = "7")]
      public override void Exit(ScheduleListElement entity)
      {
      }

      [Token(Token = "0x6011FD1")]
      [Address(RVA = "0x43780E8", Offset = "0x43780E8", VA = "0x43780E8", Slot = "8")]
      public override int GetStateType() => new int();

      [Token(Token = "0x6011FD2")]
      [Address(RVA = "0x4377830", Offset = "0x4377830", VA = "0x4377830")]
      public StateSubQuest()
      {
      }
    }

    [Token(Token = "0x2002E0B")]
    private class StateObliviae : ScheduleListElement.StyleState
    {
      [Token(Token = "0x6011FD3")]
      [Address(RVA = "0x43780F0", Offset = "0x43780F0", VA = "0x43780F0", Slot = "9")]
      public override void Show(ScheduleListElement entity)
      {
      }

      [Token(Token = "0x6011FD4")]
      [Address(RVA = "0x4378168", Offset = "0x4378168", VA = "0x4378168", Slot = "6")]
      public override void Execute(ScheduleListElement entity, float deltaTime)
      {
      }

      [Token(Token = "0x6011FD5")]
      [Address(RVA = "0x437816C", Offset = "0x437816C", VA = "0x437816C", Slot = "7")]
      public override void Exit(ScheduleListElement entity)
      {
      }

      [Token(Token = "0x6011FD6")]
      [Address(RVA = "0x4378170", Offset = "0x4378170", VA = "0x4378170", Slot = "8")]
      public override int GetStateType() => new int();

      [Token(Token = "0x6011FD7")]
      [Address(RVA = "0x4377834", Offset = "0x4377834", VA = "0x4377834")]
      public StateObliviae()
      {
      }
    }
  }
}
