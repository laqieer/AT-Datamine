-- このluaスクリプトは、MA_01105_901.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_508_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_006)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101062","001","101062001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ノワール★★:露店もすっかり片付けられたか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_9010002")


	--★★ノワール★★:見慣れた街並のはずなのに<br>祭のあとだと、なぜか寂しく見えるな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_9010003")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk_2P(Actor002,Camera002,EntryData112021_01_05,CameraAssetBundleName112021_01,CameraPos112021_01_105,Actor003,CharaPos112021_01_006,CharaPos112021_01_106)
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")

	--★★キッス★★:いたいた、ラビットちゃん<br>さがしたのよ
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01105_9010004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:それでキッスさん<br>なんの用事で俺をさがしてたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_9010009")


	--★★キッス★★:五月祭が終わったし<br>隊商さんたちがよそへ向かうらしいんだけど
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01105_9010010")

	PlayAction(Actor002,"to  Std_Talk")

	--★★キッス★★:ここのところ物騒でしょ？<br>次の目的地の近くまで護衛してあげてほしいの
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01105_9010011")


	--★★マルイル★★:隊商のリーダーから<br>腕の立つ人間がいないかと相談されまして
	Talk(Actor003,"CHRNAME_MARIL","speech","L","MA_01105_9010012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:アタシのところに依頼がきたから<br>ラビットちゃんを紹介しようと思ったワケ
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01105_9010013")

	change_face(Actor002,"Normal")

	--★★キッス★★:憲兵隊の仕事の一環としてどうかしら？
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01105_9010014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:ああ、構わないよ<br>隊商の護衛なら、傭兵時代にも何度かやってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_9010015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★マルイル★★:ありがとうございます<br>ノワールさん！
	Talk(Actor003,"CHRNAME_MARIL","speech","L","MA_01105_9010016")

	change_face(Actor003,"Normal")

	--★★マルイル★★:隊商のリーダーに伝えてきますね<br>すぐ出発することになると思います
	Talk(Actor003,"CHRNAME_MARIL","speech","L","MA_01105_9010017")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101062","001","101062001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
