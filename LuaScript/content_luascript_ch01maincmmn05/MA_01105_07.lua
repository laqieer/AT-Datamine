-- このluaスクリプトは、MA_01105_07.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_007)
	Camera002 = SetTemplate("Actor002",-50,CharaPos110101_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_004)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_070002")


	--★★リアム★★:ノワールさんではないですか<br>珍しいですね、こんな時間に
	Talk(Actor002,"CHRNAME_LIAM","speech","L","MA_01105_070003")


	--★★ノワール★★:…あの、先ほどランスロットが<br>来ていたと思うんですが
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_070004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★リアム★★:ああ。そういえば来ていましたね<br>なんでも遺品の供養をしたいとかで
	Talk(Actor002,"CHRNAME_LIAM","speech","L","MA_01105_070005")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…遺品？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_070006")

	change_face(Actor002,"Sad")

	--★★リアム★★:あまり大きな声では言えないのですが<br>ノワールさんならむしろ知らせておきましょうか
	Talk(Actor002,"CHRNAME_LIAM","speech","L","MA_01105_070007")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★リアム★★:傭兵団『不格好なコート』の遺品なのです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","MA_01105_070008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")

	--★★ノワール★★:えっ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_070010")

	change_face(Actor002,"Sad")

	--★★リアム★★:バルバロイに食い千切られ、わずかに遺った<br>団服やら剣やらを持っていらっしゃいまして
	Talk(Actor002,"CHRNAME_LIAM","speech","L","MA_01105_070011")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ランスロット、が…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_070012")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
turn_chara(Actor001,0.7,0)
set_enable_auto_lookat(Actor002,true)
lookat_delay_weight_reset(Actor002,0.6)
-- ▲直接出力

	--★★リアム★★:拾い上げてきたのでしょうね、戦場から
	Talk(Actor002,"CHRNAME_LIAM","speech","L","MA_01105_070013")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Run")
slidemove(Actor001, -1.05, 0, 1.04, 1.6)
turn_chara(Actor002,-10,0.5) 
wait_time(0.2)
PlayActionDirect(Actor002,"to  Std_Surp")
wait_time(1.3)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リアム★★:ノワールさん！？
	Talk(Actor002,"CHRNAME_LIAM","speech","L","MA_01105_070015")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110101)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
