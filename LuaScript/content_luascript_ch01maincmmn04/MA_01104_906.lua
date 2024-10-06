-- このluaスクリプトは、MA_01104_906.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115054)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	template1()

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ケイ<br>バルバロイの掃討作戦を終わらせてきた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_9060002")


	--★★ケイ★★:そうか、ご苦労
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9060003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:それだけか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_9060004")


	--★★ケイ★★:それだけだ
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9060005")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Anger")

	--★★ケイ★★:…貴公は私に称賛されがたいために<br>憲兵団の任務に参加していたのか？
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9060006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")

	--★★ノワール★★:そういうわけじゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_9060007")

	change_face(Actor002,"Normal")

	--★★ケイ★★:ならば下がり、任務を続けるのだな<br>学生として勉学に励むのもいいだろう
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9060008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:今回の働きについては<br>私から王によく伝えておく
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9060009")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115054)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
