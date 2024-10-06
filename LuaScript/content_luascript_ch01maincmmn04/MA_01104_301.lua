-- このluaスクリプトは、MA_01104_301.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Nbl_f_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
-- ▼直接出力
 --set_pos(Actor002,{-1.757,0,-0.491})
Hide(Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --IN_WALK(Actor002,CharaPos110011_04_005)
EntryWalk(Actor002,Camera002,EntryData110191_01_02,CameraAssetBundleName110191_01,CameraPos110191_01_102)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
 --wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ウレリー★★:ノワールくん、頭は良さそうなのに<br>勉強は…えーっと、大丈夫？ついていけてる？
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3010001")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あからさまに気を遣うな…！<br>こんな立派な学園に通ったことないんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_3010002")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ウレリー★★:教えてあげる
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3010003")


	--★★ウレリー★★:大図書院、入ってみた？<br>あそこでは勉強ができるよ
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3010004")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ウレリー★★:あの静けさ、整然とした本の積まれ具合<br>新しい紙の匂い、古書のカビ臭さ…イイよねえ
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3010005")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
