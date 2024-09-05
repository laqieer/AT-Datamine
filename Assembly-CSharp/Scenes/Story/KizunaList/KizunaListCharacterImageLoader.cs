// Decompiled with JetBrains decompiler
// Type: Scenes.Story.KizunaList.KizunaListCharacterImageLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Dicing;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Story.KizunaList
{
  [Token(Token = "0x2002E97")]
  public class KizunaListCharacterImageLoader
  {
    [Token(Token = "0x400C7B0")]
    [FieldOffset(Offset = "0x10")]
    private readonly HashSet<int> LoadStyleIdList;

    [Token(Token = "0x6012306")]
    [Address(RVA = "0x4593834", Offset = "0x4593834", VA = "0x4593834")]
    public void AddToLoadList(int styleId)
    {
    }

    [Token(Token = "0x6012307")]
    [Address(RVA = "0x459388C", Offset = "0x459388C", VA = "0x459388C")]
    public IEnumerator LoadAsync() => (IEnumerator) null;

    [Token(Token = "0x6012308")]
    [Address(RVA = "0x459391C", Offset = "0x459391C", VA = "0x459391C")]
    public IllustLayoutInfo GetIllustLayoutInfo(int styleId) => (IllustLayoutInfo) null;

    [Token(Token = "0x6012309")]
    [Address(RVA = "0x45939DC", Offset = "0x45939DC", VA = "0x45939DC")]
    public CharaImage GetCharacterImage(int styleId) => (CharaImage) null;

    [Token(Token = "0x601230A")]
    [Address(RVA = "0x4593B4C", Offset = "0x4593B4C", VA = "0x4593B4C")]
    public void Release()
    {
    }

    [Token(Token = "0x601230B")]
    [Address(RVA = "0x4593D08", Offset = "0x4593D08", VA = "0x4593D08")]
    public KizunaListCharacterImageLoader()
    {
    }
  }
}
