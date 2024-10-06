-- このluaスクリプトは、PT2_01C_10_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:マルディサント、おはよう<br>今日はディナタンは一緒じゃないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_10_0010002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力

	--★★マルディサント★★:アタシひとりで悪かったな<br>ディーナはなんか買い物だってよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT2_01C_10_0010003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:そっか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_10_0010004")

	change_face(Actor002,"Sad")

	--★★マルディサント★★:………
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT2_01C_10_0010005")


	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_10_0010006")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:今日の天気ってどうなんだろうな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_10_0010007")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力

	--★★マルディサント★★:さぁな
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT2_01C_10_0010008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:日曜日って夕方から憂鬱になるよな<br>翌日から授業だし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_10_0010009")


	--★★マルディサント★★:アタシ、ダリィときは授業出ねぇから
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT2_01C_10_0010010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:（会話が続かない…<br>ディナタン、早く戻ってきてくれ…！）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","PT2_01C_10_0010011")

-- ▼直接出力
PlayPartVoice("マルディサント", "挨拶")
-- ▲直接出力

	--★★マルディサント★★:あのさ、オニーサン<br>ディーナを守ってくれてありがとな
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT2_01C_10_0010012")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:マルディサント…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_10_0010013")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、森へ逃げられたのは俺の力じゃないし<br>むしろ守ってもらったのは俺のほうというか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_10_0010014")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルディサント★★:やれやれ。あの森での話だけじゃねぇよ<br>行間読めっての
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT2_01C_10_0010015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★マルディサント★★:少しは見直してやろうかと思ったけど<br>やっぱりまだまだだな
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT2_01C_10_0010016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルディサント", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルディサント★★:これからもアタシがサポートしてやっからさ<br>せいぜい頑張んな、オニーサン
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT2_01C_10_0010017")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
