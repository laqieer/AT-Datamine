// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.ScheduleList.UI.ScheduleListCategory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.ScheduleList.UI
{
  [Token(Token = "0x2002DFA")]
  public class ScheduleListCategory : MonoBehaviour, Scenes.Story.PocketBook.StoryIndex.InstanceHandler<ScheduleListCategory>.IManaged
  {
    [Token(Token = "0x400C57D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ScheduleListElement element;
    [Token(Token = "0x400C57E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private HorizontalLayoutGroup horizontal;

    [Token(Token = "0x17003D46")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6011F89"), Address(RVA = "0x4376FA4", Offset = "0x4376FA4", VA = "0x4376FA4")] get
      {
        return (RectTransform) null;
      }
      [Token(Token = "0x6011F8A"), Address(RVA = "0x4376FAC", Offset = "0x4376FAC", VA = "0x4376FAC")] private set
      {
      }
    }

    [Token(Token = "0x6011F8B")]
    [Address(RVA = "0x4376FB4", Offset = "0x4376FB4", VA = "0x4376FB4")]
    public Vector2 GetElementSize() => new Vector2();

    [Token(Token = "0x6011F8C")]
    [Address(RVA = "0x4377058", Offset = "0x4377058", VA = "0x4377058", Slot = "4")]
    private void Scenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EInstanceHandler\u003CScenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EScheduleList\u002EUI\u002EScheduleListCategory\u003E\u002EIManaged\u002EOnInitialize()
    {
    }

    [Token(Token = "0x6011F8D")]
    [Address(RVA = "0x43771C0", Offset = "0x43771C0", VA = "0x43771C0", Slot = "5")]
    private void Scenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EInstanceHandler\u003CScenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EScheduleList\u002EUI\u002EScheduleListCategory\u003E\u002EIManaged\u002EOnRelease()
    {
    }

    [Token(Token = "0x6011F8E")]
    [Address(RVA = "0x437705C", Offset = "0x437705C", VA = "0x437705C")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6011F8F")]
    [Address(RVA = "0x43771C4", Offset = "0x43771C4", VA = "0x43771C4")]
    public void Release()
    {
    }

    [Token(Token = "0x6011F90")]
    [Address(RVA = "0x43771E8", Offset = "0x43771E8", VA = "0x43771E8")]
    public void Show(bool show)
    {
    }

    [Token(Token = "0x6011F91")]
    [Address(RVA = "0x4377310", Offset = "0x4377310", VA = "0x4377310")]
    private void OnValidate()
    {
    }

    [Token(Token = "0x6011F92")]
    [Address(RVA = "0x437622C", Offset = "0x437622C", VA = "0x437622C")]
    public ScheduleListElement GetElement() => (ScheduleListElement) null;

    [Token(Token = "0x6011F93")]
    [Address(RVA = "0x437744C", Offset = "0x437744C", VA = "0x437744C")]
    public ScheduleListCategory()
    {
    }

    [Token(Token = "0x2002DFB")]
    public class InstanceHandler : Scenes.Story.PocketBook.StoryIndex.InstanceHandler<ScheduleListCategory>
    {
      [Token(Token = "0x400C580")]
      [FieldOffset(Offset = "0x20")]
      private ScheduleListCategory origin;
      [Token(Token = "0x400C581")]
      [FieldOffset(Offset = "0x28")]
      private Transform parent;

      [Token(Token = "0x6011F94")]
      [Address(RVA = "0x4377454", Offset = "0x4377454", VA = "0x4377454")]
      public InstanceHandler(ScheduleListCategory origin, Transform parent)
      {
      }

      [Token(Token = "0x6011F95")]
      [Address(RVA = "0x4376188", Offset = "0x4376188", VA = "0x4376188")]
      public ScheduleListCategory GetCategoryInstance() => (ScheduleListCategory) null;
    }
  }
}
