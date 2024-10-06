-- このluaスクリプトは、MA_01C201_22.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111012_02","111012_02_h")
Include("content_adv_advsmall_111012_02","Template111012_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-42,CharaPos111012_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName111012_02,CameraPos111012_02_003)
	InitializeTemplateRandomCamera111012_02()
	InitializeTemplate111012_02()
-- ▼直接出力
change_face(Actor001,"Sad")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111012)
	Actor001 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:私は誰を恨めばいいのでしょう<br>もう、それすらわからない
	Talk(Actor002,"telop","narration","N","MA_01C201_220002")


	--★★テロップ★★:いっそあなたが<br>あの子を選んでくれれば楽だったのに
	Talk(Actor002,"telop","narration","N","MA_01C201_220003")

-- ▼直接出力
wait_time(0.5)
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネマウア★★:…そう。始めるのね<br>相変わらず、ワガママで勝手な子
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C201_220005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネマウア★★:しかたないから<br>お姉ちゃんが付き合ってあげるわ
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C201_220006")

	change_face(Actor001,"Sad")

	--★★ギネマウア★★:それが、私からあなたに<br>してあげられる唯一のことだから
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C201_220007")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111012)
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111012_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
