// Decompiled with JetBrains decompiler
// Type: ADV2.AdvTextAccessManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.AdvTextAccessNS;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003DEA")]
  public class AdvTextAccessManager : IAdvTextAccess
  {
    [Token(Token = "0x4010F67")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<string, int> refDict;
    [Token(Token = "0x4010F68")]
    [FieldOffset(Offset = "0x18")]
    private List<AdvTextAccessManager.TextDLCAttributeData> useTextDataList;
    [Token(Token = "0x4010F69")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<string, AdvTextAccessManager.LoadingTextDLCProcess> loadingDict;
    [Token(Token = "0x4010F6A")]
    [FieldOffset(Offset = "0x28")]
    private List<string> requestList;

    [Token(Token = "0x6018E2D")]
    [Address(RVA = "0x23A41A4", Offset = "0x23A41A4", VA = "0x23A41A4")]
    private IEnumerator UseTextDLCProcess(string abName) => (IEnumerator) null;

    [Token(Token = "0x6018E2E")]
    [Address(RVA = "0x23A4240", Offset = "0x23A4240", VA = "0x23A4240")]
    private void UnUsedTextDLC(string abName)
    {
    }

    [Token(Token = "0x6018E2F")]
    [Address(RVA = "0x23A4400", Offset = "0x23A4400", VA = "0x23A4400")]
    public void UseRequest(string abName, TextAttributeData textAt)
    {
    }

    [Token(Token = "0x6018E30")]
    [Address(RVA = "0x2393534", Offset = "0x2393534", VA = "0x2393534")]
    public IEnumerator LoadRequsetList() => (IEnumerator) null;

    [Token(Token = "0x6018E31")]
    [Address(RVA = "0x2391AA4", Offset = "0x2391AA4", VA = "0x2391AA4")]
    public IEnumerator UseProcess(string abName, TextAttributeData textAt) => (IEnumerator) null;

    [Token(Token = "0x6018E32")]
    [Address(RVA = "0x239A320", Offset = "0x239A320", VA = "0x239A320", Slot = "4")]
    public string GetText(string textId) => (string) null;

    [Token(Token = "0x6018E33")]
    [Address(RVA = "0x23A4610", Offset = "0x23A4610", VA = "0x23A4610")]
    public string GetVoice(string textId) => (string) null;

    [Token(Token = "0x6018E34")]
    [Address(RVA = "0x239B3FC", Offset = "0x239B3FC", VA = "0x239B3FC")]
    public void OnTimingByCarenderChange(CanederTimingData timigdata)
    {
    }

    [Token(Token = "0x6018E35")]
    [Address(RVA = "0x23A1E00", Offset = "0x23A1E00", VA = "0x23A1E00")]
    public void OnTimingByAdvEnd()
    {
    }

    [Token(Token = "0x6018E36")]
    [Address(RVA = "0x23A4808", Offset = "0x23A4808", VA = "0x23A4808")]
    public AdvTextAccessManager()
    {
    }

    [Token(Token = "0x2003DEB")]
    private class TextDLCAttributeData
    {
      [Token(Token = "0x170050FF")]
      public CarenderRangeData DLCCarederRange
      {
        [Token(Token = "0x6018E37"), Address(RVA = "0x23A4950", Offset = "0x23A4950", VA = "0x23A4950")] get
        {
          return (CarenderRangeData) null;
        }
        [Token(Token = "0x6018E38"), Address(RVA = "0x23A4958", Offset = "0x23A4958", VA = "0x23A4958")] set
        {
        }
      }

      [Token(Token = "0x17005100")]
      public bool IsDLCAdvOnece
      {
        [Token(Token = "0x6018E39"), Address(RVA = "0x23A4960", Offset = "0x23A4960", VA = "0x23A4960")] get
        {
          return new bool();
        }
        [Token(Token = "0x6018E3A"), Address(RVA = "0x23A4968", Offset = "0x23A4968", VA = "0x23A4968")] set
        {
        }
      }

      [Token(Token = "0x17005101")]
      public string AbName
      {
        [Token(Token = "0x6018E3B"), Address(RVA = "0x23A4974", Offset = "0x23A4974", VA = "0x23A4974")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6018E3C"), Address(RVA = "0x23A497C", Offset = "0x23A497C", VA = "0x23A497C")] set
        {
        }
      }

      [Token(Token = "0x6018E3D")]
      [Address(RVA = "0x23A47D0", Offset = "0x23A47D0", VA = "0x23A47D0")]
      public bool ShouldUnUseByChanderTimig(CanederTimingData timingdata) => new bool();

      [Token(Token = "0x6018E3E")]
      [Address(RVA = "0x23A4800", Offset = "0x23A4800", VA = "0x23A4800")]
      public bool ShouldUnUseByAdvEnd() => new bool();

      [Token(Token = "0x6018E3F")]
      [Address(RVA = "0x23A4568", Offset = "0x23A4568", VA = "0x23A4568")]
      public TextDLCAttributeData()
      {
      }
    }

    [Token(Token = "0x2003DEC")]
    private class LoadingTextDLCProcess
    {
      [Token(Token = "0x17005102")]
      public int RefenceCount
      {
        [Token(Token = "0x6018E40"), Address(RVA = "0x23A4984", Offset = "0x23A4984", VA = "0x23A4984")] get
        {
          return new int();
        }
        [Token(Token = "0x6018E41"), Address(RVA = "0x23A498C", Offset = "0x23A498C", VA = "0x23A498C")] set
        {
        }
      }

      [Token(Token = "0x6018E42")]
      [Address(RVA = "0x23A4994", Offset = "0x23A4994", VA = "0x23A4994")]
      public IEnumerator Process(string abName) => (IEnumerator) null;

      [Token(Token = "0x6018E43")]
      [Address(RVA = "0x23A4A24", Offset = "0x23A4A24", VA = "0x23A4A24")]
      public static (string, string[]) GetAssetInfo(string abName) => ();

      [Token(Token = "0x6018E44")]
      [Address(RVA = "0x23A4C00", Offset = "0x23A4C00", VA = "0x23A4C00")]
      public LoadingTextDLCProcess()
      {
      }
    }
  }
}
