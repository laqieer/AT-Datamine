// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.ActionList.UI.ActionListUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.ActionList.UI
{
  [Token(Token = "0x2002E49")]
  public class ActionListUI : MonoBehaviour
  {
    [Token(Token = "0x400C684")]
    [FieldOffset(Offset = "0x18")]
    [Header("施設")]
    [SerializeField]
    private ActionListCategory facility;
    [Token(Token = "0x400C685")]
    [FieldOffset(Offset = "0x20")]
    [Header("コミュ")]
    [SerializeField]
    private ActionListCategory communication;
    [Token(Token = "0x400C686")]
    [FieldOffset(Offset = "0x28")]
    [Header("サブクエスト")]
    [SerializeField]
    private ActionListCategory subquest;

    [Token(Token = "0x17003D85")]
    public ActionListCategory Facility
    {
      [Token(Token = "0x601217E"), Address(RVA = "0x4384F00", Offset = "0x4384F00", VA = "0x4384F00")] get
      {
        return (ActionListCategory) null;
      }
    }

    [Token(Token = "0x17003D86")]
    public ActionListCategory Communication
    {
      [Token(Token = "0x601217F"), Address(RVA = "0x4384F08", Offset = "0x4384F08", VA = "0x4384F08")] get
      {
        return (ActionListCategory) null;
      }
    }

    [Token(Token = "0x17003D87")]
    public ActionListCategory SubQuest
    {
      [Token(Token = "0x6012180"), Address(RVA = "0x4384F10", Offset = "0x4384F10", VA = "0x4384F10")] get
      {
        return (ActionListCategory) null;
      }
    }

    [Token(Token = "0x6012181")]
    [Address(RVA = "0x4384F18", Offset = "0x4384F18", VA = "0x4384F18")]
    public ActionListUI()
    {
    }
  }
}
