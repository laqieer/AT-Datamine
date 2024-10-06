// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.ReverseLookupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.ADV
{
  [Token(Token = "0x2003079")]
  public class ReverseLookupData
  {
    [Token(Token = "0x400CE61")]
    [FieldOffset(Offset = "0x10")]
    public string ScriptFileName;
    [Token(Token = "0x400CE62")]
    [FieldOffset(Offset = "0x18")]
    public List<ReserveLookupMasterData> reserveLookupMasterDataList;
    [Token(Token = "0x400CE63")]
    [FieldOffset(Offset = "0x20")]
    public List<AdvDemoInfoData> advDemoInfoDataList;

    [Token(Token = "0x6012F37")]
    [Address(RVA = "0x431C5BC", Offset = "0x431C5BC", VA = "0x431C5BC")]
    public ReverseLookupData(AdvDemoInfoData advDemoinfoData)
    {
    }

    [Token(Token = "0x6012F38")]
    [Address(RVA = "0x431C710", Offset = "0x431C710", VA = "0x431C710")]
    public MasterDataType GetMasterType() => new MasterDataType();

    [Token(Token = "0x6012F39")]
    [Address(RVA = "0x431C770", Offset = "0x431C770", VA = "0x431C770")]
    public string Report() => (string) null;
  }
}
