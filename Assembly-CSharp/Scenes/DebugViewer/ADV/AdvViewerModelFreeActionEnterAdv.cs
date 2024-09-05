// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerModelFreeActionEnterAdv
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.ADV
{
  [Token(Token = "0x2003000")]
  public class AdvViewerModelFreeActionEnterAdv : IAdvViewerModel, IDebugViewerModel
  {
    [Token(Token = "0x400CCC4")]
    [FieldOffset(Offset = "0x10")]
    private AdvViewerModel Parent;
    [Token(Token = "0x400CCC9")]
    [FieldOffset(Offset = "0x38")]
    private Dictionary<int, StoryFreeActionAreaSettingData> paramDict;
    [Token(Token = "0x400CCCA")]
    [FieldOffset(Offset = "0x40")]
    private bool isPrepare;

    [Token(Token = "0x17003F55")]
    public BindingParam<IEnumerable<StoryMainQuestSequenceData>> SequenceList
    {
      [Token(Token = "0x6012C36"), Address(RVA = "0x42A94FC", Offset = "0x42A94FC", VA = "0x42A94FC")] get
      {
        return (BindingParam<IEnumerable<StoryMainQuestSequenceData>>) null;
      }
    }

    [Token(Token = "0x17003F56")]
    public BindingParam<int> SequenceId
    {
      [Token(Token = "0x6012C37"), Address(RVA = "0x42A9504", Offset = "0x42A9504", VA = "0x42A9504")] get
      {
        return (BindingParam<int>) null;
      }
    }

    [Token(Token = "0x17003F57")]
    public BindingParam<int> TelopID
    {
      [Token(Token = "0x6012C38"), Address(RVA = "0x42A950C", Offset = "0x42A950C", VA = "0x42A950C")] get
      {
        return (BindingParam<int>) null;
      }
    }

    [Token(Token = "0x17003F58")]
    public BindingParam<bool> CanPlay
    {
      [Token(Token = "0x6012C39"), Address(RVA = "0x42A9514", Offset = "0x42A9514", VA = "0x42A9514")] get
      {
        return (BindingParam<bool>) null;
      }
    }

    [Token(Token = "0x6012C3A")]
    [Address(RVA = "0x42992C8", Offset = "0x42992C8", VA = "0x42992C8")]
    public AdvViewerModelFreeActionEnterAdv(AdvViewerModel parent)
    {
    }

    [Token(Token = "0x6012C3B")]
    [Address(RVA = "0x42A9B3C", Offset = "0x42A9B3C", VA = "0x42A9B3C")]
    private bool UpdateEnable() => new bool();

    [Token(Token = "0x6012C3C")]
    [Address(RVA = "0x42A9CF4", Offset = "0x42A9CF4", VA = "0x42A9CF4")]
    public void Play()
    {
    }

    [Token(Token = "0x6012C3D")]
    [Address(RVA = "0x42AA00C", Offset = "0x42AA00C", VA = "0x42AA00C")]
    private IEnumerator OnPlay(int advID) => (IEnumerator) null;

    [Token(Token = "0x6012C3E")]
    [Address(RVA = "0x42AA084", Offset = "0x42AA084", VA = "0x42AA084")]
    private void OnEndAdv()
    {
    }

    [Token(Token = "0x6012C3F")]
    [Address(RVA = "0x42AA088", Offset = "0x42AA088", VA = "0x42AA088", Slot = "4")]
    public void Update()
    {
    }

    [Token(Token = "0x6012C40")]
    [Address(RVA = "0x42AA08C", Offset = "0x42AA08C", VA = "0x42AA08C", Slot = "5")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6012C41")]
    [Address(RVA = "0x42A951C", Offset = "0x42A951C", VA = "0x42A951C")]
    public IEnumerable<StoryMainQuestSequenceData> GetSequenceList()
    {
      return (IEnumerable<StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x6012C42")]
    [Address(RVA = "0x429951C", Offset = "0x429951C", VA = "0x429951C")]
    public IEnumerable<StoryFreeActionTelopData> GetTeloptList()
    {
      return (IEnumerable<StoryFreeActionTelopData>) null;
    }
  }
}
