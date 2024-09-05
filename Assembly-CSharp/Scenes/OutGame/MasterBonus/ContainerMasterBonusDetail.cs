// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.MasterBonus.ContainerMasterBonusDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.MasterBonus
{
  [Token(Token = "0x200350E")]
  public class ContainerMasterBonusDetail : MonoBehaviour
  {
    [Token(Token = "0x400E6DD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ContentMasterBonusDetail templateDetailContent;
    [Token(Token = "0x400E6DE")]
    [FieldOffset(Offset = "0x20")]
    private List<ContentMasterBonusDetail> detailContetns;

    [Token(Token = "0x6014D02")]
    [Address(RVA = "0x1B39138", Offset = "0x1B39138", VA = "0x1B39138")]
    public void SetupBefore(ContainerMasterBonusDetailResource resource)
    {
    }

    [Token(Token = "0x6014D03")]
    [Address(RVA = "0x1B39738", Offset = "0x1B39738", VA = "0x1B39738")]
    public void SetupAfter(ContainerMasterBonusDetailResource resource)
    {
    }

    [Token(Token = "0x6014D04")]
    [Address(RVA = "0x1B39C74", Offset = "0x1B39C74", VA = "0x1B39C74")]
    public ContainerMasterBonusDetail()
    {
    }
  }
}
