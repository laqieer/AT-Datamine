-- このluaスクリプトは、PT2_01A_11_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_002)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor002,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力

	--★★ディナタン★★:おはよう、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01A_11_0010004")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:おはよう、ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_11_0010005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:学園祭、楽しかったね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01A_11_0010006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ログレスの外からもたくさんの人が来て<br>大盛り上がりだったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_11_0010007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:だね！<br>本当にやれてよかったと思う
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01A_11_0010008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:もうあれから１週間経つのか～
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01A_11_0010009")

	change_face(Actor002,"Smile")

	--★★ディナタン★★:…で、どう？少し休んで<br>役者魂にまた火が点き始めた頃じゃない？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01A_11_0010010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:よ、よせって<br>俺はしばらく芝居はいいよ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_11_0010011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "喜び")
-- ▲直接出力

	--★★ディナタン★★:あははっ！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01A_11_0010012")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:ランス兄ちゃんたちも<br>来れたら良かったのにね、学園祭
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01A_11_0010013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:聖杯の出現情報が錯綜してて<br>聖杯探索班は毎日忙しくしてるそうだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_11_0010014")

	change_face(Actor002,"Surprise")

	--★★ディナタン★★:聖杯、見つかりそうなの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01A_11_0010015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:どうだろうな<br>あとでランスロットに会ったら聞いてみるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_11_0010016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:うん。じゃ、私たちは<br>ランス兄ちゃんたちが安心して聖杯を探せるよう
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01A_11_0010017")


	--★★ディナタン★★:なるべく早く<br>ローマの人たちを懲らしめないとね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01A_11_0010018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:いつまでも<br>お祭り気分じゃいられないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_11_0010019")

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
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
