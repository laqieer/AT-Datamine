-- このluaスクリプトは、EA_006_013.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_03","110111_03_h")
Include("content_adv_advsmall_110111_03","Template110111_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_001)
	InitializeTemplateRandomCamera110111_03()
	InitializeTemplate110111_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101032","002","101032002","content_animationpack__common","FacialPack","Actor001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力

PlayPartVoiceDirect("ガレス","0012")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガレス★★:ついにわたしも円卓の騎士だ♪<br>…正確に言えば、まだ見習いだけど！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0130002")

-- ▼直接出力
wait_time(1.5)
-- ▲直接出力

	--★★ガレス★★:リオネスとＧＳして、戦功もたくさん上げて<br>ようやく円卓への第一歩を踏み出せたんだ
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0130003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ガレス★★:この調子で、見習い卒業を目指すぞ～♪<br>向かうは円卓の間だな～！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0130004")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101032","002","101032002","content_animationpack__common","FacialPack","Actor001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
