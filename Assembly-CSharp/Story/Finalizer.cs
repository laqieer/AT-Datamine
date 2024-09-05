// Decompiled with JetBrains decompiler
// Type: Story.Finalizer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000577")]
  public class Finalizer : IContentTask
  {
    [Token(Token = "0x17000456")]
    public ContentTaskQueue TaskQueue
    {
      [Token(Token = "0x6001F89"), Address(RVA = "0x2A0430C", Offset = "0x2A0430C", VA = "0x2A0430C")] get
      {
        return (ContentTaskQueue) null;
      }
    }

    [Token(Token = "0x6001F8A")]
    [Address(RVA = "0x2A04314", Offset = "0x2A04314", VA = "0x2A04314")]
    private Finalizer()
    {
    }

    [Token(Token = "0x6001F8B")]
    [Address(RVA = "0x2A04378", Offset = "0x2A04378", VA = "0x2A04378")]
    public static Finalizer Create() => (Finalizer) null;

    [Token(Token = "0x6001F8C")]
    [Address(RVA = "0x2A04468", Offset = "0x2A04468", VA = "0x2A04468")]
    public static void OnDestroy()
    {
    }

    [Token(Token = "0x6001F8D")]
    [Address(RVA = "0x2A04524", Offset = "0x2A04524", VA = "0x2A04524", Slot = "4")]
    private IEnumerator Story\u002EIContentTask\u002EStart() => (IEnumerator) null;

    [Token(Token = "0x6001F8E")]
    [Address(RVA = "0x2A045B4", Offset = "0x2A045B4", VA = "0x2A045B4", Slot = "5")]
    private void Story\u002EIContentTask\u002EUpdate()
    {
    }

    [Token(Token = "0x6001F8F")]
    [Address(RVA = "0x2A045CC", Offset = "0x2A045CC", VA = "0x2A045CC", Slot = "6")]
    private bool Story\u002EIContentTask\u002EIsBusy() => new bool();

    [Token(Token = "0x2000578")]
    public class FinalizeStoryText : IContentTask
    {
      [Token(Token = "0x4001C07")]
      [FieldOffset(Offset = "0x10")]
      private bool destroyed;

      [Token(Token = "0x6001F90")]
      [Address(RVA = "0x2A045F0", Offset = "0x2A045F0", VA = "0x2A045F0", Slot = "6")]
      private bool Story\u002EIContentTask\u002EIsBusy() => new bool();

      [Token(Token = "0x6001F91")]
      [Address(RVA = "0x2A04600", Offset = "0x2A04600", VA = "0x2A04600", Slot = "4")]
      private IEnumerator Story\u002EIContentTask\u002EStart() => (IEnumerator) null;

      [Token(Token = "0x6001F92")]
      [Address(RVA = "0x2A04690", Offset = "0x2A04690", VA = "0x2A04690")]
      private void FinalizeInternal()
      {
      }

      [Token(Token = "0x6001F93")]
      [Address(RVA = "0x2A04698", Offset = "0x2A04698", VA = "0x2A04698", Slot = "5")]
      private void Story\u002EIContentTask\u002EUpdate()
      {
      }

      [Token(Token = "0x6001F94")]
      [Address(RVA = "0x2A04478", Offset = "0x2A04478", VA = "0x2A04478")]
      public static void OnDestory()
      {
      }

      [Token(Token = "0x6001F95")]
      [Address(RVA = "0x2A04458", Offset = "0x2A04458", VA = "0x2A04458")]
      public FinalizeStoryText()
      {
      }
    }

    [Token(Token = "0x200057A")]
    public class FinalizeStoryUI : IContentTask
    {
      [Token(Token = "0x4001C0B")]
      [FieldOffset(Offset = "0x10")]
      private bool destroyed;

      [Token(Token = "0x6001F9C")]
      [Address(RVA = "0x2A0472C", Offset = "0x2A0472C", VA = "0x2A0472C", Slot = "6")]
      private bool Story\u002EIContentTask\u002EIsBusy() => new bool();

      [Token(Token = "0x6001F9D")]
      [Address(RVA = "0x2A0473C", Offset = "0x2A0473C", VA = "0x2A0473C", Slot = "4")]
      private IEnumerator Story\u002EIContentTask\u002EStart() => (IEnumerator) null;

      [Token(Token = "0x6001F9E")]
      [Address(RVA = "0x2A047CC", Offset = "0x2A047CC", VA = "0x2A047CC")]
      private void FinalizeInternal()
      {
      }

      [Token(Token = "0x6001F9F")]
      [Address(RVA = "0x2A049D8", Offset = "0x2A049D8", VA = "0x2A049D8", Slot = "5")]
      private void Story\u002EIContentTask\u002EUpdate()
      {
      }

      [Token(Token = "0x6001FA0")]
      [Address(RVA = "0x2A044D0", Offset = "0x2A044D0", VA = "0x2A044D0")]
      public static void OnDestory()
      {
      }

      [Token(Token = "0x6001FA1")]
      [Address(RVA = "0x2A04460", Offset = "0x2A04460", VA = "0x2A04460")]
      public FinalizeStoryUI()
      {
      }
    }
  }
}
