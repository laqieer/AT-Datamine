-- このluaスクリプトは、PT4_01A_12_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_002)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
lookat_weight(Actor003,0.45,0.1,0.8,0.2)
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ラヴェイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラヴェイン★★:血のように赤い空、淀み切った空気…<br>この世界はどうなってしまうのでしょうね
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_12_0030002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネマウア★★:日に日に崩壊に向けて近づいていっている<br>そんな気すらします
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","PT4_01A_12_0030003")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:そうなる前にルーシャスと魔女を討つ<br>それだけですよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_12_0030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラヴェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラヴェイン★★:君ならきっとそれをなし遂げられる<br>私はそう信じています。でも…
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_12_0030005")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ラヴェイン★★:私は妹が心配です
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_12_0030006")


	--★★ギネマウア★★:………
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","PT4_01A_12_0030007")

	change_face(Actor002,"Normal")

	--★★ラヴェイン★★:君が戦場に赴くとき<br>妹はまたその隣に立とうとするでしょう
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_12_0030008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ラヴェイン★★:もちろん<br>この身に代えても妹のことを守るつもりです
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_12_0030009")

	change_face(Actor002,"Sad")

	--★★ラヴェイン★★:でも、もしも、また…
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_12_0030010")


	--★★ギネマウア★★:………
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","PT4_01A_12_0030011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ラヴェイン", "悲しみ")
-- ▲直接出力

	--★★ラヴェイン★★:…いけないいけない
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_12_0030012")

	change_face(Actor002,"Normal")

	--★★ラヴェイン★★:この空気のせいでしょうか<br>ついついよくないことを考えてしまいます
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_12_0030013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラヴェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラヴェイン★★:妹に叱られてしまいますね<br>頭を冷やしてこなくては
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_12_0030014")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:ノワール様
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","PT4_01A_12_0030015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:なんでしょう、ギネマウアさん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_12_0030016")

	change_face(Actor003,"Sad")

	--★★ギネマウア★★:あの子のことを…<br>いえ、私たちの妹のことをよろしくお願いします
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","PT4_01A_12_0030017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:はい<br>任せてください
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_12_0030018")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
