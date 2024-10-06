// Decompiled with JetBrains decompiler
// Type: Story.StoryArchive.StoryArchiveSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Scene;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Story.StoryArchive
{
  [Token(Token = "0x200061B")]
  public class StoryArchiveSubScene : SubScene
  {
    [Token(Token = "0x4001DE5")]
    [FieldOffset(Offset = "0x58")]
    private StoryArchiveSubScene.Parameter _parameter;

    [Token(Token = "0x600234E")]
    [Address(RVA = "0x2DA53B8", Offset = "0x2DA53B8", VA = "0x2DA53B8", Slot = "6")]
    public override void Initialize(ChangeSceneParameter parameter = null)
    {
    }

    [Token(Token = "0x600234F")]
    [Address(RVA = "0x2DA5440", Offset = "0x2DA5440", VA = "0x2DA5440", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6002350")]
    [Address(RVA = "0x2DA54D0", Offset = "0x2DA54D0", VA = "0x2DA54D0", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x6002351")]
    [Address(RVA = "0x2DA54DC", Offset = "0x2DA54DC", VA = "0x2DA54DC")]
    private void OnBack()
    {
    }

    [Token(Token = "0x6002352")]
    [Address(RVA = "0x2DA54E8", Offset = "0x2DA54E8", VA = "0x2DA54E8")]
    public StoryArchiveSubScene()
    {
    }

    [Token(Token = "0x200061C")]
    public class Parameter : ChangeSceneParameter
    {
      [Token(Token = "0x4001DE6")]
      [FieldOffset(Offset = "0x14")]
      public StoryReplayCategoryTypeEnum CategoryTypeEnum;
      [Token(Token = "0x4001DE7")]
      [FieldOffset(Offset = "0x18")]
      public int ArchiveId;

      [Token(Token = "0x6002353")]
      [Address(RVA = "0x2DA4794", Offset = "0x2DA4794", VA = "0x2DA4794")]
      public Parameter()
      {
      }
    }
  }
}
