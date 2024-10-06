-- このluaスクリプトは、EA_069_011.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoiceDirect("アーサー","0008")
-- ▲直接出力

	--★★アーサー★★:皆、それぞれ発ったようだな
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0110003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0007")
-- ▲直接出力

	--★★マーリン★★:はい。コルベニック城からの留学生の対応も<br>滞りなく済みました
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","EA_069_0110004")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マーリン★★:ギネヴィア様もお元気そうでしたね
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","EA_069_0110005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0007")
-- ▲直接出力

	--★★アーサー★★:…そうだな
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0110006")

-- ▼直接出力
PlayPartVoiceDirect("マーリン","0034")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:…もちろん、心の傷がすべて<br>癒えたわけではないでしょうが
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","EA_069_0110007")

-- ▼直接出力
PlayPartVoiceDirect("アーサー","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★アーサー★★:それでも、里帰りをさせてやれた<br>ノワールのおかげだな
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0110008")

-- ▼直接出力
PlayPartVoiceDirect("アーサー","0021")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★アーサー★★:…彼女が元気になってよかった<br>この件に関して、俺は本当に無力だったな
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0110009")

-- ▼直接出力
setup_small_camera_end(RndCamera001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0019")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:そんなこと…あなたは彼女のことを<br>ずっと気にかけていたじゃないですか
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","EA_069_0110010")


	--★★マーリン★★:あの夏休みのこと<br>忘れてはいないでしょう？
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","EA_069_0110011")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★アーサー★★:あのふたりがこの学園に来て最初の夏休みか<br>勿論覚えているさ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0110012")


	--★★アーサー★★:あの頃はあの頃で色々大変だったな<br>俺がというよりも、彼女が
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0110013")

	change_face(Actor001,"Surprise")

	--★★アーサー★★:ああ――別荘でのあの騒ぎから<br>もう1年になるのか――
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0110015")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
