// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.ActionList.UI.ActionListElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Story.PocketBook.StoryIndex.Common.UI;
using UI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.ActionList.UI
{
  [Token(Token = "0x2002E48")]
  public class ActionListElement : MonoBehaviour, InstanceHandler<ActionListElement>.IManaged
  {
    [Token(Token = "0x400C681")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ActionIcon actionIcon;
    [Token(Token = "0x400C682")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextAccessor title;
    [Token(Token = "0x400C683")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button button;

    [Token(Token = "0x17003D84")]
    public ActionIcon ActionIcon
    {
      [Token(Token = "0x6012177"), Address(RVA = "0x4384E00", Offset = "0x4384E00", VA = "0x4384E00")] get
      {
        return (ActionIcon) null;
      }
    }

    [Token(Token = "0x6012178")]
    [Address(RVA = "0x4384E08", Offset = "0x4384E08", VA = "0x4384E08")]
    public Button GetButton() => (Button) null;

    [Token(Token = "0x6012179")]
    [Address(RVA = "0x43844C0", Offset = "0x43844C0", VA = "0x43844C0")]
    public void SetTitle(string text)
    {
    }

    [Token(Token = "0x601217A")]
    [Address(RVA = "0x4384E10", Offset = "0x4384E10", VA = "0x4384E10", Slot = "4")]
    private void Scenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EInstanceHandler\u003CScenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EActionList\u002EUI\u002EActionListElement\u003E\u002EIManaged\u002EOnInitialize()
    {
    }

    [Token(Token = "0x601217B")]
    [Address(RVA = "0x4384E34", Offset = "0x4384E34", VA = "0x4384E34", Slot = "5")]
    private void Scenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EInstanceHandler\u003CScenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EActionList\u002EUI\u002EActionListElement\u003E\u002EIManaged\u002EOnRelease()
    {
    }

    [Token(Token = "0x601217C")]
    [Address(RVA = "0x4384E58", Offset = "0x4384E58", VA = "0x4384E58")]
    private void OnValidate()
    {
    }

    [Token(Token = "0x601217D")]
    [Address(RVA = "0x4384EF8", Offset = "0x4384EF8", VA = "0x4384EF8")]
    public ActionListElement()
    {
    }
  }
}
