-- このluaスクリプトは、PT4_01_05_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",242,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
lookat_weight(Actor002,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor002,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor003,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Worry")
	change_face(Actor003,"Sad")

	--★★ラグネル★★:うーん…
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","PT4_01_05_0030002")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ラグネル？どうしたんだ、深刻そうな顔して
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_05_0030003")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル", "驚き")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラグネル★★:あ、ノワール実は今、ギネマウア先輩から相談を受けててね
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","PT4_01_05_0030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定2")
-- ▲直接出力

	--★★ギネマウア★★:殿下を少しでも元気づける方法がないか<br>ラグネル様にお伺いしていたのです
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT4_01_05_0030005")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なるほど。勝手なイメージかもしれないけどラグネルってそういうの得意そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_05_0030006")

-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル", "照れ")
-- ▲直接出力
	change_face(Actor003,"Shy")

	--★★ラグネル★★:えっ？えっ？そう？そうかな？ノワール、本当にそう思う？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","PT4_01_05_0030007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:うん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_05_0030008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ラグネル", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル★★:よーし！じゃあ、ここは張り切ってギネマウア先輩の期待に応えないとだね！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","PT4_01_05_0030009")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:いい方法、浮かびそうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_05_0030010")

-- ▼直接出力
PlayPartVoice("ラグネル", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラグネル★★:そうだなあ…<br>それほど特別な方法ってわけじゃないけど
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","PT4_01_05_0030011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:やっぱり誰かがそばにいてあげること、かな
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","PT4_01_05_0030012")

-- ▼直接出力
PlayPartVoice("ギネマウア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネマウア★★:そばに…？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT4_01_05_0030013")

-- ▼直接出力
PlayPartVoice("ラグネル", "肯定2")
-- ▲直接出力

	--★★ラグネル★★:ひとりでいると余計にあれこれ悩んじゃいますから
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","PT4_01_05_0030014")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ラグネル★★:話を聞いてくれる人がそばにいるだけでだいぶ気持ちが楽になると思います
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","PT4_01_05_0030015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ラグネル★★:それが自分のことを理解してくれてる人ならなおさらです
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","PT4_01_05_0030016")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル★★:あたしも、そうでしたから！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","PT4_01_05_0030017")

-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:なるほど…！参考になりました
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT4_01_05_0030018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力

	--★★ギネマウア★★:ノワール様も話を聞いていただき、ありがとうございました
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT4_01_05_0030019")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いえ、俺はなにも…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_05_0030020")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:でも、ギネヴィアが少しでも元気になってくれるといいですね
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_05_0030021")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115910)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
