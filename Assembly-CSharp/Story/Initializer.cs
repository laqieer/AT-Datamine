// Decompiled with JetBrains decompiler
// Type: Story.Initializer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using StaqData;
using System.Collections;

#nullable disable
namespace Story
{
  [Token(Token = "0x200057F")]
  public class Initializer : IContentTask
  {
    [Token(Token = "0x17000464")]
    public ContentTaskQueue TaskQueue
    {
      [Token(Token = "0x6001FC2"), Address(RVA = "0x2A04CF8", Offset = "0x2A04CF8", VA = "0x2A04CF8")] get
      {
        return (ContentTaskQueue) null;
      }
    }

    [Token(Token = "0x6001FC3")]
    [Address(RVA = "0x2A04D00", Offset = "0x2A04D00", VA = "0x2A04D00")]
    public static Initializer Create(PlayingStoryInfo playingStory) => (Initializer) null;

    [Token(Token = "0x6001FC4")]
    [Address(RVA = "0x2A04E7C", Offset = "0x2A04E7C", VA = "0x2A04E7C")]
    private Initializer()
    {
    }

    [Token(Token = "0x6001FC5")]
    [Address(RVA = "0x2A04FC4", Offset = "0x2A04FC4", VA = "0x2A04FC4", Slot = "4")]
    private IEnumerator Story\u002EIContentTask\u002EStart() => (IEnumerator) null;

    [Token(Token = "0x6001FC6")]
    [Address(RVA = "0x2A05054", Offset = "0x2A05054", VA = "0x2A05054", Slot = "5")]
    private void Story\u002EIContentTask\u002EUpdate()
    {
    }

    [Token(Token = "0x6001FC7")]
    [Address(RVA = "0x2A0506C", Offset = "0x2A0506C", VA = "0x2A0506C", Slot = "6")]
    private bool Story\u002EIContentTask\u002EIsBusy() => new bool();

    [Token(Token = "0x2000580")]
    public class InitializeStoryText : IContentTask
    {
      [Token(Token = "0x4001C1B")]
      [FieldOffset(Offset = "0x10")]
      private bool loaded;

      [Token(Token = "0x6001FC8")]
      [Address(RVA = "0x2A05090", Offset = "0x2A05090", VA = "0x2A05090", Slot = "6")]
      private bool Story\u002EIContentTask\u002EIsBusy() => new bool();

      [Token(Token = "0x6001FC9")]
      [Address(RVA = "0x2A050A0", Offset = "0x2A050A0", VA = "0x2A050A0", Slot = "4")]
      private IEnumerator Story\u002EIContentTask\u002EStart() => (IEnumerator) null;

      [Token(Token = "0x6001FCA")]
      [Address(RVA = "0x2A05130", Offset = "0x2A05130", VA = "0x2A05130", Slot = "5")]
      private void Story\u002EIContentTask\u002EUpdate()
      {
      }

      [Token(Token = "0x6001FCB")]
      [Address(RVA = "0x2A04FB4", Offset = "0x2A04FB4", VA = "0x2A04FB4")]
      public InitializeStoryText()
      {
      }
    }

    [Token(Token = "0x2000582")]
    public class InitializeStoryUI : IContentTask
    {
      [Token(Token = "0x4001C1F")]
      [FieldOffset(Offset = "0x10")]
      private bool loaded;

      [Token(Token = "0x6001FD2")]
      [Address(RVA = "0x2A051F0", Offset = "0x2A051F0", VA = "0x2A051F0", Slot = "6")]
      private bool Story\u002EIContentTask\u002EIsBusy() => new bool();

      [Token(Token = "0x6001FD3")]
      [Address(RVA = "0x2A05200", Offset = "0x2A05200", VA = "0x2A05200", Slot = "4")]
      private IEnumerator Story\u002EIContentTask\u002EStart() => (IEnumerator) null;

      [Token(Token = "0x6001FD4")]
      [Address(RVA = "0x2A05290", Offset = "0x2A05290", VA = "0x2A05290", Slot = "5")]
      private void Story\u002EIContentTask\u002EUpdate()
      {
      }

      [Token(Token = "0x6001FD5")]
      [Address(RVA = "0x2A04FBC", Offset = "0x2A04FBC", VA = "0x2A04FBC")]
      public InitializeStoryUI()
      {
      }
    }

    [Token(Token = "0x2000584")]
    public class ApiStory : IContentTask
    {
      [Token(Token = "0x4001C23")]
      [FieldOffset(Offset = "0x10")]
      private StoryID storyID;
      [Token(Token = "0x4001C24")]
      [FieldOffset(Offset = "0x18")]
      private APIStory api;
      [Token(Token = "0x4001C25")]
      [FieldOffset(Offset = "0x20")]
      private APIStoryRequest request;

      [Token(Token = "0x6001FDC")]
      [Address(RVA = "0x2A04EE8", Offset = "0x2A04EE8", VA = "0x2A04EE8")]
      public ApiStory(StoryID storyID)
      {
      }

      [Token(Token = "0x6001FDD")]
      [Address(RVA = "0x2A055A4", Offset = "0x2A055A4", VA = "0x2A055A4", Slot = "6")]
      public bool IsBusy() => new bool();

      [Token(Token = "0x6001FDE")]
      [Address(RVA = "0x2A055B4", Offset = "0x2A055B4", VA = "0x2A055B4", Slot = "4")]
      public IEnumerator Start() => (IEnumerator) null;

      [Token(Token = "0x6001FDF")]
      [Address(RVA = "0x2A05644", Offset = "0x2A05644", VA = "0x2A05644", Slot = "5")]
      private void Story\u002EIContentTask\u002EUpdate()
      {
      }
    }

    [Token(Token = "0x2000586")]
    public class LoadLocalData : IContentTask
    {
      [Token(Token = "0x6001FE7")]
      [Address(RVA = "0x2A057FC", Offset = "0x2A057FC", VA = "0x2A057FC", Slot = "6")]
      private bool Story\u002EIContentTask\u002EIsBusy() => new bool();

      [Token(Token = "0x6001FE8")]
      [Address(RVA = "0x2A05804", Offset = "0x2A05804", VA = "0x2A05804", Slot = "4")]
      private IEnumerator Story\u002EIContentTask\u002EStart() => (IEnumerator) null;

      [Token(Token = "0x6001FE9")]
      [Address(RVA = "0x2A0588C", Offset = "0x2A0588C", VA = "0x2A0588C", Slot = "5")]
      private void Story\u002EIContentTask\u002EUpdate()
      {
      }

      [Token(Token = "0x6001FEA")]
      [Address(RVA = "0x2A04EE0", Offset = "0x2A04EE0", VA = "0x2A04EE0")]
      public LoadLocalData()
      {
      }
    }
  }
}
