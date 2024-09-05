// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.ActionList.Model
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Data;
using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.ActionList
{
  [Token(Token = "0x2002E3E")]
  public class Model
  {
    [Token(Token = "0x400C668")]
    [FieldOffset(Offset = "0x30")]
    private CurrentFreeActionParam current;

    [Token(Token = "0x17003D7C")]
    public ShowFlag ShowFlag
    {
      [Token(Token = "0x6012136"), Address(RVA = "0x438361C", Offset = "0x438361C", VA = "0x438361C")] get
      {
        return (ShowFlag) null;
      }
    }

    [Token(Token = "0x14000178")]
    public event Action<CurrentFreeActionParam> OnSet
    {
      [Token(Token = "0x6012137"), Address(RVA = "0x438241C", Offset = "0x438241C", VA = "0x438241C")] add
      {
      }
      [Token(Token = "0x6012138"), Address(RVA = "0x4383624", Offset = "0x4383624", VA = "0x4383624")] remove
      {
      }
    }

    [Token(Token = "0x14000179")]
    public event Action OnRelease
    {
      [Token(Token = "0x6012139"), Address(RVA = "0x43824CC", Offset = "0x43824CC", VA = "0x43824CC")] add
      {
      }
      [Token(Token = "0x601213A"), Address(RVA = "0x43836D4", Offset = "0x43836D4", VA = "0x43836D4")] remove
      {
      }
    }

    [Token(Token = "0x1400017A")]
    public event Action<Presenter.IsShow> OnShow
    {
      [Token(Token = "0x601213B"), Address(RVA = "0x4382568", Offset = "0x4382568", VA = "0x4382568")] add
      {
      }
      [Token(Token = "0x601213C"), Address(RVA = "0x4383770", Offset = "0x4383770", VA = "0x4383770")] remove
      {
      }
    }

    [Token(Token = "0x601213D")]
    [Address(RVA = "0x4383820", Offset = "0x4383820", VA = "0x4383820")]
    public void Set(CurrentFreeActionParam freeactionParam)
    {
    }

    [Token(Token = "0x1400017B")]
    public event Action<FreeMapUIParamBase> OnClickIcon
    {
      [Token(Token = "0x601213E"), Address(RVA = "0x4383840", Offset = "0x4383840", VA = "0x4383840")] add
      {
      }
      [Token(Token = "0x601213F"), Address(RVA = "0x43838F0", Offset = "0x43838F0", VA = "0x43838F0")] remove
      {
      }
    }

    [Token(Token = "0x6012140")]
    [Address(RVA = "0x43839A0", Offset = "0x43839A0", VA = "0x43839A0")]
    public void InvokeOnClickIcon(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x1400017C")]
    public event Action<bool> OnFacilityToggle
    {
      [Token(Token = "0x6012141"), Address(RVA = "0x43839BC", Offset = "0x43839BC", VA = "0x43839BC")] add
      {
      }
      [Token(Token = "0x6012142"), Address(RVA = "0x4383A6C", Offset = "0x4383A6C", VA = "0x4383A6C")] remove
      {
      }
    }

    [Token(Token = "0x1400017D")]
    public event Action<bool> OnCommunicationToggle
    {
      [Token(Token = "0x6012143"), Address(RVA = "0x4383B1C", Offset = "0x4383B1C", VA = "0x4383B1C")] add
      {
      }
      [Token(Token = "0x6012144"), Address(RVA = "0x4383BCC", Offset = "0x4383BCC", VA = "0x4383BCC")] remove
      {
      }
    }

    [Token(Token = "0x1400017E")]
    public event Action<bool> OnSubQuestToggle
    {
      [Token(Token = "0x6012145"), Address(RVA = "0x4383C7C", Offset = "0x4383C7C", VA = "0x4383C7C")] add
      {
      }
      [Token(Token = "0x6012146"), Address(RVA = "0x4383D2C", Offset = "0x4383D2C", VA = "0x4383D2C")] remove
      {
      }
    }

    [Token(Token = "0x6012147")]
    [Address(RVA = "0x4383DDC", Offset = "0x4383DDC", VA = "0x4383DDC")]
    public void FacilityToggle(bool value)
    {
    }

    [Token(Token = "0x6012148")]
    [Address(RVA = "0x4383DFC", Offset = "0x4383DFC", VA = "0x4383DFC")]
    public void CommunicationToggle(bool value)
    {
    }

    [Token(Token = "0x6012149")]
    [Address(RVA = "0x4383E1C", Offset = "0x4383E1C", VA = "0x4383E1C")]
    public void SubQuestToggle(bool value)
    {
    }

    [Token(Token = "0x601214A")]
    [Address(RVA = "0x438350C", Offset = "0x438350C", VA = "0x438350C")]
    public void Show()
    {
    }

    [Token(Token = "0x601214B")]
    [Address(RVA = "0x4383E3C", Offset = "0x4383E3C", VA = "0x4383E3C")]
    public void Refresh()
    {
    }

    [Token(Token = "0x601214C")]
    [Address(RVA = "0x4383ED4", Offset = "0x4383ED4", VA = "0x4383ED4")]
    private bool IsShow(FreeMapUIParamBase param) => new bool();

    [Token(Token = "0x601214D")]
    [Address(RVA = "0x4384024", Offset = "0x4384024", VA = "0x4384024")]
    public Model()
    {
    }
  }
}
