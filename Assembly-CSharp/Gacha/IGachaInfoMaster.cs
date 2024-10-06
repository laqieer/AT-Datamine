// Decompiled with JetBrains decompiler
// Type: Gacha.IGachaInfoMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x20014FB")]
  public interface IGachaInfoMaster
  {
    [Token(Token = "0x60076A5")]
    List<GachaBackgroundResource> FindBackgroundResources(string gachaName);

    [Token(Token = "0x60076A6")]
    int GetGachaId(string gachaName, int groupId, GachaTypeEnum gachaType);

    [Token(Token = "0x60076A7")]
    GachaListItemInfo GetGachaListItemInfo(string gachaName);

    [Token(Token = "0x60076A8")]
    SelectGachaTargetInfo GetSelectGachaTargetInfo(string gachaName, int selectGachaTargetId);
  }
}
