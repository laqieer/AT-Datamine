-- このluaスクリプトは、PT5_01_0050.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
-- ▼直接出力
MobsNo = 2
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
-- ▼直接出力
hideobj01 =get_object("geo_desk_item_02")
hideobj02 =get_object("geo_desk_item_04")
hideobj03 =get_object("geo_desk_item_07")
hideobj04 =get_object("geo_desk_item_10")
hideobj05 =get_object("geo_desk_item_13")
hideobj06 =get_object("geo_desk_item_06")
set_pos(hideobj01,{0,-20,0})
set_pos(hideobj02,{0,-20,0})
set_pos(hideobj03,{0,-20,0})
set_pos(hideobj04,{0,-20,0})
set_pos(hideobj05,{0,-20,0})
set_pos(hideobj06,{0,-20,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:それでは今日は<br>我々の住むブリテン島の歴史について話そう
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00500002")


	--★★ケイ★★:このブリテン島は<br>もともとはローマ大帝国の領土のひとつだった
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00500003")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:しかし数十年前
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00500004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ケイ", "悩む")
-- ▲直接出力

	--★★ケイ★★:島にバルバロイが増えたことが原因で<br>ローマの勢力は次第に衰退
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00500005")


	--★★ケイ★★:そしてその機に乗じて<br>ブリテン島各地の領主たちが領土争いをはじめた
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00500006")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:我が国の前王ユーサーもそのひとりだ
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00500007")

	PlayAction(Actor005,"to  Std_Talk")

	--★★ケイ★★:しかしユーサー王が<br>他の領主たちと違ったのは
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00500008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:ひとあし先にバルバロイを倒すすべを<br>知りえていたこと
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00500009")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:ゲシュタルト・シフトの秘儀のことだな
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00500010")


	--★★ケイ★★:ゆえに１５年前<br>ローマがこの島から去ったあとも
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00500011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:ユーサー王はバルバロイの脅威を恐れることなく<br>他領主を退け、この国を築くことができたのだ
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00500012")

	PlayAction(Actor005,"to  Std_Worry")
	change_face(Actor005,"Surprise")

	--★★ケイ★★:…おっと、少々長くなったな<br>続きはまた次回に話すとしよう
	Talk(Actor005,"CHRNAME_KAY","speech","L","PT5_01_00500013")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
