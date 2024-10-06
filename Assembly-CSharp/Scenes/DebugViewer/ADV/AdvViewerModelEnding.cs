// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerModelEnding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.ADV
{
  [Token(Token = "0x2002FCF")]
  public class AdvViewerModelEnding : IAdvViewerModel, IDebugViewerModel
  {
    [Token(Token = "0x17003F0C")]
    private AdvViewerModel Parent
    {
      [Token(Token = "0x6012B06"), Address(RVA = "0x42A2BC0", Offset = "0x42A2BC0", VA = "0x42A2BC0")] get
      {
        return (AdvViewerModel) null;
      }
    }

    [Token(Token = "0x17003F0D")]
    public BindingParam<IEnumerable<StoryEndingData>> EndingList
    {
      [Token(Token = "0x6012B07"), Address(RVA = "0x42A2BC8", Offset = "0x42A2BC8", VA = "0x42A2BC8")] get
      {
        return (BindingParam<IEnumerable<StoryEndingData>>) null;
      }
    }

    [Token(Token = "0x17003F0E")]
    public BindingParam<string> ScriptFileName
    {
      [Token(Token = "0x6012B08"), Address(RVA = "0x42A2BD0", Offset = "0x42A2BD0", VA = "0x42A2BD0")] get
      {
        return (BindingParam<string>) null;
      }
    }

    [Token(Token = "0x6012B09")]
    [Address(RVA = "0x42995A4", Offset = "0x42995A4", VA = "0x42995A4")]
    public AdvViewerModelEnding(AdvViewerModel parent)
    {
    }

    [Token(Token = "0x6012B0A")]
    [Address(RVA = "0x42A2E18", Offset = "0x42A2E18", VA = "0x42A2E18")]
    public void Play(int endingId, int endingType)
    {
    }

    [Token(Token = "0x6012B0B")]
    [Address(RVA = "0x42A3100", Offset = "0x42A3100", VA = "0x42A3100", Slot = "4")]
    public void Update()
    {
    }

    [Token(Token = "0x6012B0C")]
    [Address(RVA = "0x42A3104", Offset = "0x42A3104", VA = "0x42A3104", Slot = "5")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6012B0D")]
    [Address(RVA = "0x42A2BD8", Offset = "0x42A2BD8", VA = "0x42A2BD8")]
    public IEnumerable<StoryEndingData> GetEndingSequenceList()
    {
      return (IEnumerable<StoryEndingData>) null;
    }
  }
}
