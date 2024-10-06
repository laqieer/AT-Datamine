-- このluaスクリプトは、MA_01A109_902.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera002 = SetTemplate("Actor002",-170,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	Camera003 = SetTemplate("Actor003",-155,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	template1()
-- ▼直接出力
set_common_look_at(Actor001,Actor002,1.0)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor002,Actor001,1.0)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor003,Actor001,1.0)
-- ▲直接出力
-- ▼直接出力
        -- 背景移動回転スケール
        local bg = get_object("BG")
        set_pos(bg,{-10,0,10})

        -- 固定モブ移動回転スケール
        local pro = get_object("Pro_1101_45")
        set_pos(pro,{-10,0,10})
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
set_enable_auto_lookat(Actor003,false)
 --PlayPartVoice("フレン", "挨拶")
-- ▲直接出力

	--★★フレン★★:ノワールくん、どこに行くの？
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_9020002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ、フレン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_9020003")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:憲兵団の仕事でさ<br>ちょっとロンディニウムの近くまで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_9020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フレン", "納得")
-- ▲直接出力

	--★★フレン★★:そう<br>私たちもついていっていいかな？
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_9020005")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？でも…<br>バルバロイと戦うことになるかもしれないぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_9020006")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ローラ", "肯定")
-- ▲直接出力

	--★★ローラ★★:大丈夫<br>私たちもちゃんと授業受けているもの
	Talk(Actor003,"CHRNAME_LOLA","speech","L","MA_01A109_9020007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかった<br>でも、くれぐれも無理はしないでくれよ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_9020008")

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
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
