// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerModelSampleAdv
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
  [Token(Token = "0x200305D")]
  public class AdvViewerModelSampleAdv : IAdvViewerModel, IDebugViewerModel
  {
    [Token(Token = "0x400CDE2")]
    [FieldOffset(Offset = "0x18")]
    private AdvDemoInfoData advDemoInfoData;
    [Token(Token = "0x400CDE3")]
    [FieldOffset(Offset = "0x20")]
    private string[] fileNameList;

    [Token(Token = "0x17003FB9")]
    private AdvViewerModel Parent
    {
      [Token(Token = "0x6012E87"), Address(RVA = "0x3FC8F58", Offset = "0x3FC8F58", VA = "0x3FC8F58")] get
      {
        return (AdvViewerModel) null;
      }
    }

    [Token(Token = "0x17003FBA")]
    public BindingParam<IEnumerable<string>> ScriptFileList
    {
      [Token(Token = "0x6012E88"), Address(RVA = "0x3FC8F60", Offset = "0x3FC8F60", VA = "0x3FC8F60")] get
      {
        return (BindingParam<IEnumerable<string>>) null;
      }
    }

    [Token(Token = "0x17003FBB")]
    public BindingParam<string> ScriptFileName
    {
      [Token(Token = "0x6012E89"), Address(RVA = "0x3FC8F68", Offset = "0x3FC8F68", VA = "0x3FC8F68")] get
      {
        return (BindingParam<string>) null;
      }
    }

    [Token(Token = "0x6012E8A")]
    [Address(RVA = "0x3FC8F70", Offset = "0x3FC8F70", VA = "0x3FC8F70")]
    public AdvViewerModelSampleAdv(AdvViewerModel parent)
    {
    }

    [Token(Token = "0x6012E8B")]
    [Address(RVA = "0x3FC9200", Offset = "0x3FC9200", VA = "0x3FC9200")]
    public void SetScriptFileName(string fileName)
    {
    }

    [Token(Token = "0x6012E8C")]
    [Address(RVA = "0x3FC921C", Offset = "0x3FC921C", VA = "0x3FC921C")]
    public void Play()
    {
    }

    [Token(Token = "0x6012E8D")]
    [Address(RVA = "0x3FC9350", Offset = "0x3FC9350", VA = "0x3FC9350")]
    private IEnumerable<string> SetFileList() => (IEnumerable<string>) null;

    [Token(Token = "0x6012E8E")]
    [Address(RVA = "0x3FC9198", Offset = "0x3FC9198", VA = "0x3FC9198")]
    protected IEnumerator LoadLuaSampleAssetbundle() => (IEnumerator) null;

    [Token(Token = "0x6012E8F")]
    [Address(RVA = "0x3FC944C", Offset = "0x3FC944C", VA = "0x3FC944C", Slot = "5")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6012E90")]
    [Address(RVA = "0x3FC9450", Offset = "0x3FC9450", VA = "0x3FC9450", Slot = "4")]
    public void Update()
    {
    }
  }
}
