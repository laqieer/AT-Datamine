// Decompiled with JetBrains decompiler
// Type: IronSourceRewardedVideoAndroid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x200005F")]
public class IronSourceRewardedVideoAndroid : AndroidJavaProxy, IUnityRewardedVideo
{
  [Token(Token = "0x600033D")]
  [Address(RVA = "0x44A4FF4", Offset = "0x44A4FF4", VA = "0x44A4FF4")]
  public IronSourceRewardedVideoAndroid()
  {
  }

  [Token(Token = "0x14000072")]
  public event Action<IronSourceError> OnRewardedVideoAdShowFailed
  {
    [Token(Token = "0x600033E"), Address(RVA = "0x44A5B80", Offset = "0x44A5B80", VA = "0x44A5B80", Slot = "9")] add
    {
    }
    [Token(Token = "0x600033F"), Address(RVA = "0x44A5C30", Offset = "0x44A5C30", VA = "0x44A5C30", Slot = "10")] remove
    {
    }
  }

  [Token(Token = "0x14000073")]
  public event Action OnRewardedVideoAdOpened
  {
    [Token(Token = "0x6000340"), Address(RVA = "0x44A5CE0", Offset = "0x44A5CE0", VA = "0x44A5CE0", Slot = "11")] add
    {
    }
    [Token(Token = "0x6000341"), Address(RVA = "0x44A5D7C", Offset = "0x44A5D7C", VA = "0x44A5D7C", Slot = "12")] remove
    {
    }
  }

  [Token(Token = "0x14000074")]
  public event Action OnRewardedVideoAdClosed
  {
    [Token(Token = "0x6000342"), Address(RVA = "0x44A5E18", Offset = "0x44A5E18", VA = "0x44A5E18", Slot = "13")] add
    {
    }
    [Token(Token = "0x6000343"), Address(RVA = "0x44A5EB4", Offset = "0x44A5EB4", VA = "0x44A5EB4", Slot = "14")] remove
    {
    }
  }

  [Token(Token = "0x14000075")]
  public event Action OnRewardedVideoAdStarted
  {
    [Token(Token = "0x6000344"), Address(RVA = "0x44A5F50", Offset = "0x44A5F50", VA = "0x44A5F50", Slot = "15")] add
    {
    }
    [Token(Token = "0x6000345"), Address(RVA = "0x44A5FEC", Offset = "0x44A5FEC", VA = "0x44A5FEC", Slot = "16")] remove
    {
    }
  }

  [Token(Token = "0x14000076")]
  public event Action OnRewardedVideoAdEnded
  {
    [Token(Token = "0x6000346"), Address(RVA = "0x44A6088", Offset = "0x44A6088", VA = "0x44A6088", Slot = "17")] add
    {
    }
    [Token(Token = "0x6000347"), Address(RVA = "0x44A6124", Offset = "0x44A6124", VA = "0x44A6124", Slot = "18")] remove
    {
    }
  }

  [Token(Token = "0x14000077")]
  public event Action<IronSourcePlacement> OnRewardedVideoAdRewarded
  {
    [Token(Token = "0x6000348"), Address(RVA = "0x44A61C0", Offset = "0x44A61C0", VA = "0x44A61C0", Slot = "19")] add
    {
    }
    [Token(Token = "0x6000349"), Address(RVA = "0x44A6270", Offset = "0x44A6270", VA = "0x44A6270", Slot = "20")] remove
    {
    }
  }

  [Token(Token = "0x14000078")]
  public event Action<IronSourcePlacement> OnRewardedVideoAdClicked
  {
    [Token(Token = "0x600034A"), Address(RVA = "0x44A6320", Offset = "0x44A6320", VA = "0x44A6320", Slot = "21")] add
    {
    }
    [Token(Token = "0x600034B"), Address(RVA = "0x44A63D0", Offset = "0x44A63D0", VA = "0x44A63D0", Slot = "22")] remove
    {
    }
  }

  [Token(Token = "0x14000079")]
  public event Action<bool> OnRewardedVideoAvailabilityChanged
  {
    [Token(Token = "0x600034C"), Address(RVA = "0x44A6480", Offset = "0x44A6480", VA = "0x44A6480", Slot = "23")] add
    {
    }
    [Token(Token = "0x600034D"), Address(RVA = "0x44A6530", Offset = "0x44A6530", VA = "0x44A6530", Slot = "24")] remove
    {
    }
  }

  [Token(Token = "0x1400007A")]
  public event Action<string> OnRewardedVideoAdOpenedDemandOnlyEvent
  {
    [Token(Token = "0x600034E"), Address(RVA = "0x44A65E0", Offset = "0x44A65E0", VA = "0x44A65E0", Slot = "25")] add
    {
    }
    [Token(Token = "0x600034F"), Address(RVA = "0x44A6690", Offset = "0x44A6690", VA = "0x44A6690", Slot = "26")] remove
    {
    }
  }

  [Token(Token = "0x1400007B")]
  public event Action<string> OnRewardedVideoAdClosedDemandOnlyEvent
  {
    [Token(Token = "0x6000350"), Address(RVA = "0x44A6740", Offset = "0x44A6740", VA = "0x44A6740", Slot = "27")] add
    {
    }
    [Token(Token = "0x6000351"), Address(RVA = "0x44A67F0", Offset = "0x44A67F0", VA = "0x44A67F0", Slot = "28")] remove
    {
    }
  }

  [Token(Token = "0x1400007C")]
  public event Action<string> OnRewardedVideoAdLoadedDemandOnlyEvent
  {
    [Token(Token = "0x6000352"), Address(RVA = "0x44A68A0", Offset = "0x44A68A0", VA = "0x44A68A0", Slot = "29")] add
    {
    }
    [Token(Token = "0x6000353"), Address(RVA = "0x44A6950", Offset = "0x44A6950", VA = "0x44A6950", Slot = "30")] remove
    {
    }
  }

