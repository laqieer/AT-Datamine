-- このluaスクリプトは、PT3_01_07_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_03","110191_03_h")
Include("content_adv_advsmall_110191_03","Template110191_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_002)
	InitializeTemplateRandomCamera110191_03()
	InitializeTemplate110191_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:マルディサント、おはよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_07_0010003")

-- ▼直接出力
PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力

	--★★マルディサント★★:よう、オニーサン
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01_07_0010004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:あれから体の調子はどうだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_07_0010005")


	--★★マルディサント★★:ディーナのおかげで咳も止まったし<br>こうして自由に歩き回れるようにもなったぜ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01_07_0010006")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルディサント", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルディサント★★:もうすっかりケンコー、ゼッコーチョーよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01_07_0010007")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そうか<br>それはよかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_07_0010008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("マルディサント", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルディサント★★:あー、でも<br>オニーサンには謝らなきゃと思ってたんだよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01_07_0010009")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺に謝る？<br>なにをだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_07_0010010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルディサント★★:ディーナは<br>アタシの相方になっちまっただろ？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01_07_0010011")


	--★★マルディサント★★:これからは<br>ディーナを借りることが増えると思うんだ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01_07_0010012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、気にしないでくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_07_0010013")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ディナタンに仲の良い友達ができるのは<br>俺も嬉しいからさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_07_0010014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルディサント", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルディサント★★:優しいオニーサンがいて<br>ディーナはシアワセモンだねえ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01_07_0010015")

	change_face(Actor002,"Normal")

	--★★マルディサント★★:さて。じゃーオニーサンの許可ももらったし<br>ディーナを誘って訓練にでも行くかね
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01_07_0010016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:待て<br>これから授業だろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_07_0010017")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("マルディサント", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルディサント★★:…ギクッ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01_07_0010018")

	change_face(Actor001,"Serious")

	--★★ノワール★★:ディナタンを非行の道に引きずり込むのは<br>許さないからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_07_0010019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルディサント★★:しくった…具合わりーフリして<br>シカト決め込むべきだった…
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01_07_0010020")

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
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
