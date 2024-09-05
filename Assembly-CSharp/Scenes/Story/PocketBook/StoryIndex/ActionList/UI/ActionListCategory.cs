// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.ActionList.UI.ActionListCategory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.ActionList.UI
{
  [Token(Token = "0x2002E47")]
  public class ActionListCategory : MonoBehaviour
  {
    [Token(Token = "0x400C67E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ActionListElement element;
    [Token(Token = "0x400C67F")]
    [FieldOffset(Offset = "0x20")]
    private List<ActionListElement> instances;

    [Token(Token = "0x17003D83")]
    public EventData<bool> Toggle
    {
      [Token(Token = "0x601216F"), Address(RVA = "0x4384AC8", Offset = "0x4384AC8", VA = "0x4384AC8")] get
      {
        return (EventData<bool>) null;
      }
    }

    [Token(Token = "0x6012170")]
    [Address(RVA = "0x4384AD0", Offset = "0x4384AD0", VA = "0x4384AD0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6012171")]
    [Address(RVA = "0x4384778", Offset = "0x4384778", VA = "0x4384778")]
    public ActionListElement CreateInstance() => (ActionListElement) null;

    [Token(Token = "0x6012172")]
    [Address(RVA = "0x4384AFC", Offset = "0x4384AFC", VA = "0x4384AFC")]
    public void Release()
    {
    }

    [Token(Token = "0x6012173")]
    [Address(RVA = "0x4384C94", Offset = "0x4384C94", VA = "0x4384C94")]
    public void OnToggle(bool value)
    {
    }

    [Token(Token = "0x6012174")]
    [Address(RVA = "0x4384CEC", Offset = "0x4384CEC", VA = "0x4384CEC")]
    private void OnValidate()
    {
    }

    [Token(Token = "0x6012175")]
    [Address(RVA = "0x4384D3C", Offset = "0x4384D3C", VA = "0x4384D3C")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6012176")]
    [Address(RVA = "0x4384D40", Offset = "0x4384D40", VA = "0x4384D40")]
    public ActionListCategory()
    {
    }
  }
}