  [Token(Token = "0x1400007D")]
  public event Action<string> OnRewardedVideoAdRewardedDemandOnlyEvent
  {
    [Token(Token = "0x6000354"), Address(RVA = "0x44A6A00", Offset = "0x44A6A00", VA = "0x44A6A00", Slot = "31")] add
    {
    }
    [Token(Token = "0x6000355"), Address(RVA = "0x44A6AB0", Offset = "0x44A6AB0", VA = "0x44A6AB0", Slot = "32")] remove
    {
    }
  }

  [Token(Token = "0x1400007E")]
  public event Action<string, IronSourceError> OnRewardedVideoAdShowFailedDemandOnlyEvent
  {
    [Token(Token = "0x6000356"), Address(RVA = "0x44A6B60", Offset = "0x44A6B60", VA = "0x44A6B60", Slot = "33")] add
    {
    }
    [Token(Token = "0x6000357"), Address(RVA = "0x44A6C10", Offset = "0x44A6C10", VA = "0x44A6C10", Slot = "34")] remove
    {
    }
  }

  [Token(Token = "0x1400007F")]
  public event Action<string> OnRewardedVideoAdClickedDemandOnlyEvent
  {
    [Token(Token = "0x6000358"), Address(RVA = "0x44A6CC0", Offset = "0x44A6CC0", VA = "0x44A6CC0", Slot = "35")] add
    {
    }
    [Token(Token = "0x6000359"), Address(RVA = "0x44A6D70", Offset = "0x44A6D70", VA = "0x44A6D70", Slot = "36")] remove
    {
    }
  }

  [Token(Token = "0x14000080")]
  public event Action<string, IronSourceError> OnRewardedVideoAdLoadFailedDemandOnlyEvent
  {
    [Token(Token = "0x600035A"), Address(RVA = "0x44A6E20", Offset = "0x44A6E20", VA = "0x44A6E20", Slot = "37")] add
    {
    }
    [Token(Token = "0x600035B"), Address(RVA = "0x44A6ED0", Offset = "0x44A6ED0", VA = "0x44A6ED0", Slot = "38")] remove
    {
    }
  }

  [Token(Token = "0x600035C")]
  [Address(RVA = "0x44A6F80", Offset = "0x44A6F80", VA = "0x44A6F80")]
  private void onRewardedVideoAdShowFailed(string description)
  {
  }

  [Token(Token = "0x600035D")]
  [Address(RVA = "0x44A6FC4", Offset = "0x44A6FC4", VA = "0x44A6FC4")]
  private void onRewardedVideoAdClosed()
  {
  }

  [Token(Token = "0x600035E")]
  [Address(RVA = "0x44A6FE0", Offset = "0x44A6FE0", VA = "0x44A6FE0")]
  private void onRewardedVideoAdOpened()
  {
  }

  [Token(Token = "0x600035F")]
  [Address(RVA = "0x44A6FFC", Offset = "0x44A6FFC", VA = "0x44A6FFC")]
  private void onRewardedVideoAdStarted()
  {
  }

  [Token(Token = "0x6000360")]
  [Address(RVA = "0x44A7018", Offset = "0x44A7018", VA = "0x44A7018")]
  private void onRewardedVideoAdEnded()
  {
  }

  [Token(Token = "0x6000361")]
  [Address(RVA = "0x44A7034", Offset = "0x44A7034", VA = "0x44A7034")]
  private void onRewardedVideoAdRewarded(string description)
  {
  }

  [Token(Token = "0x6000362")]
  [Address(RVA = "0x44A72E8", Offset = "0x44A72E8", VA = "0x44A72E8")]
  private void onRewardedVideoAdClicked(string description)
  {
  }

  [Token(Token = "0x6000363")]
  [Address(RVA = "0x44A734C", Offset = "0x44A734C", VA = "0x44A734C")]
  private void onRewardedVideoAvailabilityChanged(string stringAvailable)
  {
  }

  [Token(Token = "0x6000364")]
  [Address(RVA = "0x44A73D4", Offset = "0x44A73D4", VA = "0x44A73D4")]
  private void onRewardedVideoAdShowFailedDemandOnly(string args)
  {
  }

  [Token(Token = "0x6000365")]
  [Address(RVA = "0x44A74E8", Offset = "0x44A74E8", VA = "0x44A74E8")]
  private void onRewardedVideoAdClosedDemandOnly(string instanceId)
  {
  }

  [Token(Token = "0x6000366")]
  [Address(RVA = "0x44A7504", Offset = "0x44A7504", VA = "0x44A7504")]
  private void onRewardedVideoAdOpenedDemandOnly(string instanceId)
  {
  }

  [Token(Token = "0x6000367")]
  [Address(RVA = "0x44A7520", Offset = "0x44A7520", VA = "0x44A7520")]
  private void onRewardedVideoAdRewardedDemandOnly(string instanceId)
  {
  }

  [Token(Token = "0x6000368")]
  [Address(RVA = "0x44A753C", Offset = "0x44A753C", VA = "0x44A753C")]
  private void onRewardedVideoAdClickedDemandOnly(string instanceId)
  {
  }

  [Token(Token = "0x6000369")]
  [Address(RVA = "0x44A7558", Offset = "0x44A7558", VA = "0x44A7558")]
  private void onRewardedVideoAdLoadedDemandOnly(string instanceId)
  {
  }

  [Token(Token = "0x600036A")]
  [Address(RVA = "0x44A7574", Offset = "0x44A7574", VA = "0x44A7574")]
  private void onRewardedVideoAdLoadFailedDemandOnly(string args)
  {
  }
}
