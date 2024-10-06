-- このluaスクリプトは、MA_01104_305.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_03","110071_03_h")
Include("content_adv_advsmall_110071_03","Template110071_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_03,CameraPos110071_03_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Nbl_f_StdController","to Std_Loop",CameraAssetBundleName110071_03,CameraPos110071_03_002)
	InitializeTemplateRandomCamera110071_03()
	InitializeTemplate110071_03()
-- ▼直接出力
 --set_pos(Actor002,{-1.757,0,-0.491})
set_pos(Actor002,{-0.5,0.13,17.519})
Hide(Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
IN_WALK(Actor002,CharaPos110071_03_002)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.8)
wait_time(0.5)
-- ▲直接出力

	--★★ウレリー★★:平気で花を踏みつぶしたりしない<br>優しさにあふれる人間だよね？ノワールくんは
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3050001")

-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
turn_chara(Actor002,40,0.5)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.8)
-- ▲直接出力

	--★★ウレリー★★:お願いしたいことがあるんだあ<br>暇なら、でいいんだけどね…？
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3050002")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:お願いって、なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_3050003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ウレリー★★:教えてあげる！
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3050004")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:うわっ<br>そういうパターンもあるのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_3050005")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ウレリー★★:最近立て込んでて<br>大聖堂前のガーデニングができてないんだ
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3050006")


	--★★ウレリー★★:司祭のリアムさんと一緒にやってたんだけど<br>あの人も最近は手が回らないことが多いみたいで
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3050007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★ウレリー★★:貴方の中にひとかけらでも優しさがあるなら<br>ちょっと手伝ってもらえると嬉しいなあ…チラッ
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3050008")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
