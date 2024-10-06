// Decompiled with JetBrains decompiler
// Type: Story.Content
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System.Collections;

#nullable disable
namespace Story
{
  [Token(Token = "0x200053D")]
  public abstract class Content
  {
    [Token(Token = "0x1700041D")]
    public bool IsBusy
    {
      [Token(Token = "0x6001E55"), Address(RVA = "0x29FCE7C", Offset = "0x29FCE7C", VA = "0x29FCE7C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6001E56"), Address(RVA = "0x29FCE84", Offset = "0x29FCE84", VA = "0x29FCE84")] set
      {
      }
    }

    [Token(Token = "0x1700041E")]
    protected IStoryContentSystem ContentSystem
    {
      [Token(Token = "0x6001E57"), Address(RVA = "0x29FCE90", Offset = "0x29FCE90", VA = "0x29FCE90")] get
      {
        return (IStoryContentSystem) null;
      }
      [Token(Token = "0x6001E58"), Address(RVA = "0x29FCE98", Offset = "0x29FCE98", VA = "0x29FCE98")] private set
      {
      }
    }

    [Token(Token = "0x6001E59")]
    [Address(RVA = "0x29FCEA0", Offset = "0x29FCEA0", VA = "0x29FCEA0")]
    public void Initialize(IStoryContentSystem contentSystem)
    {
    }

    [Token(Token = "0x6001E5A")]
    [Address(RVA = "0x29FCEA8", Offset = "0x29FCEA8", VA = "0x29FCEA8")]
    public void Start()
    {
    }

    [Token(Token = "0x6001E5B")]
    [Address(RVA = "0x29FCEBC", Offset = "0x29FCEBC", VA = "0x29FCEBC", Slot = "4")]
    protected virtual void OnStart()
    {
    }

    [Token(Token = "0x6001E5C")]
    [Address(RVA = "0x29FCF78", Offset = "0x29FCF78", VA = "0x29FCF78")]
    public void Update()
    {
    }

    [Token(Token = "0x6001E5D")]
    [Address(RVA = "0x29FCF84", Offset = "0x29FCF84", VA = "0x29FCF84", Slot = "5")]
    protected virtual void OnUpdate()
    {
    }

    [Token(Token = "0x6001E5E")]
    [Address(RVA = "0x29FCF88", Offset = "0x29FCF88", VA = "0x29FCF88")]
    public void Abort()
    {
    }

    [Token(Token = "0x6001E5F")]
    [Address(RVA = "0x29FCF94", Offset = "0x29FCF94", VA = "0x29FCF94", Slot = "6")]
    protected virtual void OnAbort()
    {
    }

    [Token(Token = "0x6001E60")]
    [Address(RVA = "0x29FCF98", Offset = "0x29FCF98", VA = "0x29FCF98")]
    protected PlayingStoryInfo GetPlayingStory() => (PlayingStoryInfo) null;

    [Token(Token = "0x6001E61")]
    [Address(RVA = "0x29FD03C", Offset = "0x29FD03C", VA = "0x29FD03C", Slot = "7")]
    protected virtual IEnumerator HideLoadingPanelWait() => (IEnumerator) null;

    [Token(Token = "0x6001E62")]
    [Address(RVA = "0x29FD0C4", Offset = "0x29FD0C4", VA = "0x29FD0C4", Slot = "8")]
    protected virtual IEnumerator ShowLoadingPanelWait() => (IEnumerator) null;

    [Token(Token = "0x6001E63")]
    [Address(RVA = "0x29FCEC0", Offset = "0x29FCEC0", VA = "0x29FCEC0")]
    protected void HideLoadingPanel()
    {
    }

    [Token(Token = "0x6001E64")]
    [Address(RVA = "0x29FD14C", Offset = "0x29FD14C", VA = "0x29FD14C")]
    protected void ShowLoadingPanel()
    {
    }

    [Token(Token = "0x6001E65")]
    [Address(RVA = "0x29FD204", Offset = "0x29FD204", VA = "0x29FD204")]
    protected Content()
    {
    }
  }
}
