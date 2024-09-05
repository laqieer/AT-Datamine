// Decompiled with JetBrains decompiler
// Type: Story.IAdvDirection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Adv;

#nullable disable
namespace Story
{
  [Token(Token = "0x200055D")]
  public interface IAdvDirection : IDirection
  {
    [Token(Token = "0x6001EFD")]
    AdvDemoInfoData GetDemoInfo();

    [Token(Token = "0x6001EFE")]
    AdvStage CreateAdvStage();

    [Token(Token = "0x17000440")]
    bool ShowHeader { [Token(Token = "0x6001EFF")] get; }
  }
}
