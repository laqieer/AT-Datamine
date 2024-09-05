// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerModelFlavorObject
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
  [Token(Token = "0x2002FFA")]
  public class AdvViewerModelFlavorObject : IAdvViewerModel, IDebugViewerModel
  {
    [Token(Token = "0x400CCB3")]
    [FieldOffset(Offset = "0x50")]
    private Dictionary<int, StoryFreeActionAreaSettingData> paramDict;
    [Token(Token = "0x400CCB4")]
    [FieldOffset(Offset = "0x58")]
    private bool isPrepare;

    [Token(Token = "0x17003F4B")]
    private AdvViewerModel Parent
    {
      [Token(Token = "0x6012C0F"), Address(RVA = "0x42A7AB0", Offset = "0x42A7AB0", VA = "0x42A7AB0")] get
      {
        return (AdvViewerModel) null;
      }
    }

    [Token(Token = "0x17003F4C")]
    public BindingParam<IEnumerable<StoryFreeActionFlavorObjectData>> EventList
    {
      [Token(Token = "0x6012C10"), Address(RVA = "0x42A7AB8", Offset = "0x42A7AB8", VA = "0x42A7AB8")] get
      {
        return (BindingParam<IEnumerable<StoryFreeActionFlavorObjectData>>) null;
      }
    }

    [Token(Token = "0x17003F4D")]
    public BindingParam<IEnumerable<StoryFreeActionFlavorObjectTextData>> EventTextList
    {
      [Token(Token = "0x6012C11"), Address(RVA = "0x42A7AC0", Offset = "0x42A7AC0", VA = "0x42A7AC0")] get
      {
        return (BindingParam<IEnumerable<StoryFreeActionFlavorObjectTextData>>) null;
      }
    }

    [Token(Token = "0x17003F4E")]
    public BindingParam<IEnumerable<StoryMainQuestSequenceData>> SequenceList
    {
      [Token(Token = "0x6012C12"), Address(RVA = "0x42A7AC8", Offset = "0x42A7AC8", VA = "0x42A7AC8")] get
      {
        return (BindingParam<IEnumerable<StoryMainQuestSequenceData>>) null;
      }
    }

    [Token(Token = "0x17003F4F")]
    public BindingParam<int> SequenceId
    {
      [Token(Token = "0x6012C13"), Address(RVA = "0x42A7AD0", Offset = "0x42A7AD0", VA = "0x42A7AD0")] get
      {
        return (BindingParam<int>) null;
      }
    }

    [Token(Token = "0x17003F50")]
    public BindingParam<int> EventID
    {
      [Token(Token = "0x6012C14"), Address(RVA = "0x42A7AD8", Offset = "0x42A7AD8", VA = "0x42A7AD8")] get
      {
        return (BindingParam<int>) null;
      }
    }

    [Token(Token = "0x17003F51")]
    public BindingParam<int> EventTextID
    {
      [Token(Token = "0x6012C15"), Address(RVA = "0x42A7AE0", Offset = "0x42A7AE0", VA = "0x42A7AE0")] get
      {
        return (BindingParam<int>) null;
      }
    }

    [Token(Token = "0x17003F52")]
    public BindingParam<bool> CanPlay
    {
      [Token(Token = "0x6012C16"), Address(RVA = "0x42A7AE8", Offset = "0x42A7AE8", VA = "0x42A7AE8")] get
      {
        return (BindingParam<bool>) null;
      }
    }

    [Token(Token = "0x6012C17")]
    [Address(RVA = "0x4297E5C", Offset = "0x4297E5C", VA = "0x4297E5C")]
    public AdvViewerModelFlavorObject(AdvViewerModel parent)
    {
    }

    [Token(Token = "0x6012C18")]
    [Address(RVA = "0x42A822C", Offset = "0x42A822C", VA = "0x42A822C")]
    private bool UpdateEnable() => new bool();

    [Token(Token = "0x6012C19")]
    [Address(RVA = "0x42A83EC", Offset = "0x42A83EC", VA = "0x42A83EC")]
    public void Play()
    {
    }

    [Token(Token = "0x6012C1A")]
    [Address(RVA = "0x42A87D4", Offset = "0x42A87D4", VA = "0x42A87D4", Slot = "4")]
    public void Update()
    {
    }

    [Token(Token = "0x6012C1B")]
    [Address(RVA = "0x42A87D8", Offset = "0x42A87D8", VA = "0x42A87D8", Slot = "5")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6012C1C")]
    [Address(RVA = "0x42A7B8C", Offset = "0x42A7B8C", VA = "0x42A7B8C")]
    public IEnumerable<StoryMainQuestSequenceData> GetSequenceList()
    {
      return (IEnumerable<StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x6012C1D")]
    [Address(RVA = "0x42981C8", Offset = "0x42981C8", VA = "0x42981C8")]
    public IEnumerable<StoryFreeActionFlavorObjectData> GetEventList()
    {
      return (IEnumerable<StoryFreeActionFlavorObjectData>) null;
    }

    [Token(Token = "0x6012C1E")]
    [Address(RVA = "0x42A7AF0", Offset = "0x42A7AF0", VA = "0x42A7AF0")]
    public IEnumerable<StoryFreeActionFlavorObjectTextData> GetEventTextList()
    {
      return (IEnumerable<StoryFreeActionFlavorObjectTextData>) null;
    }

    [Token(Token = "0x6012C1F")]
    [Address(RVA = "0x42A8F78", Offset = "0x42A8F78", VA = "0x42A8F78")]
    private IEnumerator OnBeginAdv(int demoInfoID) => (IEnumerator) null;

    [Token(Token = "0x6012C20")]
    [Address(RVA = "0x42A9018", Offset = "0x42A9018", VA = "0x42A9018")]
    private void OnEndAdv()
    {
    }
  }
}
