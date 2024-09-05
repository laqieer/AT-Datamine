// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.ScheduleList.Model
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Data;
using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using Scenes.Story.PocketBook.StoryIndex.ActionList;
using System;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.ScheduleList
{
  [Token(Token = "0x2002DED")]
  public class Model
  {
    [Token(Token = "0x400C560")]
    [FieldOffset(Offset = "0x50")]
    private CurrentFreeActionParam current;
    [Token(Token = "0x400C561")]
    [FieldOffset(Offset = "0x58")]
    private FreeMapUIParamBase highlight;

    [Token(Token = "0x17003D40")]
    public ShowFlag ShowFlag
    {
      [Token(Token = "0x6011F39"), Address(RVA = "0x43745D8", Offset = "0x43745D8", VA = "0x43745D8")] get
      {
        return (ShowFlag) null;
      }
    }

    [Token(Token = "0x1400015C")]
    public event Action<CurrentFreeActionParam> OnSet
    {
      [Token(Token = "0x6011F3A"), Address(RVA = "0x4372B68", Offset = "0x4372B68", VA = "0x4372B68")] add
      {
      }
      [Token(Token = "0x6011F3B"), Address(RVA = "0x43745E0", Offset = "0x43745E0", VA = "0x43745E0")] remove
      {
      }
    }

    [Token(Token = "0x1400015D")]
    public event Action<Presenter.IsShow> OnShow
    {
      [Token(Token = "0x6011F3C"), Address(RVA = "0x4372C18", Offset = "0x4372C18", VA = "0x4372C18")] add
      {
      }
      [Token(Token = "0x6011F3D"), Address(RVA = "0x4374690", Offset = "0x4374690", VA = "0x4374690")] remove
      {
      }
    }

    [Token(Token = "0x1400015E")]
    public event Action<FreeMapUIParamBase> OnHighlight
    {
      [Token(Token = "0x6011F3E"), Address(RVA = "0x4372CC8", Offset = "0x4372CC8", VA = "0x4372CC8")] add
      {
      }
      [Token(Token = "0x6011F3F"), Address(RVA = "0x4374740", Offset = "0x4374740", VA = "0x4374740")] remove
      {
      }
    }

    [Token(Token = "0x1400015F")]
    public event Action OnHighlightClear
    {
      [Token(Token = "0x6011F40"), Address(RVA = "0x4372D78", Offset = "0x4372D78", VA = "0x4372D78")] add
      {
      }
      [Token(Token = "0x6011F41"), Address(RVA = "0x43747F0", Offset = "0x43747F0", VA = "0x43747F0")] remove
      {
      }
    }

    [Token(Token = "0x14000160")]
    public event Action<FreeMapUIParamBase> OnFocus
    {
      [Token(Token = "0x6011F42"), Address(RVA = "0x4372E14", Offset = "0x4372E14", VA = "0x4372E14")] add
      {
      }
      [Token(Token = "0x6011F43"), Address(RVA = "0x437488C", Offset = "0x437488C", VA = "0x437488C")] remove
      {
      }
    }

    [Token(Token = "0x14000161")]
    public event Action<FreeMapUIParamBase> OnClickSchedule
    {
      [Token(Token = "0x6011F44"), Address(RVA = "0x437493C", Offset = "0x437493C", VA = "0x437493C")] add
      {
      }
      [Token(Token = "0x6011F45"), Address(RVA = "0x43749EC", Offset = "0x43749EC", VA = "0x43749EC")] remove
      {
      }
    }

    [Token(Token = "0x17003D41")]
    public Func<bool> IsShowTab
    {
      [Token(Token = "0x6011F46"), Address(RVA = "0x4374A9C", Offset = "0x4374A9C", VA = "0x4374A9C")] private get
      {
        return (Func<bool>) null;
      }
      [Token(Token = "0x6011F47"), Address(RVA = "0x4374AA4", Offset = "0x4374AA4", VA = "0x4374AA4")] set
      {
      }
    }

    [Token(Token = "0x6011F48")]
    [Address(RVA = "0x4374AAC", Offset = "0x4374AAC", VA = "0x4374AAC")]
    public Model()
    {
    }

    [Token(Token = "0x6011F49")]
    [Address(RVA = "0x4374B3C", Offset = "0x4374B3C", VA = "0x4374B3C")]
    public void Set(CurrentFreeActionParam current)
    {
    }

    [Token(Token = "0x6011F4A")]
    [Address(RVA = "0x4374B5C", Offset = "0x4374B5C", VA = "0x4374B5C")]
    public void Show()
    {
    }

    [Token(Token = "0x6011F4B")]
    [Address(RVA = "0x4374BF4", Offset = "0x4374BF4", VA = "0x4374BF4")]
    public bool IsShow(FreeMapUIParamBase param) => new bool();

    [Token(Token = "0x6011F4C")]
    [Address(RVA = "0x4374D50", Offset = "0x4374D50", VA = "0x4374D50")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6011F4D")]
    [Address(RVA = "0x4374DB8", Offset = "0x4374DB8", VA = "0x4374DB8")]
    public void HighlightToggle(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x6011F4E")]
    [Address(RVA = "0x4374E28", Offset = "0x4374E28", VA = "0x4374E28")]
    public void Highlight(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x6011F4F")]
    [Address(RVA = "0x4374D68", Offset = "0x4374D68", VA = "0x4374D68")]
    public void HighlightClear()
    {
    }

    [Token(Token = "0x6011F50")]
    [Address(RVA = "0x4374E8C", Offset = "0x4374E8C", VA = "0x4374E8C")]
    public void Focus(FreeMapUIParamBase target)
    {
    }

    [Token(Token = "0x6011F51")]
    [Address(RVA = "0x4374EF8", Offset = "0x4374EF8", VA = "0x4374EF8")]
    public void InvokeOnClickSchedule(FreeMapUIParamBase param)
    {
    }
  }
}
