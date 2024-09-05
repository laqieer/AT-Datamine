// Decompiled with JetBrains decompiler
// Type: Story.StoryPlayerBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using UnityEngine;

#nullable disable
namespace Story
{
  [Token(Token = "0x20005A5")]
  public class StoryPlayerBehaviour : MonoBehaviour
  {
    [Token(Token = "0x4001C69")]
    [FieldOffset(Offset = "0x18")]
    private StoryContentPlayDirector storyPlayDirector;

    [Token(Token = "0x6002089")]
    [Address(RVA = "0x2A08148", Offset = "0x2A08148", VA = "0x2A08148")]
    public void Initialize(PlayingStoryInfo playingStory)
    {
    }

    [Token(Token = "0x600208A")]
    [Address(RVA = "0x2A09190", Offset = "0x2A09190", VA = "0x2A09190")]
    public void Initialize(PlayingStoryInfo playingStory, IContentDirectorFactory directorFactory)
    {
    }

    [Token(Token = "0x600208B")]
    [Address(RVA = "0x2A08218", Offset = "0x2A08218", VA = "0x2A08218")]
    public void AddExternalTask(IContentTask task)
    {
    }

    [Token(Token = "0x600208C")]
    [Address(RVA = "0x2A08230", Offset = "0x2A08230", VA = "0x2A08230")]
    public void Play()
    {
    }

    [Token(Token = "0x600208D")]
    [Address(RVA = "0x2A0808C", Offset = "0x2A0808C", VA = "0x2A0808C")]
    public static StoryPlayerBehaviour Create(Transform parent) => (StoryPlayerBehaviour) null;

    [Token(Token = "0x600208E")]
    [Address(RVA = "0x2A09430", Offset = "0x2A09430", VA = "0x2A09430")]
    private void Update()
    {
    }

    [Token(Token = "0x600208F")]
    [Address(RVA = "0x2A07AAC", Offset = "0x2A07AAC", VA = "0x2A07AAC")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6002090")]
    [Address(RVA = "0x2A095D8", Offset = "0x2A095D8", VA = "0x2A095D8")]
    public StoryPlayerBehaviour()
    {
    }
  }
}
